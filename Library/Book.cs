using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Library
{
    class Book
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public bool Available { get; set; }

        public DateTime ReturnDate { get; set; }

        public int ID { get; set; }

        public Image Image{ get; set; }
        
    }
}
