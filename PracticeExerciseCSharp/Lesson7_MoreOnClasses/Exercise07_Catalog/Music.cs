namespace Exercise07_Catalog
{
    internal class Music : Item
    {
        protected string singer;
        protected int length;

        public Music() { }

        public Music(string singer, int length)
        {
            this.singer = singer;
            this.length = length;
        }

        public string Singer
        {
            get { return singer; }
            set { singer = value; }
        }
        public int Lenght
        {
            get { return length; }
            set { length = value; }
        }

        public void Play() { }

        public void RetrieveInformation() { }
    }
}