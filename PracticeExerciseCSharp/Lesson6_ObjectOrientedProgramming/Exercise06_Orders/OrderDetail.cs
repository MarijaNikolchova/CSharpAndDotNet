namespace Exercise06_Orders
{
    internal class OrderDetail
    {
        public OrderDetail()
        {
            quantity = 0.0;
            taxStatus = "";
        }
        protected Item[] i;
        protected double quantity;
        protected string taxStatus;

        public double calcSubTotal()
        {
            return 0;
        }

        public double calcWeight()
        {
            return 0;
        }
    }
}