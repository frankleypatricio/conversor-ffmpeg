using Conversor.Models;
using System.Diagnostics;
using System.IO;
using System.Text;
using Conversor.Exceptions;
using Conversor.Business;
using Conversor.Helpers;

namespace Conversor.Controlers.Ffmpeg {
    class FFmpeg {
        private const string ffmpeg = "ffmpeg.exe";

        private MediaFile file;
        private OutputSettings settings;
        private FFmpegParams fileParams;
        private OperationResult isReady;

        private Process process;

        public OperationResult IsReady {
            get => isReady;
        }
        public MediaFile File {
            get => file;
        }
        public OutputSettings Settings {
            get => settings;
        }

        public string StandardOutput {
            get { return process.StandardOutput.ReadToEnd(); }
        }
        public StreamWriter StandardInput {
            get { return process.StandardInput; }
        }
        // Por algum motivo, o StandardError que retorna a saída do ffmpeg, sendo erro ou não...
        public string StandardError {
            get { return process.StandardError.ReadToEnd(); }
        }
        public bool HasExited {
            get { return process.HasExited; }
        }

        public FFmpeg(){}

        public FFmpeg(MediaFile file, OutputSettings settings) {
            this.file=file;
            this.settings=settings;
            isReady=new OperationResult(false);
            fileParams=new FFmpegParams();
        }

        private static ProcessStartInfo getProcessStartInfo(string _params, bool redirect) {
            ProcessStartInfo info = new ProcessStartInfo(ffmpeg, _params);
            info.UseShellExecute=false;
            info.CreateNoWindow=true;
            info.RedirectStandardOutput=info.RedirectStandardInput=info.RedirectStandardError=redirect;
            return info;
        }

        public void PreapareStatement()
            => isReady = fileParams.SetParams(this);

        public bool Start() {
            return true;
        }

        public string ConvertSubtitle(string srtFile) {
            srtFile=srtFile.Trim();
            if(!new FileInfo(srtFile).Exists) throw new ConvertSubtitleException("O seguinte arquivo de legenda não existe:", srtFile);
            if(!srtFile.EndsWith(".srt")) throw new ConvertSubtitleException($"O seguinte arquivo de legenda está no formato errado (esperado: .srt):", srtFile);

            new FileValidator().ValidateTempFolder();

            string assFile = srtFile.Replace(".srt", ".ass");
            addTempFolder(ref assFile);
            string _params = new StringBuilder().AppendFormat("-i {0} {1}", srtFile, assFile).ToString();

            ProcessStartInfo info = getProcessStartInfo(_params, false);
            using(process = new Process()) {
                process.StartInfo=info;
                process.Start();
                process.WaitForExit();
            }

            if(process.ExitCode==1)
                throw new ConversionException(ConversionException.getErrorMessege(StandardError));

            return assFile;
        }

        private void addTempFolder(ref string file) {
            int start = file.Contains("\\") ? file.LastIndexOf("\\") : file.LastIndexOf("/");
            string path = file.Remove(start);
            string fileName = file.Remove(0, start);
            file=$"{path}\\temp{fileName}";
        }
    }
}
