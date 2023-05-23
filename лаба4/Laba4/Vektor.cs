using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Laba4
{
    public class Vektor
    {
        private double[] mas;
        private int _size;
        public int Size
        {
            get { return _size; }
        }
        public double get(int j)
        {
            return mas[j];
        }
        public void set(int j,double a)
        {
            mas[j] = a;
        }
        public Vektor()
        {
            double[] c = { };
            mas = c;
            _size = 0;
        }
        public Vektor(int i)
        {
            mas = new double[i];
            _size = i;
        }
        public Vektor(double[] s)
        {
            mas = new double[s.Length];
            for (int i = 0; i < s.Length; i++)
            {
                mas[i] = s[i];
            }
            _size = s.Length;
        }
        public Vektor(Vektor b)
        {
            mas = new double[b.mas.Length];

            for (int i = 0; i < b.mas.Length; i++)
            {
                mas[i] = b.mas[i];
            }
            _size=mas.Length;
        }
        public void append(double a)
        {
            if(_size == mas.Length)
            {
                if(mas.Length != 0)
                    Array.Resize(ref mas, mas.Length *2);
                else
                    Array.Resize(ref mas, 4);
            }
            mas[_size++]=a;
            
        }
        public void append(int a,double b)
        {
            double[] s;
            if (_size == mas.Length)
            {
                s = new double[mas.Length*2];
            }
            else
            {
                s=new double[mas.Length];
            }
            for (int i = 0; i < a; i++)
            {
                s[i] = mas[i];
            }
            s[a] = b;
            for (int i = a; i < _size; i++)
            {
                s[i+1]=mas[i];
            }
            _size++;
            for (int i = 0; i < _size; i++)
            {
                mas[i] = s[i];
            }
            
        }
        public void delete()
        {
            int i = mas.Length-_size;
            Array.Resize(ref mas, _size - 1);_size--;
            Array.Resize(ref mas, i +_size);
            if (mas.Length > _size * 2)
            {
                Array.Resize(ref mas, Convert.ToInt16(mas.Length / 2));
            }
        }
        public void deleteIn(int a)
        {
            double[] s;
            s = new double[mas.Length ];
            for (int i = 0; i < a ; i++)
            {
                s[i] = mas[i];
            }
            for (int i = a+1 ; i < _size; i++)
            {
                s[i-1 ] = mas[i];
            }
            _size--;
            for (int i = 0; i < _size; i++)
            {
                mas[i] = s[i];
            }
            if (mas.Length > _size * 2)
            {
                Array.Resize(ref mas, Convert.ToInt16(mas.Length / 2));
            }
        }
        public void delete(double a)
        {
            if (line(a) != -1)
            {
                deleteIn(line(a));
            }
            else
            {
                Console.WriteLine("Нет такого элемента!");
            }
            if (mas.Length > _size * 2)
            {
                Array.Resize(ref mas, Convert.ToInt16(mas.Length / 2));
            }
        }
        public bool poln()
        {
            if (_size == mas.Length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void vvod()
        {
            Console.WriteLine("Введите размер массива:");
            int N = Convert.ToInt16(Console.ReadLine());
            mas = new double[N];
            _size = N;
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("Введите элемент массива:");
                double a = Convert.ToDouble(Console.ReadLine());
                mas[i] = a;
            }
        }
        public override string ToString()
        {
            string y = "(";
            for (int i = 0; i < _size; i++)
            {
                if (i < _size - 1)
                {
                    y += mas[i] + ","+"\t";
                }
                else
                {
                    y += mas[_size - 1];
                }
            }
            y += ")";
            return y;
        }
        public int InMax()
        {
            int t = 0;
            double max = mas[0];
            for (int i = 0; i < mas.Length; i++)
            {
                if (max < mas[i])
                {
                    max = mas[i];
                    t = i;
                }
            }
            return t;
        }
        public double value(int index)
        {
            if (index > 0 && index < mas.Length)
            {
                return mas[index];
            }
            else
            {
                return double.PositiveInfinity;
            }
        }
        public void change(int index, double a)
        {
            if (index > 0 && index < mas.Length)
            {
                mas[index] = a;
            }
            else
            {
                Console.WriteLine("Нет такого индекса!");
            }
        }
        public void rnd(int a, int b)
        {
            var rand = new Random();
            if (a > b)
            {
                for (int i = 0; i < mas.Length; i++)
                {
                    mas[i] = rand.Next(b, a);
                }
            }
            else
            {
                for (int i = 0; i < mas.Length; i++)
                {
                    mas[i] = rand.Next(a, b);
                }
            }
        }
        public int line(double a)
        {
            int i = 0;
            while (i <= mas.Length - 1 && mas[i] != a)
            {
                if (i != mas.Length - 1) { i++; }
                else
                {
                    i = -1;
                    break;
                }
            }
            return i;
        }
        
    }
}
