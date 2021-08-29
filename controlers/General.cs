using System.Collections.Generic;
using Conversor.Models;
using Conversor.Exceptions;
using Conversor.Components;

namespace Conversor.Controlers {
    class General {
        /*private List<MediaFile> fileList;
        private Dictionary<string, MediaFile> listMap;*/
        private OutputSettings outputSettings;

        /*public List<MediaFile> FileList {
            get { return fileList; }
        }*/

        public OutputSettings OutputSettings {
            get { return outputSettings; }
            set { outputSettings=value; }
        }

        public General() {
            /*fileList=new List<MediaFile>();
            listMap=new Dictionary<string, MediaFile>();*/
            outputSettings=new OutputSettings(true);
        }

        public void addToFileList(string[] files, ref FileListBox list) {
            try {
                foreach(string path in files) {
                    MediaFile file = new MediaFile(path);

                    list.AddFile(file);
                }
            } catch(FileAlreadyOnList e) {
                // faliou
            }
        }

        public void removeFromFileList(int index, ref FileListBox list) {
            if(list.Items.Count > 0) list.RemoveFile(index);
        }

        public void clearFileList(ref FileListBox list) {
            list.ClearAll();
            outputSettings.Clear();
        }
    }
}
