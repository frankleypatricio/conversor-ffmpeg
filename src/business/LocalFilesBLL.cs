using System;
using System.IO;
using Conversor.Data;
using Conversor.Exceptions;

namespace Conversor.Business {
    class LocalFilesBLL {
        public string tempFolder() {
            if(!Directory.Exists(Helpers.Path.TempFolder))
                new LocalFilesDAO().CreateTempFolder();

            return Helpers.Path.TempFolder;
        }

        public string ffmpegExe() {
            if(!File.Exists(Helpers.Path.FFmpeg))
                throw new LocalFileException(Helpers.Path.FFmpeg);

            return Helpers.Path.FFmpeg;
        }
    }
}
