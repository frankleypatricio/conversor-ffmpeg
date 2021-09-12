using System;

namespace Conversor.Exceptions {
    class ConvertSubtitleException : Exception {
        const string defaultMessage = "Ocorreu um erro ao converter o seguinte arquivo de legenda:";
        const string title = "Falha ao converter arquivo de legenda";

        public string File { get; }
        public string Title {
            get => title;
        }

        public ConvertSubtitleException(string file) : base(String.Format("{0} {1}", defaultMessage, file))
            => File=file;

        public ConvertSubtitleException(string messege, string file) : base(String.Format("{0} {1}", messege, file))
            => File=file;
    }
}
