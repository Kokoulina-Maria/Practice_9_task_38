using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_9_task_38
{
    class Program
    {
        static int Readint(string msg)
        {// Ввод целого числа с проверкой
            int number; bool ok;// переменная для проверки
            do
            {
                Console.Write(msg);
                ok = int.TryParse(Console.ReadLine(), out number);
                if (!ok) Console.WriteLine("Неверный ввод!");
            } while (!ok);// конец проверки
            return (number);
        }
        static Head MadeHead(int N)
        {//заполняем исходный список
            Head list = new Head();
            Head beg = new Head();
            beg = list;
            for (int i=0; i<N; i++)
            {
                beg.Info=Readint("Введите элемент:");
                beg = beg.Next;
            }
            return list;
        }

        static void WriteList(Point2 list)
        {

        }
        static void MadeLists(Head head)
        {//процедура создания двух списков с информационными полями, ссылающимися на элементы списка head
            Point2 Pos = new Practice_9_task_38.Point2();
            Point2 PosBeg = new Practice_9_task_38.Point2();
            Point2 Neg = new Practice_9_task_38.Point2();
            Point2 NegBeg = new Point2();
            Head beg = new Head();
            beg = head;
            while (beg!= null)
            {
                if (beg.Info > 0)
                {
                    PosBeg.Info = beg;
                    PosBeg = PosBeg.Next;
                }
                if (beg.Info < 0)
                {
                    NegBeg.Info = beg;
                    NegBeg = NegBeg.Next;
                }
                beg = beg.Next;
            }
        }      
        static void Main(string[] args)
        {
            int N;
            do
            {
                N = Readint("Введите количество элементов в исходном списке: ");
                if (N <= 0) Console.WriteLine("Неверный ввод!");
            } while (N <= 0);

            Head head = new Head();
            head = MadeHead(N);
            MadeLists(head);
        }
    }
}
