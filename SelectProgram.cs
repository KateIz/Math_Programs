using System;
using System.Collections.Generic;
using System.Threading;


namespace Programs
{
    class SelectProgram
    {
        static void Main()
        {
            SelectProgram program = new SelectProgram();
            Console.WriteLine("Choose the program:\n 1 - Program which will find all numbers which are divisible by 7\n " +
                "but aren't a multiple of 5\n 2 - Program that accepts a sentence and calculate the number of \n " +
                "upper case letters and lower case letters");
            var a = Convert.ToInt32(Console.ReadLine());
           
            if (a == 1)
            {
                program.Divisible_by_7_and_5();
                Environment.Exit(0);
            }
            if (a == 2)
            {
                program.CountLetters();
                Thread.Sleep(3000);
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Wrong input. Please try again\n\n");
                SelectProgram.Main();
            }


        }
         
        public void Divisible_by_7_and_5()
        {
            int i = 2000;
            List<int> lista = new List<int>();
            while (i <= 3200)
            {
                if (i % 7 == 0)
                {
                    if (!(i % 5 == 0))
                    {
                        lista.Add(i);
                    }
                }
                i++;
            }
            Console.WriteLine(String.Join(",", lista));
            Thread.Sleep(3000);
        }

        public void CountLetters()
        {
            Console.WriteLine("Please input the sentence:\n");
            string sentence = Console.ReadLine();
            int UpCase = 0, LowCase = 0;

            foreach(char c in sentence)
            {
                if (Char.IsUpper(c))
                    UpCase++;
                if (Char.IsLower(c))
                    LowCase++;
                continue;
            }

            Console.WriteLine("UPCASE: "+ UpCase) ;
            Console.WriteLine("LOWERCASE: "+ LowCase);
        }
  
    }
}

