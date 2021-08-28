using System.Collections.Generic;
using System.Windows.Forms;
using Conversor.Models;

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
            foreach(string file in files) {
                MediaFile mediaFile = new MediaFile(file);
                fileList.Add(mediaFile);
                list.Items.Add(mediaFile.Name);
                listMap.Add(mediaFile.Name, mediaFile);
            }
        }
    }
}
