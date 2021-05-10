
namespace diaryApp
{
    partial class diaryAppForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(diaryAppForm));
            this.mainTextBox = new System.Windows.Forms.TextBox();
            this.dateLabel = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.commitButton = new System.Windows.Forms.Button();
            this.displayButton = new System.Windows.Forms.Button();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.titleName = new System.Windows.Forms.Label();
            this.goodTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.badTextBox = new System.Windows.Forms.TextBox();
            this.mindsetTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mainTextBox
            // 
            this.mainTextBox.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mainTextBox.Location = new System.Drawing.Point(54, 918);
            this.mainTextBox.Multiline = true;
            this.mainTextBox.Name = "mainTextBox";
            this.mainTextBox.Size = new System.Drawing.Size(1328, 513);
            this.mainTextBox.TabIndex = 5;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Enabled = false;
            this.dateLabel.Font = new System.Drawing.Font("Meiryo UI", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dateLabel.Location = new System.Drawing.Point(12, 25);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(160, 67);
            this.dateLabel.TabIndex = 0;
            this.dateLabel.Text = "Date";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(54, 1490);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(306, 38);
            this.dateTimePicker.TabIndex = 6;
            // 
            // commitButton
            // 
            this.commitButton.Location = new System.Drawing.Point(1145, 1462);
            this.commitButton.Name = "commitButton";
            this.commitButton.Size = new System.Drawing.Size(237, 99);
            this.commitButton.TabIndex = 8;
            this.commitButton.Text = "Commit";
            this.commitButton.UseVisualStyleBackColor = true;
            this.commitButton.Click += new System.EventHandler(this.commitButton_Click);
            // 
            // displayButton
            // 
            this.displayButton.Location = new System.Drawing.Point(390, 1462);
            this.displayButton.Name = "displayButton";
            this.displayButton.Size = new System.Drawing.Size(328, 99);
            this.displayButton.TabIndex = 7;
            this.displayButton.Text = "Display";
            this.displayButton.UseVisualStyleBackColor = true;
            this.displayButton.Click += new System.EventHandler(this.displayButton_Click);
            // 
            // titleTextBox
            // 
            this.titleTextBox.Font = new System.Drawing.Font("Meiryo UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.titleTextBox.Location = new System.Drawing.Point(234, 283);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(1148, 54);
            this.titleTextBox.TabIndex = 2;
            // 
            // titleName
            // 
            this.titleName.AutoSize = true;
            this.titleName.Enabled = false;
            this.titleName.Font = new System.Drawing.Font("Meiryo UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.titleName.Location = new System.Drawing.Point(54, 274);
            this.titleName.Name = "titleName";
            this.titleName.Size = new System.Drawing.Size(128, 61);
            this.titleName.TabIndex = 0;
            this.titleName.Text = "Title";
            // 
            // goodTextBox
            // 
            this.goodTextBox.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.goodTextBox.Location = new System.Drawing.Point(234, 397);
            this.goodTextBox.Multiline = true;
            this.goodTextBox.Name = "goodTextBox";
            this.goodTextBox.Size = new System.Drawing.Size(1148, 165);
            this.goodTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Font = new System.Drawing.Font("Meiryo UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(40, 451);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 61);
            this.label2.TabIndex = 0;
            this.label2.Text = "Good";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Font = new System.Drawing.Font("Meiryo UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(58, 658);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 61);
            this.label3.TabIndex = 0;
            this.label3.Text = "Bad";
            // 
            // badTextBox
            // 
            this.badTextBox.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.badTextBox.Location = new System.Drawing.Point(234, 609);
            this.badTextBox.Multiline = true;
            this.badTextBox.Name = "badTextBox";
            this.badTextBox.Size = new System.Drawing.Size(1148, 176);
            this.badTextBox.TabIndex = 4;
            // 
            // mindsetTextBox
            // 
            this.mindsetTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.mindsetTextBox.Font = new System.Drawing.Font("Meiryo UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mindsetTextBox.Location = new System.Drawing.Point(334, 126);
            this.mindsetTextBox.Name = "mindsetTextBox";
            this.mindsetTextBox.Size = new System.Drawing.Size(1048, 68);
            this.mindsetTextBox.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Font = new System.Drawing.Font("Meiryo UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(54, 838);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(258, 61);
            this.label4.TabIndex = 9;
            this.label4.Text = "本日の雑記";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Enabled = false;
            this.label5.Font = new System.Drawing.Font("Meiryo UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(54, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(227, 47);
            this.label5.TabIndex = 10;
            this.label5.Text = "今月の気構え";
            // 
            // diaryAppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1414, 1587);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.mindsetTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.badTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.goodTextBox);
            this.Controls.Add(this.titleName);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.displayButton);
            this.Controls.Add(this.commitButton);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.mainTextBox);
            this.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "diaryAppForm";
            this.Text = "自省日記";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox mainTextBox;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button commitButton;
        private System.Windows.Forms.Button displayButton;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.Label titleName;
        private System.Windows.Forms.TextBox goodTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox badTextBox;
        private System.Windows.Forms.TextBox mindsetTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

