using System.IO;
using System;

namespace Conversor.Models {
    class MediaFile {
        private string name;
        private string path;
        private string fullPath;
        private OutputSettings outputSettings;

        public string Name {
            get { return name; }
        }
        public string Path {
            get { return path; }
        }
        public string FullPath {
            get {return fullPath; }
        }
        public OutputSettings OutputSettings {
            get { return outputSettings; }
        }

        public MediaFile(string fullPath) {
            FileInfo info = new FileInfo(fullPath);
            if(info.Exists) {
                name=info.Name;
                path=info.DirectoryName;
                this.fullPath=fullPath;
            }
        }

        public void setConfigs(string extension, int[] scale, string prefix, string subtitle, string path, bool isGeneral)
            => outputSettings=new OutputSettings(extension, scale, prefix, subtitle, path, isGeneral);
    }
}
