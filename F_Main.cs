using System.Diagnostics;
using System.Security;
using System.Windows.Forms;

namespace FilesToArray
{
    public partial class F_Main : Form
    {
        public F_Main()
        {
            InitializeComponent();
        }

        private void openFileDiag_HelpRequest(object sender, EventArgs e)
        {

        }

        private void rtbOutput_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            if (openFileDiag.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string folderPath = openFileDiag.SelectedPath;
                    string[] files = Directory.GetFiles(folderPath);

                    rtbOutput.Clear();
                    rtbOutput.Text += "[\n";

                    foreach (string file in files)
                    {
                        string fileName = Path.GetFileName(file);
                        rtbOutput.Text += $"\"./sample_data/{fileName}\",\n";
                    }

                    rtbOutput.Text = rtbOutput.Text.Remove(rtbOutput.Text.Length - 2);
                    rtbOutput.Text += "\n]";

                    MessageBox.Show("Texto copiado para área de transferência");

                    rtbOutput.ForeColor = Color.Green;

                    Clipboard.SetText(rtbOutput.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao acessar a pasta.\n\nMensagem de erro: {ex.Message}\n\n" +
                                    $"Detalhes:\n\n{ex.StackTrace}");
                }
            }
        }
    }
}