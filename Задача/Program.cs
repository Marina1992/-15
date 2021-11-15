using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача
{
	class Program
	{
        /*   Разработать интерфейс ISeries генерации ряда чисел. Интерфейс содержит следующие элементы:
	• метод void setStart(int x) - устанавливает начальное значение
	• метод int getNext() - возвращает следующее число ряда
	• метод void reset() - выполняет сброс к начальному значению
     Разработать классы ArithProgression и GeomProgression, которые реализуют интерфейс ISeries. В классах реализовать методы интерфейса в соответствии с логикой арифметической и геометрической прогрессии соответственно.

    */
        static void Main(string[] args)
			{

            Console.WriteLine(" Арифметическая  прогрессия: ");

            ArithProgression ob = new ArithProgression();

          
            Console.WriteLine(" \n Начать с числа 3   ");
            ob.SetStart(3);
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(" Следующее число равно " + ob.GetNext());

            }
            Console.WriteLine(" \n Cбросить   ");
            ob.Reset();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(" Следующее число равно " + ob.GetNext());

            }

            Console.WriteLine(" \n Начать с числа 100   ");

            ob.SetStart(100);

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(" Следующее число равно " + ob.GetNext());

            }

            Console.WriteLine();

            Console.WriteLine(" Геометрическая прогрессия: ");

            GeomProgression geom = new GeomProgression();


            
            Console.WriteLine(" \n Начать с числа 7   ");

            geom.SetStart(7);

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(" Следующее число равно " + geom.GetNext());

            }



            Console.ReadKey();

        }
		}

		public interface ISeries
		{
			
			int GetNext();// возратит след. по порядку число 
			void Reset();// перезапустит 
		     void SetStart(int x);// задать начальное значение 
	    }

    class ArithProgression : ISeries
    {
        int start;
        int val;


        public ArithProgression()
        {
            start = 0;
            val = 0;
        }
        public int GetNext()
        {
           val +=1;
            return val;
        }

        public void Reset()
        {
            val = start;
        }

        public void SetStart(int x)
        {
            start= x ;
            val = start;
        }
    }

    class GeomProgression : ISeries
    {
        int start;
        int val;


        public GeomProgression()
        {
            start = 0;
            val = 0;
        }
        public int GetNext()
        {
            val = val*2;
            return val;
        }

        public void Reset()
        {
            val = start;
        }

        public void SetStart(int x)
        {
            start = x;
            val = start;
        }
    }



}
	
