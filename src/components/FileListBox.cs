using System.Windows.Forms;
using System.Collections.Generic;
using Conversor.Models;

namespace Conversor.Components {
    class FileListBox : ListBox {
        private List<MediaFile> file = new List<MediaFile>();

        public MediaFile SelectedFile {
            get => file[SelectedIndex];
        }

        public List<MediaFile> Files {
            get => file;
        }

        public FileListBox() : base() {}

        public void SelectLastItem() => SelectedIndex=Items.Count-1;

        public void AddFile(MediaFile mediafile) {
            file.Add(mediafile);
            Items.Add(mediafile.FullName);
        }

        public void RemoveFile(int index) {
            int nextSelected = SelectedIndex;
            file.RemoveAt(index);
            Items.RemoveAt(index);
            SelectedIndex= nextSelected<Items.Count ? nextSelected : Items.Count-1;
        }

        public void ClearAll() {
            file.Clear();
            this.Items.Clear();
        }
    }
}
