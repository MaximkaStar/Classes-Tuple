using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesEnterense
{
    //public, private, protected
    public class User
    {
        // int long Guid 
        private int _id;
        private string login;
        private string password;
        private Car car;

        //модификатор_доступа Название_класса(аргументы) {тело}
        public User()
        {
            //Stub
        }
        //конструктор, который вызывается всего 1 раз при создании любого количество обьектов.
        static User()
        {
            //инициализация статических значений
        }
        public User(int id)//любое кол-во элементов
        {
            _id = id;
        }

        //модификатор_доступа возращаемый_тип Глагол_описывающий действия (аргументы) {Тело}
        public string GetLogin()
        {
            return login;
        }
        public void SetLogin(string login)
        {
            this.login = login;
        }

        public void SetId(int id)
        {
            _id = id;
        }

        public void ToDo()
        {

        }

        public void ToDo(ref string text)
        {
            text = "aaa";
            return 0;
        }
        public void ToDo(string num = "aaaa")
        {
            Sum(1, 2, 3, 4, 5, 6, 7);
            Sum(1);
            Sum(1, 2, 3);
        }

        public void Sum(params int[] numbers)
        {

        }
    }
}
