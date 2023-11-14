using Microsoft.Identity.Client;
using SQLdel5CodeFirst.Db;
using System.Linq.Expressions;

namespace SQLdel5CodeFirst
{
	internal class Program
	{
		private static StoreContext storeContext = new StoreContext(); 
		
		static void Main(string[] args)
		{
			MainMenu();
		}

		public static void MainMenu()
		{
			string[] menuOptions = { "1. Create new product", "2. Show all products", "3. Update product", "4. Delete product" };
			
			Console.WriteLine("What you wanna do?");

			foreach (string option in menuOptions)
			{
				Console.WriteLine(option);
			}
			try
			{
				int chooice = int.Parse(Console.ReadLine());
				switch (chooice)
				{
					case 1:
						Create();
						break;
					case 2:
						Show();
						break;
					case 3:
						Update();
						break;
					case 4:
						Delete();
						break;
					case 5:
						Environment.Exit(0);
						break;
				}
			}
			catch
			{
                Console.WriteLine("Input is not a number");
            }
		}

		public static void Create()
		{
            Console.Write("Product Name: ");
			string inputName = Console.ReadLine();
			Console.Write("Product description: ");
			string description = Console.ReadLine();
			Console.Write("Price: ");
			double price = int.Parse(Console.ReadLine());
			Console.Write("Categoryid:");
			int category = int.Parse(Console.ReadLine());
        }
		public static void Show()
		{
			foreach(var product in storeContext._categories)
			{
				Console.WriteLine();
			}
		}
		public static void Update()
		{

		}
		public static void Delete()
		{

		}

	}
}