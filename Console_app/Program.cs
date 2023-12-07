using Console_app;
internal class Program
{
    

    private static void Main(string[] args)
    {
        //int[] notes = { 1, 2, 3, 4 };
        //Console.WriteLine("La troisième note est :" + notes[2]);
        //notes[2] = 19;
        //Console.WriteLine("La nouvelle troisième note est : " + notes[2]);
        //notes = new int[5];

        Product produit = new Product();
        Facture facture = new Facture();

        produit.productSold += facture.sendInvoice;

        produit.Name = "KOUFAME";
        produit.Price = 25;
        produit.Quantity = 20;
        Console.WriteLine("Le libellé est: " + produit.Name + " et son prix est: " + produit.Price + " FCFA");

        //produit.Price = 200;
        //Console.WriteLine("Le libellé est: " + produit.Name + " et son prix est: " + produit.Price + " FCFA");

        produit.sell(-5);
        produit.sell(10);
        produit.sell(15);

        //Console.WriteLine("Bienvenue dans le systeme d'info sur les livres");

        //Console.Write("Veuillez entrer le titre du livre: ");
        //string title = Console.ReadLine();

        //Console.Write("Veuillez entrer l'auteur du livre: ");
        //string author = Console.ReadLine();


        //int quantity;
        //while (true)
        //{
        //    Console.Write("Veuillez entrer la quantité du livre: ");
        //    try
        //    {
        //        quantity = Convert.ToInt32(Console.ReadLine());
        //        break;
        //    }
        //    catch (Exception)
        //    {
        //        Console.WriteLine("Enrtrée invalide. Réésayez");
        //    }
        //}

        //double price;
        //while (true)
        //{
        //    Console.Write("Veuillez entrer la prix du livre: ");
        //    try
        //    {
        //        price = Convert.ToDouble(Console.ReadLine());
        //        break;
        //    }
        //    catch (FormatException)
        //    {
        //        Console.WriteLine("Enrtrée invalide. Réésayez");
        //    }
        //}

        //Console.WriteLine("Veuillez entrer les personnages du livre (separés par des virgules): ");
        //string charactersInput = Console.ReadLine();
        //string[] characters = charactersInput.Split(',');


        //Book book = new Book();
        //book.Title = title;
        //book.Author = author;
        //book.Characters = characters;
        //book.Quantity = quantity;
        //book.Price = price;

        //book.book_info();


        int variable1 = 5;
        int variable2 = variable1;

        Product product1 = new Product();

        product1.Name = "KOUFAME";
        product1.Price = 10;

        Product product2 = product1;


        Console.WriteLine("Product 1: " + product1.Name + " " + product1.Price);
        Console.WriteLine("Product 2: " + product2.Name + " " + product2.Price);

        Product product3 = new Product();

        product3.Name = "KOUFAME";
        product3.Price = 10;

        Product product4 = new Product();

        product4.Name = "KOUFAME";
        product4.Price = 10;

        if (product3 == product4)
        {
            Console.WriteLine("Les deux produits sont egaux");
        }
        else
        {
            Console.WriteLine("Les deux produits ne sont pas egaux");
        }

        Product product5 = product4;

        if (product4 == product5)
        {
            Console.WriteLine("Les deux produits sont egaux");
        }
        else
        {
            Console.WriteLine("Les deux produits ne sont pas egaux");
        }
    }



}