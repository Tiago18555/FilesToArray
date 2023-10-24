using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Runtime.CompilerServices;
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

        private string? SelectedFolderPath { get; set; } = "";
        private const string REMOVE_TEXT_VALUE = "Download";
        private string[] allowedExtensions { get; set; } = { ".ts", ".mp4", ".avi", ".mp3", ".wav", ".flac" };
        private string[]? Titles { get; set; }

        private void btn_Generate_Click(object sender, EventArgs e)
        {
            this.Titles = GetTitlesFromInput();

            if (Titles.Length == 0)
            {
                MessageBox.Show("Lista vazia");
                return;
            }

            if (string.IsNullOrWhiteSpace(SelectedFolderPath))
            {
                MessageBox.Show("Por favor, selecione um diretório primeiro.");
                return;
            }

            RenameFilesInDirectory(Titles);
        }

        private void btn_Openfolder_Click(object sender, EventArgs e)
        {
            if (openFileDiag.ShowDialog() == DialogResult.OK)
            {
                this.SelectedFolderPath = openFileDiag.SelectedPath;
            }
        }

        private string[] GetTitlesFromInput()
        {
            return rtb_Input.Text.Replace(REMOVE_TEXT_VALUE, "").Split("\n\n");
        }

        private void RenameFilesInDirectory(string[] titles)
        {
            var files = new DirectoryInfo(this.SelectedFolderPath)
                .GetFiles()
                .Where(file => !file.Attributes.HasFlag(FileAttributes.Directory)) // Ignorar pastas
                .Where(file => !file.Attributes.HasFlag(FileAttributes.Hidden)) // Ignorar arquivos ocultos
                .Where(file => allowedExtensions.Contains(file.Extension.ToLower())) // Filtrar por extensão
                .OrderBy(file => file.LastWriteTime) // Ordenar por data de criação
                .ToList();

            if (files.Count != titles.Length)
            {
                MessageBox.Show("O número de títulos não corresponde ao número de arquivos!");
                MessageBox.Show($"FILES: {files.Count()} \nTITLES: {titles.Length}");
                return;
            }

            for (int i = 0; i < files.Count; i++)
            {
                var newFileName = titles[i].Sanitize() + Path.GetExtension(files[i].FullName);
                var newFilePath = Path.Combine(this.SelectedFolderPath, newFileName);

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
