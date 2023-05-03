using System.Security.Cryptography.X509Certificates;

namespace HobbyVelger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] HobbyValg = { "Kunster med avhengighetsproblemer", "Passifist-Pirat", "Hagesteller", "Kjellervasker", "Piperenser"};
            
            Random random = new();
            int randomNum = random.Next(0, 4);


            Console.WriteLine("Hei, hva er ditt navn?");
            string name = Console.ReadLine();
            Console.WriteLine("Hallo, " + name);
            Console.WriteLine("Okei, " + name + " er du klar for å finne ut hva din nye hobby er?");
            string svar = Console.ReadLine();
            if(svar == "nei" || svar == "Nei") { 
            Console.WriteLine("Har ingenting å si, her er din nye hobby: ");
            }
            else
            {
                Console.WriteLine("Supert, her er din nye hobby:");
                Console.WriteLine(HobbyValg[randomNum]);
            }
        }
    }
}