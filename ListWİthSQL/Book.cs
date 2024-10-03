using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ListWİthSQL
{
    internal class Book
    {
        int id;
        string name;
        string author;
        string page;
        string type;
        string publisher;

        public int Id { get { return id; } set { id = value; } }
        public string Name { get { return name; } set { name = value; } }
        public string Author { get { return author; } set { author = value; } }
        public string Page { get { return page; } set { page = value; } }
        public string Type { get { return type; } set { type = value; } }
        public string Publisher { get { return publisher; } set { publisher = value; } }
    }
}
