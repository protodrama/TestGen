namespace TestGen
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
            TestFileList = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            WordToTranslate = new Label();
            CheckBtn = new Button();
            txtAnswer = new TextBox();
            label3 = new Label();
            LabelGood = new Label();
            label4 = new Label();
            LabelWrong = new Label();
            LabelRest = new Label();
            label6 = new Label();
            MistakesList = new ListBox();
            BtnRepeatMistakes = new Button();
            btnReset = new Button();
            CorrectList = new ListBox();
            SuspendLayout();
            // 
            // TestFileList
            // 
            TestFileList.FormattingEnabled = true;
            TestFileList.Location = new Point(152, 23);
            TestFileList.Name = "TestFileList";
            TestFileList.Size = new Size(345, 23);
            TestFileList.TabIndex = 1;
            TestFileList.SelectedIndexChanged += TestFileList_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 26);
            label1.Name = "label1";
            label1.Size = new Size(112, 15);
            label1.TabIndex = 2;
            label1.Text = "Nombre del archivo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 75);
            label2.Name = "label2";
            label2.Size = new Size(102, 15);
            label2.TabIndex = 3;
            label2.Text = "Palabra a traducir:";
            // 
            // WordToTranslate
            // 
            WordToTranslate.AutoSize = true;
            WordToTranslate.Location = new Point(22, 104);
            WordToTranslate.Name = "WordToTranslate";
            WordToTranslate.Size = new Size(12, 15);
            WordToTranslate.TabIndex = 4;
            WordToTranslate.Text = "-";
            // 
            // CheckBtn
            // 
            CheckBtn.Enabled = false;
            CheckBtn.Location = new Point(328, 133);
            CheckBtn.Name = "CheckBtn";
            CheckBtn.Size = new Size(75, 23);
            CheckBtn.TabIndex = 5;
            CheckBtn.Text = "Check";
            CheckBtn.UseVisualStyleBackColor = true;
            CheckBtn.Click += CheckBtn_Click;
            // 
            // txtAnswer
            // 
            txtAnswer.Enabled = false;
            txtAnswer.Location = new Point(22, 134);
            txtAnswer.Name = "txtAnswer";
            txtAnswer.Size = new Size(300, 23);
            txtAnswer.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(328, 228);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 7;
            label3.Text = "Correctas";
            // 
            // LabelGood
            // 
            LabelGood.AutoSize = true;
            LabelGood.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LabelGood.ForeColor = Color.DarkGreen;
            LabelGood.Location = new Point(410, 228);
            LabelGood.Name = "LabelGood";
            LabelGood.Size = new Size(12, 15);
            LabelGood.TabIndex = 9;
            LabelGood.Text = "-";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 228);
            label4.Name = "label4";
            label4.Size = new Size(65, 15);
            label4.TabIndex = 8;
            label4.Text = "Incorrectas";
            // 
            // LabelWrong
            // 
            LabelWrong.AutoSize = true;
            LabelWrong.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LabelWrong.ForeColor = Color.Red;
            LabelWrong.Location = new Point(107, 228);
            LabelWrong.Name = "LabelWrong";
            LabelWrong.Size = new Size(12, 15);
            LabelWrong.TabIndex = 10;
            LabelWrong.Text = "-";
            // 
            // LabelRest
            // 
            LabelRest.AutoSize = true;
            LabelRest.Location = new Point(258, 183);
            LabelRest.Name = "LabelRest";
            LabelRest.Size = new Size(12, 15);
            LabelRest.TabIndex = 12;
            LabelRest.Text = "-";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(195, 183);
            label6.Name = "label6";
            label6.Size = new Size(57, 15);
            label6.TabIndex = 11;
            label6.Text = "Restantes";
            // 
            // MistakesList
            // 
            MistakesList.FormattingEnabled = true;
            MistakesList.ItemHeight = 15;
            MistakesList.Location = new Point(19, 257);
            MistakesList.Name = "MistakesList";
            MistakesList.Size = new Size(170, 169);
            MistakesList.TabIndex = 13;
            // 
            // BtnRepeatMistakes
            // 
            BtnRepeatMistakes.Enabled = false;
            BtnRepeatMistakes.Location = new Point(195, 257);
            BtnRepeatMistakes.Name = "BtnRepeatMistakes";
            BtnRepeatMistakes.Size = new Size(127, 23);
            BtnRepeatMistakes.TabIndex = 14;
            BtnRepeatMistakes.Text = "Repetir Errores";
            BtnRepeatMistakes.UseVisualStyleBackColor = true;
            BtnRepeatMistakes.Click += BtnRepeatMistakes_Click;
            // 
            // btnReset
            // 
            btnReset.Enabled = false;
            btnReset.Location = new Point(195, 286);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(127, 23);
            btnReset.TabIndex = 15;
            btnReset.Text = "Resetear applicación";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // CorrectList
            // 
            CorrectList.FormattingEnabled = true;
            CorrectList.ItemHeight = 15;
            CorrectList.Location = new Point(328, 257);
            CorrectList.Name = "CorrectList";
            CorrectList.Size = new Size(169, 169);
            CorrectList.TabIndex = 16;
            // 
            // Form1
            // 
            AcceptButton = CheckBtn;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(512, 450);
            Controls.Add(CorrectList);
            Controls.Add(btnReset);
            Controls.Add(BtnRepeatMistakes);
            Controls.Add(MistakesList);
            Controls.Add(LabelRest);
            Controls.Add(label6);
            Controls.Add(LabelWrong);
            Controls.Add(LabelGood);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtAnswer);
            Controls.Add(CheckBtn);
            Controls.Add(WordToTranslate);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TestFileList);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Generador de tests";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox TestFileList;
        private Label label1;
        private Label label2;
        private Label WordToTranslate;
        private Button CheckBtn;
        private TextBox txtAnswer;
        private Label label3;
        private Label LabelGood;
        private Label label4;
        private Label LabelWrong;
        private Label LabelRest;
        private Label label6;
        private ListBox MistakesList;
        private Button BtnRepeatMistakes;
        private Button btnReset;
        private ListBox CorrectList;
    }
}