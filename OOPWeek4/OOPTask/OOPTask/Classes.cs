using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace OOPTask
{
    internal class Student
    {
        public string Name;
        public int RollNumber;
        public float CGPA;
        public int MatricMarks;
        public int FscMarks;
        public int EcatMarks;
        public string Hometown;
        public bool isHostellite;
        public bool isTakingScholarship;

        public Student()
        {
        
        }

        public Student(string n, int rn, float cgpa, int m, int f, int e, string ht, bool h, bool ts)
        {
            Name = n;
            RollNumber = rn;
            CGPA = cgpa;
            MatricMarks = m;
            FscMarks = f;
            EcatMarks = e;
            Hometown = ht;
            isHostellite = h;
            isTakingScholarship = ts;
        }
        public float calculateMerit()
        {
            float merit = 0;
            merit = (((float)FscMarks/1100)*60 + ((float)(EcatMarks/400)*40));
            return merit;
        }

        public bool isEligibleForScholarship(float merit)
        {
            if(merit>80 && isHostellite)
            {
                return true;
            }
            else 
            { 
                return false; 
            }
        }
    }

    internal class Book
    {
        public string Author;
        public int Pages;
        public string Title;
        public List<String> Chapters = new List<string>();
        public int Bookmark;
        public int Price;

        public Book()
        {

        }
        public Book(List<Book> book)
        {

        }

        public Book(string author, int pages, List<string> chapters, int bookmark, int price, string title)
        {
            Author = author;
            Pages = pages;
            Title = title;
            Chapters = chapters;
            Bookmark = bookmark;
            Price = price;
        }

        public string getChapter(int chapterNumber)
        {
            if(chapterNumber <= Chapters.Count)
            {
                return Chapters[chapterNumber - 1];
            }
            return null;
        }
        public int GetPrice()
        {
            return Price;
        }
        public void setPrice(int price)
        {
            Price = price;
        }
        public int getBookmark()
        {
            return Bookmark;
        }
        public void setBookmark(int bookmark)
        {
            if(bookmark <= Pages)
            {
                Bookmark = bookmark;
            }
        }
    }

    internal class Customer
    {
        public string CustomerName;
        public string CustomerAddress;
        public string CustomerContact;
        public List<Product> products = new List<Product>();
        public List<Product> getAllProducts()
        {
            return products;
        }
        public void addProduct(Product p)
        {
            products.Add(p);
        }
    }
    internal class Product
    {
        public string ProductName;
        public string ProductCategory;
        public int price;

        public float calculateTax(List<Product> products)
        {
            float temp = 0F;
            for(int i = 0; i< products.Count; i++)
            {
                temp = temp + (products[i].price * 5) / 100;
            }
            return temp;
        }
    }
}
