using System;

namespace Conversor.Exceptions {
    class LocalFileException : Exception {
        const string defaultMessage = "O seguinte arquivo não foi encontrado na pasta raíz do programa:";
        const string title = "Falha ao buscar arquivo";

        public string File { get; }
        public string Title {
            get => title;
        }

        public LocalFileException(string file) : base(String.Format("{0} {1}", defaultMessage, file))
            => File=file;
    }
}
