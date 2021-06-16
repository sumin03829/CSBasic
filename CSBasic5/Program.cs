﻿    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSBasic5
{
    class Program
    {
        static void Main(string[] args)
        {
            MultiClass ml = new MultiClass();
            Console.WriteLine(ml.Multi(52,273));
            Console.WriteLine(ml.Multi(103,32));
            ml.Print();
            Console.WriteLine(ml.Sum(1, 100));
            MyMath.Abs(52);
            MyMath.Abs(273);
            MyMath.Abs(52.273);
            MyMath.Abs(3000000000);

            ml.somePublic();
            /*ml.someDefault();
            ml.somePrivate();*/

            Product productA = new Product("감자", 2000);
            Product productB = new Product("고구마", 3000);
            Console.WriteLine(productA);
            Console.WriteLine(productB);
            Console.WriteLine(Product.counter + "개 생성되었습니다.");

            Console.WriteLine("첫 번째 위치");
            Sample sample = new Sample();
            // Console.WriteLine(Sample.value);
            Console.WriteLine("두 번째 위치");
            Console.WriteLine(Sample.value);
            //Sample sample = new Sample();
            Console.WriteLine("세 번째 위치");
        }

        class Sample
        {
            public static int value;
            static Sample()
            {
                value = 10;
                Console.WriteLine("정적 생성자 호출");
            }
        }

        class Product
        {
            public static int counter = 0;
            public readonly int id; //생성자에서만 딱1번 변경 가능
            public string name;
            public int price;

            public Product(string name, int price)
            {
                Product.counter = Product.counter + 1;
                this.id = Product.counter;
                this.name = name;
                this.price = price;
            }

            ~Product()
            {
                Console.WriteLine(this + "의 소멸자 호출되었습니다.");
                Console.WriteLine(this.name+"曰: \"안녕히 계세요 여러분\"");
            }

            public override string ToString()
            {
                return id + ":" + name;
            }
        }

        class MyMath
        {
            public static void Abs(int input)
            {
                Console.WriteLine("정수: "+ ((input < 0) ? -input : input));  
            }
            public static void Abs(double input)
            {
                Console.WriteLine("더블: " + ((input < 0) ? -input : input));
            }
            public static void Abs(long input)
            {
                Console.WriteLine("롱: " + ((input < 0) ? -input : input));
            }
        }

        class MultiClass
        {
            public void somePublic()
            {
                Console.WriteLine("public:");
            }
            public void someDefault()
            {
                Console.WriteLine("Default:");
            }
            public void somePrivate()
            {
                Console.WriteLine("Private:");
            }


            public int Multi(int x, int y)
            {
                return x * y;
            }

            public void Print()
            {
                Console.WriteLine("Print() 메서드 호출");
            }
            public int Sum(int min, int max)
            {
                int output = 0;
                for(int i = min; i < max; i++)
                {
                    output += i;
                }
                return output;
            }
        }
    }
}
