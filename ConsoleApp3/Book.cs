namespace ConsoleApp3
{
    internal class Book : Product
    {
        public string AuthorName { get; set; }
        public int PageCount { get; set; }

        public Book(string name, double price, int count, string authorName, int pageCount)
            : base(name, price, count)
        {
            AuthorName = authorName;
            PageCount = pageCount;
        }

        public override void Sell()
        {
            throw new NotImplementedException();
        }

        public override void ShowInfo()
        {
            throw new NotImplementedException();
        }

    }
}
