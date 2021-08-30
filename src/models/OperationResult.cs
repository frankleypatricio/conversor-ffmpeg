using System.Collections.Generic;

namespace Conversor.Models {
    class OperationResult {
        private bool state;
        private List<string> messege;
        private List<string> content;
        private string title;

        public bool State {
            get => state;
        }

        public List<string> Messege {
            get => messege;
        }

        public List<string> Content {
            get => content;
        }

        public string Title {
            get => title;
            set => title=value;
        }

        public OperationResult(bool state = true) {
            this.state=state;
            messege=content=new List<string>();
            title="Ocorreu um erro inesperado";
        }

        public void AddMessege(string msg) => messege.Add(msg);
        public void AddContent(string msg) => content.Add(msg);

        public void Error() => state=false;
    }
}
