using System;
namespace Console_app
{
	public class Book
	{
		private String title;
		private String author;
		private String[] characters;
		private int quantity;
		private double price;

		public Book()
		{
		}

		public String Title
		{
			get
			{
				return title;
			}
			set
			{
				title = value;
			}
		}

		public String Author
		{
			get
			{
				return author;
			}
			set
			{
				author = value;
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

		public String[] Characters
		{
			get
			{
				return characters;
			}
			set
			{
				characters = value;
			}
		}

        public double Price
		{
			get
			{
				return price;
			}
			set
			{
				price = value;
			}
		}

		public void book_info()
		{
			Console.WriteLine("Ce livre est intitulé: " + title + " et est écrit par : " + author);
            Console.WriteLine("\nLes personnages sont:");
            foreach (String character in characters){
				Console.WriteLine(character);
			};
			Console.WriteLine("\nNous disposons de ce livre en " + quantity + " exemplaires et se vend à " + price + " FCFA l'unité ");
		}

    }


}

