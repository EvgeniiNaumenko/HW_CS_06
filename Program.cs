using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Завдання 1
//В одному з попередніх практичних завдань ви створювали клас «Журнал». Додайте до вже створеного класу
//інформацію про кількість працівників. Виконайте навантаження + (для збільшення кількості працівників на вказану кількість), — (для зменшення кількості працівників
//на вказану кількість), == (перевірка на рівність кількості
//працівників), < і > (перевірка на меншу чи більшу кількість працівників), != і Equals. Використовуйте механізм
//властивостей полів класу.

//Завдання 2
//В одному з попередніх практичних завдань ви створювали клас «Магазин». Додайте до вже створеного класу
//інформацію про площу магазину. Виконайте навантаження + (для збільшення площі магазину на вказаний
//розмір), — (для зменшення площі магазину на вказаний
//розмір), == (перевірка на рівність площ магазинів), < і >
//(перевірка магазинів менших або більших за площею),
//!= і Equals. Використовуйте механізм властивостей
//полів класу.

//Завдання 3
//Створіть додаток «Список книг до прочитання». Додаток
//має дозволяти додавати книги до списку, видаляти книги
//зі списку, перевіряти чи є книга у списку, і т.д. Використовуйте механізм властивостей, навантаження операторів,
//індексаторів. 

namespace HW_06_07_06_2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("====================================");
                EmployeesList employeesList = new EmployeesList(10);
                EmployeesList employeesList2 = new EmployeesList(5);
                employeesList += 1;
                Console.WriteLine(employeesList); 
                employeesList -= 5;
                Console.WriteLine(employeesList);
                Console.WriteLine($"равны? {employeesList == employeesList2}");
                Console.WriteLine($"не равны? {employeesList == employeesList2}");
                Console.WriteLine($"Первый больше? {employeesList > employeesList2}");
                Console.WriteLine($"Первый меньше? {employeesList < employeesList2}");
                Console.WriteLine("====================================");

                Shop shop1 = new Shop(50);
                Shop shop2 = new Shop(50);
                shop1 += 10;
                Console.WriteLine(shop1);
                shop1 -= 30;
                Console.WriteLine(shop1);
                Console.WriteLine($"равны? {shop1 == shop2}");
                Console.WriteLine($"не равны? {shop1 != shop2}");
                Console.WriteLine($"Первый больше? {shop1 > shop2}");
                Console.WriteLine($"Первый меньше? {shop1 < shop2}");
                Console.WriteLine($"Равны? {shop1.Equals(shop2)}");
                Console.WriteLine("====================================");

                BookListToRead bookList = new BookListToRead("Book1","Author1");
                Book book2 = new Book("Book2", "Author2");
                bookList += book2;
                Console.WriteLine(bookList);
                Console.WriteLine($"Есть ли книга в списке Book4? {bookList.IsContains("Book4")}");
                Console.WriteLine($"Есть ли книга в списке Book2? {bookList.IsContains("Book2")}");
                Console.WriteLine(bookList);
                bookList -= "Book2";
                Console.WriteLine(bookList);
                Console.WriteLine($"Есть ли книга в списке? {bookList.IsContains("Book2")}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

        }
    }
}
