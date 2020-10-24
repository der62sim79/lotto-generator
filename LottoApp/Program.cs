using System;
using System.Collections.Generic;

namespace LottoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lottoTicket = GenerateNummber();

            Console.Write("\n");

            int action = chooseInput();

            while (action != 0)
            {

                switch (action)
                {
                    case 1:

                        List<int> numbersInput = new List<int>();
                        int i = 0;
                        int count = 6;
                        int input = 0;
                        while (i < count)
                        {
                            Console.WriteLine($"Gib deine {i + 1}. Zahl ein: ");
                            input = Convert.ToInt32(Console.ReadLine());

                            if (!numbersInput.Contains(input))
                            {
                                numbersInput.Add(input);
                                i++;
                            } 
                            else
                            {
                                Console.WriteLine("\n" + input + $" wurde schon eingegeben. Bitte andere {i + 1}. Zahl verwenden\n");
                            }

                        }


                        foreach (int numb in numbersInput)
                        {

                            Console.Write(numb);
                        }



                        foreach (int lottoNumber in lottoTicket)
                        {
                            foreach (int guessNumber in numbersInput)
                            {
                                if (lottoNumber == guessNumber)
                                {
                                    Console.Write("\nRichtige Nummer: " + guessNumber + "\n");
                                }
                            }

                        }break;
                }
                action = chooseInput(); ;

            }
     }

        public static List<int> GenerateNummber()
        {
            Random random = new Random();
            List<int> lottoTicket = new List<int>();

            while (lottoTicket.Count < 6)
            {
                int nummber = random.Next(1, 10);
                if (!lottoTicket.Contains(nummber))
                {
                    lottoTicket.Add(nummber);
                    Console.Write(nummber);
                }

            }

            Console.Write("\n");

            foreach (int numb in lottoTicket)
            {
                Console.Write(numb);
            }
            return lottoTicket;
        }

        static public int chooseInput()
        {
            int choice = 0;
            Console.WriteLine("Wähle eine action (0) für Aufgeben, (1) Zahlenraten \n ");

            choice = int.Parse(Console.ReadLine());
            return choice;
        }
    }
}
