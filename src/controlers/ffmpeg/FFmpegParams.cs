using Conversor.Exceptions;
using Conversor.Models;
using System;
using System.Text;

namespace Conversor.Controlers.Ffmpeg {
    class FFmpegParams {
        private const string defaultParams = "-i ";
        private StringBuilder inParams = new StringBuilder(""); // parâmetros de entrada
        private StringBuilder outParams = new StringBuilder(""); // parâmetros de saída

        public string InParams {
            get => inParams.ToString();
        }
        public string OutParams {
            get => outParams.ToString();
        }

        public void SetParams(OutputSettings settings) {
            inParams.Append(defaultParams);
            if(settings.ChangeScale) SetScale(settings.Scale);
            if(settings.Subtitle!="") SetSubtitle(new FFmpeg().ConvertSubtitle(settings.Subtitle));
        }

        private void RemoveParams(string toRemove) {
            string removed;

            if(outParams.ToString().Contains(toRemove)) {
                removed=outParams.ToString().Replace(toRemove, "");
                outParams.Clear();
                outParams.Append(removed);
            }
        }

        private void setVF() {
            if(!outParams.ToString().Contains("-vf"))
                outParams.Append("-vf ");
        }

        public void SetScale(string[] scale) {
            setVF();
            outParams.AppendFormat("-vf scale={0}:{1} ", scale[0], scale[1]);
        }

        public void SetSubtitle(string assFile) {
            setVF();
            outParams.AppendFormat("ass={0} ", assFile);
        }
        
        public void DisableAudio(bool disable) {
            if(disable) outParams.AppendFormat("-an ");
            else RemoveParams("-an ");
        }
        public void DisableVideo(bool disable) {
            if(disable) inParams.AppendFormat("-vn ");
            else RemoveParams("-vn ");
        }
        public void Overwrite(bool overwrite)
            => outParams.AppendFormat("{0} ", overwrite==true ? "-y" : "-n");

        public void Clear() {
            inParams=new StringBuilder("");
            outParams=new StringBuilder("");
        }
    }
}
