using System;
using System.Drawing;
using System.Windows.Forms;
using Conversor.Controlers;
using Conversor.Helpers;
using Conversor.Models;
using Conversor.Components;

namespace Conversor {
    public partial class form_main : Form {
        private FileListBox fileList = new FileListBox();
        private General general = new General();
        private int selectedItem = -1;
        
        public form_main() {
            InitializeComponent();
            radio_geral.Checked=true;

            // fileList
            fileList.BackColor=Color.FromArgb(50, 56, 66);
            fileList.BorderStyle=BorderStyle.None;
            fileList.ForeColor=Color.White;
            fileList.FormattingEnabled=true;
            fileList.Name="list_files";
            fileList.SelectedIndexChanged+=new EventHandler(this.list_files_SelectedIndexChanged);
            fileList.Location=new Point(15, 64);
            fileList.Size=new Size(466, 196);

            this.Controls.Add(fileList);
        }

        /* EVENTS
         *************************/
        private void btnSearchFiles_Click(object sender, EventArgs e) {
            if(!Util.checkDialogResult(input.ShowDialog())) return;

            updateFileList(input.FileNames);
        }

        private void btnClear_Click(object sender, EventArgs e) {
            DialogResult result = MessageBox.Show("Limpar lista de arquivos?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(!Util.checkDialogResult(result)) return;

            cbx_scale.Checked=false;
            fileList.SelectedIndex= -1;
            general.clearFileList(ref fileList);
        }

        private void btnRemove_Click(object sender, EventArgs e) {
            DialogResult result = MessageBox.Show(String.Format("Remover o seguinte item?\n   - {0}", fileList.SelectedItem), "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(!Util.checkDialogResult(result)) return;

            general.removeFromFileList(selectedItem, ref fileList);
        }

        private void btnSubtitle_Click(object sender, EventArgs e) {
            if(Util.checkDialogResult(open_subtitle.ShowDialog()))
                txt_sub.Text=Util.getFileName(open_subtitle.FileName);
        }

        private void list_files_SelectedIndexChanged(object sender, EventArgs e) {
            selectedItem=fileList.SelectedIndex;
            bool haveItens = (fileList.Items.Count>0 && selectedItem>=0);

            if(haveItens) {
                MediaFile selected = fileList.SelectedFile;
                if(selected!=null) updateConfigs(selected.OutputSettings);
                else {
                    cbx_scale.Checked=false;
                    Util.clearTextBox(new TextBox[] { txt_ext, txt_output, txt_prefix, txt_sub, txt_scaleW, txt_scaleH });
                }
            }
            setEditor(haveItens);
        }

        private void cbx_scale_CheckedChanged(object sender, EventArgs e) {
            panel_scale.Enabled=cbx_scale.Checked;
            if(!panel_scale.Enabled) {
                Util.clearTextBox(new TextBox[]{ txt_scaleW, txt_scaleH });
            }
        }

        /* METHODS
         *************************/
        private void updateFileList(string[] files) {
            general.addToFileList(files, ref fileList);
            fileList.SelectLastItem();
        }

        private void updateConfigs(OutputSettings settings) {
            txt_ext.Text=settings.Extension;
            txt_prefix.Text=settings.Prefix;
            txt_sub.Text=settings.Subtitle;
            txt_output.Text=settings.Path;
            txt_scaleW.Text=settings.Scale[0];
            txt_scaleH.Text=settings.Scale[1];
        }

        private void setEditor(bool enabled) {
            btn_remove.Enabled=
                btn_clear.Enabled=
                    panel_config.Enabled=
                        btn_process.Enabled=enabled;

            if(!enabled) Util.clearTextBox(new TextBox[] { txt_ext, txt_output, txt_prefix, txt_sub, txt_scaleW, txt_scaleH });
        }
    }
}
