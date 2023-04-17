using System;
using System.IO;

namespace Interview_ClientDev_WavPlayer
{
    public class Utilities: IUtilities
    {
        public string smallMediaDescription(Language _language, FileStatus _fileStatus)
        {
            switch (_fileStatus)
            {
                case FileStatus.Opened:
                    return ((_language == Language.Deutsch) ? "Kleine Datei geöffnet" : "Small file opened");
                case FileStatus.Closed:
                    return ((_language == Language.Deutsch) ? "Kleine Datei geschlossen" : "Small file closed");
                case FileStatus.Playing:
                    return ((_language == Language.Deutsch) ? "Kleine Datei läuft" : "Small file playing");
                case FileStatus.Stopped:
                    return ((_language == Language.Deutsch) ? "Kleine Datei gestoppt" : "Small file stopped");
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
        
        public string bigMediaDescription(Language _language, FileStatus _fileStatus)
        {
            switch (_fileStatus)
            {
                case FileStatus.Opened:
                    return ((_language == Language.Deutsch) ? "Große Datei geöffnet" : "Big file opened");
                case FileStatus.Closed:
                    return ((_language == Language.Deutsch) ? "Große Datei geschlossen" : "Big file closed");
                case FileStatus.Playing:
                    return ((_language == Language.Deutsch) ? "Große Datei läuft" : "Big file playing");
                case FileStatus.Stopped:
                    return ((_language == Language.Deutsch) ? "Große Datei gestoppt" : "Big file stopped");
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        public bool isFileBig(string filename)
        {
            FileInfo fileInfo = new FileInfo(filename);
            long fileSize = fileInfo.Length;
            return fileSize > 150000;
        }

    }
}
