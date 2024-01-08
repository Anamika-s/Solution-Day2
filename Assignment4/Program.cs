namespace Assignment4
{
    enum UserType { Admin, Customer };
    internal class Program
    { 

    static void Main(string[] args)
        {
           
            Product product = new Product();
            Console.WriteLine("Enter User Type");
            int userType = Byte.Parse(Console.ReadLine());
            switch(userType)
            {
                case (byte)UserType.Admin:
                    {
                        product.GetProductDetails();
                        break;
                    }
                    case (byte)UserType.Customer:
                    {
                        product.DisplayProductDetails();
                        break;
                    }
            }
        }
        // static void Menu()
        //{
        //    Console.WriteLine("1. Add Product");
        //    Console.WriteLine("2. List of Products");
        //    Console.WriteLine("Enter your choice");
        //    //Product[] products = new Product[10];
        //    //Product p = new Product();
        //    //p.GetProductDetails();

        //}
    }
}