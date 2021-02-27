using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookListRazor2.Model
{
    public class Book
    {

        [key]

        public int Id { get; set; }

        [required]
        public string Book { get; set; }
        public string Author { get; set; }
    }
}
