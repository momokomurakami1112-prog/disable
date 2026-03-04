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

        #region ファイル出力

        private void OutputFileButton_Click(object sender, EventArgs e)
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
            string insertText = BuildEnableFalseBlock(_controlNameList);

            // 挿入位置チェック
            int initIndex = designerText.IndexOf("Private Sub InitializeComponent()");
            if (initIndex < 0)
            {
                MessageBox.Show("InitializeComponent が見つかりません");
                return;
            }
            int endSubIndex = designerText.IndexOf("End Sub", initIndex);
            if (endSubIndex < 0)
            {
                MessageBox.Show("End Sub が見つかりません");
                return;
            }

            // Falseのブロックを挿入
            string modifiedText = designerText.Insert(endSubIndex, insertText);

            string exeDir = Path.GetDirectoryName(Application.ExecutablePath);
            string outputDir = Path.Combine(exeDir, "output");
            // ディレクトリチェック
            if (!Directory.Exists(outputDir))
            {
                Directory.CreateDirectory(outputDir);
            }
             string inputPath = Path.GetFileNameWithoutExtension(DesignerFilePathTextBox.Text).Replace(".designer", "");

            // 出力ファイル名
            string outputPath = Path.Combine(outputDir,Path.GetFileNameWithoutExtension(inputPath) + "_Disabled.Designer.vb");
            // ファイル書き込み
            File.WriteAllText(outputPath, modifiedText);

            MessageBox.Show("出力完了: " + outputPath);
        }

        private List<string> ExtractGcInputControls(string designerText)
        {
            List<string> results = new List<string>();

            string pattern = @"Me\.(?<name>\w+)\s*=\s*new\s+[^\r\n]*\.(GcTextBox|GcNumber|GcLabel)\b";

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
