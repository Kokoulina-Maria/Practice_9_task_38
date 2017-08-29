using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_9_task_38
{
    class Point
    {
        int info;//информационное поле
        Point next;//адресное поле

        //свойства

        public int Info
        {
            get { return info; }
            set { info = value; }
        }
        public Point Next
        {
            get { return next; }
            set { next = value; }
        }

        //конструкторы

        public Point()//конструктор без параметров
        {
            info = 0;
            next = null;
        }
        public Point(int number)//конструктор с одним параметром
        {
            info = number;
            next = null;
        }
        public Point (int number, Point next)//конструктор с двумя параметрами
        {
            this.next = next;
            info = number;
        }

        public override string ToString()
        {
            return info + " --> ";
        }
    }
}
