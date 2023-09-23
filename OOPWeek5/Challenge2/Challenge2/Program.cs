using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<MUser> users = new List<MUser>();
            List<Customer> customers = new List<Customer>();
            List<Products> product = new List<Products>();
            int choice = 0;
            string username = "";
            string role = "";
            while (choice != 3)
            {
                choice = MainMenu();
                
                if(choice == 1)
                {
                    Console.Clear();
                    signUp(users, customers);
                }
                else if(choice == 2)
                {
                    Console.Clear();
                    role = signIn(users, ref username);

                    if (role == "admin" || role == "Admin")
                    {
                        Console.Clear();
                        while (choice != 6)
                        {
                            choice = menu();
                            if (choice == 1)
                            {
                                Console.Clear();
                                product.Add(AddProduct());
                            }
                            else if (choice == 2)
                            {
                                Console.Clear();
                                viewList(product);
                            }
                            else if (choice == 3)
                            {
                                Console.Clear();
                                int x = highestPrice(product);
                                Console.Write("Product with Highest PPU: " + product[x].name);
                                
                            }
                            else if (choice == 4)
                            {
                                Console.Clear();
                                viewTax(product);
                            }
                            else if (choice == 5)
                            {
                                Console.Clear();
                                ordered(product);
                            }
                            Console.Clear();
                        }
                    }
                    if (role == "customer" || role == "Customer")
                    {
                        Console.Clear();
                        Customer customer = new Customer(username);
                        while (choice != 4)
                        {
                            choice = menuCustomer();
                            if (choice == 1)
                            {
                                Console.Clear();
                                viewList(product);
                            }
                            else if (choice == 2)
                            {
                                Console.Clear();
                                buyAProduct(customer, product);
                            }
                            else if (choice == 3)
                            {
                                Console.Clear();
                                Console.WriteLine("Total Bill: " + customer.CreateInvoice());
                            }
                            Console.Clear();
                        }
                    }
                }
                Console.Clear();
            }
        }
        static string signIn(List<MUser> users, ref string n)
        {
            string role = "";
            Console.Write("Enter name: ");
            string name = Console.ReadLine();
            Console.Write("Enter password: ");
            string password = Console.ReadLine();

            foreach(var person in users)
            {
                if(name==person.Name && password==person.Password)
                {
                    role = person.Role;
                    break;
                }
            }
            return role;
        }
        static void signUp(List<MUser> user, List<Customer> customers)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter password: ");
            string password = Console.ReadLine();
            Console.Write("Enter role (Admin/Customer): ");
            string role = Console.ReadLine();

            if(role == "Admin" || role == "admin")
            {
                MUser u = new MUser(name, password, role);
                user.Add(u);
            }
            else if(role == "Customer" || role == "customer")
            {
                MUser u = new MUser(name, password, role);
                user.Add(u);
                Customer c = new Customer(name);
                customers.Add(c);
            }
        }
        static int MainMenu()
        {
            Console.WriteLine("1. SignUp");
            Console.WriteLine("2. SignIn");
            Console.WriteLine("3. Exit");
            Console.WriteLine("Enter choice: ");
            return int.Parse(Console.ReadLine());
        }
        static int menuCustomer()
        {
            Console.WriteLine("1. View all Products");
            Console.WriteLine("2. Buy a Product");
            Console.WriteLine("3. Generate Invoice");
            Console.WriteLine("Enter choice: ");
            return int.Parse(Console.ReadLine());
        }
        static int menu()
        {
            Console.WriteLine("1.\tAdd New Product");
            Console.WriteLine("2.\tView List of all Products");
            Console.WriteLine("3.\tView Product With The Highest Unit Price");
            Console.WriteLine("4.\tView Sales Tax of All Products");
            Console.WriteLine("5.\tView Products To Be Ordered");
            Console.WriteLine("6.\tExit.");
            Console.Write("Enter Choice: ");

            return int.Parse(Console.ReadLine());
        }
        static Products AddProduct()
        {
            string name;
            string category;
            float price;
            int quantity;
            int minimumQuantity;

            Console.Write("Product Name: ");
            name = Console.ReadLine();

            Console.Write("Product Category: ");
            category = Console.ReadLine();

            Console.Write("Product Price: ");
            price = float.Parse(Console.ReadLine());

            Console.Write("Product Quantity: ");
            quantity = int.Parse(Console.ReadLine());

            Console.Write("Product Minimum Quantity: ");
            minimumQuantity = int.Parse(Console.ReadLine());

            Products product = new Products(name, category, price, quantity, minimumQuantity);

            return product;
        }
        static void viewList(List<Products> p)
        {
            Console.WriteLine("Product Name\tCategory\tPrice\t\tStock\t\tMinimum Stock");
            foreach (var x in p)
            {
                Console.WriteLine("{0}\t\t{1}\t\t{2}\t\t{3}\t\t{4}", x.name, x.category, x.price, x.quantity, x.minimumQuantity);
            }
            Console.ReadKey();
        }
        static void ordered(List<Products> p)
        {
            Console.WriteLine("Product Name \tCurrent Stock \tMinimum Stock");

            foreach (var item in p)
            {
                if (item.quantity < item.minimumQuantity)
                {
                    Console.WriteLine("{0} \t\t {1} \t\t {2}", item.name, item.quantity, item.minimumQuantity);
                }
            }
            Console.ReadKey();
        }
        static void viewTax(List<Products> product)
        {
            Console.WriteLine("Product Name\tCategory\ttax");
            foreach (var item in product)
            {
                Console.WriteLine("{0} \t\t {1} \t\t {2}", item.name, item.category, item.calculateTax());
            }
            Console.ReadKey();
        }
        static int highestPrice(List<Products> p)
        {
            float max = 0;
            int idx = 0;
            for (int x = 0; x < p.Count; x++)
            {
                if (max < p[x].price)
                {
                    max = p[x].price;
                    idx = x;
                }
            }
            return idx;
        }
        static void buyAProduct(Customer c, List<Products> p)
        {
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Quantity: ");
            int productQuantity = int.Parse(Console.ReadLine());

            foreach (var item in p)
            {
                if(item.name.Equals(name)) 
                {
                    if(item.quantity>productQuantity)
                    {
                        c.AddProduct(item,productQuantity);
                    }
                }
            }
        }
    }
}