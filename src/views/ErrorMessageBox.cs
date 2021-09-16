using System.Windows.Forms;
using Conversor.Models;

namespace Conversor.Views {
    public partial class FormMessage : Form {
        public FormMessage() {
            InitializeComponent();
        }

        private void Ok_Click(object sender, System.EventArgs e)
            => Close();

        public void ShowDialog(OperationResult result) {
            Text=result.FormTitle;
            txt_title.Text=result.Title;
            txt_messageList.Lines=result.Messeges.ToArray();
            ShowDialog();
        }
    }
}
