using System.Windows.Forms;
using System.Collections.Generic;
using Conversor.Models;

namespace conversor_ffmpeg.components {
    class FileListBox : ListBox {
        private Dictionary<string, MediaFile> file = new Dictionary<string, MediaFile>();
        public MediaFile SelectedFile {
            get => file[this.SelectedItem.ToString()];
        }

        public void ClearAll() {
            file.Clear();
            this.Items.Clear();
        }

        public void AddFile(MediaFile mediafile) {
            file.Add(mediafile.FullName, mediafile);
            this.Items.Add(mediafile.FullName);
        }
    }
}
