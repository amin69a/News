using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News.Entites
{
    public class Category:BaseEntity<Byte>
    {
        public byte? ParentId { get; set; }
        public string Name { get; set; }
    }
}
