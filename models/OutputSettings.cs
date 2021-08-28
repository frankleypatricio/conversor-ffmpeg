namespace Conversor.Models {
    class OutputSettings {
        private string extension;
        private int[] scale = new int[2];
        private string prefix;
        private string subtitle;
        private string path;
        private bool isGeneral; // Se é configurações gerais

        public string Extension {
            get; set;
        }
        public int[] Scale {
            get; set;
        }
        public string Prefix {
            get; set;
        }
        public string Subtitle {
            get; set;
        }
        public string Path {
            get; set;
        }
        public bool IsGeneral {
            get; set;
        }

        public OutputSettings(bool isGeneral) => this.isGeneral=isGeneral;

        public OutputSettings(string extension, int[] scale, string prefix, string subtitle, string path, bool isGeneral) {
            this.extension=extension;
            this.scale=scale;
            this.prefix=prefix;
            this.subtitle=subtitle;
            this.path=path;
            this.isGeneral=isGeneral;
        }
    }
}
