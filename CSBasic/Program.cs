using System;

namespace CSBasic
{
    class Program
    {
        string Var = "테스트";
        static void Main(string[] args)
        {
            var name = "최" + "수" + "민";
            Console.Write("개행이 안되는 녀석");
            Console.Write("");
            Console.WriteLine("개행이 되는 녀셕");

            var alpha = "알파";
            //var 273alpha = "숫자이름";
            var 한글변수명 = "된다";
            //var 🥽= "이모지";

            //인라인 주석
            /*여러줄
                주석*/

            Console.WriteLine(52);
            //Arithmetic Operator 
            Console.WriteLine(52 + 273);
            //Operator Priority
            Console.WriteLine(5 + 3 * 2);

            Console.WriteLine(10 / 5);
            Console.WriteLine(10 % 5);
            Console.WriteLine(7 % 3);

            //Real Number
            Console.WriteLine(52.273);
            Console.WriteLine(0);
            Console.WriteLine(0.0);

            Console.WriteLine(1.0 + 2.0);
            Console.WriteLine(1.0 - 2.0); 
            Console.WriteLine(1.0 * 2.0); 

            Console.WriteLine(1.0 / 2.0); 
            Console.WriteLine(1 / 2);
            Console.WriteLine(1 / 2.0);

            Console.WriteLine('A');
            Console.WriteLine('가');
            //Console.WriteLine('AB'); -> 에러뜨는거 정상 문자 Error 
            Console.WriteLine("AB"); //-> 문자는 큰 따옴표로 묶기

            //Escape Character
            Console.WriteLine("미\t림여자정보\t과학고");
            Console.WriteLine("미림\t여자정보\t과학고");
            Console.WriteLine("미림여\t자정보\t과학고");
            Console.WriteLine("미림여자정보과학고\t안녕");
            Console.WriteLine("\\역슬래시 \n 엔터문자 \" 큰따옴표");

            //문자열 연결 연산자 Concanteantion operator
            Console.WriteLine("A" + "B");
            Console.WriteLine("A" + 1);
            Console.WriteLine(1+"ㅁ");
            Console.WriteLine("1"+"1");
            Console.WriteLine('A'+'B');
            Console.WriteLine('A'-'B');
            //Console.WriteLine("A" - "B"); //오류나는거 정상
            Console.WriteLine("안녕하세요!"[0]);
            Console.WriteLine("안녕하세요!"[1]);
            Console.WriteLine("안녕하세요!"[2]);
            Console.WriteLine("안녕하세요!"[3]);
            //Console.WriteLine("안녕하세요!"[-1]);

            //bool / boolean
            Console.WriteLine(true);
            Console.WriteLine(false);

            //Comparison operator
            //== != > < >= <= 
            //=> <= -------- 오류
            Console.WriteLine(62 < 273);//이거 안되는거얌

            Console.WriteLine(DateTime.Now.Hour < 3 || 8< DateTime.Now.Hour); 
            Console.WriteLine(DateTime.Now.Hour < 3 && 8< DateTime.Now.Hour);

            //integer overflow
            int a = 2147483647;
            int b = 1;
            Console.WriteLine(a + b); //변수의 크기를 넘어서서 - 형태로 출력됨

            double c = 52.263;
            char d = '아';

            //size of 연산자
            Console.WriteLine("int: " + sizeof(int));
            Console.WriteLine("double: " + sizeof(double));
            Console.WriteLine("long: " + sizeof(long));
            Console.WriteLine("float: " + sizeof(float));
            Console.WriteLine("char: " + sizeof(char));
            Console.WriteLine("bool: " + sizeof(bool));

            bool TrueOrFalse = true;



            int output = 0;
            output += 52; //output=output+52
            output += 273;
            output += 103;
            Console.WriteLine(output);

            output *= 2;
            Console.WriteLine(output);

            //문자열 관련 복합 대입 연산자
            string output2 = "Hello ";
            output2 += "world";
            output2 += "!";
            Console.WriteLine(output2);

            //증감연산자
            int number = 10;            //num   출력값
            Console.WriteLine(number++); //11     10
            Console.WriteLine(++number); //12     12
            Console.WriteLine(number--); //11     12
            Console.WriteLine(--number); //10     10
            Console.WriteLine(number);   //10

            int _int = 273;
            long _long = 624235252342;
            float _float = 52.273F;
            double _double = 52.273;
            char _char = '글';
            string _string = "문자열";

            Console.WriteLine(_int.GetType());
            Console.WriteLine(_long.GetType());
            Console.WriteLine(_float.GetType());
            Console.WriteLine(_double.GetType());
            Console.WriteLine(_char.GetType());
            Console.WriteLine(_char.GetType());
            Console.WriteLine((2211111111L).GetType());

            var number3 = 100;
            var number4="엄마보고싶다";
            var number5 = 100.0;
            var number6 = 100.0F;

            string input=Console.ReadLine(); //콘솔에서 키보드 입력받기
            Console.WriteLine("input: " + input);
            /*while (true)
            {
                input = Console.ReadLine();
                if (input != "q")
                {
                    Console.WriteLine(input);
                }
                else
                {
                    break;
                }
            }*/

            // 강제 형변환
            long longNumber = 100;
            int intNumber = (int)longNumber;
            Console.WriteLine(intNumber);

            // 자동형변환
            intNumber = 100;
            longNumber = intNumber;
            Console.WriteLine(longNumber);

            // int -> long, float, double
            // long -> float, double
            // char -> int, long, float, double
            // float -> double

            // Widening Casting 자동형변환
            // byte -> short -> char -> int  -> long -> float -> double

            // Narrowing Casting 강제 형변환
            // double -> float -> long -> int -> char -> short -> byte

            // int.Parse() / long.Parse()
            // float.Parse() / double.Parse()
            string numberString = "3234";
            intNumber = int.Parse(numberString);
            Console.WriteLine(intNumber);


            try
            {
                Console.WriteLine(int.Parse("43.567"));
                Console.WriteLine("오십일");
                Console.WriteLine("Seven");
            }
            catch (FormatException e)
            {
                Console.WriteLine("숫자로 변경할 수 없습니다.");
            }
            catch (Exception e)
            {
                Console.WriteLine("알 수 없는 오류 : " + e.Message);
            }

            // 다른 자료형을 문자열로 변환
            Console.WriteLine((10).ToString());
            Console.WriteLine((52.378).ToString());
            Console.WriteLine(('a').ToString());
            Console.WriteLine((true).ToString());
            Console.WriteLine((false).ToString());

            double number2 = 52.273103;
            Console.WriteLine(number2.ToString("0.0"));
            Console.WriteLine(number2.ToString("0.00"));
            Console.WriteLine(number2.ToString("0.000"));
            Console.WriteLine(number2.ToString("0.0000"));

            Console.WriteLine(52 + "");   // 문자열
            Console.WriteLine(52 + 3 + "");
            Console.WriteLine("" + 52 + 3);
            Console.WriteLine(52 + "" + 3);

            number = 273;
            string outputA = number + "";
            Console.WriteLine(outputA);

            char ch = 'a';
            string outputB = ch + "";
            /*string outputC = ch;*/  // 문자를 문자열에 넣지 못함.
            Console.WriteLine(outputB);

            //string to bool 변환
            Console.WriteLine(bool.Parse("True"));
            Console.WriteLine(bool.Parse("true"));
            Console.WriteLine(bool.Parse("False"));
            Console.WriteLine(bool.Parse("false"));
            //최댓값 최솟값은 상수로
            Console.WriteLine(-1*int.MaxValue);
            //Console.WriteLine(-1*int.MinValue);
            Console.WriteLine(-1L*int.MinValue);

        }
    }
}
