using News.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News.Contract
{
    public interface IKeywordDB
    {
        void InsertKeyword(Keyword keyword);
        void UpdateKeyword(Keyword keyword);
        List<Keyword> Search(string keywordTitle);
    }
}
