using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    internal class Product
    {
        readonly string pCode;
        string pName;
        int qtyInStock;
        float discount;
        static string brand;
        public Product()
        {

        }
        public Product (string pCode, string pName
            , int qtyInStock,float discount )
        {
            this.pCode = pCode;
            this.pName = pName;
            this.qtyInStock= qtyInStock;
            this.discount = discount;
        }
        static Product()
        {
            brand = "Lewis";
        }

        public void GetProductDetails()
        {
            Console.WriteLine("Enter Product NAme");
            pName = Console.ReadLine();
            Console.WriteLine("Enter Qty in Stock");
            qtyInStock = int.Parse( Console.ReadLine() );
            Console.WriteLine("Enter Disount Allowwd");
            discount = float.Parse(Console.ReadLine() );

        }
        public void DisplayProductDetails()
        {
            Console.WriteLine(pCode + pName + qtyInStock + discount);
        }
    }
}
