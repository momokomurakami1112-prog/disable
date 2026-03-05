using System.Text.RegularExpressions;
using System.Text;

namespace disable
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
            if (!File.Exists(DesignerFilePathTextBox.Text))
            {
                MessageBox.Show("ファイルが見つかりません");
                return;
            }

            // デザイナーファイル読込
            string designerText = File.ReadAllText(DesignerFilePathTextBox.Text);

            // コントロール名取得
            _controlNameList = ExtractGcInputControls(designerText);
            // 「xxx.Enable = False」を作成
            BlockTextBox.Text = BuildEnableFalseBlock(_controlNameList);
        }

        private List<string> ExtractGcInputControls(string designerText)
        {
            List<string> results = new List<string>();

            string pattern = @"Me\.(?<name>\w+)\s*=\s*New.*\.(GcTextBox|GcNumber|GcLabel)\(";

            MatchCollection matches = Regex.Matches(designerText, pattern, RegexOptions.IgnoreCase);

            foreach (Match match in matches)
            {
                string controlName = match.Groups["name"].Value;
                results.Add(controlName);
            }

            return results;
        }

        private string BuildEnableFalseBlock(List<string> controlNames)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine();
            stringBuilder.AppendLine("' ===== Disabled Start =====");
            stringBuilder.AppendLine();
            foreach (string name in controlNames)
            {
                stringBuilder.AppendLine("        Me." + name + ".Enabled = False");
            }
            stringBuilder.AppendLine();
            stringBuilder.AppendLine("' ===== Disabled End =====");
            stringBuilder.AppendLine();
            return stringBuilder.ToString();
        }

        #endregion


    }
}
