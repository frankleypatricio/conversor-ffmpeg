using System;
using System.IO;

namespace Conversor.Data {
    class FileCreator {
        public void CreateTempFolder()
            => Directory.CreateDirectory($"{Helpers.Path.Root}/temp");
    }
}
