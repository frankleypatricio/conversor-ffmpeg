using System;
using System.Windows.Forms;
using Conversor.Controlers;
using Conversor.Helpers;
using Conversor.Models;

namespace Conversor {
    public partial class form_main : Form {
        private General general = new General();

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
        }

        private void list_files_SelectedIndexChanged(object sender, EventArgs e) {
            bool haveItens = (list_files.Items.Count>0 && list_files.SelectedIndex>=0);
            if(haveItens) {
                MediaFile selected = general.getListItem(list_files.SelectedItem.ToString());
                if(selected!=null) updateConfigs(selected.OutputSettings);
                else clearConfig();
            }
            setButtons(haveItens);
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

        private void clearConfig()
            => txt_ext.Text=txt_prefix.Text=txt_sub.Text=txt_output.Text=txt_scaleW.Text=txt_scaleH.Text="";

        private void setButtons(bool enabled) {
            btn_remove.Enabled=
                btn_clear.Enabled=
                    panel_config.Enabled=
                        btn_process.Enabled=enabled;
        }
    }
}
