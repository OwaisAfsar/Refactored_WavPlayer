namespace Interview_ClientDev_WavPlayer
{
    public interface IUtilities
    {
        string smallMediaDescription(Language _language, FileStatus _fileStatus);

        string bigMediaDescription(Language _language, FileStatus _fileStatus);

        bool isFileBig(string filename);
    }
}
