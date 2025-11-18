namespace _01_Functions
{
    internal class Program
{
    static void Main(string[] args)
    {
        Program program = new Program();
        program.Run();
        // Function: Run
        // Deze function laat de program werken
        // Het type van de function is program
        program.Vraag1();
        program.Vraag2();
        program.Vraag3();
        program.Vraag4();
        program.Vraag5();
        program.Vraag6();
    }

    internal void Run()
        {
            Console.WriteLine("Dit is nu de start van mijn programma");
        }
        internal void Vraag1()
        {
            Console.WriteLine("How long do you think you'd survive in a zombie apocalypse?");
            string antwoord = Console.ReadLine();

            Console.WriteLine(antwoord);
        }
        internal void Vraag2()
        {
            Console.WriteLine("Wat is jouw favoriete film/serie?");
            string antwoord = Console.ReadLine();

            Console.WriteLine(antwoord);
        }
        internal void Vraag3()
        {
            Console.WriteLine("Waarom is de lucht blauw?");
            string antwoord = Console.ReadLine();

            Console.WriteLine(antwoord);

        }
        internal void Vraag4()
        {
            Console.WriteLine("Wat is 9 gedeeld door 3?");
            string antwoord = Console.ReadLine();

            Console.WriteLine(antwoord);

        }
        internal void Vraag5()
        {
            Console.WriteLine("Wat is jouw favoriete kleur?");
            string antwoord = Console.ReadLine();

            Console.WriteLine(antwoord);

        }
        internal void Vraag6()
        {
            Console.WriteLine("Wat is jouw favoriete dier?");
            string antwoord = Console.ReadLine();

            Console.WriteLine(antwoord);

        }
}
}