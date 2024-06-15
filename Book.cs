using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_06_07_06_2024
{
    internal class Book
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public Book() { }
        public Book(string name, string author) 
        {
            Name = name;
            Author = author;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            Book other = (Book)obj;
            return Name == other.Name;
        }
        public override string ToString()
        {
            return $"Name: {Name}\nAuthor: {Author}\n";
        }
    }
}
