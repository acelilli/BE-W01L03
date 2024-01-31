using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ESERCIZIO 1 -> CONTO CORRENTE
            Console.WriteLine("Benvenuto in EpiBank \n scegli l'operazione da effettuare: \n");
            // If else if else o switch in cui:
            // 1 Aprire un conto 
            // 2 Versare
            // 3 Prelevare 
            ContoCorrente mioConto = null; // dichiarazione istanza FUORI dal blocco condizionale o si blocca tutto
            char scelta;

            do
            {
                Console.WriteLine("\nPremi 1 per Aprire un conto \nPremi 2 per versare sul tuo conto \nPremi 3 per prelevare dal conto\n");
                int choice = int.Parse(Console.ReadLine());
                // APERTURA CONTO
                if (choice == 1)
                {
                    Console.WriteLine("\nPer aprire il conto hai bisogno di un saldo iniziale di 1000$. \n Premi i per inserire:\n");
                    char key = Console.ReadKey().KeyChar;
                    if (key == 'i' || key == 'I')
                    {
                        Console.WriteLine("\nOperazione effettuata con successo.\n Apertura conto in corso...\n ");
                        mioConto = new ContoCorrente();
                        mioConto.ApriNuovoConto();
                        Console.WriteLine("\nOperazione effettuata con successo!");
                    }
                    else
                    {
                        Console.WriteLine("\nOperazione non effettuata. Riprovare?");
                    }
                }
                // VERSAMENTO
                else if (choice == 2)
                {   // CONTROLLO: se il valore di mioConto non è più null E la proprietà ContoPresente è true
                    if (mioConto != null && mioConto.ContoPresente == true)
                    {   // allora lancio metodo versamento
                        mioConto.Versamento();
                    }
                    else
                    {
                        Console.WriteLine("\nNon è possibile versare su un conto non esistente.");
                    }
                }
                //PRELIEVO
                else if (choice == 3)
                {   // CONTROLLO: se il valore di mioConto non è più null E la proprietà ContoPresente è true
                    if (mioConto != null && mioConto.ContoPresente == true)
                    {   // allora lancio metodo prelievo
                        mioConto.Prelievo();
                    }
                    else
                    {
                        Console.WriteLine("\nNon è possibile prelevare da un conto non esistente.");
                    }
                }

                Console.WriteLine("\nVuoi fare altro? (y / n)");
                scelta = Console.ReadKey().KeyChar;

            } while (scelta == 'y' || scelta == 'Y');

            Console.ReadLine();
        }
    }
}
