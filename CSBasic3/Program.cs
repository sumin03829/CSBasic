using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSBasic3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = { 52, 172, 13, 13, 103 };
            intArray[2] = 0;
            Console.WriteLine(intArray[0]);
            Console.WriteLine(intArray[1]);
            Console.WriteLine(intArray[2]);
            Console.WriteLine(intArray[3]);
            Console.WriteLine(intArray[4]);
            Console.WriteLine(intArray.Length);

            int[] intArray2 = new int[1000];
            Console.WriteLine(intArray2[0]);
            Console.WriteLine(intArray2[999]);

            int i = 0;
            int[] intArray3 = { 52, 273, 32, 65, 103 };
            while (i < intArray3.Length)
            {
                Console.WriteLine(i + "번째 출력:" + intArray3[i]);
                i++;
            }

            string input;
            do
            {
                Console.WriteLine("입력 (exit를 입력하면 종료) :");
                input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        Console.WriteLine("gp 공지사항");
                        break;
                    case "2":
                        Console.WriteLine("go 오늘의 점심");
                        break;
                }
                Console.WriteLine("잘못된 입력입니다.");
            } while (input != "exit");

            /*for (int i2 = '가'; i2 <= '힣'; i2++)
            {
                Console.WriteLine((char)i2);
            }*/

            for (i = intArray3.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(intArray3[i]);
            }

            string[] array = { "사과", "배", "포도", "딸기", "바나나" };
            foreach (string item in array)
            {
                Console.WriteLine(item);
            }

            for (i = 0; i < 10; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
            for (i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j--)
                    Console.Write(' ');
                for (int j = 0; j < i + 1; j++)
                    Console.Write('*');
                Console.WriteLine("");
            }

            string inputString = "potato Tomato";
            inputString.ToUpper();//return POTATO TOMATO
            Console.WriteLine(inputString);//potato Tomato
            Console.WriteLine(inputString.ToLower());//potato tomato
            Console.WriteLine(inputString);//potato Tomato

            string foodString = "감자 고구마 토마토 치킨";
            string[] foods = foodString.Split(new char[] { ' ' });
            foreach (var food in foods)
            {
                Console.WriteLine(food);
            }

            string pathString = "C:\\oraclexe\\app\\oracle\\product\\11.2.0\\server\\bin;;C:\\oraclexe\\app\\oracle\\product\\11.2.0\\server\\bin;C:\\Program Files (x86)\\Common Files\\Oracle\\Java\\javapath;C:\\Program Files (x86)\\Intel\\iCLS Client\\;C:\\Program Files\\Intel\\iCLS Client\\;%SystemRoot%\\system32;%SystemRoot%;%SystemRoot%\\System32\\Wbem;%SYSTEMROOT%\\System32\\WindowsPowerShell\\v1.0\\;%SYSTEMROOT%\\System32\\OpenSSH\\;C:\\Program Files (x86)\\Intel\\Intel(R) Management Engine Components\\DAL;C:\\Program Files\\Intel\\Intel(R) Management Engine Components\\DAL;C:\\Program Files (x86)\\Intel\\Intel(R) Management Engine Components\\IPT;C:\\Program Files\\Intel\\Intel(R) Management Engine Components\\IPT;C:\\Program Files\\Java\\jdk1.8.0_201\\bin;C:\\Users\\82104\\Desktop\\java;D:\\eclipse\\chap_05\\src\\chap_05;D:\\eclipse;D:\\eclipse\\chap_05;C:\\Program Files\\Git\\cmd;C:\\python프로젝트\\venv\\Scripts;C:\\Program Files\\nodejs\\;C:\\Program Files\\dotnet\\;C:\\Program Files\\Microsoft SQL Server\\130\\Tools\\Binn\\;C:\\Program Files\\Microsoft SQL Server\\Client SDK\\ODBC\\170\\Tools\\Binn\\;C:\\Program Files\\Microsoft VS Code\\bin;C:\\Program Files (x86)\\dotnet\\";
            string[] paths = pathString.Split(new char[] { ';' });
            foreach (var path in paths)
                Console.WriteLine(path);

            string StrangeInput = " test \n     \n ";
            Console.WriteLine("[" + StrangeInput + "]");
            Console.WriteLine("[" + StrangeInput.Trim() + "]");

            string[] foodsArray = { "감자", "고구마", "토마토" };
            Console.WriteLine(string.Join(",", foodsArray));

            Console.Clear();
            Console.WriteLine("포맷중: 0% [__________]");
            var hash = "";
            for(int f = 0; f < 10; f++)
            {
                Console.SetCursorPosition(0, 0);
                Console.Write("포맷중: ");
                Console.Write((f+1)*10+"% [__________]");
                for(int f2 = 0; f2 < f; f2++)
                    Console.Write("#");
                for (int f2 = f+1; f2 < 10; f2++)
                    Console.Write("_");
                Console.WriteLine("]");
                Thread.Sleep(1000);
            }
            Thread.Sleep(3000);

            int x = 1;
            while (x < 50)
            {
                Console.Clear();
                Console.SetCursorPosition(x, 5);
                if (x % 3 == 0)
                    Console.WriteLine("___@");
                else if (x % 3 == 1)
                    Console.WriteLine("_^@");
                else
                    Console.WriteLine("^-@");
                Thread.Sleep(1000);
                x++;
            }
        }
    }
}
