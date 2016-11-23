using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace UniversityRank
{
    public class FileWriter
    {
        #region Const
        public string DataBasePath = "c:\\university_ranks";
        public const char FIRST_LEVEL = '|';

        #endregion

        #region DataMembers
        private static FileWriter _instance;
        private static StreamWriter _stream;
        #endregion

        #region Properties
        public static FileWriter Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new FileWriter();
                }
                return _instance;
            }
        }

        #endregion

        #region Ctor
        private FileWriter()
        {
            _stream = new StreamWriter(DataBasePath + Global.year.ToString()+".txt");
        }
        #endregion

        #region Methods
        public void WriteToFile(string str)
        {
            _stream.WriteLine(str);
        }

        public void CloseStream()
        {
            _stream.Close();
        }
        #endregion
    }
}
