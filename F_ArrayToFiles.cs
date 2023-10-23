using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilesToArray
{
    public partial class F_ArrayToFiles : Form
    {
        public F_ArrayToFiles()
        {
            InitializeComponent();
        }

        private string? selectedFolderPath;

        private const string RemoveTextValue = "Download";
        private string[] titles { get; set; }

        private void btn_Generate_Click(object sender, EventArgs e)
        {
            this.titles = GetTitlesFromInput();

            if (titles.Length == 0)
            {
                MessageBox.Show("Lista vazia");
                return;
            }

            if (string.IsNullOrWhiteSpace(selectedFolderPath))
            {
                MessageBox.Show("Por favor, selecione um diretório primeiro.");
                return;
            }

            RenameFilesInDirectory(titles, selectedFolderPath);
        }

        private void btn_Openfolder_Click(object sender, EventArgs e)
        {
            if (openFileDiag.ShowDialog() == DialogResult.OK)
            {
                selectedFolderPath = openFileDiag.SelectedPath;
            }
        }

        private string[] GetTitlesFromInput()
        {
            return rtb_Input.Text.Replace(RemoveTextValue, "").Split("\n\n");
        }

        private void RenameFilesInDirectory(string[] titles, string directoryPath)
        {
            var files = new DirectoryInfo(directoryPath).GetFiles()
                .Where(file => !file.Attributes.HasFlag(FileAttributes.Directory)) // Ignorar pastas
                .OrderBy(file => file.CreationTime) // Ordenar por data de criação
                .ToList();

            if (files.Count != titles.Length)
            {
                MessageBox.Show("O número de títulos não corresponde ao número de arquivos!");
                MessageBox.Show($"FILES: {files.Count()} \nTITLES: {titles.Length}");
                return;
            }

            for (int i = 0; i < files.Count; i++)
            {
                var newFileName = titles[i] + Path.GetExtension(files[i].FullName);
                var newFilePath = Path.Combine(directoryPath, newFileName);

                try
                {
                    files[i].MoveTo(newFilePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao renomear o arquivo {files[i].Name}: {ex.Message}");
                    return; // Interrompe o processo se houver um erro
                }
            }

            MessageBox.Show("Arquivos renomeados com sucesso!");
        }
    }
}
