using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_9_task_38
{
    class Head
    {
        int info;//информационное поле
        Head next;//адресное поле

        //свойства

        public int Info
        {
            get { return info; }
            set { info = value; }
        }
        public Head Next
        {
            get { return next; }
            set { next = value; }
        }

        //конструкторы

        public Head()//конструктор без параметров
        {
            info = 0;
            next = null;
        }
        //public Head(int number)//конструктор с одним параметром
        //{
        //    info = number;
        //    next = null;
        //}
        //public Head (int number, Head next)//конструктор с двумя параметрами
        //{
        //    this.next = next;
        //    info = number;
        //}

        public override string ToString()
        {
            return info + " --> ";
        }
    }
}
