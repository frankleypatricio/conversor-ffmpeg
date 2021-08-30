using Conversor.Models;
using Conversor.Exceptions;
using Conversor.Components;
using System;

namespace Conversor.Controlers {
    class General {
        private OutputSettings outputSettings;

        public OutputSettings OutputSettings {
            get { return outputSettings; }
            set { outputSettings=value; }
        }

        public General() => outputSettings=new OutputSettings(Enums.Setting.GENERAL);

        public void addToFileList(string[] files, ref FileListBox list) {
            try {
                foreach(string path in files) {
                    MediaFile file = new MediaFile(path);

                    list.AddFile(file);
                }
            } catch(Exception e) {
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
