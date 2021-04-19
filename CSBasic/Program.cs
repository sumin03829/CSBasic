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

        }
    }
}
