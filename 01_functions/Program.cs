using System.Reflection.Metadata.Ecma335;

namespace _01_functions;
    internal class Program
    {
        string[] vragen = new string[]
        {
            "What 1997 N64 video game features James Bond and is named after the 1995 film?",
            "What arcade game was called Puckman in Japan?",
            "Which spooky 2001 GameCube game starring Mario’s brother got a reboot for Nintendo Switch in 2019",
            "Regarded as one of the greatest video games of all time, what 1981 arcade game features the titular amphibian trying to cross a road without getting squashed by cars, and a river without getting eaten by predators?",
            "What is thought to be the first video game, created in 1958 and becoming popular in the 1970s?"
        };
            static void Main(string[] args)
            {
                Program program = new Program();
                program.Run(); // We hebben een variable gemaakt voor de class program. De function die we gebruiken heet Run();. De return type van de function is nu nog niks omdat, de function nog niet aangemaakt is.
            }

            internal void Run()
            {
                Console.WriteLine("...");

                string antwoord1 = Vraag1();
                Console.WriteLine(antwoord1);

                string antwoord2 = Vraag2();
                Console.WriteLine(antwoord2);

                string antwoord3 = Vraag3();
                Console.WriteLine(antwoord3);

                string antwoord4 = Vraag4();
                Console.WriteLine(antwoord4);

                string antwoord5 = Vraag5();
                Console.WriteLine(antwoord5);

                string vraag0 = GetVraag(0);
            }

            internal string Vraag1()
            {
                Console.WriteLine("Hoe lang zou jij overleven in een zombie apocalypse?");

                string antwoord = Console.ReadLine();
                
                return antwoord;
            }

            internal string Vraag2()
            {
                Console.WriteLine("If you can still remember, what are your funniest childhood memories?");

                string antwoord = Console.ReadLine();
                
                return antwoord;
            }

            internal string Vraag3()
            {
                Console.WriteLine("Why do round pizzas come in square boxes?");

                string antwoord = Console.ReadLine();
                
                return antwoord;
            }

            internal string Vraag4()
            {
                Console.WriteLine("What would you call a male ladybug?");

                string antwoord = Console.ReadLine();
                
                return antwoord;
            }

            internal string Vraag5()
            {
                Console.WriteLine("Has someone caught you dancing in front of the mirror?");

                string antwoord = Console.ReadLine();
                
                return antwoord;
            }

            internal string GetVraag(int vraagIndex)
            {
                return vragen[vraagIndex];
            }
    }
