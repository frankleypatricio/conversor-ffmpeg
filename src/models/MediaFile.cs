using System.IO;
using Conversor.Helpers;

namespace Conversor.Models {
    class MediaFile {
        private string name;
        private string extension;
        private string path;
        private string fullPath;
        private OutputSettings outputSettings;

        public string Name {
            get { return name; }
        }
        public string Extension {
            get { return extension; }
        }
        public string FullName {
            get { return $"{name}.{extension}"; }
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
                name=Util.removeExtension(info.Name);
                extension=Util.removeString(".", info.Extension);
                path=info.DirectoryName;
                this.fullPath=fullPath;
                outputSettings=new OutputSettings(Enums.Setting.INDIVIDUAL, extension);
            }
        }

        public void setConfigs(string extension, bool changeScale, string prefix, string subtitle, string path, Enums.Setting type, string[] scale)
            => outputSettings=new OutputSettings(extension, changeScale, prefix, subtitle, path, type, scale);
    }
}
