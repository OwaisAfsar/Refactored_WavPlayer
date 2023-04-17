using System;
using System.Drawing;
using System.IO;
using System.Media;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace Interview_ClientDev_WavPlayer
{
    public enum Language
    {
        Deutsch,
        English
    }

    public enum FileStatus
    {
        Closed,
        Opened,
        Playing,
        Stopped
    }

    public enum FileSize
    { 
        Big,
        Small
    }

    public partial class SimpleWavPlayer : Form
    {
        //DO NOT REPLACE THIS BY ANOTHER API
        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        public static extern int MessageBox(IntPtr hWnd, String text, String caption, uint type);

        Utilities UtilitiesMethods = new Utilities();
        private SoundPlayer soundPlayer;
        private string filename = null;
        private Language language = Language.Deutsch;
        private FileStatus fileStatus = FileStatus.Closed;
        private FileSize fileSize;

        public SimpleWavPlayer()
        {
            InitializeComponent();
            soundPlayer = new SoundPlayer();
        }

        private void SimpleWavPlayer_Load(object sender, EventArgs e)
        {
            RadioButtonDeutsch.Checked = true;

            ButtonPlay.Enabled = false;
            ButtonStop.Enabled = false;
            ButtonOpen.Enabled = true;
            ButtonClose.Enabled = false;

            UpdateFileName(language);
        }

        private void ButtonOpen_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.FileName = "";
                openFileDialog1.Filter = "WAV Files (*.wav)|*.wav";

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    filename = openFileDialog1.FileName;

                    // Simulate big operation
                    Thread.Sleep(5000);

                    if (UtilitiesMethods.isFileBig(filename))
                    {
                        lblFilename.ForeColor = Color.Red;
                        fileSize = FileSize.Big;
                    }
                    else
                    {
                        lblFilename.ForeColor = Color.Black;
                        fileSize = FileSize.Small;
                    }

                    Protokoll.WriteToProtokoll(DateTime.Now + ": File opened " + filename);
                    lblFilename.Text = Path.GetFileName(filename);
                    soundPlayer.SoundLocation = filename;
                    fileStatus = FileStatus.Opened;
                    ChangeLanguage(fileStatus, fileSize, language);

                    if (language == Language.Deutsch)
                    {
                        MessageBox(this.Handle, Properties.Resources.FileOpened_Deutsch_Message, Properties.Resources.FileOpened_Deutsch_Info, 0);
                    }
                    else if (language == Language.English)
                    {
                        MessageBox(this.Handle, Properties.Resources.File_Opened_English_Message, Properties.Resources.File_Opened_English_Info, 0);
                    }

                    ButtonPlay.Enabled = true;
                    ButtonStop.Enabled = false;
                    ButtonOpen.Enabled = false;
                    ButtonClose.Enabled = true;
                }
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            soundPlayer.Dispose();
            soundPlayer = new SoundPlayer();

            Protokoll.WriteToProtokoll(DateTime.Now + ": File closed " + filename);
            fileStatus = FileStatus.Closed;
            ChangeLanguage(fileStatus, fileSize, language);
            UpdateFileName(language);

            ButtonPlay.Enabled = false;
            ButtonStop.Enabled = false;
            ButtonOpen.Enabled = true;
            ButtonClose.Enabled = false;
        }

        private void ButtonPlay_Click(object sender, EventArgs e)
        {
            soundPlayer.Play();

            Protokoll.WriteToProtokoll(DateTime.Now + ": Playback started " + filename);
            fileStatus = FileStatus.Playing;
            ChangeLanguage(fileStatus, fileSize, language);

            ButtonPlay.Enabled = false;
            ButtonStop.Enabled = true;
            ButtonOpen.Enabled = false;
            ButtonClose.Enabled = false;
        }

        private void ButtonStop_Click(object sender, EventArgs e)
        {
            soundPlayer.Stop();

            Protokoll.WriteToProtokoll(DateTime.Now + ": Playback stopped " + filename);
            fileStatus = FileStatus.Stopped;
            ChangeLanguage(fileStatus, fileSize, language);

            ButtonPlay.Enabled = true;
            ButtonStop.Enabled = false;
            ButtonOpen.Enabled = false;
            ButtonClose.Enabled = true;
        }

        private void RadioButtonDeutsch_CheckedChanged(object sender, EventArgs e)
        {
            language = Language.Deutsch;
            ChangeLanguage(fileStatus, fileSize, language);
            UpdateButtonLabels();
        }

        private void RadioButtonEnglish_CheckedChanged(object sender, EventArgs e)
        {
            language = Language.English;
            ChangeLanguage(fileStatus, fileSize, language);
            UpdateButtonLabels();
        }

        private void ChangeLanguage(FileStatus _fileStatus, FileSize _fileSize, Language _language)
        {
            switch (_fileStatus)
            {
                case FileStatus.Opened:
                    lblFileDescription.Text = ((_fileSize == FileSize.Small) ? UtilitiesMethods.smallMediaDescription(_language, _fileStatus) : UtilitiesMethods.bigMediaDescription(_language, _fileStatus));
                    break;
                case FileStatus.Closed:
                    lblFileDescription.Text = ((_fileSize == FileSize.Small) ? UtilitiesMethods.smallMediaDescription(_language, _fileStatus) : UtilitiesMethods.bigMediaDescription(_language, _fileStatus));
                    break;
                case FileStatus.Playing:
                    lblFileDescription.Text = ((_fileSize == FileSize.Small) ? UtilitiesMethods.smallMediaDescription(_language, _fileStatus) : UtilitiesMethods.bigMediaDescription(_language, _fileStatus));
                    break;
                case FileStatus.Stopped:
                    lblFileDescription.Text = ((_fileSize == FileSize.Small) ? UtilitiesMethods.smallMediaDescription(_language, _fileStatus) : UtilitiesMethods.bigMediaDescription(_language, _fileStatus));
                    break;
            }

            if (lblFilename.Text == Properties.Resources.LabelTextDeutsch && language == Language.English)
            {
                lblFilename.Text = Properties.Resources.LabelTextEnglish;
            }
            else if (lblFilename.Text == Properties.Resources.LabelTextEnglish && language == Language.Deutsch)
            {
                lblFilename.Text = Properties.Resources.LabelTextDeutsch;
            }
        }

       
        private void UpdateFileName(Language _language)
        {
            lblFilename.Text = ((_language == Language.Deutsch) ? Properties.Resources.LabelTextDeutsch : Properties.Resources.LabelTextEnglish);
            lblFilename.ForeColor = Color.Black;
        }

        private void UpdateButtonLabels()
        {
            if (language == Language.Deutsch)
            {
                ButtonOpen.Text = "ÖFFNEN";
                ButtonClose.Text = "SCHLIEßEN";
                ButtonPlay.Text = "SPIELEN";
                ButtonStop.Text = "STOPP";
            }
            else
            {
                ButtonOpen.Text = "OPEN";
                ButtonClose.Text = "CLOSE";
                ButtonPlay.Text = "PLAY";
                ButtonStop.Text = "STOP";
            }
        }

    }
}
