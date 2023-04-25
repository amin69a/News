using News.AdoDB;
using News.ApplicationService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News.ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            KeywordService service = new KeywordService(new AdoKeywordDB());
        }
    }
}
