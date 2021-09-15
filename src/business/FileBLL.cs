using Conversor.Models;
using Conversor.Helpers;
using Conversor.Exceptions;
using Conversor.Controlers.Ffmpeg;
using System.IO;
using System;

namespace Conversor.Business {
    class FileBLL {
        OperationResult result;
        public OperationResult Start(MediaFile file, OutputSettings settings) {
            result=new OperationResult(false);

            try {
                new LocalFilesBLL().ffmpegExe();
            } catch(LocalFileException) {
                result.AddMessege("- Não foi possível encontrar o arquivo 'ffmpeg.exe' na pasta raíz do programa");
            }

            // FUTURAMENTE VALIDAR SE EXTENÇÕES DE CONVERSÃO SÃO SUPORTADAS

            if(Util.isEmpty(settings.Extension))
                result.AddMessege("- O campo 'Extenção' é requerido");

            if(Util.isEmpty(settings.Path))
                result.AddMessege("- O campo 'Pasta de saída' é requerido");

            if(!File.Exists(file.FullPath))
                result.AddMessege(
                    string.Format("- Arquivo a ser convertido não encontrado no caminho '{0}'", file.FullPath)
                );

            if(!Directory.Exists(settings.Path))
                result.AddMessege(
                    string.Format("- Diretório de saída não encontrado no caminho '{0}'", settings.Path)
                );

            if(!Util.isEmpty(settings.Prefix)) {
                string[] invalid = Util.InvalidCharacters.Split(' ');

                foreach(string ch in invalid) {
                    if(settings.Prefix.Contains(ch)) {
                        result.AddMessege(
                            string.Format(
                                "- Caractere '{0}' inválido para o prefixo de saída '{1}'. "+
                                "Não utilize nenhum dos seguintes caracteres: {2}",
                                ch, settings.Prefix, Util.InvalidCharacters)
                        );
                    }
                }
            }

            if(!Util.isEmpty(settings.Subtitle) && !File.Exists(settings.Subtitle)) {
                result.AddMessege(
                    String.Format("- Arquivo de legenda não encontrado no caminho '{0}'", settings.Subtitle)
                );
            }

            if(settings.ChangeScale) {
                if(Util.isEmpty(settings.Scale[0]))
                    result.AddMessege("- O campo 'Altura' da escala é requerido");

                if(Util.isEmpty(settings.Scale[1]))
                    result.AddMessege("- O campo 'Largura' da escala é requerido");
            }

            if(result.Count>0) {
                result.File=file.FullName;
                result.FormTitle="Falha na conversão";
                result.Title=$"Não foi possível converter o arquivo '{result.File}'. Resolva os seguintes erros antes de prosseguir:";
                return result;
            }

            string outname = Util.isEmpty(settings.Prefix) ? file.Name : settings.Prefix;
            settings.FullPath=string.Format("{0}/{1}.{2}", settings.Path, outname, settings.Extension);

            FFmpeg fFmpeg = new FFmpeg(file, settings);
            fFmpeg.Start(ref result);

            return result;
        }

        public string GetValidFileName(OutputSettings settings, ref int num) {
            string validPrefix;
            string isValid;

            do {
                num++;
                validPrefix=$"{settings.Prefix}_{num}";
                isValid=$"{settings.Path}/{validPrefix}.{settings.Extension}";
            } while(File.Exists(isValid));

            return validPrefix;
        }
    }
}
