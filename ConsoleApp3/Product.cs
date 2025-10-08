namespace ConsoleApp3
{
    internal abstract class Product
    {
        private double price;

        protected Product(string name, double price, int count)
        {
            Name = name;
            this.price = price;
            Count = count;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int Count { get; set; }
        public int TotalInCome { get; set; }
        public abstract void Sell();
        public abstract void ShowInfo();
    }
}
