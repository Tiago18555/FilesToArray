namespace FilesToArray
{
    partial class F_Main
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
            components = new System.ComponentModel.Container();
            openFileDiag = new FolderBrowserDialog();
            rtbOutput = new RichTextBox();
            label1 = new Label();
            btnOpenFile = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // openFileDiag
            // 
            openFileDiag.HelpRequest += openFileDiag_HelpRequest;
            // 
            // rtbOutput
            // 
            rtbOutput.Cursor = Cursors.Hand;
            rtbOutput.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            rtbOutput.ForeColor = Color.FromArgb(255, 100, 100);
            rtbOutput.Location = new Point(12, 70);
            rtbOutput.Name = "rtbOutput";
            rtbOutput.Size = new Size(776, 319);
            rtbOutput.TabIndex = 0;
            rtbOutput.Text = "";
            rtbOutput.Click += rtbOutput_Click;
            rtbOutput.TextChanged += rtbOutput_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 47);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 1;
            label1.Text = "OUTPUT";
            label1.TextAlign = ContentAlignment.TopRight;
            // 
            // btnOpenFile
            // 
            btnOpenFile.BackColor = Color.FromArgb(224, 224, 224);
            btnOpenFile.Location = new Point(692, 15);
            btnOpenFile.Name = "btnOpenFile";
            btnOpenFile.Size = new Size(96, 52);
            btnOpenFile.TabIndex = 2;
            btnOpenFile.Text = "&OPEN FOLDER";
            btnOpenFile.UseVisualStyleBackColor = false;
            btnOpenFile.Click += btnOpenFile_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // F_Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 401);
            Controls.Add(btnOpenFile);
            Controls.Add(label1);
            Controls.Add(rtbOutput);
            Name = "F_Main";
            Text = "¿ Choose a File ?";
            Load += F_Main_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FolderBrowserDialog openFileDiag;
        private RichTextBox rtbOutput;
        private Label label1;
        private Button btnOpenFile;
        private ErrorProvider errorProvider1;
    }
}