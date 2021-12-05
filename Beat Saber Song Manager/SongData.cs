using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Beat_Saber_Song_Manager
{
    public class SongData
    {
        public string _version { get; set; }
        public string _songName { get; set; }
        public string _songAuthorName { get; set; }
        public string _coverImageFilename { get; set; }
        public string _levelAuthorName { get; set; }
        public string _databaseKey { get; set; }
        public bool _isValid { get; set; }
    }
}
