namespace FilesToArray
{
    partial class F_ArrayToFiles
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rtb_Input = new System.Windows.Forms.RichTextBox();
            this.btn_Generate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Openfolder = new System.Windows.Forms.Button();
            this.openFileDiag = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // rtb_Input
            // 
            this.rtb_Input.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rtb_Input.Location = new System.Drawing.Point(0, 156);
            this.rtb_Input.Name = "rtb_Input";
            this.rtb_Input.Size = new System.Drawing.Size(800, 294);
            this.rtb_Input.TabIndex = 0;
            this.rtb_Input.Text = "";
            // 
            // btn_Generate
            // 
            this.btn_Generate.Location = new System.Drawing.Point(408, 97);
            this.btn_Generate.Name = "btn_Generate";
            this.btn_Generate.Size = new System.Drawing.Size(380, 53);
            this.btn_Generate.TabIndex = 1;
            this.btn_Generate.Text = "&GENERATE";
            this.btn_Generate.UseVisualStyleBackColor = true;
            this.btn_Generate.Click += new System.EventHandler(this.btn_Generate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(470, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "COPIE O TEXTO DA LISTA DA PÁGINA DA UDEMY.FASTHUB SEM O TíTULO E COLE AQUI.";
            // 
            // btn_Openfolder
            // 
            this.btn_Openfolder.Location = new System.Drawing.Point(12, 97);
            this.btn_Openfolder.Name = "btn_Openfolder";
            this.btn_Openfolder.Size = new System.Drawing.Size(380, 53);
            this.btn_Openfolder.TabIndex = 1;
            this.btn_Openfolder.Text = "&OPEN FOLDER";
            this.btn_Openfolder.UseVisualStyleBackColor = true;
            this.btn_Openfolder.Click += new System.EventHandler(this.btn_Openfolder_Click);
            // 
            // F_ArrayToFiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Openfolder);
            this.Controls.Add(this.btn_Generate);
            this.Controls.Add(this.rtb_Input);
            this.Name = "F_ArrayToFiles";
            this.Text = "F_ArrayToFiles";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RichTextBox rtb_Input;
        private Button btn_Generate;
        private Label label1;
        private Button btn_Openfolder;
        private FolderBrowserDialog openFileDiag;
    }
}