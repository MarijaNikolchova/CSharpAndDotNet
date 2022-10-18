namespace Exercise07_Catalog
{
    internal class Film : Item
    {
        protected string director;
        protected string mainActor, mainActress;

        public Film() { }

        public Film(string director, string mainActor, string mainActress)
        {
            this.director = director;
            this.mainActor = mainActor;
            this.mainActress = mainActress;
        }

        public string Director
        {
            get { return director; }
            set { director = value; }
        }
        public string MainActor
        {
            get { return mainActor; }
            set { mainActor = value; }
        }
        public string MainActress
        {
            get { return mainActress; }
            set { mainActress = value; }
        }

        public void Play() { }

        public void RetrieveInformation() { }
    }
}