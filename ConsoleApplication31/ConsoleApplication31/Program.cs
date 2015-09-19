using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApplication30
{

    class Program
    {

        [STAThread]
        static void Main(string[] args)
        {
            string word = "privet kak dela";
            word = Clipboard.GetText();
            Console.WriteLine(word);


            string[] split = word.Split(new Char[] { ' ', ',', '.', ':', '\t' }, StringSplitOptions.RemoveEmptyEntries);


            IEnumerable<string> sort =
       from wo in split
       orderby wo //"ascending" is default
       select wo;
            var DistincList = sort.Distinct();
            foreach (string a in DistincList.Take(1000))
            {
                Console.WriteLine(a);
            }

            Console.ReadKey();
        }
    }
}