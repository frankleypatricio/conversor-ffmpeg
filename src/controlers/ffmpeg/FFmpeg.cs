using Conversor.Models;
using System.Diagnostics;
using System.IO;
using System.Text;
using Conversor.Exceptions;
using Conversor.Business;
using Conversor.Helpers;
using System;
using System.Windows.Forms;
using Conversor.Enums;

namespace Conversor.Controlers.Ffmpeg {
    class FFmpeg {
        private const string ffmpeg = "ffmpeg.exe";

        private MediaFile file;
        private OutputSettings settings;

        private FFmpegParams fileParams;
        private Process process;

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

        public FFmpeg() {}

        public FFmpeg(MediaFile file, OutputSettings settings) {
            this.file=file;
            this.settings=settings;
            fileParams=new FFmpegParams();
        }

        private bool PreapareStatement(string inPath, ref string outPath, ref OperationResult result) {
            Overwrite overwrite = settings.Overwrite;
            try {
                fileParams.SetParams(settings);
                if(File.Exists(outPath)) {
                    if(overwrite==Overwrite.DECIDE)
                        overwrite=fileAlreadyExistsDialog(outPath);

                    switch(overwrite) {
                        case Overwrite.YES:
                            fileParams.Overwrite(true);
                            break;
                        case Overwrite.NO:
                            outPath=KeepFile(outPath);
                            break;
                        case Overwrite.CANCEL:
                            MessageBox.Show("Conversão do arquivo "+file.FullName+" cancelada!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return false;
                    }
                }
            } catch(ConversionException e) {
                result.AddMessege(e.Message);
                return false;
            } catch(ConvertSubtitleException e) {
                result.AddMessege(e.Message);
                return false;
            } catch(Exception e) {
                result.AddMessege(e.Message);
                return false;
            }

            return true;
        }

        public void Start(ref OperationResult result) {
            // VALIDAR INFILE E OUTPATH NA BLL
            string inFile = file.FullPath;
            string outFile = settings.FullPath; // Montar o outFile com o prefixo na BLL
            if(!PreapareStatement(inFile, ref outFile, ref result)) return;

            string _params = string.Format(
                "{0} {1} {2} {3}", // 0- InParams / 1- InFile / 2- OutParams / 3- OutFile
                fileParams.InParams,
                inFile,
                fileParams.OutParams,
                outFile
            ).ToString();

            try {
                ProcessStartInfo info = getProcessStartInfo(_params, true);
                using(process=new Process()) {
                    process.StartInfo=info;
                    process.Start();
                    process.WaitForExit();

                    if(process.ExitCode==1)
                        throw new ConversionException(
                            ConversionException.getErrorMessege(StandardError, file.FullName, settings.Extension));
                }

                result.State=true;
            } catch(ConversionException e) {
                result.AddMessege(e.Message);
            } catch(ConvertSubtitleException e) {
                result.AddMessege(e.Message);
            } catch(Exception e) {
                result.AddMessege(e.Message);
            }
        }

        private ProcessStartInfo getProcessStartInfo(string _params, bool redirect) {
            ProcessStartInfo info = new ProcessStartInfo(ffmpeg, _params);
            info.UseShellExecute=false;
            info.CreateNoWindow=true;
            info.RedirectStandardOutput=info.RedirectStandardInput=info.RedirectStandardError=redirect;
            return info;
        }

        public string ConvertSubtitle(string srtFile) {
            if(!new FileInfo(srtFile).Exists) throw new ConvertSubtitleException("O seguinte arquivo de legenda não existe:", srtFile);
            if(!srtFile.EndsWith(".srt")) throw new ConvertSubtitleException($"O seguinte arquivo de legenda está no formato errado (esperado: .srt):", srtFile);

            new LocalFilesBLL().tempFolder();

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
                throw new ConversionException(
                    ConversionException.getErrorMessege(StandardError, srtFile, "ass"));

            return assFile;
        }

        private void addTempFolder(ref string file) {
            int start = file.Contains("\\") ? file.LastIndexOf("\\") : file.LastIndexOf("/");
            string path = file.Remove(start);
            string fileName = file.Remove(0, start);
            file=$"{path}\\temp{fileName}";
        }

        private Overwrite fileAlreadyExistsDialog(string outPath) {
            DialogResult result = MessageBox.Show(
                "O arquivo de saída já existe no diretório, deseja substituílo?\n"+
                "- "+outPath+
                "\n( Caso escolha 'Não', os dois arquivos serão mantidos )",
                "Atenção",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Warning
            );

            switch(result) {
                case DialogResult.Yes: return Overwrite.YES;
                case DialogResult.No: return Overwrite.NO;
                case DialogResult.Cancel: return Overwrite.CANCEL;
                default: return settings.Overwrite;
            }
        }

        private string KeepFile(string outFile) {
            string ext = Util.getFileExtension(outFile);
            string path = Util.removeExtension(outFile);
            int num = 1;

            while(File.Exists(outFile))
                outFile=$"{path}{num++}_{ext}";

            return outFile;
        }
    }
}
