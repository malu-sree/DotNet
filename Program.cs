using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceApp
{
    class Product
    {
        public int Id;
        public string Name;
        public double Price;

        public Product(int id, string name, double price)
        {
            Id = id;
            Name = name;
            Price = price;
        }

        public void DisplayProduct()
        {
            Console.WriteLine("Product ID: " + Id);
            Console.WriteLine("Product Name: " + Name);
            Console.WriteLine("Product Price: " + Price);
        }

    }

    class shoppingCart
    {
        private Product[] cartItem = new Product[20];
        private int count = 0;

        public void AddCartItem(Product product)
        {
            if (count < 20)
            {

                cartItem[count] = product;
                count++;
                Console.WriteLine($"Product {product.Name} added to cart");
            }

            else
            {
                Console.WriteLine("Cart is full");
            }


        }

        public void Displaycart()
        {

            if (count == 0)
            {
                Console.WriteLine("Cart is empty");
            }
            
            double total = 0;
            for (int i=0;i<count;i++)
            {
                Console.WriteLine($"Product:{cartItem[i].Name} And  Price: {cartItem[i].Price}");
                total += (int)cartItem[i].Price;

            }
            Console.WriteLine($"Total Price: {total}");
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product(1, "Laptop", 50000);
            Product product2 = new Product(2, "Mobile", 20000);
            Product product3 = new Product(3, "Tablet", 10000);
            Product product4 = new Product(4, "Headphone", 5000);
            Product product5 = new Product(5, "Speaker", 1000);

            shoppingCart shopping = new shoppingCart();

            while (true)
            {
                Console.WriteLine("Welcome to Ecommerce App");
                Console.WriteLine("1. Display Products");
                Console.WriteLine("2. Add to Cart");
                Console.WriteLine("3. Display Cart");
                Console.WriteLine("4. Exit");
                Console.WriteLine("Enter your choice");

                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        product1.DisplayProduct();
                        product2.DisplayProduct();
                        product3.DisplayProduct();
                        product4.DisplayProduct();
                        product5.DisplayProduct();
                        break;
                    case 2:
                        Console.WriteLine("Enter Product ID to add to cart");
                        int id = Convert.ToInt32(Console.ReadLine());
                        if (id == 1)
                        {
                            shopping.AddCartItem(product1);
                        }
                        else if (id == 2)
                        {
                            shopping.AddCartItem(product2);
                        }
                        else if (id == 3)
                        {
                            shopping.AddCartItem(product3);
                        }
                        else if (id == 4)
                        {
                            shopping.AddCartItem(product4);
                        }
                        else if (id == 5)
                        {
                            shopping.AddCartItem(product5);
                        }
                        else
                        {
                            Console.WriteLine("Invalid Product ID");
                        }
                        break;
                    case 3:
                        shopping.Displaycart();
                        break;
                    case 4:
                        Console.WriteLine("Thank you for shopping with us");
                        return;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            }
        }
    }
}
