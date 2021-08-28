using System.Windows.Forms;
using System.Collections.Generic;
using Conversor.Models;

namespace Conversor.Helpers {
    class Util {
        public static bool checkDialogResult(DialogResult result)
            => result==DialogResult.OK | result==DialogResult.Yes;

        public static string getFileName(string fullName) {
            int count = fullName.LastIndexOf(".");
            return fullName.Remove(count);
        }

        public static string removeString(string remove, string str) => str.Replace(remove, "");
        //public static void removeString(string remove, ref string str) => str.Replace(remove, "");

        public static string toString(object data) => data!=null ? data.ToString() : "";
        
    }
}
