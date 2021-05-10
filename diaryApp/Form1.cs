using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.VisualBasic.FileIO;


namespace diaryApp
{ 

    public partial class diaryAppForm : Form
    {

        public static String THIS_PROGRAM = "自省日記";

        //本日の日付
        DateTime dateTime = DateTime.Now;

        //これらをもとに動く
        public String rootFolderPath;
        public String monthFolderPath;
        public String monthKIGAMAEfilePath;
        public String dayFilePath;

        // 新規フラグ
        public Boolean newDataFlag;

        public diaryAppForm()
        {
            InitializeComponent();


            //新規フラグの初期化
            newDataFlag = false;

            //フォルダパスの設定
            setFolderPath(dateTime);

            //読み込み
             displayFiles();

            //日付の設定
            dateLabel.Text = "本日：" + dateTime.ToString("yyyy年MM月dd日");

        }

        //コミットボタンクリック処理
        private void commitButton_Click(object sender, EventArgs e)
        {
            saveFiles();
        }


        //ディスプレイボタンクリック処理
        private void displayButton_Click(object sender, EventArgs e)
        {
            DateTime selectDateTime = dateTimePicker.Value.Date;

            cleanText();

            setFolderPath(selectDateTime);

            displayFiles();


        }







        //指定されたフォルダやパスをもとに内容を表示する
        //なければ新規フラグを立てる
        //画面終了時に新規フラグがONの場合は保存して終了するようにメッセージを出す
        private void displayFiles()
        {
            try
            {
                // 全体フォルダの存在チェック、なければ作る
                if (Directory.Exists(rootFolderPath)==false) { Directory.CreateDirectory(rootFolderPath); }

                // 該当月フォルダの存在チェック、なければ作る
                if (Directory.Exists(monthFolderPath)==false) { Directory.CreateDirectory(monthFolderPath); }

                // 気構えファイルの存在チェック、なければ作る
                if (File.Exists(monthKIGAMAEfilePath)==false) { File.CreateText(monthKIGAMAEfilePath); }

                // 該当日ファイルの存在チェック、なければ作る
                if (File.Exists(dayFilePath) == false) { File.CreateText(dayFilePath); }


                //気構えファイルを読み込み、気構えフィールドに展開
                var kigamaeParcer = new TextFieldParser(monthKIGAMAEfilePath);
                kigamaeParcer.Delimiters = new string[] { "," };

                //読み込んだCSVに中身がなければ新規判定とし、関数処理を終了
                if (kigamaeParcer.EndOfData) { newDataFlag = true; return; }

                mindsetTextBox.Text = kigamaeParcer.ReadLine();
                if (mindsetTextBox.Text == "") { mindsetTextBox.Text = "入力してください"; }

                //読み込み
                var contentParcer = new TextFieldParser(dayFilePath);
                contentParcer.Delimiters = new string[] { "," };


                //読み込んだCSVに中身がなければ新規判定とし、関数処理を終了
                if (contentParcer.EndOfData) { newDataFlag = true; return; }

                //第一フィールドはタイトル
                //第二フィールドは良かった点
                //第三フィールドは悪かった点
                //第四フィールドは雑記
                var fields = contentParcer.ReadFields();

                titleTextBox.Text = fields[0];
                goodTextBox.Text = fields[1];
                badTextBox.Text = fields[2];
                mainTextBox.Text = fields[3];

            } catch (Exception e)
            {
                Console.WriteLine(e.Message.ToString());
                //握りつぶす

                MessageBox.Show(e.Message.ToString());
            }

        }

        //指定されているフォルダやパスをもとに内容を保存する
        //新規フラグがfalseのときは、確認を行うようにする（モーダルでよい）
        private void saveFiles()
        {
            if (newDataFlag == false) { 
                var result = MessageBox.Show("既存ファイルを上書します。" + "\r\n" + "よろしいですか？", THIS_PROGRAM,
                                 MessageBoxButtons.YesNo, MessageBoxIcon.Error); 

                //イエス以外は処理中断
                if (result != DialogResult.Yes)
                {
                    return;
                }

            }

            //気構えフィールド更新
            File.WriteAllText(monthKIGAMAEfilePath, mindsetTextBox.Text);

            //コンテンツを文字列へ
            StringBuilder contents = new StringBuilder();

            contents.Append("\"" + titleTextBox.Text + "\"" + ",");
            contents.Append("\"" + goodTextBox.Text + "\"" + ",");
            contents.Append("\"" + badTextBox.Text + "\"" + ",");
            contents.Append("\"" + mainTextBox.Text + "\"");

            String strings = contents.ToString();

            //出力
            File.WriteAllText(dayFilePath, strings);



        }

        //CSVパーサー
        //引数に渡すものによって読み込みと書き込みを分ける


        //セットフォルダ
        //渡されたDateTime型によって日記帳表示に使用するフォルダパスを更新する
        private void setFolderPath(DateTime givenDateTime)
        {
            //フォルダパス、ファイルパスの設定
            rootFolderPath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + @"\diaryroot";
            monthFolderPath = rootFolderPath + @"\" + givenDateTime.Year + givenDateTime.Month;
            monthKIGAMAEfilePath = monthFolderPath + @"\" + "KIGAMAE.csv";
            dayFilePath = monthFolderPath + @"\" + givenDateTime.Day + ".csv";
        }

        //クリーンテキスト
        private void cleanText()
        {
            mindsetTextBox.Text = "";
            titleTextBox.Text = "";
            goodTextBox.Text = "";
            badTextBox.Text = "";
            mainTextBox.Text = "";
        }
    }
}
