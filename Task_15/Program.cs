using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите начальное число прогрессии a");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите шаг прогрессии b");
            int b = Convert.ToInt32(Console.ReadLine());
            ArithProgression arith = new ArithProgression();
            Console.WriteLine("Арифметическая прогрессия:");

            arith.setStart(a);
            arith.setStep(b);
            Console.WriteLine(arith.getNext());
            Console.WriteLine(arith.getNext());
            Console.WriteLine(arith.getNext());
            Console.WriteLine("Сброс фрифметической прогрессии");
            arith.reset();
            Console.WriteLine(arith.getNext());
            Console.WriteLine(arith.getNext());
            Console.WriteLine(arith.getNext());

            GeomProgression geom = new GeomProgression();
            Console.WriteLine("Геометрическая прогрессия:");
            geom.setStart(a);
            geom.setStep(b);
            Console.WriteLine(geom.getNext());
            Console.WriteLine(geom.getNext());
            Console.WriteLine(geom.getNext());

            Console.WriteLine("Сброс геометрической прогрессии");
            geom.reset();
            Console.WriteLine(geom.getNext());
            Console.WriteLine(geom.getNext());
            Console.WriteLine(geom.getNext());



            Console.ReadKey();
        }
    }
    interface ISeries
    {
        void setStart(int x); //метод устанавливает начальное значение
        int getNext();  //метод возвращает следующее число ряда
        void reset(); //метод выполняет сброс к начальному значению
    }

    class ArithProgression : ISeries
    {
        int step;
        int startValue;
        int currentValue;

        public int getNext()
        {
            currentValue += step;
            return currentValue;
        }

        public void reset()
        {
            currentValue = startValue;
        }

        public void setStart(int x)
        {
            startValue = x;
            currentValue = startValue;
        }

        public void setStep(int s)
        {
            step = s;

        }
    }

    class GeomProgression : ISeries
    {
        int step;
        int startValue;
        int currentValue;

        public int getNext()
        {
            currentValue *= step;
            return currentValue;
        }

        public void reset()
        {
            currentValue = startValue;
        }

        public void setStart(int x)
        {
            startValue = x;
            currentValue = startValue;
        }

        public void setStep(int s)
        {
            step = s;

        }

    }
}
