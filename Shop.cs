using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Завдання 2
//В одному з попередніх практичних завдань ви створювали клас «Магазин». Додайте до вже створеного класу
//інформацію про площу магазину. Виконайте навантаження + (для збільшення площі магазину на вказаний
//розмір), — (для зменшення площі магазину на вказаний
//розмір), == (перевірка на рівність площ магазинів), < і >
//(перевірка магазинів менших або більших за площею),
//!= і Equals. Використовуйте механізм властивостей
//полів класу.
namespace HW_06_07_06_2024
{
    internal class Shop
    {
        public int Square { get; set; }
        public Shop(){}
        public Shop(int val)
        {
            Square = val;
        }
        public void addShop(int sq)
        {
            Square += sq;
        }
        public void delWorker(int sq)
        {
            if (Square >= sq && Square != 0)
            {
                Square -= sq;
            }
            else
            {
                throw new Exception("Площадь не может быть меньше 0");
            }

        }
        public static Shop operator +(Shop shop, int sq)
        {
            shop.Square+=sq;
            return shop;
        }
        public static Shop operator -(Shop shop, int sq)
        {
            shop.Square -= sq;
            return shop;
        }
        public static bool operator ==(Shop shop1, Shop shop2)
        {
            if (shop1.Square == shop2.Square)
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(Shop shop1, Shop shop2)
        {
            if (shop1.Square != shop2.Square)
            {
                return true;
            }
            return false;
        }
        public static bool operator >(Shop shop1, Shop shop2)
        {
            if (shop1.Square > shop2.Square)
            {
                return true;
            }
            return false;
        }
        public static bool operator <(Shop shop1, Shop shop2)
        {
            if (shop1.Square < shop2.Square)
            {
                return true;
            }
            return false;
        }
       
        public override bool Equals(object ob)
        {
            return (ob as Shop).Square == this.Square;
        }
        public override string ToString()
        {
            return $"Square of shop : {Square}";
        }
    }
}
