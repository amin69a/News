using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News.Entites
{
    public class Keyword:BaseEntity<short>
    {
        public string Title { get; set; }
    }
}
