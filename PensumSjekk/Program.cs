namespace PensumSjekk
{
   

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hvem vil ha en ny hobby?");
            string name = Console.ReadLine();
            MakeHobby( name);
            Main(null);
            }
            
        
        static void MakeHobby (string name)
        {
        string[] hobbies = { "Fursuiter", "Illustratør", "Sanger", "Dancer", "Musiker" };
        Random rnd = new Random();
            int rng = rnd.Next(hobbies.Length);
            Console.WriteLine($"{name}s nye hobby er {hobbies[rng]}");
            Console.WriteLine("Er du fornøyd? (true/false)");
            string answer = Console.ReadLine();
            bool pleasure = Convert.ToBoolean(answer);
            if (pleasure) {
                Console.WriteLine($"Wonderful! {name} er nå {hobbies[rng]}");
                return; }
             else
            {
                MakeHobby(name);
            }
        }
    }
}