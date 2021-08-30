using System;
using System.IO;
using Conversor.Data;

namespace Conversor.Business {
    class FileValidator {
        public string ValidateTempFolder() {
            if(!Directory.Exists(Helpers.Path.TempFolder))
                new FileCreator().CreateTempFolder();

            return Helpers.Path.TempFolder;
        }
    }
}
