class Quiz
{
    internal QuizVraag[] vragen;
    internal QuizVraagAntwoord[] ingevuldeAntwoorden;


    internal Quiz(int aantalVragen)
    {
        vragen = new QuizVraag[aantalVragen];
        ingevuldeAntwoorden = new QuizVraagAntwoord[aantalVragen];
    }
    internal void VoegVraagToeOpIndex(int index, QuizVraag vraag)
    {
        vragen[index] = vraag;
    }

    internal void VoegVraagToeOpIndex(int index, string vraag, string antwoord)
    {
        QuizVraag quizVraag = new QuizVraag(vraag, antwoord);
        VoegVraagToeOpIndex(index, quizVraag);
    }

    internal void StelVraag(int index)
    {
        QuizVraag vraag = vragen[index];
        QuizVraagAntwoord antwoord = new QuizVraagAntwoord(vraag);
        Console.WriteLine(vraag.vraag); 
        Console.ReadLine();
        
        string antwoord1 = Console.ReadLine();
        if (antwoord1 == vraag.antwoord)
        {
            antwoord.goed = true;
            Console.WriteLine("Correct!");

        }else 
        {
            antwoord.goed = false;
            Console.WriteLine("Incorrect!");
        }
    }
}
