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
        }
    }
}
