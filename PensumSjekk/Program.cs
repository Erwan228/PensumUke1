namespace PensumSjekk
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hvem vil ha en ny hobby?");
            string name = Console.ReadLine();
            string[] hobbies = { "Fursuiter", "Illustratør", "Sanger", "Dancer", "Musiker" };
            Random rnd = new Random();
            int rng = rnd.Next(hobbies.Length);
            Console.WriteLine($"{name}s nye hobby er {hobbies[rng]}");
            Main(null);
        }
    }
}