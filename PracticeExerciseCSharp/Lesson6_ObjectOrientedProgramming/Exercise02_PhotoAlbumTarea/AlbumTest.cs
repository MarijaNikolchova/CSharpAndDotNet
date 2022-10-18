using System;

namespace Exercise02_PhotoAlbumTarea
{
    /// <summary>
    /// Create a class "PhotoAlbum" with a private attribute "numberOfPages."
    /// 
    /// It should also have a public method "GetNumberOfPages", which will return the number of pages.
    /// 
    /// The default constructor will create an album with 16 pages.There will be an additional constructor, 
    /// with which we can specify the number of pages we want in the album.
    /// 
    /// Create a class "BigPhotoAlbum" whose constructor will create an album with 64 pages.
    /// 
    /// Create a test class "AlbumTest" to create an album with its default constructor,one with 24 pages, 
    /// a "BigPhotoAlbum" and show the number of pages that the three albums have.
    /// </summary>
    internal class AlbumTest
    {
        static void Main(string[] args)
        {
            bool debug = false;

            //Create an album with its default constructor
            PhotoAlbum myAlbum1 = new PhotoAlbum();
            Console.WriteLine(myAlbum1.GetNumberOfPages());

            //Create an album with 24 pages
            PhotoAlbum myAlbum2 = new PhotoAlbum(24);
            Console.WriteLine(myAlbum2.GetNumberOfPages());

            //Create an BigPhotoAlbum 
            BigPhotoAlbum myBigPhotoAlbum1 = new BigPhotoAlbum();
            Console.WriteLine(myBigPhotoAlbum1.GetNumberOfPages());

            if (debug)
                Console.ReadLine();
        }
    }
}
