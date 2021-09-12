using Conversor.Enums;
using Conversor.Helpers;

namespace Conversor.Models {
    class OutputSettings {
        private string extension="";
        private bool changeScale = false;
        private string[] scale = Util.EmptyScale;
        private string prefix="";
        private string subtitle="";
        private string path="";
        private Setting type; // Se é configurações gerais ou individuais

        public string Extension {
            get { return extension; }
            set { extension=value; }
        }
        public bool ChangeScale {
            get { return changeScale; }
            set { changeScale=value; }
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
        public Setting Type {
            get => type;
        }
        public string FullPath { // Path + Prefixo / Nome do arquivo
            get; set;
        }


        public OutputSettings(Setting type) => this.type=type;

        public OutputSettings(Setting type, string extension) {
            this.type=type;
            this.extension=extension;
        }

        public OutputSettings(string extension, bool changeScale, string prefix, string subtitle, string path, Setting type, string[] scale = null) {
            this.extension=extension;
            this.changeScale=changeScale;
            this.scale = (changeScale && scale!=null) ? scale : Util.EmptyScale;
            this.prefix=prefix;
            this.subtitle=subtitle;
            this.path=path;
            this.type=type;
        }

        public void Clear() {
            extension = "";
            scale = Util.EmptyScale;
            prefix = "";
            subtitle = "";
            path = "";
        }

        public void Trim() {
            Util.Trim(ref prefix);
            Util.Trim(ref extension);
            extension=extension.Replace(".", "");
            if(changeScale) {
                Util.Trim(ref scale[0]);
                Util.Trim(ref scale[1]);
            }
        }

        override public string ToString() {
            string toString = $"Extenção: {extension}\n";
            toString+=$"Prefixo: {prefix}\n";
            toString+=changeScale? $"Escala: {scale[0]}:{scale[1]}\n":"";
            toString+=$"Subs: {subtitle}\n";
            toString+=$"Pasta: {path}\n";
            toString+=$"Tipo: {type}";
            return toString;
        }
    }
}
