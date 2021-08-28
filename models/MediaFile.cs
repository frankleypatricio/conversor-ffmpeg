﻿using System.IO;
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
                name=Util.getFileName(info.Name);
                extension=Util.removeString(".", info.Extension);
                path=info.DirectoryName;
                this.fullPath=fullPath;
                outputSettings=new OutputSettings(false, extension);
            }
        }

        public void setConfigs(string extension, string[] scale, string prefix, string subtitle, string path, bool isGeneral)
            => outputSettings=new OutputSettings(extension, scale, prefix, subtitle, path, isGeneral);
    }
}
