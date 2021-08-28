using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Conversor.Controlers;
using Conversor.Helpers;

namespace Conversor {
    public partial class form_main : Form {
        private General general = new General();

        public form_main() {
            InitializeComponent();
        }

        /* EVENTS
         *************************/
        private void btnSearchFiles_Click(object sender, EventArgs e) {
            if(!Util.checkDialogResult(input.ShowDialog())) return;
            Console.WriteLine(list_files.Items.Count);
            updateFileList(input.FileNames);
        }

        /* METHODS
         *************************/
        private void updateFileList(string[] files) => general.addToFileList(files, ref list_files);
    }
}
