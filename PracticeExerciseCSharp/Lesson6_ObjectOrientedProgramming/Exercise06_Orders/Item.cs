namespace Exercise06_Orders
{
    internal class Item : OrderDetail
    {
        public Item()
        {
            shippingWeight = "";
            description = "";
        }

        protected string shippingWeight;
        protected string description;

        public double getPriceForQuantity()
        {
            return 0;
        }

        public double getWeight()
        {
            return 0;
        }

        public string GetShippingWeight()
        {
            return shippingWeight;
        }

        public string GetDescription()
        {
            return description;
        }
        public void SetShippingWeight(string shippingWeight)
        {
            this.shippingWeight = shippingWeight;
        }

        public void SetDescription(string description)
        {
            this.description = description;
        }
    }
}