
namespace Conversor {
    partial class form_main {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing&&(components!=null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_main));
            this.btn_searchFiles = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txt_ext = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btn_delete = new FontAwesome.Sharp.IconButton();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txt_prefix = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txt_scaleH = new System.Windows.Forms.TextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txt_scaleW = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.lbl_progressPerc = new System.Windows.Forms.Label();
            this.lbl_progressFile = new System.Windows.Forms.Label();
            this.panel_progress = new System.Windows.Forms.Panel();
            this.cbx_scale = new System.Windows.Forms.CheckBox();
            this.panel10 = new System.Windows.Forms.Panel();
            this.txt_sub = new System.Windows.Forms.TextBox();
            this.btn_process = new FontAwesome.Sharp.IconButton();
            this.btn_sub = new FontAwesome.Sharp.IconButton();
            this.panel_config = new System.Windows.Forms.Panel();
            this.btn_output = new FontAwesome.Sharp.IconButton();
            this.panel9 = new System.Windows.Forms.Panel();
            this.txt_output = new System.Windows.Forms.TextBox();
            this.input = new System.Windows.Forms.OpenFileDialog();
            this.output = new System.Windows.Forms.SaveFileDialog();
            this.list_files = new System.Windows.Forms.ListBox();
            this.panel_progress.SuspendLayout();
            this.panel_config.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_searchFiles
            // 
            this.btn_searchFiles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(229)))), ((int)(((byte)(200)))));
            this.btn_searchFiles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_searchFiles.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btn_searchFiles, "btn_searchFiles");
            this.btn_searchFiles.IconChar = FontAwesome.Sharp.IconChar.FolderOpen;
            this.btn_searchFiles.IconColor = System.Drawing.Color.White;
            this.btn_searchFiles.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_searchFiles.Name = "btn_searchFiles";
            this.btn_searchFiles.UseVisualStyleBackColor = false;
            this.btn_searchFiles.Click += new System.EventHandler(this.btnSearchFiles_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(229)))), ((int)(((byte)(200)))));
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(229)))), ((int)(((byte)(200)))));
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(229)))), ((int)(((byte)(200)))));
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(229)))), ((int)(((byte)(200)))));
            resources.ApplyResources(this.panel4, "panel4");
            this.panel4.Name = "panel4";
            // 
            // txt_ext
            // 
            this.txt_ext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(66)))));
            this.txt_ext.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.txt_ext, "txt_ext");
            this.txt_ext.ForeColor = System.Drawing.Color.White;
            this.txt_ext.Name = "txt_ext";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(229)))), ((int)(((byte)(200)))));
            resources.ApplyResources(this.panel5, "panel5");
            this.panel5.Name = "panel5";
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.btn_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btn_delete, "btn_delete");
            this.btn_delete.FlatAppearance.BorderSize = 0;
            this.btn_delete.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btn_delete.IconColor = System.Drawing.Color.White;
            this.btn_delete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_delete.IconSize = 38;
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(229)))), ((int)(((byte)(200)))));
            resources.ApplyResources(this.panel6, "panel6");
            this.panel6.Name = "panel6";
            // 
            // txt_prefix
            // 
            this.txt_prefix.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(66)))));
            this.txt_prefix.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.txt_prefix, "txt_prefix");
            this.txt_prefix.ForeColor = System.Drawing.Color.White;
            this.txt_prefix.Name = "txt_prefix";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(229)))), ((int)(((byte)(200)))));
            resources.ApplyResources(this.panel7, "panel7");
            this.panel7.Name = "panel7";
            // 
            // txt_scaleH
            // 
            this.txt_scaleH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(66)))));
            this.txt_scaleH.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.txt_scaleH, "txt_scaleH");
            this.txt_scaleH.ForeColor = System.Drawing.Color.White;
            this.txt_scaleH.Name = "txt_scaleH";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(229)))), ((int)(((byte)(200)))));
            resources.ApplyResources(this.panel8, "panel8");
            this.panel8.Name = "panel8";
            // 
            // txt_scaleW
            // 
            this.txt_scaleW.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(66)))));
            this.txt_scaleW.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.txt_scaleW, "txt_scaleW");
            this.txt_scaleW.ForeColor = System.Drawing.Color.White;
            this.txt_scaleW.Name = "txt_scaleW";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(229)))), ((int)(((byte)(200)))));
            this.label1.Name = "label1";
            // 
            // progressBar
            // 
            resources.ApplyResources(this.progressBar, "progressBar");
            this.progressBar.Name = "progressBar";
            // 
            // lbl_progressPerc
            // 
            resources.ApplyResources(this.lbl_progressPerc, "lbl_progressPerc");
            this.lbl_progressPerc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(229)))), ((int)(((byte)(200)))));
            this.lbl_progressPerc.Name = "lbl_progressPerc";
            // 
            // lbl_progressFile
            // 
            resources.ApplyResources(this.lbl_progressFile, "lbl_progressFile");
            this.lbl_progressFile.ForeColor = System.Drawing.Color.White;
            this.lbl_progressFile.Name = "lbl_progressFile";
            // 
            // panel_progress
            // 
            this.panel_progress.Controls.Add(this.progressBar);
            this.panel_progress.Controls.Add(this.lbl_progressPerc);
            this.panel_progress.Controls.Add(this.lbl_progressFile);
            resources.ApplyResources(this.panel_progress, "panel_progress");
            this.panel_progress.Name = "panel_progress";
            // 
            // cbx_scale
            // 
            resources.ApplyResources(this.cbx_scale, "cbx_scale");
            this.cbx_scale.Name = "cbx_scale";
            this.cbx_scale.UseVisualStyleBackColor = true;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(229)))), ((int)(((byte)(200)))));
            resources.ApplyResources(this.panel10, "panel10");
            this.panel10.Name = "panel10";
            // 
            // txt_sub
            // 
            this.txt_sub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(66)))));
            this.txt_sub.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.txt_sub, "txt_sub");
            this.txt_sub.ForeColor = System.Drawing.Color.White;
            this.txt_sub.Name = "txt_sub";
            this.txt_sub.ReadOnly = true;
            // 
            // btn_process
            // 
            this.btn_process.BackColor = System.Drawing.Color.Transparent;
            this.btn_process.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_process.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btn_process, "btn_process");
            this.btn_process.IconChar = FontAwesome.Sharp.IconChar.PlayCircle;
            this.btn_process.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(203)))), ((int)(((byte)(122)))));
            this.btn_process.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_process.IconSize = 80;
            this.btn_process.Name = "btn_process";
            this.btn_process.UseVisualStyleBackColor = false;
            // 
            // btn_sub
            // 
            this.btn_sub.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_sub.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btn_sub, "btn_sub");
            this.btn_sub.IconChar = FontAwesome.Sharp.IconChar.ClosedCaptioning;
            this.btn_sub.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(229)))), ((int)(((byte)(200)))));
            this.btn_sub.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_sub.IconSize = 37;
            this.btn_sub.Name = "btn_sub";
            this.btn_sub.UseVisualStyleBackColor = true;
            // 
            // panel_config
            // 
            this.panel_config.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(66)))));
            this.panel_config.Controls.Add(this.btn_output);
            this.panel_config.Controls.Add(this.panel9);
            this.panel_config.Controls.Add(this.txt_output);
            this.panel_config.Controls.Add(this.txt_ext);
            this.panel_config.Controls.Add(this.btn_sub);
            this.panel_config.Controls.Add(this.label1);
            this.panel_config.Controls.Add(this.panel10);
            this.panel_config.Controls.Add(this.panel5);
            this.panel_config.Controls.Add(this.txt_sub);
            this.panel_config.Controls.Add(this.txt_prefix);
            this.panel_config.Controls.Add(this.cbx_scale);
            this.panel_config.Controls.Add(this.panel6);
            this.panel_config.Controls.Add(this.txt_scaleH);
            this.panel_config.Controls.Add(this.panel7);
            this.panel_config.Controls.Add(this.panel8);
            this.panel_config.Controls.Add(this.txt_scaleW);
            resources.ApplyResources(this.panel_config, "panel_config");
            this.panel_config.Name = "panel_config";
            // 
            // btn_output
            // 
            this.btn_output.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_output.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btn_output, "btn_output");
            this.btn_output.IconChar = FontAwesome.Sharp.IconChar.Folder;
            this.btn_output.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(229)))), ((int)(((byte)(200)))));
            this.btn_output.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_output.IconSize = 37;
            this.btn_output.Name = "btn_output";
            this.btn_output.UseVisualStyleBackColor = true;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(229)))), ((int)(((byte)(200)))));
            resources.ApplyResources(this.panel9, "panel9");
            this.panel9.Name = "panel9";
            // 
            // txt_output
            // 
            this.txt_output.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(66)))));
            this.txt_output.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.txt_output, "txt_output");
            this.txt_output.ForeColor = System.Drawing.Color.White;
            this.txt_output.Name = "txt_output";
            this.txt_output.ReadOnly = true;
            // 
            // input
            // 
            this.input.FileName = "Abrir arquivos";
            this.input.Multiselect = true;
            // 
            // output
            // 
            this.output.FileName = "Pasta de saída";
            // 
            // list_files
            // 
            this.list_files.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(66)))));
            this.list_files.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.list_files, "list_files");
            this.list_files.ForeColor = System.Drawing.Color.White;
            this.list_files.FormattingEnabled = true;
            this.list_files.Name = "list_files";
            // 
            // form_main
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(66)))));
            this.Controls.Add(this.panel_progress);
            this.Controls.Add(this.panel_config);
            this.Controls.Add(this.btn_process);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_searchFiles);
            this.Controls.Add(this.list_files);
            this.ForeColor = System.Drawing.Color.White;
            this.MaximizeBox = false;
            this.Name = "form_main";
            this.panel_progress.ResumeLayout(false);
            this.panel_progress.PerformLayout();
            this.panel_config.ResumeLayout(false);
            this.panel_config.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton btn_searchFiles;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txt_ext;
        private System.Windows.Forms.Panel panel5;
        private FontAwesome.Sharp.IconButton btn_delete;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txt_prefix;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox txt_scaleH;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox txt_scaleW;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label lbl_progressPerc;
        private System.Windows.Forms.Label lbl_progressFile;
        private System.Windows.Forms.Panel panel_progress;
        private System.Windows.Forms.CheckBox cbx_scale;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.TextBox txt_sub;
        private FontAwesome.Sharp.IconButton btn_process;
        private FontAwesome.Sharp.IconButton btn_sub;
        private System.Windows.Forms.Panel panel_config;
        private FontAwesome.Sharp.IconButton btn_output;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.TextBox txt_output;
        private System.Windows.Forms.OpenFileDialog input;
        private System.Windows.Forms.SaveFileDialog output;
        private System.Windows.Forms.ListBox list_files;
    }
}

