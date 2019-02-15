namespace Generics
{
    public class DiscountCalculator<TProduct> where TProduct : Product
    {
      public float Calc(TProduct product)
        {
            return product.Price;
        }
    }
    public class Product
    {
        public float Price { get; set; }
    }

    public class Book : Product
    {
        public string Isbn { get; set; }
    }
}

