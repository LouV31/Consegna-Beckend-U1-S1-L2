using System;

namespace VersioneConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Inserisci il nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("\n");
            Console.WriteLine("Inserisci il cognome: ");
            string cognome = Console.ReadLine();
            Console.WriteLine("\n");
            Console.WriteLine("Inserisci l'età");
            int età;
            while (!int.TryParse(Console.ReadLine(), out età))
            {
                Console.WriteLine("Devi inserire un numero.");
            }
            Console.WriteLine("\n");

            Persona persona1 = new Persona(nome, cognome, età);
            Console.WriteLine("Solo il nome: ");
            Console.WriteLine(persona1.GetNome());
            Console.WriteLine("\n");
            Console.WriteLine("Solo il Cognome: ");
            Console.WriteLine(persona1.GetCognome());
            Console.WriteLine("\n");
            Console.WriteLine("Solo l'età: ");
            Console.WriteLine(persona1.GetEtà());
            Console.WriteLine("\n");

            Console.WriteLine("Profilo persona completo");
            Console.WriteLine(persona1.GetDettagli());

            Console.ReadLine();


        }
    }
}
