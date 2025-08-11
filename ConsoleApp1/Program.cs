using System;

namespace ConsoleApp1
{
    class GiftBox
    {
        public string Letter;
        public int Money;

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            GiftBox addressA = GIftBoxMaker("sdsd",10000);
            GiftBox addressB = GIftBoxMaker("ssdsdsd", 10000);

            Console.WriteLine(addressA.Letter);
            Console.WriteLine(addressA.Money);

            Console.WriteLine(addressB.Letter);
            Console.WriteLine(addressB.Money);

            Console.WriteLine("시작부분");
            //인스턴스 생성
            GiftBox a = new GiftBox()
            {
                Letter = "잘지내니?",
                Money = 10000,
            };

            Console.WriteLine(a.Letter);
            Console.WriteLine(a.Money);

            //송장을 전달
            GiftBox b = a;

            Console.WriteLine(b.Letter);
            Console.WriteLine(b.Money);

            a.Letter = "어떻게 지내?";
            a.Money = 15000;

            GiftBox c = new GiftBox()
            {
                Letter = "잘지내니?",
                Money = 10000,
            };



        }

        private static GiftBox GIftBoxMaker(String Letter, int Money)
        {
            GiftBox addressA = new GiftBox()
            {
                Letter = Letter,
                Money = Money,
                
            };

            return addressA;//여기서 함수를 중단하고 값을 돌려주겠다.
        }


    }
}


