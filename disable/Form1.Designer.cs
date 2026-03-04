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
            groupBox1 = new GroupBox();
            OutputFileButton = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // DesignerFilePathTextBox
            // 
            DesignerFilePathTextBox.BorderStyle = BorderStyle.FixedSingle;
            DesignerFilePathTextBox.Location = new Point(6, 22);
            DesignerFilePathTextBox.Name = "DesignerFilePathTextBox";
            DesignerFilePathTextBox.Size = new Size(188, 23);
            DesignerFilePathTextBox.TabIndex = 0;
            // 
            // LoadDsignerFileButton
            // 
            LoadDsignerFileButton.Location = new Point(119, 51);
            LoadDsignerFileButton.Name = "LoadDsignerFileButton";
            LoadDsignerFileButton.Size = new Size(75, 23);
            LoadDsignerFileButton.TabIndex = 1;
            LoadDsignerFileButton.Text = "ファイル読込";
            LoadDsignerFileButton.UseVisualStyleBackColor = true;
            LoadDsignerFileButton.Click += LoadDsignerFileButton_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(LoadDsignerFileButton);
            groupBox1.Controls.Add(DesignerFilePathTextBox);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 82);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "designer.vb読込";
            // 
            // OutputFileButton
            // 
            OutputFileButton.Location = new Point(12, 104);
            OutputFileButton.Name = "OutputFileButton";
            OutputFileButton.Size = new Size(75, 23);
            OutputFileButton.TabIndex = 3;
            OutputFileButton.Text = "ファイル出力";
            OutputFileButton.UseVisualStyleBackColor = true;
            OutputFileButton.Click += OutputFileButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(225, 139);
            Controls.Add(OutputFileButton);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "でぃ";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox DesignerFilePathTextBox;
        private Button LoadDsignerFileButton;
        private GroupBox groupBox1;
        private Button OutputFileButton;
    }
}
