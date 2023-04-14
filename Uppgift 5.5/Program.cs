using System;
using System.Diagnostics;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Threading.Channels;

namespace uppgift5._5
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ställ en fråga eller svara 'a' för att avsluta programmet.");
            string x = Console.ReadLine();

            string[] svar = new string[10];
            svar[0] = "Ja";
            svar[1] = "Nej";
            svar[2] = "Kanske";
            svar[3] = "Osäker";
            svar[4] = "Kanske en dag";
            svar[5] = "Det finns en chans";
            svar[6] = "Testa imorgon";
            svar[7] = "Jag vet inte";
            svar[8] = "Tänk efter, du vet svaret";
            svar[9] = "Aldrig";

            while (x !="a") 
            {
                     Random r = new Random();
                    int y = r.Next(0, 10);
                    Console.WriteLine(svar[y]);
                    Console.WriteLine("Ställ en fråga till om du vill, annars svarar du 'a' för att avsluta programmet.");
                    x = Console.ReadLine();
            }

        }
    }
}