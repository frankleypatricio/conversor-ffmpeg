using System.IO;

namespace Conversor.Helpers {
    class Path {
        public static string Root {
            get => Directory.GetCurrentDirectory();
        }

        public static string TempFolder {
            get => $"{Root}/temp";
        }

        public static string FFmpeg {
            get => $"{Root}/ffmpeg.exe";
        }

        public static string Database {
            get => $"{Root}/configs.config"; // AQUI SERÁ O DATABASE, MAS COM EXTENÇAÕ ALTERADA SE POSSÍVEL...
        }
    }
}
