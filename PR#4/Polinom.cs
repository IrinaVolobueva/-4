using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR_4
{
    public class Polynom<T> where T : struct
    {
        public int Degree { get; private set; }
        public List<T> Coefficients { get; private set; }

        public Polynom()
        {
            Degree = 0;
            Coefficients = new List<T> { default(T) };
        }

        // Конструктор с заданной степенью и коэффициентами 
        public Polynom(int degree, params T[] coefficients)
        {
            Degree = degree;
            Coefficients = coefficients.ToList();
        }

        // Конструктор копирования 
        public Polynom(Polynom<T> other)
        {
            Degree = other.Degree;
            Coefficients = new List<T>(other.Coefficients);
        }

        // Метод для вычисления значения полинома 
        public T Calculate(T x)
        {
            dynamic result = default(T);
            for (int i = 0; i <= Degree; i++)
            {
                result += Coefficients[i] * Math.Pow((dynamic)x, i);
            }
            return result;
        }

        // Метод для сложения полиномов 
        public Polynom<T> Add(Polynom<T> other)
        {
            int maxDegree = Math.Max(Degree, other.Degree);
            List<T> newCoefficients = new List<T>();
            for (int i = 0; i <= maxDegree; i++)
            {
                dynamic coefficient = default(T);
                if (i <= Degree)
                {
                    coefficient += Coefficients[i];
                }
                if (i <= other.Degree)
                {
                    coefficient += other.Coefficients[i];
                }
                newCoefficients.Add(coefficient);
            }
            return new Polynom<T>(maxDegree, newCoefficients.ToArray());
        }

        // Метод для вычитания полиномов 
        public Polynom<T> Subtract(Polynom<T> other)
        {
            int maxDegree = Math.Max(Degree, other.Degree);
            List<T> newCoefficients = new List<T>();
            for (int i = 0; i <= maxDegree; i++)
            {
                dynamic coefficient = default(T);
                if (i <= Degree)
                {
                    coefficient += Coefficients[i];
                }
                if (i <= other.Degree)
                {
                    coefficient -= other.Coefficients[i];
                }
                newCoefficients.Add(coefficient);
            }
            return new Polynom<T>(maxDegree, newCoefficients.ToArray());
        }

        // Метод для умножения полиномов 
        public Polynom<T> Multiply(Polynom<T> other)
        {
            int newDegree = Degree + other.Degree;
            List<T> newCoefficients = new List<T>();
            for (int i = 0; i <= newDegree; i++)
            {
                double coefficient = 0;
                for (int j = 0; j <= Degree; j++)
                {
                    if (i - j <= other.Degree)
                    {
                        coefficient += Convert.ToDouble(Coefficients[j]) * Convert.ToDouble(other.Coefficients[i - j]);
                    }
                }
                newCoefficients.Add((T)Convert.ChangeType(coefficient, typeof(T)));
            }
            return new Polynom<T>(newDegree, newCoefficients.ToArray());
        }

        // Перегрузка операций 
        public static Polynom<T> operator +(Polynom<T> p1, Polynom<T> p2)
        {
            return p1.Add(p2);
        }

        public static Polynom<T> operator -(Polynom<T> p1, Polynom<T> p2)
        {
            return p1.Subtract(p2);
        }

        public static Polynom<T> operator *(Polynom<T> p1, Polynom<T> p2)
        {
            return p1.Multiply(p2);
        }

        public static Polynom<T> operator ++(Polynom<T> p)
        {
            for (int i = 0; i <= p.Degree; i++)
            {
                dynamic coefficient = p.Coefficients[i];
                coefficient++;
                p.Coefficients[i] = coefficient;
            }
            return p;
        }

        public static Polynom<T> operator --(Polynom<T> p)
        {
            for (int i = 0; i <= p.Degree; i++)
            {
                dynamic coefficient = p.Coefficients[i];
                coefficient--;
                p.Coefficients[i] = coefficient;
            }
            return p;
        }

        // Вывод полинома на экран 
        public void Print()
        {
            for (int i = Degree; i >= 0; i--)
            {
                if (!Coefficients[i].Equals(default(T)))
                {
                    if (i > 1)
                    {
                        textBox2.Text = ($"{Coefficients[i]}x^{i} + ");
                    }
                    else if (i == 1)
                    {
                        textBox2.Text = ($"{Coefficients[i]}x + ");
                    }
                    else
                    {
                        textBox2.Text = ($"{Coefficients[i]}");
                    }
                }
            }
        }
    }
}