using System;

namespace Exercise02_PhotoAlbumTarea
{
    internal class PhotoAlbum
    {
        private int numberOfPages;
        public PhotoAlbum()
        {
            this.numberOfPages = 12;
        }
        public PhotoAlbum(int numberOfPages)
        {
            this.numberOfPages = numberOfPages;
        }

        internal int GetNumberOfPages()
        {
            return numberOfPages;
        }
    }
}