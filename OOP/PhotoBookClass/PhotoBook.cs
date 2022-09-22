using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoBookClass
{
    public class PhotoBook
    {
        private int numOfPages { get; set; }
        public PhotoBook()
        {
            numOfPages = 16;
        }

        public PhotoBook(int _numOfPages)
        {
            numOfPages = _numOfPages;
        }

        public int GetNumberPages()
        {
            return numOfPages;
        }
    }
}
