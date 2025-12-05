using System.Security.Cryptography;

namespace RijSchool;

class Program
{
    static void Main(string[] args)
    {
        Program program = new Program();
        program.Run();
    }

    internal void Run()
    {
        Auto auto1 = new Auto()
        {
            automaat = true,
            kenteken = "AA824H",
            kilometerStand = 20567,
            merk = "Volkswagen"
        };

        Auto auto2 = new Auto()
        {
            automaat = false,
            kenteken = "KU786G",
            kilometerStand = 65739,
            merk = "Volvo"
        };

        RijLeraar rijLeraar = new RijLeraar()
        {
            leeftijd = 30,
            naam = "John",
            zzp = false
        };

        LesPakket lesPakket1 = new LesPakket()
        {
            urenGekocht = 60,
            urenVerbruikt = 60,
            examenPogingen = 1,
            automaat = true
        };

        LesPakket lesPakket2 = new LesPakket()
        {
            urenGekocht = 60,
            urenVerbruikt = 60,
            examenPogingen = 1,
            automaat = true
        };

        TheorieTest theorieTest1 = new TheorieTest()
        {
            aantalFouten = 5,
            gehaald = true,
            afnameDatum = new DateTime(2024, 5, 26)
        };

        TheorieTest theorieTest2 = new TheorieTest()
        {
            aantalFouten = 5,
            gehaald = true,
            afnameDatum = new DateTime(2024, 5, 26)
        };

        RijTest rijTest1 = new RijTest()
        {
            gehaald = true,
            afnameDatum = new DateTime(2024, 5, 26)
        };

        RijTest rijTest2 = new RijTest()
        {
            gehaald = true,
            afnameDatum = new DateTime(2024, 5, 26)
        };

        Student student1 = new Student()
        {
            naam = "Nathan Cruz Martinez",
            leeftijd = 17,  
            lesPakket = lesPakket1,
            leraar = rijLeraar,
            theorieTest = theorieTest1,
            rijTest = rijTest1,
        };

        Student student2 = new Student()
        {
            naam = "Martinez Cruz Nathan",
            leeftijd = 71,  
            lesPakket = lesPakket2,
            leraar = rijLeraar,
            theorieTest = theorieTest2,
            rijTest = rijTest2,
        };

        Dag dag1 = new Dag()
        {
            datum = new DateTime(2024, 5, 24),
            lesUren = new LesUur[]
            {
                new LesUur() {tijd = 60, student = student1, rijLeraar = rijLeraar, auto = auto1},
                new LesUur() {tijd = 60, student = student2, rijLeraar = rijLeraar, auto = auto2}
            }
        };
    }
}