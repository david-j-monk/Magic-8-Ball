using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic_8_Ball
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables
            string[] answer = new string[21];
            answer[0] = "It is certain";
            answer[1] = "It is decidedly so";
            answer[2] = "Without a doubt";
            answer[3] = "Yes definitely";
            answer[4] = "You may rely on it";
            answer[5] = "As I see it, yes";
            answer[6] = "Most likely";
            answer[7] = "Outlook good";
            answer[8] = "Yes";
            answer[9] = "Signs point to yes";
            answer[10] = "Reply hazy try again";
            answer[11] = "Ask again later";
            answer[12] = "Better not tell you now";
            answer[13] = "Cannot predict now";
            answer[14] = "Concentrate and ask again";
            answer[15] = "Don't count on it";
            answer[16] = "My reply is no";
            answer[17] = "My sources say no";
            answer[18] = "Outlook not so good";
            answer[19] = "Very doubtful";
            answer[20] = "HAHAHAHAHAHAHAHAHA!!!";
            Random random = new Random();

            Start:

            //inputs
            Console.WriteLine("8888888888888888888888888888888\n" +
                              "8                             8\n" +
                              "8  Please, ask your question  8\n" +
                              "8                             8\n" +
                              "8888888888888888888888888888888");
            Console.ReadLine();

            //Output
            Console.Write("Thinking");
            System.Threading.Thread.Sleep(1000);
            Console.Write(".");
            System.Threading.Thread.Sleep(1000);
            Console.Write(".");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine(".");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine(answer[random.Next(0, 20)]);
            Console.ReadKey();
            Console.WriteLine("\n\n\n");
            goto Start;
        }
    }
}
