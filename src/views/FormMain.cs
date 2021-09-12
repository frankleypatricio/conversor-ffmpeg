using System;
using System.Drawing;
using System.Windows.Forms;
using Conversor.Controlers;
using Conversor.Helpers;
using Conversor.Models;
using Conversor.Components;
using Conversor.Enums;
using Microsoft.WindowsAPICodePack.Dialogs;
using FontAwesome.Sharp;

namespace Conversor {
    public partial class form_main : Form {
        CommonOpenFileDialog output = new CommonOpenFileDialog(); // Selecionar pasta de saída
        private FileListBox fileList = new FileListBox(); // Lista de arquivos
        private General general = new General(); // Configurações gerais
        private int selectedItem = -1; // Item selecionado na lista
        private Setting setting = Setting.GENERAL; // Configurações selecionada

        private OutputSettings UsedSettings { // Configs atualmente usadas baseada no RadioButton delas
            get => setting==Setting.GENERAL ? general.OutputSettings : fileList.SelectedFile.OutputSettings;
        }

        public form_main() {
            InitializeComponent();
            radio_geral.Checked=true;

            // output
            output.IsFolderPicker=true;
            output.Title="Selecionar pasta de saída";

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
        private void btnProcess_Click(object sender, EventArgs e) {
            foreach(MEd)
            if(setting==Setting.GENERAL) {
                general.OutputSettings.Trim();

            }
        }

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
            if(Util.checkDialogResult(open_subtitle.ShowDialog())) {
                txt_sub.Text=Util.getFileName(open_subtitle.FileName);
                UsedSettings.Subtitle=open_subtitle.FileName;
            } else UsedSettings.Subtitle=txt_sub.Text="";

            updateCrossRemoveButtons();
        }

        private void btnOutput_Click(object sender, EventArgs e) {
            if(Util.checkDialogResult(output.ShowDialog()))
                UsedSettings.Path=txt_output.Text=output.FileName;
            else UsedSettings.Path=txt_output.Text="";

            updateCrossRemoveButtons();
        }

        private void btnCrossRemove_Click(object sender, EventArgs e) {
            IconButton btn = (IconButton)sender;
            string tag = btn.Tag.ToString();

            btn.Enabled=false;
            switch(tag) {
                case "sub":
                    UsedSettings.Subtitle=txt_sub.Text="";
                    break;
                case "output":
                    UsedSettings.Path=txt_output.Text="";
                    break;
            }
        }

        private void list_files_SelectedIndexChanged(object sender, EventArgs e) {
            selectedItem=fileList.SelectedIndex;
            bool haveItens = (fileList.Items.Count>0 && selectedItem>=0);

            if(haveItens && setting == Setting.INDIVIDUAL) {
                MediaFile selected = fileList.SelectedFile;
                if(selected!=null) updateSettings();
                else {
                    cbx_scale.Checked=false;
                    Util.clearTextBox(new TextBox[] { txt_ext, txt_output, txt_prefix, txt_sub, txt_scaleW, txt_scaleH });
                }
            }

            setEditor(haveItens);
        }

        private void cbx_scale_CheckedChanged(object sender, EventArgs e) {
            UsedSettings.ChangeScale=panel_scale.Enabled=cbx_scale.Checked;
            if(!panel_scale.Enabled) {
                Util.clearTextBox(new TextBox[]{ txt_scaleW, txt_scaleH });
                UsedSettings.Scale=Util.EmptyScale;
            }
        }

        private void RadioSettings_CheckedChanged(object sender, EventArgs e) {
            RadioButton radio = (RadioButton)sender;
            short tag = Convert.ToInt16(radio.Tag);
            setting=tag==0 ? Setting.INDIVIDUAL : Setting.GENERAL;
            updateSettings();
        }

        /* CASO DÊ PROBLEMA, TROCAR PRA AO ALTERAR TEXTO INVÉS DE PERDER O FOCO */
        private void TextBox_FocusLeave(object sender, EventArgs e) {
            TextBox value = (TextBox)sender;

            switch(value.Tag.ToString()) {
                case "ext": UsedSettings.Extension=value.Text; break;
                case "prefix": UsedSettings.Prefix=value.Text; break;
                case "scaleW": UsedSettings.Scale[0]=value.Text; break;
                case "scaleH": UsedSettings.Scale[1]=value.Text; break;
                
            }
        }

        private void TextBox_TextChanged(object sender, EventArgs e) {
            TextBox value = (TextBox)sender;

            switch(value.Tag.ToString()) {
                case "sub": UsedSettings.Subtitle=value.Text; break;
                case "output": UsedSettings.Path=value.Text; break;

            }
        }

        /* METHODS
         *************************/
        private void updateFileList(string[] files) {
            general.addToFileList(files, ref fileList);
            fileList.SelectLastItem();
        }

        private void updateSettings() {
            txt_ext.Text=UsedSettings.Extension;
            txt_prefix.Text=UsedSettings.Prefix;
            txt_sub.Text=Util.getFileName(UsedSettings.Subtitle);
            txt_output.Text=UsedSettings.Path;
            setTxtScales(UsedSettings.ChangeScale ? UsedSettings.Scale : Util.EmptyScale);
            cbx_scale.Checked=UsedSettings.ChangeScale;
            updateCrossRemoveButtons();
        }

        private void setTxtScales(string[] scales) {
            txt_scaleW.Text=scales[0];
            txt_scaleH.Text=scales[1];
        }

        private void setEditor(bool enabled) {
            btn_remove.Enabled=
                btn_clear.Enabled=
                    panel_config.Enabled=
                        btn_process.Enabled=enabled;

            if(!enabled) Util.clearTextBox(new TextBox[] { txt_ext, txt_output, txt_prefix, txt_sub, txt_scaleW, txt_scaleH });
        }

        private void updateCrossRemoveButtons() {
            btn_removeSub.Enabled=(txt_sub.Text!="");
            btn_removeOutput.Enabled=(txt_output.Text!="");
        }
    }
}
