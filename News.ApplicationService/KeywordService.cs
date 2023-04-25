using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using News.ApplicationService;
using News.Contract;
using News.Entites;

namespace News.ApplicationService
{
    public class KeywordService
    {
        private readonly IKeywordDB _keywordDB;
        public KeywordService(IKeywordDB keywordDB)
        {
            _keywordDB = keywordDB;
        }  
        public void Save(Keyword keyword)
        {
            if(keyword.Id==0)
            {
                _keywordDB.InsertKeyword(keyword);
            }
            else
            {
                _keywordDB.UpdateKeyword(keyword);
            }
        }
    }
}
