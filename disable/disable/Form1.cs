using System.Text.RegularExpressions;
using System.Text;

namespace BlockMaker
{
    public partial class Form1 : Form
    {
        private List<string> _controlNameList = new List<string>();

        public Form1()
        {
            InitializeComponent();

            // イベント登録
            DesignerFilePathTextBox.DragEnter += FilePathTextBox_DragEnter;
            DesignerFilePathTextBox.DragDrop += FilePathTextBox_DragDrop;
        }

        #region イベントハンドラ

        private void FilePathTextBox_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }
        private void FilePathTextBox_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

            if (files.Length > 0)
            {
                DesignerFilePathTextBox.Text = files[0];
            }
        }

        #endregion


        #region ファイル読込

        private void LoadDsignerFileButton_Click(object sender, EventArgs e)
        {
            using OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "デザイナーファイルを選択";
            dialog.Filter = "Designerファイル (*.designer.vb)|*.designer.vb|すべてのファイル (*.*)|*.*";
            dialog.Multiselect = false;

            if (dialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            DesignerFilePathTextBox.Text = dialog.FileName;
        }

        #endregion

        #region ブロック出力

        private void OutputBlockButton_Click(object sender, EventArgs e)
        {
            BlockTextBox.Text = "";
            if (!File.Exists(DesignerFilePathTextBox.Text))
            {
                MessageBox.Show("ファイルが見つかりません。");
                return;
            }

            // デザイナーファイル読込
            string designerText = File.ReadAllText(DesignerFilePathTextBox.Text);

            // コントロール名取得
            _controlNameList = ExtractGcInputControls(designerText);
            // ユーザー指定取得
            string property = GetSelectedPropertyName();
            string propertyValue = GetSelectedPropertyValue();

            if (string.IsNullOrWhiteSpace(property) || string.IsNullOrWhiteSpace(propertyValue))
            {
                MessageBox.Show("ユーザー指定がされていません。");
                return;
            }
            BlockTextBox.Text = BuildEnableFalseBlock(_controlNameList, property, propertyValue);
        }

        private List<string> ExtractGcInputControls(string designerText)
        {
            List<string> results = new List<string>();
            string pattern = string.Empty;
            if (TextBoxAndNumberRadioButton.Checked)
            {
                pattern = @"Me\.(?<name>\w+)\s*=\s*New.*\.(GcTextBox|GcNumber)\(";
            }
            else if (GcTextBoxRadioButton.Checked)
            {
                pattern = @"Me\.(?<name>\w+)\s*=\s*New.*\.(GcTextBox)\(";
            }
            else if (GcNumberRadioButton.Checked)
            {
                pattern = @"Me\.(?<name>\w+)\s*=\s*New.*\.(GcNumber)\(";
            }
            else
            {
                pattern = @"Me\.(?<name>\w+)\s*=\s*New.*\.(" + CustomControlTextBox.Text + @")\(";
            }

            MatchCollection matches = Regex.Matches(designerText, pattern, RegexOptions.IgnoreCase);

            foreach (Match match in matches)
            {
                string controlName = match.Groups["name"].Value;
                results.Add(controlName);
            }

            return results;
        }



        private string GetSelectedPropertyName()
        {
            if (EnabledRadioButton.Checked)
            {
                return "Enabled";
            }
            else if (ReadOnlyRadioButton.Checked)
            {
                return "ReadOnly";
            }
            else if (TabStopRadioButton.Checked)
            {
                return "TabStop";
            }
            else if (CustomPropertyRadioButton.Checked)
            {
                return CustomPropertyTextBox.Text;
            }

            return string.Empty;
        }

        private string GetSelectedPropertyValue()
        {
            if (TrueRadioButton.Checked)
            {
                return "True";
            }
            else if (FalseRadioButton.Checked)
            {
                return "False";
            }
            else if (CustomPropertyValueRadioButton.Checked)
            {
                return CustomPropertyValueTextBox.Text;
            }

            return string.Empty;
        }
        private string BuildEnableFalseBlock(List<string> controlNames, string property, string propertyValue)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("' ===== Block Start =====");
            stringBuilder.AppendLine();


            foreach (string name in controlNames)
            {
                stringBuilder.AppendLine($"Me.{name}.{property} = {propertyValue}");
            }
            stringBuilder.AppendLine();
            stringBuilder.AppendLine("' ===== Block End =====");
            return stringBuilder.ToString();
        }

        #endregion


        private async void SelectButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(BlockTextBox.Text))
            {
                MessageBox.Show("ブロックが作成されていません。");
                return;
            }
            BlockTextBox.Focus();
            BlockTextBox.SelectAll();
            BlockTextBox.Copy();

            CopyStatusLabel.Visible = true;
            await Task.Delay(1500);
            CopyStatusLabel.Visible = false;
        }

        #region ラジオボタン
        private void CustomControlRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (CustomControlRadioButton.Checked)
            {
                CustomControlTextBox.Enabled = true;
            }
            else
            {
                CustomControlTextBox.Text = "";
                CustomControlTextBox.Enabled = false;
            }
        }

        private void CustomPropertyRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (CustomPropertyRadioButton.Checked)
            {
                CustomPropertyTextBox.Enabled = true;
            }
            else
            {
                CustomPropertyTextBox.Text = "";
                CustomPropertyTextBox.Enabled = false;
            }
        }

        private void CustomPropertyValueRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (CustomPropertyValueRadioButton.Checked)
            {
                CustomPropertyValueTextBox.Enabled = true;
            }
            else
            {
                CustomPropertyValueTextBox.Text = "";
                CustomPropertyValueTextBox.Enabled = false;
            }
        }
        #endregion


    }
}
