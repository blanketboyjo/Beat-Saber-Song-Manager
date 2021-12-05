using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using System.Xml.Linq;

namespace Beat_Saber_Song_Manager
{


    public partial class SongBox : UserControl, IEquatable<SongBox>, IComparable<SongBox>
    {
        private static int MINIMUM_KEY_LENGTH = 1;
        private static Regex titleRegex = new Regex("\\\"_songName\\\".+?\"(.+?)\"", RegexOptions.Compiled | RegexOptions.IgnoreCase);
        private static Regex artistRegex = new Regex("\\\"_songAuthorName\\\".+?\"(.+?)\"", RegexOptions.Compiled | RegexOptions.IgnoreCase);
        private static Regex mapperRegex = new Regex("\\\"_levelAuthorName\\\".+?\"(.+?)\"", RegexOptions.Compiled | RegexOptions.IgnoreCase);
        private static Regex coverRegex = new Regex("\\\"_coverImageFilename\\\".+?\"(.+?)\"", RegexOptions.Compiled | RegexOptions.IgnoreCase);
        private static Regex versionRegex = new Regex("\\\"_version\\\".+?\"(.+?)\"", RegexOptions.Compiled | RegexOptions.IgnoreCase);

        public SongBox(string _path)
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.Selectable, true);
            directoryInfo = new DirectoryInfo(_path);
            int t_keyLength = directoryInfo.Name.IndexOf("(");
            selected = false;
            Boolean t_validEntry = true;
            string t_databaseKey= "";
            //Get key
            if (MINIMUM_KEY_LENGTH <= t_keyLength)
            {
                t_databaseKey = directoryInfo.Name.Substring(0, t_keyLength).Trim();
                string verifyKey = t_databaseKey.ToUpper();
                for (int i = 0; i < verifyKey.Length; i++)
                {
                    if (!(('A' <= verifyKey[i] && 'F' >= verifyKey[i]) || ('0' <= verifyKey[i] && '9' >= verifyKey[i])))
                    {
                        t_validEntry = false;
                    }
                }
            }
            else
            {
                t_validEntry = false;
            }

            string t_infoFile = directoryInfo.FullName + "\\Info.dat";
            if (File.Exists(t_infoFile))
            {
                try
                {
                    using FileStream openStream = File.OpenRead(t_infoFile);
                    songData = JsonSerializer.Deserialize<SongData>(openStream);



                }
                catch
                {
                }
            }
            Label_SongTitle.Text = songData._songName;
            Label_ArtistName.Text = songData._songAuthorName;
            Label_Mapper.Text = songData._levelAuthorName;
            if (0 < songData._coverImageFilename.Length)
            {
                try
                {

                    Image coverArt = Image.FromFile(directoryInfo.FullName + "\\" + songData._coverImageFilename);
                    Image thumbnailImage = coverArt.GetThumbnailImage(48, 38, new Image.GetThumbnailImageAbort(ThumbnailCallback), IntPtr.Zero);
                    Thumbnail.Image = thumbnailImage;
                    coverArt.Dispose();
                }
                catch
                {

                }
            }
            
            if (t_validEntry)
            {
                songData._databaseKey = t_databaseKey;
            }
            songData._isValid = t_validEntry;
        }
        private bool ThumbnailCallback()
        {
            return false;
        }

        public XElement toXML()
        {
            return new XElement("SONG",
                new XElement("TITLE", songData._songName),
                new XElement("ARTIST", songData._songAuthorName),
                new XElement("MAPPER", songData._levelAuthorName),
                new XElement("KEY", songData._databaseKey)
                );
        }
        public SongData songData { get; }
        public DirectoryInfo directoryInfo { get; }
        public bool selected { get; set; }
        public int CompareTo(SongBox compareAgainst)
        {
            if(null == compareAgainst)
            {
                return 1;
            }
            else
            {
                return songData._songName.ToUpper().CompareTo(compareAgainst.songData._songName.ToUpper());
            }
        }

        public bool Equals(SongBox compareAgainst)
        {
            if(null == compareAgainst)
            {
                return false;
            }
            return (this.songData._songName.ToUpper().Equals(compareAgainst.songData._songName.ToUpper()));
        }

        private void SongBox_Click(object sender, EventArgs e)
        {

            selected = !selected;
            System.Diagnostics.Debug.WriteLine(toXML());
            if (selected)
            {
                this.BackColor = SystemColors.ActiveCaption;
            }
            else
            {
                this.BackColor = SystemColors.Control;
            }
        }
        static bool firstBoxIsSelected = false;

        private void SongBox_DragOver(object sender, DragEventArgs e)
        {
            selected = true;
            firstBoxIsSelected = selected;
            if (selected)
            {
                this.BackColor = SystemColors.ActiveCaption;
            }
            else
            {
                this.BackColor = SystemColors.Control;
            }
        }
    }


}
