using System;

namespace UniversityRank
{
    public class UserInterface
    {
        public  void DisplayInterface()
        {
            Console.WriteLine("Please enter ranking year between 2010-2016");
            int yearResult;
           
            while ((!int.TryParse(Console.ReadLine(), out yearResult)) || ((yearResult < 2009 ) || (yearResult > 2017)))
                Console.WriteLine("Error, Please enter ranking year between 2010-2016");

            Global.year = yearResult;

            try
            {
                new ReadHtmlRank(new UniversityRankService().MakeRequest()).CreateRankingFile();
            }
            catch(Exception e)
            {
                Console.WriteLine("faild taking data, please try later");
                Console.ReadKey();
            }


        }
    }
}
