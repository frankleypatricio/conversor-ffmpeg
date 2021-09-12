using System.Windows.Forms;
using System.Collections.Generic;
using System.IO;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace Conversor.Helpers {
    class Util {
        public static string[] EmptyScale {
            get => new string[] { "", "" };
        }
        
        public static string InvalidCharacters {
            get => "\\ / | < > * : \" ? ";
        }

        public static bool checkDialogResult(DialogResult result)
            => result==DialogResult.OK | result==DialogResult.Yes;

        public static bool checkDialogResult(CommonFileDialogResult result)
            => result==CommonFileDialogResult.Ok;

        public static string removeExtension(string fullName) {
            int count = fullName.LastIndexOf(".");
            return fullName.Remove(count);
        }

        public static string getFileName(string fullPath) {
            try {
                FileInfo file = new FileInfo(fullPath);
                return file.Exists ? file.Name : "";
            } catch(System.ArgumentException) {
                return "";
            }
        }

        public static bool isEmpty(string str)
            => str=="";

        public static string getFileExtension(string fullPath) {
            int end = fullPath.LastIndexOf(".");
            return fullPath.Remove(0, end);
        }

        public static void clearTextBox(TextBox[] itens) {
            foreach(TextBox item in itens) item.Text="";
        }

        public static string removeString(string remove, string str) => str.Replace(remove, "");
        //public static void removeString(string remove, ref string str) => str.Replace(remove, "");

        public static string toString(object data) => data!=null ? data.ToString() : "";

        public static string Trim(ref string str) => str=str.Trim();

    }
}
