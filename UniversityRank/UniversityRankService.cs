using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace UniversityRank
{
    public class UniversityRankService
    {
        public string MakeRequest()
        {
            var uri = "http://www.urapcenter.org/" + Global.year.ToString() + "/world.php?q=MS0yNTA=";
            var mRequest = (HttpWebRequest)WebRequest.Create(uri);
            mRequest.Method = "GET";

            var response = mRequest.GetResponse();
            var sr = new StreamReader(response.GetResponseStream());
            return sr.ReadToEnd();

        }
    }
}
