namespace StockAccountManagement
{
    class Program
    {
        public static void Main(string[] args)
        { 
            Console.WriteLine("Welcome to Stock Account Management");

            string path = "C:\\Users\\Mansi Mohan\\source\\repos\\StockAccountManagement\\StockAccountManagement\\Stock.json";

            StockFetching fetchStock = new StockFetching();

            StockDetails data = fetchStock.Read(path);

            Console.WriteLine("\nSTOCK VALUE: ");

            for (int i = 0; i < data.Stock.Count; i++)
            {
                Console.WriteLine("\n" + data.Stock[i].NameOfStock);
                Console.WriteLine("shares: " + data.Stock[i].Share);
                Console.WriteLine("price: " + data.Stock[i].Price);

                int TotalValue = data.Stock[i].Share * data.Stock[i].Price;
                Console.WriteLine("\nThe Total Value of {0} for {1} shares is: {2} ", data.Stock[i].NameOfStock, data.Stock[i].Share, TotalValue);
                Console.WriteLine("-------------------------------");
            }
        }
    }
}
