using System;
using System.Windows.Forms;
using Conversor.Controlers;
using Conversor.Helpers;
using Conversor.Models;

namespace Conversor {
    public partial class form_main : Form {
        private General general = new General();
        private string selectedItem = "";
        
        public form_main() {
            InitializeComponent();
            radio_geral.Checked=true;
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

            list_files.SelectedIndex=-1;
            general.clearFileList(ref list_files);
            Util.clearTextBox(new TextBox[] { txt_ext, txt_output, txt_prefix, txt_sub, txt_scaleW, txt_scaleH });
        }

        private void btnRemove_Click(object sender, EventArgs e) {
            DialogResult result = MessageBox.Show(String.Format("Remover o seguinte item?\n   - {0}", list_files.SelectedItem), "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(!Util.checkDialogResult(result)) return;

            general.removeFromFileList(selectedItem, ref list_files);
        }

        private void btnSubtitle_Click(object sender, EventArgs e) {
            if(Util.checkDialogResult(open_subtitle.ShowDialog()))
                txt_sub.Text=Util.getFileName(open_subtitle.FileName);
        }

        private void list_files_SelectedIndexChanged(object sender, EventArgs e) {
            bool haveItens = (list_files.Items.Count>0 && list_files.SelectedIndex>=0);
            if(haveItens) {
                selectedItem=list_files.SelectedItem.ToString();
                MediaFile selected = general.getListItem(selectedItem);
                if(selected!=null) updateConfigs(selected.OutputSettings);
                else Util.clearTextBox(new TextBox[] { txt_ext, txt_output, txt_prefix, txt_sub, txt_scaleW, txt_scaleH });
            }
            setButtons(haveItens);
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
            general.addToFileList(files, ref list_files);
            list_files.SelectedIndex=list_files.Items.Count-1;
        }

        private void updateConfigs(OutputSettings settings) {
            txt_ext.Text=settings.Extension;
            txt_prefix.Text=settings.Prefix;
            txt_sub.Text=settings.Subtitle;
            txt_output.Text=settings.Path;
            txt_scaleW.Text=settings.Scale[0];
            txt_scaleH.Text=settings.Scale[1];
        }

        private void setButtons(bool enabled) {
            btn_remove.Enabled=
                btn_clear.Enabled=
                    panel_config.Enabled=
                        btn_process.Enabled=enabled;
        }
    }
}
