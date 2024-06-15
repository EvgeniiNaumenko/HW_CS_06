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
namespace HW_06_07_06_2024
{
    internal class EmployeesList
    {
        private int _workers;

        public EmployeesList()
        {
            _workers = 0;
        }
        public EmployeesList(int val)
        { 
            _workers = val; 
        }
        public int getWorkers()
        {
            return _workers;
        }
        public void addNewWorker(int worker)
        {
            _workers += worker;
        }
        public void delWorker(int worker)
        {
            if (_workers >= worker && _workers != 0)
            {
                _workers -= worker;
            }
            else
            {
                throw new Exception("Нет такого количества рабочих");
            }

        }
        public static EmployeesList operator +(EmployeesList list, int worker)
        {
            list.addNewWorker(worker);
            return list;
        }
        public static EmployeesList operator -(EmployeesList list, int worker)
        {
            list.delWorker(worker);
            return list;
        }
        public static bool operator ==(EmployeesList list1, EmployeesList list2)
        {
            if (list1._workers == list2._workers)
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(EmployeesList list1, EmployeesList list2)
        {
            if (list1._workers != list2._workers)
            {
                return true;
            }
            return false;
        }
        public static bool operator >(EmployeesList list1, EmployeesList list2)
        {
            if (list1._workers > list2._workers)
            {
                return true;
            }
            return false;
        }
        public static bool operator <(EmployeesList list1, EmployeesList list2)
        {
            if (list1._workers < list2._workers)
            {
                return true;
            }
            return false;
        }
        public override bool Equals(object ob)
        {
            return (ob as EmployeesList)._workers == this._workers;
        }
        public override string ToString()
        {
            return $"Num of workers : {_workers}";
        }
    }
}
