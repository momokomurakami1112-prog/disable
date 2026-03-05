namespace disable
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
            SuspendLayout();
            // 
            // DesignerFilePathTextBox
            // 
            DesignerFilePathTextBox.AllowDrop = true;
            DesignerFilePathTextBox.BorderStyle = BorderStyle.FixedSingle;
            DesignerFilePathTextBox.Location = new Point(12, 12);
            DesignerFilePathTextBox.Name = "DesignerFilePathTextBox";
            DesignerFilePathTextBox.Size = new Size(100, 23);
            DesignerFilePathTextBox.TabIndex = 0;
            // 
            // LoadDsignerFileButton
            // 
            LoadDsignerFileButton.Location = new Point(118, 12);
            LoadDsignerFileButton.Name = "LoadDsignerFileButton";
            LoadDsignerFileButton.Size = new Size(75, 23);
            LoadDsignerFileButton.TabIndex = 1;
            LoadDsignerFileButton.Text = "ファイル読込";
            LoadDsignerFileButton.UseVisualStyleBackColor = true;
            LoadDsignerFileButton.Click += LoadDsignerFileButton_Click;
            // 
            // OutputBlockButton
            // 
            OutputBlockButton.Location = new Point(199, 12);
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
            BlockTextBox.Location = new Point(12, 41);
            BlockTextBox.Multiline = true;
            BlockTextBox.Name = "BlockTextBox";
            BlockTextBox.Size = new Size(262, 397);
            BlockTextBox.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(289, 450);
            Controls.Add(BlockTextBox);
            Controls.Add(OutputBlockButton);
            Controls.Add(LoadDsignerFileButton);
            Controls.Add(DesignerFilePathTextBox);
            Name = "Form1";
            Text = "でぃ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox DesignerFilePathTextBox;
        private Button LoadDsignerFileButton;
        private Button OutputBlockButton;
        private TextBox BlockTextBox;
    }
}
