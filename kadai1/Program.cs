using System;
using System.Runtime.CompilerServices;
using System.Text;
using System.Transactions;

namespace kadai1
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("passコードを入力してください。");
            string userPass = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("passコードの設定が完了しました。");

            string correctAnswer = userPass;
            Console.WriteLine("passコード入力");
            string userAnswer = Console.ReadLine();


            while (userAnswer != correctAnswer)
            {
                
                Console.Clear();
                Console.WriteLine("入力が不正です");

                DateTime dt = DateTime.Now;
                Console.WriteLine(dt);

                Console.WriteLine("passコード入力してください");
                userAnswer = Console.ReadLine();
            }
            Console.WriteLine("passコードを認証しました");
            Console.ReadKey();
           
        }
        
    }
}




