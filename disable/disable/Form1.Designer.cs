namespace BlockMaker
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
            DesignerFilePathTextBox = new TextBox();
            LoadDsignerFileButton = new Button();
            OutputBlockButton = new Button();
            BlockTextBox = new TextBox();
            CustomPropertyTextBox = new TextBox();
            groupBox1 = new GroupBox();
            CustomPropertyRadioButton = new RadioButton();
            TabStopRadioButton = new RadioButton();
            ReadOnlyRadioButton = new RadioButton();
            EnabledRadioButton = new RadioButton();
            CustomPropertyValueTextBox = new TextBox();
            TrueRadioButton = new RadioButton();
            FalseRadioButton = new RadioButton();
            groupBox2 = new GroupBox();
            CustomPropertyValueRadioButton = new RadioButton();
            SelectButton = new Button();
            CopyStatusLabel = new Label();
            groupBox3 = new GroupBox();
            TextBoxAndNumberRadioButton = new RadioButton();
            CustomControlRadioButton = new RadioButton();
            GcNumberRadioButton = new RadioButton();
            GcTextBoxRadioButton = new RadioButton();
            CustomControlTextBox = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // DesignerFilePathTextBox
            // 
            DesignerFilePathTextBox.AllowDrop = true;
            DesignerFilePathTextBox.BorderStyle = BorderStyle.FixedSingle;
            DesignerFilePathTextBox.Location = new Point(12, 12);
            DesignerFilePathTextBox.Name = "DesignerFilePathTextBox";
            DesignerFilePathTextBox.Size = new Size(309, 23);
            DesignerFilePathTextBox.TabIndex = 0;
            // 
            // LoadDsignerFileButton
            // 
            LoadDsignerFileButton.Location = new Point(327, 12);
            LoadDsignerFileButton.Name = "LoadDsignerFileButton";
            LoadDsignerFileButton.Size = new Size(75, 23);
            LoadDsignerFileButton.TabIndex = 1;
            LoadDsignerFileButton.Text = "ファイル読込";
            LoadDsignerFileButton.UseVisualStyleBackColor = true;
            LoadDsignerFileButton.Click += LoadDsignerFileButton_Click;
            // 
            // OutputBlockButton
            // 
            OutputBlockButton.Location = new Point(327, 308);
            OutputBlockButton.Name = "OutputBlockButton";
            OutputBlockButton.Size = new Size(75, 23);
            OutputBlockButton.TabIndex = 2;
            OutputBlockButton.Text = "ブロック作成";
            OutputBlockButton.UseVisualStyleBackColor = true;
            OutputBlockButton.Click += OutputBlockButton_Click;
            // 
            // BlockTextBox
            // 
            BlockTextBox.BorderStyle = BorderStyle.FixedSingle;
            BlockTextBox.Location = new Point(12, 337);
            BlockTextBox.Multiline = true;
            BlockTextBox.Name = "BlockTextBox";
            BlockTextBox.ScrollBars = ScrollBars.Vertical;
            BlockTextBox.Size = new Size(384, 213);
            BlockTextBox.TabIndex = 3;
            // 
            // CustomPropertyTextBox
            // 
            CustomPropertyTextBox.BorderStyle = BorderStyle.FixedSingle;
            CustomPropertyTextBox.Enabled = false;
            CustomPropertyTextBox.Location = new Point(97, 47);
            CustomPropertyTextBox.Name = "CustomPropertyTextBox";
            CustomPropertyTextBox.Size = new Size(287, 23);
            CustomPropertyTextBox.TabIndex = 4;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(CustomPropertyRadioButton);
            groupBox1.Controls.Add(TabStopRadioButton);
            groupBox1.Controls.Add(ReadOnlyRadioButton);
            groupBox1.Controls.Add(EnabledRadioButton);
            groupBox1.Controls.Add(CustomPropertyTextBox);
            groupBox1.Location = new Point(12, 130);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(390, 83);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "指定プロパティ";
            // 
            // CustomPropertyRadioButton
            // 
            CustomPropertyRadioButton.AutoSize = true;
            CustomPropertyRadioButton.Location = new Point(6, 47);
            CustomPropertyRadioButton.Name = "CustomPropertyRadioButton";
            CustomPropertyRadioButton.Size = new Size(85, 19);
            CustomPropertyRadioButton.TabIndex = 8;
            CustomPropertyRadioButton.Text = "ユーザー指定";
            CustomPropertyRadioButton.UseVisualStyleBackColor = true;
            CustomPropertyRadioButton.CheckedChanged += CustomPropertyRadioButton_CheckedChanged;
            // 
            // TabStopRadioButton
            // 
            TabStopRadioButton.AutoSize = true;
            TabStopRadioButton.Location = new Point(161, 22);
            TabStopRadioButton.Name = "TabStopRadioButton";
            TabStopRadioButton.Size = new Size(67, 19);
            TabStopRadioButton.TabIndex = 7;
            TabStopRadioButton.Text = "TabStop";
            TabStopRadioButton.UseVisualStyleBackColor = true;
            // 
            // ReadOnlyRadioButton
            // 
            ReadOnlyRadioButton.AutoSize = true;
            ReadOnlyRadioButton.Location = new Point(79, 22);
            ReadOnlyRadioButton.Name = "ReadOnlyRadioButton";
            ReadOnlyRadioButton.Size = new Size(76, 19);
            ReadOnlyRadioButton.TabIndex = 6;
            ReadOnlyRadioButton.Text = "ReadOnly";
            ReadOnlyRadioButton.UseVisualStyleBackColor = true;
            // 
            // EnabledRadioButton
            // 
            EnabledRadioButton.AutoSize = true;
            EnabledRadioButton.Checked = true;
            EnabledRadioButton.Location = new Point(6, 22);
            EnabledRadioButton.Name = "EnabledRadioButton";
            EnabledRadioButton.Size = new Size(67, 19);
            EnabledRadioButton.TabIndex = 5;
            EnabledRadioButton.TabStop = true;
            EnabledRadioButton.Text = "Enabled";
            EnabledRadioButton.UseVisualStyleBackColor = true;
            // 
            // CustomPropertyValueTextBox
            // 
            CustomPropertyValueTextBox.BorderStyle = BorderStyle.FixedSingle;
            CustomPropertyValueTextBox.Enabled = false;
            CustomPropertyValueTextBox.Location = new Point(97, 43);
            CustomPropertyValueTextBox.Name = "CustomPropertyValueTextBox";
            CustomPropertyValueTextBox.Size = new Size(287, 23);
            CustomPropertyValueTextBox.TabIndex = 4;
            // 
            // TrueRadioButton
            // 
            TrueRadioButton.AutoSize = true;
            TrueRadioButton.Checked = true;
            TrueRadioButton.Location = new Point(6, 22);
            TrueRadioButton.Name = "TrueRadioButton";
            TrueRadioButton.Size = new Size(47, 19);
            TrueRadioButton.TabIndex = 5;
            TrueRadioButton.TabStop = true;
            TrueRadioButton.Text = "True";
            TrueRadioButton.UseVisualStyleBackColor = true;
            // 
            // FalseRadioButton
            // 
            FalseRadioButton.AutoSize = true;
            FalseRadioButton.Location = new Point(72, 22);
            FalseRadioButton.Name = "FalseRadioButton";
            FalseRadioButton.Size = new Size(50, 19);
            FalseRadioButton.TabIndex = 6;
            FalseRadioButton.Text = "False";
            FalseRadioButton.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(CustomPropertyValueRadioButton);
            groupBox2.Controls.Add(FalseRadioButton);
            groupBox2.Controls.Add(TrueRadioButton);
            groupBox2.Controls.Add(CustomPropertyValueTextBox);
            groupBox2.Location = new Point(12, 219);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(390, 83);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "指定設定値";
            // 
            // CustomPropertyValueRadioButton
            // 
            CustomPropertyValueRadioButton.AutoSize = true;
            CustomPropertyValueRadioButton.Location = new Point(6, 47);
            CustomPropertyValueRadioButton.Name = "CustomPropertyValueRadioButton";
            CustomPropertyValueRadioButton.Size = new Size(85, 19);
            CustomPropertyValueRadioButton.TabIndex = 9;
            CustomPropertyValueRadioButton.Text = "ユーザー指定";
            CustomPropertyValueRadioButton.UseVisualStyleBackColor = true;
            CustomPropertyValueRadioButton.CheckedChanged += CustomPropertyValueRadioButton_CheckedChanged;
            // 
            // SelectButton
            // 
            SelectButton.Location = new Point(302, 556);
            SelectButton.Name = "SelectButton";
            SelectButton.Size = new Size(100, 23);
            SelectButton.TabIndex = 10;
            SelectButton.Text = "ブロックをコピー";
            SelectButton.UseVisualStyleBackColor = true;
            SelectButton.Click += SelectButton_Click;
            // 
            // CopyStatusLabel
            // 
            CopyStatusLabel.AutoSize = true;
            CopyStatusLabel.Location = new Point(217, 560);
            CopyStatusLabel.Name = "CopyStatusLabel";
            CopyStatusLabel.Size = new Size(78, 15);
            CopyStatusLabel.TabIndex = 9;
            CopyStatusLabel.Text = "コピーしました！";
            CopyStatusLabel.Visible = false;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(TextBoxAndNumberRadioButton);
            groupBox3.Controls.Add(CustomControlRadioButton);
            groupBox3.Controls.Add(GcNumberRadioButton);
            groupBox3.Controls.Add(GcTextBoxRadioButton);
            groupBox3.Controls.Add(CustomControlTextBox);
            groupBox3.Location = new Point(12, 41);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(390, 83);
            groupBox3.TabIndex = 9;
            groupBox3.TabStop = false;
            groupBox3.Text = "指定コントロール";
            // 
            // TextBoxAndNumberRadioButton
            // 
            TextBoxAndNumberRadioButton.AutoSize = true;
            TextBoxAndNumberRadioButton.Location = new Point(185, 22);
            TextBoxAndNumberRadioButton.Name = "TextBoxAndNumberRadioButton";
            TextBoxAndNumberRadioButton.Size = new Size(142, 19);
            TextBoxAndNumberRadioButton.TabIndex = 9;
            TextBoxAndNumberRadioButton.Text = "GcTextBox/GcNumber";
            TextBoxAndNumberRadioButton.UseVisualStyleBackColor = true;
            // 
            // CustomControlRadioButton
            // 
            CustomControlRadioButton.AutoSize = true;
            CustomControlRadioButton.Location = new Point(6, 47);
            CustomControlRadioButton.Name = "CustomControlRadioButton";
            CustomControlRadioButton.Size = new Size(85, 19);
            CustomControlRadioButton.TabIndex = 8;
            CustomControlRadioButton.Text = "ユーザー指定";
            CustomControlRadioButton.UseVisualStyleBackColor = true;
            CustomControlRadioButton.CheckedChanged += CustomControlRadioButton_CheckedChanged;
            // 
            // GcNumberRadioButton
            // 
            GcNumberRadioButton.AutoSize = true;
            GcNumberRadioButton.Location = new Point(97, 22);
            GcNumberRadioButton.Name = "GcNumberRadioButton";
            GcNumberRadioButton.Size = new Size(82, 19);
            GcNumberRadioButton.TabIndex = 7;
            GcNumberRadioButton.Text = "GcNumber";
            GcNumberRadioButton.UseVisualStyleBackColor = true;
            // 
            // GcTextBoxRadioButton
            // 
            GcTextBoxRadioButton.AutoSize = true;
            GcTextBoxRadioButton.Checked = true;
            GcTextBoxRadioButton.Location = new Point(6, 22);
            GcTextBoxRadioButton.Name = "GcTextBoxRadioButton";
            GcTextBoxRadioButton.Size = new Size(80, 19);
            GcTextBoxRadioButton.TabIndex = 5;
            GcTextBoxRadioButton.TabStop = true;
            GcTextBoxRadioButton.Text = "GcTextBox";
            GcTextBoxRadioButton.UseVisualStyleBackColor = true;
            // 
            // CustomControlTextBox
            // 
            CustomControlTextBox.BorderStyle = BorderStyle.FixedSingle;
            CustomControlTextBox.Enabled = false;
            CustomControlTextBox.Location = new Point(97, 47);
            CustomControlTextBox.Name = "CustomControlTextBox";
            CustomControlTextBox.Size = new Size(287, 23);
            CustomControlTextBox.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(414, 591);
            Controls.Add(groupBox3);
            Controls.Add(CopyStatusLabel);
            Controls.Add(SelectButton);
            Controls.Add(groupBox2);
            Controls.Add(BlockTextBox);
            Controls.Add(OutputBlockButton);
            Controls.Add(LoadDsignerFileButton);
            Controls.Add(DesignerFilePathTextBox);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "め～";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox DesignerFilePathTextBox;
        private Button LoadDsignerFileButton;
        private Button OutputBlockButton;
        private TextBox BlockTextBox;
        private TextBox CustomPropertyTextBox;
        private GroupBox groupBox1;
        private RadioButton TabStopRadioButton;
        private RadioButton ReadOnlyRadioButton;
        private RadioButton EnabledRadioButton;
        private TextBox CustomPropertyValueTextBox;
        private RadioButton TrueRadioButton;
        private RadioButton FalseRadioButton;
        private GroupBox groupBox2;
        private Button SelectButton;
        private Label CopyStatusLabel;
        private RadioButton CustomPropertyRadioButton;
        private RadioButton CustomPropertyValueRadioButton;
        private GroupBox groupBox3;
        private RadioButton TextBoxAndNumberRadioButton;
        private RadioButton CustomControlRadioButton;
        private RadioButton GcNumberRadioButton;
        private RadioButton GcTextBoxRadioButton;
        private TextBox CustomControlTextBox;
    }
}
