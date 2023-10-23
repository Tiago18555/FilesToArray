using System.CodeDom;
using System.Diagnostics;
using System.Security;
using System.Text;
using System.Windows.Forms;

namespace FilesToArray
{
    public partial class F_Main : Form
    {
        public F_Main() => InitializeComponent();
        private void openFileDiag_HelpRequest(object sender, EventArgs e) { }
        private void rtbOutput_TextChanged(object sender, EventArgs e) { }
        private void BtnOpenFile_click(object sender, EventArgs e)
        {
            if (openFileDiag.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string folderPath = openFileDiag.SelectedPath;
                    string[] files = Directory.GetFiles(folderPath);

                    StringBuilder outputText = new StringBuilder();
                    outputText.Append("    files = [\n");

                    foreach (string file in files)
                    {
                        string fileName = Path.GetFileName(file);
                        outputText.AppendFormat("        \"./sample_data/{0}\",\n", fileName);
                    }

                    outputText.Length -= 2; // Remove the last comma and newline
                    outputText.Append("    ]\n");

                    rtbOutput.Clear();
                    rtbOutput.Text = outputText.ToString();

                    label1.Text = $"Files Loaded : {files.Length}";
                    rtbOutput.ForeColor = Color.FromArgb(255, 120, 120);
                }
                catch (DirectoryNotFoundException ex)
                {
                    MessageBox.Show($"Error: No such file or directory : {openFileDiag.SelectedPath}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Fatal: Unknown error\n{ex.Message}");
                }
            }
        }
        private void RtbOutput_click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(rtbOutput.Text))
            {
                MessageBox.Show("Please, choose a folder first");
                return;
            }

            Clipboard.SetText(rtbOutput.Text);
            rtbOutput.ForeColor = Color.Green;
            this.label1.Text = "COPIED !";
        }

        private void F_Main_Load(object sender, EventArgs e)
        {
            label1.Text = "OUTPUT";
        }

        private void arrayToFilesMenu_Click(object sender, EventArgs e) => new F_ArrayToFiles().Show();
    }
}