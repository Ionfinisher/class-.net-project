using System;
namespace Console_app
{
	public class DiscountedProduct: Product
	{
		private decimal discount;

		public DiscountedProduct()
		{

		}


        public DiscountedProduct(string name, decimal price, int quantity, decimal discount) : base(name, price, quantity)
        {
            Discount = discount;
        }

        public decimal Discount
        {
           get
            {
                return discount;
            }
            set
            {
                discount = value;
            }
        }

        public decimal CalculateDiscountedPrice()
        {
            return Price - (Price * Discount);
        }
    }
}

