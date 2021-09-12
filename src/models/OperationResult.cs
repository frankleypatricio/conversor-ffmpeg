using System.Collections.Generic;

namespace Conversor.Models {
    public class OperationResult {
        private bool state;
        private List<string> messeges;
        private List<string> content;
        private string title;
        private string formTitle;
        private string file;

        public bool State {
            get => state;
            set => state=value;
        }

        public List<string> Messeges {
            get => messeges;
        }

        public int Count {
            get => messeges.Count;
        }

        public List<string> Content {
            get => content;
        }

        public string Title {
            get => title;
            set => title=value;
        }

        public string FormTitle {
            get => formTitle;
            set => formTitle=value;
        }

        public string File {
            get => file;
            set => file=value;
        }

        public OperationResult(bool state = true) {
            this.state=state;
            messeges=content=new List<string>();
            title="Ocorreu um erro inesperado";
        }

        public void SetCompleteError(string tile, string message, string file) {
            this.title=Title;
            AddMessege(message);
            AddContent(file);
        }

        public void AddMessege(string msg) => messeges.Add(msg);
        public void AddContent(string msg) => content.Add(msg);
    }
}
