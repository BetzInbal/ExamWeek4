namespace Mivdak
{
    partial class Form1
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
            H1LA = new Label();
            label1 = new Label();
            DayWeekCB = new ComboBox();
            DayMonthCB = new ComboBox();
            label2 = new Label();
            YearCB = new ComboBox();
            YaerLA = new Label();
            MonthCB = new ComboBox();
            label4 = new Label();
            ResLa = new Label();
            SendBU = new Button();
            SuspendLayout();
            // 
            // H1LA
            // 
            H1LA.AutoSize = true;
            H1LA.Location = new Point(369, 70);
            H1LA.Name = "H1LA";
            H1LA.Size = new Size(79, 15);
            H1LA.TabIndex = 0;
            H1LA.Text = "כתיבת תאריך";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(652, 135);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 1;
            label1.Text = "היום בשבוע";
            // 
            // DayWeekCB
            // 
            DayWeekCB.FormattingEnabled = true;
            DayWeekCB.Items.AddRange(new object[] { "ראשון", "שני", "שלישי", "רביעי", "חמישי", "ששי" });
            DayWeekCB.Location = new Point(643, 153);
            DayWeekCB.Name = "DayWeekCB";
            DayWeekCB.Size = new Size(98, 23);
            DayWeekCB.TabIndex = 2;
            // 
            // DayMonthCB
            // 
            DayMonthCB.FormattingEnabled = true;
            DayMonthCB.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", " 9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30" });
            DayMonthCB.Location = new Point(497, 153);
            DayMonthCB.Name = "DayMonthCB";
            DayMonthCB.Size = new Size(98, 23);
            DayMonthCB.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(506, 135);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 3;
            label2.Text = "היום בחודש";
            // 
            // YearCB
            // 
            YearCB.FormattingEnabled = true;
            YearCB.Location = new Point(173, 153);
            YearCB.Name = "YearCB";
            YearCB.Size = new Size(98, 23);
            YearCB.TabIndex = 8;
            // 
            // YaerLA
            // 
            YaerLA.AutoSize = true;
            YaerLA.Location = new Point(182, 135);
            YaerLA.Name = "YaerLA";
            YaerLA.Size = new Size(29, 15);
            YaerLA.TabIndex = 7;
            YaerLA.Text = "שנה";
            // 
            // MonthCB
            // 
            MonthCB.FormattingEnabled = true;
            MonthCB.Items.AddRange(new object[] { "תשרי", "מרחשוון", "כסלו", "שבט", "אדר", "אדר הראשון", "אדר השני", "ניסן", "אייר", "סיון", "תמוז", "אב", "אלול" });
            MonthCB.Location = new Point(319, 153);
            MonthCB.Name = "MonthCB";
            MonthCB.Size = new Size(98, 23);
            MonthCB.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(328, 135);
            label4.Name = "label4";
            label4.Size = new Size(33, 15);
            label4.TabIndex = 5;
            label4.Text = "חודש";
            // 
            // ResLa
            // 
            ResLa.AutoSize = true;
            ResLa.Location = new Point(202, 226);
            ResLa.Name = "ResLa";
            ResLa.Size = new Size(0, 15);
            ResLa.TabIndex = 9;
            // 
            // SendBU
            // 
            SendBU.Location = new Point(24, 135);
            SendBU.Name = "SendBU";
            SendBU.Size = new Size(106, 77);
            SendBU.TabIndex = 10;
            SendBU.Text = "שלח";
            SendBU.UseVisualStyleBackColor = true;
            SendBU.Click += SendBU_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(SendBU);
            Controls.Add(ResLa);
            Controls.Add(YearCB);
            Controls.Add(YaerLA);
            Controls.Add(MonthCB);
            Controls.Add(label4);
            Controls.Add(DayMonthCB);
            Controls.Add(label2);
            Controls.Add(DayWeekCB);
            Controls.Add(label1);
            Controls.Add(H1LA);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label H1LA;
        private Label label1;
        private ComboBox DayWeekCB;
        private ComboBox DayMonthCB;
        private Label label2;
        private ComboBox YearCB;
        private Label YaerLA;
        private ComboBox MonthCB;
        private Label label4;
        private Label ResLa;
        private Button SendBU;
    }
}
