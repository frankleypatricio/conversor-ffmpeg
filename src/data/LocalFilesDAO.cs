using System;
using System.IO;

namespace Conversor.Data {
    class LocalFilesDAO {
        public void CreateTempFolder()
            => Directory.CreateDirectory($"{Helpers.Path.Root}/temp");
    }
}
