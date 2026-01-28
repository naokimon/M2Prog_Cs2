namespace _04_lists;

class Program
{
    static void Main(string[] args)
    {
        Program program = new Program();
        program.Run();
    }

    double[] prijzen = new double[] { 0.99, 5.60, 10.11};
    string[] artikelen = {"snoepje", "luxe broodje", "lunch menu"};
    Formulier[] formulieren = new Formulier[2];

    internal void Run()
    {
        formulieren[0] = new Formulier()
        {
            Feedback = "Prijzig maar lekker",
            Sterren = 5
        };

        formulieren[1] = new Formulier()
        {
            Feedback = "Duur en droog",
            Sterren = 3
        };

        for (int i = 0; i < prijzen.Length; i++)
        {
            Console.WriteLine(prijzen[i]);
            Console.WriteLine(artikelen[i]);
        }

        foreach (Formulier formulier in formulieren)
        {
            Console.WriteLine(formulier.Feedback);
            Console.WriteLine(formulier.Sterren);
        }
    }

    internal class Formulier
    {
        internal int Sterren { get; set; }
        internal string Feedback { get; set; }
    }
}