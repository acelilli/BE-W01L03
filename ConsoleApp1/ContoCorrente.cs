using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ContoCorrente
    {
         // dati utente:
        public string Nome { get; set; }
        public string Cognome { get; set; }
        // dati conto:
        private bool _contoPresente = false;
        public bool ContoPresente
        {
            get { return _contoPresente; }
            set { _contoPresente = value; }
        }
        public int Saldo { get; set; }
        public int Id { get; set; }

        // costruttore ContoCorrente:
        /* public ContoCorrente(string nome, string cognome, bool contoPresente, int saldo, int id ) {
            this.Nome = nome; 
            this.Cognome = cognome;
            this.ContoPresente = contoPresente;
            this.Saldo = saldo;
            this.Id = id;
        } */
        // METODI:
        //1) Apertura conto -> CONDIZIONE: con importo iniziale 1000
        public void ApriNuovoConto() // in questo caso è come se ApriNuovoConto faccia da costruttore
        {
            Console.WriteLine("Inserisci nome intestatario: \n");
            Nome = Console.ReadLine();
            Console.WriteLine("Inserisci cognome intestatario: \n");
            Cognome = Console.ReadLine();
            ContoPresente = true;
            Saldo = 1000;
            Id = 1200024;
            Console.WriteLine("\tConto corrente di: " + Nome + " " + Cognome + "\tSaldo attuale:" + Saldo + "\tId Conto:" + Id + "\t");
            
        }
        //2) Versamento
        public void Versamento()
        {
            Console.WriteLine("\nScegli importo da versare:");
            Console.WriteLine("\na.50$ \nb.100$ \nc.200$ \nd.500$");
            char add = Console.ReadKey().KeyChar; // leggo la key
            int importo = 0; // istanza dell'importo prima dello switch
                             //visto che ci sono +3 casi -> switch
            switch (add)
            { // a seconda della scelta do un valore a importo:
                case 'a':
                    importo = 50;
                    break;
                case 'b':
                    importo = 100;
                    break;
                case 'c':
                    importo = 200;
                    break;
                case 'd':
                    importo = 500;
                    break;
                default:
                    Console.WriteLine("Scelta non valida.");
                    break;
            } Saldo += importo;
            Console.WriteLine("\n Versamento di " + importo + " effettuato con successo.");
            Console.WriteLine("\tConto corrente di: " + Nome + " " + Cognome + "\tSaldo attuale:" + Saldo + "\tId Conto:" + Id + "\t");
        }
        //3) Prelievo
        public void Prelievo()
        {
            Console.WriteLine("\nScegli importo da prelevare:");
            Console.WriteLine("\na.50$ \nb.100$ \nc.200$ \nd.500$");
            char take = Console.ReadKey().KeyChar; // leggo la key
            int importo = 0; // istanza dell'importo prima dello switch
                             //visto che ci sono +3 casi -> switch
            switch (take)
            { // a seconda della scelta do un valore a importo:
                case 'a':
                    importo = 50;
                    break;
                case 'b':
                    importo = 100;
                    break;
                case 'c':
                    importo = 200;
                    break;
                case 'd':
                    importo = 500;
                    break;
                default:
                    Console.WriteLine("Scelta non valida.");
                    break;
            }
            Saldo -= importo;
            Console.WriteLine("\n Prelievo di " + importo + " effettuato con successo.");
            Console.WriteLine("\tConto corrente di: " + Nome + " " + Cognome + "\tSaldo attuale:" + Saldo + "\tId Conto:" + Id + "\t");
        } 
    }
}
