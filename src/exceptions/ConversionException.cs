using System;

namespace Conversor.Exceptions {
    class ConversionException : Exception {
        const string defaultMessage = "Ocorreu um erro ao converter o seguinte arquivo:";
        const string title = "Falha ao converter arquivo";

        public string File { get; }
        public string Title {
            get => title;
        }

        public ConversionException(string file) : base(String.Format("{0} {1}", defaultMessage, file))
            => File=file;

        public ConversionException(string messege, string file) : base(messege)
            => File=file;

        public static string getErrorMessege(string error, string file="", string ext="") {
            error=getErrorLine(error);
            string messege = defaultMessage;

            if(error.Contains("Unable to find a suitable output format for"))
                messege=String.Format("A extenção '{0}' não é suportada para conversão do arquivo '{1}'", ext, file);

            return messege;
        }

        private static string getErrorLine(string error) {
            /* Precisa de 3 remove, o 1° '\n' porque no final da saída tem um '\n'
               e o segundo é pq a mensagem relevante está na penúltima linha */
            error=error.Remove(error.LastIndexOf("\n"));
            error=error.Remove(error.LastIndexOf("\n"));
            return error.Remove(0, error.LastIndexOf("\n"));
        }
    }
}
