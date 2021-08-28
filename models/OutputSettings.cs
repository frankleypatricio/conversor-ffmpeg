namespace Conversor.Models {
    class OutputSettings {
        private string extension="";
        private string[] scale = new string[]{ "","" };
        private string prefix="";
        private string subtitle="";
        private string path="";
        private bool isGeneral; // Se é configurações gerais

        public string Extension {
            get { return extension; }
            set { extension=value; }
        }
        public string[] Scale {
            get { return scale; }
            set { scale=value; }
        }
        public string Prefix {
            get{return prefix;}
            set{prefix=value;}
        }
        public string Subtitle {
            get{return subtitle;}
            set{subtitle=value;}
        }
        public string Path {
            get{return path;}
            set => path=value;
        }
        public bool IsGeneral {
            get => isGeneral;
        }

        public OutputSettings(bool isGeneral) => this.isGeneral=isGeneral;

        public OutputSettings(bool isGeneral, string extension) {
            this.isGeneral=isGeneral;
            this.extension=extension;
        }

        public OutputSettings(string extension, string[] scale, string prefix, string subtitle, string path, bool isGeneral) {
            this.extension=extension;
            this.scale=scale;
            this.prefix=prefix;
            this.subtitle=subtitle;
            this.path=path;
            this.isGeneral=isGeneral;
        }

        public void Clear() {
            extension = "";
            scale = new string[] { "", "" };
            prefix = "";
            subtitle = "";
            path = "";
        }
    }
}
