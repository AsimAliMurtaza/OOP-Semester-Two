using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OOPTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            selfAssesmentOne();
            selfAssesmentTwo();
            selfAssesmentThree();
        }
        static void selfAssesmentOne()
        {
            List<Student> student = new List<Student>();
            Student s = new Student();

            s = takeUser();
            student.Add(s);

            Console.WriteLine("Merit: " + s.calculateMerit());
            Console.WriteLine("Avail Scholarship: " + s.isEligibleForScholarship(s.calculateMerit()));
        }
        static Student takeUser()
        {
            Student stud = new Student();
        
            Console.WriteLine("Enter name: ");
            stud.Name = Console.ReadLine();
            Console.WriteLine("Enter roll no: ");
            stud.RollNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("cGPA");
            stud.CGPA = float.Parse(Console.ReadLine());
            Console.WriteLine("Matric marks: ");
            stud.MatricMarks = int.Parse(Console.ReadLine());
            Console.WriteLine("FSC MArks: ");
            stud.FscMarks = int.Parse(Console.ReadLine());
            Console.WriteLine("Ecat marks: ");
            stud.EcatMarks = int.Parse(Console.ReadLine());
            Console.WriteLine("Hometown: ");
            stud.Hometown = Console.ReadLine();
            stud.isHostellite = true;

            return stud;
        }
        static void selfAssesmentTwo()
        {
            List<Book> book = new List<Book>();

            Book bk = new Book();
            bk.Author = "ali";
            bk.Pages = 500;
            bk.Chapters.Add("ChapOne");
            bk.Chapters.Add("ChapTwo");
            bk.Chapters.Add("ChapThree");
            bk.Title = "StarWars";
            bk.Price = 1000;
            book.Add(bk);

            Console.WriteLine("Book Title: " + bk.Title);
            Console.WriteLine("Chapter Name" + bk.getChapter(2));
            Console.WriteLine("Bookmark before: " + bk.getBookmark());
            bk.setBookmark(50);
            Console.WriteLine("Bookmarks after: " + bk.getBookmark());
            Console.WriteLine("Price before: " + bk.GetPrice());
            bk.setPrice(900);
            Console.WriteLine("Price After: " + bk.GetPrice());
        }
        static void selfAssesmentThree()
        {
            List<Customer> customers = new List<Customer>();

            Customer customer = new Customer();
            customer.CustomerName = "Jeera";
            customer.CustomerContact = "0123123231";
            customer.CustomerAddress = "Japan";
            customer.addProduct(inputProd());
            customer.addProduct(inputProd());
            customer.addProduct(inputProd());
            customers.Add(customer);
            
            Product p = new Product();
            Console.WriteLine("Total Products purchased by Customer: " + customer.products.Count);
            Console.WriteLine("5% Tax on each product which customer Purchases: " + p.calculateTax(customer.getAllProducts()));
        }
        static Product inputProd()
        {
            Product product = new Product();
            product.ProductName = "Test";
            product.ProductCategory = "Grocery";
            product.price = 1000;

            return product;
        }
    }
}
