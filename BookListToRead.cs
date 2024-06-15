using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Завдання 3
//Створіть додаток «Список книг до прочитання». Додаток
//має дозволяти додавати книги до списку, видаляти книги
//зі списку, перевіряти чи є книга у списку, і т.д. Використовуйте механізм властивостей, навантаження операторів,
//індексаторів.
namespace HW_06_07_06_2024
{
    internal class BookListToRead
    {
        private List<Book> _bookList;
        private void addBook (string bookName, string authorName)
        {
            _bookList.Add (new Book (bookName,authorName));
        }
        public BookListToRead() { }
     
        public BookListToRead(string bookName, string authorName)
        {
            _bookList = new List<Book> ();
            _bookList.Add(new Book( bookName,authorName));
        }
        public static BookListToRead operator + (BookListToRead list, Book book)
        {
            bool isIn = false;
            for (int i = 0; i < list._bookList.Count; i++)
            {
                if (list._bookList[i].Name == book.Name)
                {
                    isIn = true; break;
                }
            }
            if (!isIn)
            {
                list._bookList.Add(book);
            }
            return list;
        }
        public static BookListToRead operator - (BookListToRead list, string book)
        {
            for (int i = 0; i < list._bookList.Count; i++)
            {
                if (list._bookList[i].Name == book)
                {
                    list._bookList.Remove(list._bookList[i]);
                }
            }
            return list;
        }
        public bool IsContains(string book)
        {
            for (int i = 0; i < _bookList.Count; i++)
            {
                if (_bookList[i].Name == book)
                {
                    return true;
                }
            }
            return false;
        }
        public override string ToString()
        {
            Console.WriteLine("My List to read:");
            foreach (Book book in _bookList)
            {
                Console.WriteLine(book);
            }
            Console.WriteLine("end!");

            return "";
        }
    }
}
