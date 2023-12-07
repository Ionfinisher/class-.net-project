using System;
namespace Console_app
{
	public delegate void SellProductEventHandler(int numb);

	public class Product
	{
		private String name;
		private decimal price;
		private int quantity;
        public event SellProductEventHandler productSold;

        public Product()
		{
			Name = "";
			Price = 0;
			Quantity = 0;
		}

		public Product(String name, decimal price, int quantity)
		{
			Name = name;
			Price = price;
			Quantity = quantity;
		}

		public String Name
		{
			get
			{
				return name;
			}
			set
			{
				name = value;
			}

		}

		public decimal Price
		{
			get
			{
				return price;
			}
			set
			{
				if (value > 100)
				{
					Console.WriteLine("Il est trop chèr");
					price = 0;

				}
				else {
                    price = value;
                }
				
			}
		}

		public int Quantity
		{
			get
			{
				return quantity;
			}
			set
			{
				quantity = value;
			}
		}

		public void sell(int quantity_to_sell)
		{
			if (quantity_to_sell < 0) {
				Console.WriteLine("La quantité à vendre doit être supérieure à 0.");
			}
			else if (quantity_to_sell > quantity)
			{
				Console.WriteLine("La quantié en stock est insuffisante");
			} else {

				quantity = quantity - quantity_to_sell;
				decimal price_sold = quantity_to_sell * price;
                Console.WriteLine("Le produit a bien été vendu à " + price_sold + ". Il reste " + quantity + " produit en stock");
				if (productSold != null)
				{
					productSold(numb:quantity_to_sell);
				}
            }

		}

		

	}
}

