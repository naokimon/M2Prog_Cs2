namespace _4_schrijven;

class Program
{
    static void Main(string[] args)
    {
        Program program = new Program();
        program.Run();
    }

    void Run()
    {
        string[] lines = { "Resident Evil 4", "Resident Evil 2", "Dead Rising" };
        System.IO.File.WriteAllLines("mijngames.txt", lines);
    }
}