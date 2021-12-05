using System.Net;
using System.Xml.Linq;

namespace Beat_Saber_Song_Manager
{
    public partial class MainForm : Form
    {
        List<SongBox> m_songsInDirectory = new List<SongBox>();
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //FlowLayout_DetectedLibrary.Controls.Add(new SongBox());
            string searchDirectory = "C:\\Program Files (x86)\\Steam\\steamapps\\common\\Beat Saber\\Beat Saber_Data\\CustomLevels";
            string[] songs = Directory.GetDirectories(searchDirectory);
            foreach (string s in songs)
            {
                m_songsInDirectory.Add(new SongBox(s));
            }

            m_songsInDirectory.Sort();
            FlowLayout_DetectedLibrary.SuspendLayout();
            FlowLayout_DetectedLibrary.Controls.AddRange(m_songsInDirectory.ToArray());
            FlowLayout_DetectedLibrary.ResumeLayout();

            //using (var client = new WebClient())
            //{
            //    for (int i = 0; i < FlowLayout_DetectedLibrary.Controls.Count; i++)
            //    {
            //        SongBox t_songbox = (SongBox)FlowLayout_DetectedLibrary.Controls[i];
            //        if (t_songbox.validEntry)
            //        {
            //            client.DownloadFile("https://beatsaver.com/api/download/key/" + t_songbox.databaseKey, "C:\\Program Files (x86)\\Steam\\steamapps\\common\\Beat Saber\\Beat Saber_Data\\CustomLevels\\" + t_songbox.databaseKey + ".zip");
            //        }
            //    }
            //}
        }

        private void Btn_ToXML_Click(object sender, EventArgs e)
        {
            XDocument songList = new XDocument(new XElement("SONGLIST"));
            List<SongData> jsonListing = new List<SongData>();
            for (int i = 0; i < FlowLayout_DetectedLibrary.Controls.Count; i++)
            {
                try
                {
                    SongBox songBox = (SongBox)FlowLayout_DetectedLibrary.Controls[i];
                    if (songBox.songData._isValid)
                    {
                        songList.Root.Add(songBox.toXML());
                    }
                }
                catch
                {

                }
            }
            try
            {
                string outputFile = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\songList.xml";
                if (File.Exists(outputFile))
                {
                    File.Delete(outputFile);
                }
                using(StreamWriter sw = new StreamWriter(outputFile))
                {
                    sw.WriteLine(songList);
                }
            }
            catch { }

        }
    }
}