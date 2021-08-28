using System.Collections.Generic;
using System.Windows.Forms;
using Conversor.Models;
using Conversor.Exceptions;

namespace Conversor.Controlers {
    class General {
        private List<MediaFile> fileList;
        private Dictionary<string, MediaFile> listMap;
        private OutputSettings outputSettings;

        public List<MediaFile> FileList {
            get { return fileList; }
        }

        public OutputSettings OutputSettings {
            get { return outputSettings; }
            set { outputSettings=value; }
        }

        public General() {
            fileList=new List<MediaFile>();
            listMap=new Dictionary<string, MediaFile>();
            outputSettings=new OutputSettings(true);
        }

        public void addToFileList(string[] files, ref ListBox list) {
            try {
                foreach(string file in files) {
                    MediaFile mediaFile = new MediaFile(file);

                    fileList.Add(mediaFile);
                    list.Items.Add(mediaFile.FullPath);
                    listMap.Add(mediaFile.FullPath, mediaFile);
                }
            } catch(FileAlreadyOnList e) {
                // faliou
            }
        }

        public void removeFromFileList(string fileName, ref ListBox list) {
            if(!listMap.ContainsKey(fileName)) return;
            fileList.Remove(listMap[fileName]);
            listMap.Remove(fileName);
            list.Items.Remove(fileName);
        }

        public void clearFileList(ref ListBox list) {
            list.Items.Clear();
            fileList.Clear();
            listMap.Clear();
            outputSettings.Clear();
        }

        public MediaFile getListItem(string fileName)
            => listMap.ContainsKey(fileName) ? listMap[fileName] : null;
    }
}
