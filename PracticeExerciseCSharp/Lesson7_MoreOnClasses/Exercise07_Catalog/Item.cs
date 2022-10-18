namespace Exercise07_Catalog
{
    internal class Item
    {
        protected string name;
        protected string code;
        protected string category;
        protected string size;

        public Item() { }

        public Item(string name, string code, string category, string size)
        {
            this.name = name;
            this.code = code;
            this.category = category;
            this.size = size;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Code
        {
            get { return code; }
            set { code = value; }
        }
        public string Category
        {
            get { return category; }
            set { category = value; }
        }
        public string Size
        {
            get { return size; }
            set { size = value; }
        }
    }
}