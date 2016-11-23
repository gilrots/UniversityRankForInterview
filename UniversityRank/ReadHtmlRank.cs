using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityRank
{
    public class ReadHtmlRank
    {
        #region DataMembers
        private string[] _htmlText;
        #endregion

        #region Ctor
        public ReadHtmlRank(string htmltext)
        {
            _htmlText = htmltext.Split(new string[] { "<movie" }, StringSplitOptions.None);
        }
        #endregion

        #region Methods
        public void CreateRankingFile()
        {
            
            for (int i = 2; i < _htmlText.Length; i++)
            {
              
                    var str = _htmlText[i].Split(new string[] { "title=", "file" }, StringSplitOptions.None);
                    var universityName = str[1].Replace("\'", String.Empty);
                    FileWriter.Instance.WriteToFile(universityName + '|' + (i - 1).ToString());
                
            }
            FileWriter.Instance.CloseStream();
         
        }


        #endregion

    }
}
