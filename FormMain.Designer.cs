
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
            this.btn_clear = new FontAwesome.Sharp.IconButton();
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
            this.panel_scale = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel_configHeader = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.radio_geral = new System.Windows.Forms.RadioButton();
            this.radio_indv = new System.Windows.Forms.RadioButton();
            this.btn_output = new FontAwesome.Sharp.IconButton();
            this.panel9 = new System.Windows.Forms.Panel();
            this.txt_output = new System.Windows.Forms.TextBox();
            this.input = new System.Windows.Forms.OpenFileDialog();
            this.output = new System.Windows.Forms.SaveFileDialog();
            this.btn_remove = new FontAwesome.Sharp.IconButton();
            this.panel_process = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.open_subtitle = new System.Windows.Forms.OpenFileDialog();
            this.panel_progress.SuspendLayout();
            this.panel_config.SuspendLayout();
            this.panel_scale.SuspendLayout();
            this.panel_configHeader.SuspendLayout();
            this.panel_process.SuspendLayout();
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
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(138)))), ((int)(((byte)(211)))));
            this.btn_clear.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btn_clear, "btn_clear");
            this.btn_clear.FlatAppearance.BorderSize = 0;
            this.btn_clear.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.btn_clear.IconColor = System.Drawing.Color.White;
            this.btn_clear.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_clear.IconSize = 40;
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btnClear_Click);
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
            this.cbx_scale.CheckedChanged += new System.EventHandler(this.cbx_scale_CheckedChanged);
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
            this.btn_process.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(66)))));
            this.btn_process.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btn_process, "btn_process");
            this.btn_process.FlatAppearance.BorderSize = 0;
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
            this.btn_sub.Click += new System.EventHandler(this.btnSubtitle_Click);
            // 
            // panel_config
            // 
            this.panel_config.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(66)))));
            this.panel_config.Controls.Add(this.panel_scale);
            this.panel_config.Controls.Add(this.label6);
            this.panel_config.Controls.Add(this.label5);
            this.panel_config.Controls.Add(this.label4);
            this.panel_config.Controls.Add(this.label3);
            this.panel_config.Controls.Add(this.panel_configHeader);
            this.panel_config.Controls.Add(this.btn_output);
            this.panel_config.Controls.Add(this.panel9);
            this.panel_config.Controls.Add(this.txt_output);
            this.panel_config.Controls.Add(this.txt_ext);
            this.panel_config.Controls.Add(this.btn_sub);
            this.panel_config.Controls.Add(this.panel10);
            this.panel_config.Controls.Add(this.panel5);
            this.panel_config.Controls.Add(this.txt_sub);
            this.panel_config.Controls.Add(this.txt_prefix);
            this.panel_config.Controls.Add(this.cbx_scale);
            this.panel_config.Controls.Add(this.panel6);
            resources.ApplyResources(this.panel_config, "panel_config");
            this.panel_config.Name = "panel_config";
            // 
            // panel_scale
            // 
            this.panel_scale.Controls.Add(this.label8);
            this.panel_scale.Controls.Add(this.label1);
            this.panel_scale.Controls.Add(this.label7);
            this.panel_scale.Controls.Add(this.txt_scaleW);
            this.panel_scale.Controls.Add(this.panel8);
            this.panel_scale.Controls.Add(this.panel7);
            this.panel_scale.Controls.Add(this.txt_scaleH);
            resources.ApplyResources(this.panel_scale, "panel_scale");
            this.panel_scale.Name = "panel_scale";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(229)))), ((int)(((byte)(200)))));
            this.label8.Name = "label8";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(229)))), ((int)(((byte)(200)))));
            this.label7.Name = "label7";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(229)))), ((int)(((byte)(200)))));
            this.label6.Name = "label6";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(229)))), ((int)(((byte)(200)))));
            this.label5.Name = "label5";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(229)))), ((int)(((byte)(200)))));
            this.label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(229)))), ((int)(((byte)(200)))));
            this.label3.Name = "label3";
            // 
            // panel_configHeader
            // 
            this.panel_configHeader.Controls.Add(this.label2);
            this.panel_configHeader.Controls.Add(this.radio_geral);
            this.panel_configHeader.Controls.Add(this.radio_indv);
            resources.ApplyResources(this.panel_configHeader, "panel_configHeader");
            this.panel_configHeader.Name = "panel_configHeader";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(229)))), ((int)(((byte)(200)))));
            this.label2.Name = "label2";
            // 
            // radio_geral
            // 
            resources.ApplyResources(this.radio_geral, "radio_geral");
            this.radio_geral.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radio_geral.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(138)))), ((int)(((byte)(211)))));
            this.radio_geral.Name = "radio_geral";
            this.radio_geral.TabStop = true;
            this.radio_geral.UseVisualStyleBackColor = true;
            // 
            // radio_indv
            // 
            resources.ApplyResources(this.radio_indv, "radio_indv");
            this.radio_indv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radio_indv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(138)))), ((int)(((byte)(211)))));
            this.radio_indv.Name = "radio_indv";
            this.radio_indv.TabStop = true;
            this.radio_indv.UseVisualStyleBackColor = true;
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
            this.input.Multiselect = true;
            resources.ApplyResources(this.input, "input");
            // 
            // output
            // 
            resources.ApplyResources(this.output, "output");
            // 
            // btn_remove
            // 
            this.btn_remove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.btn_remove.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btn_remove, "btn_remove");
            this.btn_remove.FlatAppearance.BorderSize = 0;
            this.btn_remove.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btn_remove.IconColor = System.Drawing.Color.White;
            this.btn_remove.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_remove.IconSize = 38;
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.UseVisualStyleBackColor = false;
            this.btn_remove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // panel_process
            // 
            this.panel_process.Controls.Add(this.iconButton1);
            this.panel_process.Controls.Add(this.btn_process);
            resources.ApplyResources(this.panel_process, "panel_process");
            this.panel_process.Name = "panel_process";
            // 
            // iconButton1
            // 
            this.iconButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.iconButton1, "iconButton1");
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.InfoCircle;
            this.iconButton1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(229)))), ((int)(((byte)(200)))));
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 35;
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // open_subtitle
            // 
            resources.ApplyResources(this.open_subtitle, "open_subtitle");
            // 
            // form_main
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(66)))));
            this.Controls.Add(this.panel_process);
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.panel_progress);
            this.Controls.Add(this.panel_config);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_searchFiles);
            this.ForeColor = System.Drawing.Color.White;
            this.MaximizeBox = false;
            this.Name = "form_main";
            this.panel_progress.ResumeLayout(false);
            this.panel_progress.PerformLayout();
            this.panel_config.ResumeLayout(false);
            this.panel_config.PerformLayout();
            this.panel_scale.ResumeLayout(false);
            this.panel_scale.PerformLayout();
            this.panel_configHeader.ResumeLayout(false);
            this.panel_configHeader.PerformLayout();
            this.panel_process.ResumeLayout(false);
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
        private FontAwesome.Sharp.IconButton btn_clear;
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
        private FontAwesome.Sharp.IconButton btn_remove;
        private System.Windows.Forms.Panel panel_configHeader;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radio_geral;
        private System.Windows.Forms.RadioButton radio_indv;
        private System.Windows.Forms.Panel panel_process;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel_scale;
        private System.Windows.Forms.OpenFileDialog open_subtitle;
    }
}

