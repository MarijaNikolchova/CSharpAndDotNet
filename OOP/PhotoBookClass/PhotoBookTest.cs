using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoBookClass
{
    public static class PhotoBookTest
    {
        public static void ShowBooks()
        {
            PhotoBook PhotoBook16 = new PhotoBook();
            PhotoBook PhotoBook24 = new PhotoBook(24);
            BigPhotoBook BigPhotoBook = new BigPhotoBook();

            Console.WriteLine(PhotoBook16.GetNumberPages());
            Console.WriteLine(PhotoBook24.GetNumberPages());
            Console.WriteLine(BigPhotoBook.GetNumberPages());
        }
    }
}
