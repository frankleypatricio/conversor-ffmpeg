using System;

namespace Conversor.Exceptions {
    class FileAlreadyOnList : Exception {
        const string defaultMessage = "Os seguintes arquivos já estão presentes na lista, por isso não serão adicionados:";
        const string title = "Arquivos já presentes na lista";
        public string[] Files { get; }
        public string Title {
            get => title;
        }

        public FileAlreadyOnList() {}

        public FileAlreadyOnList(string[] files) : base(defaultMessage)
            => Files=files;
    }
}
