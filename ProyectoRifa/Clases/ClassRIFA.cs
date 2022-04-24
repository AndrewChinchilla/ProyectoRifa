using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoRifa.Clases
{
    internal class ClassRIFA
    {

       
        public int Aleatorio(int n1, int n2)
        {
            Random r = new Random();
            return r.Next(n1 - 1, n2 - 1);
        }

            public void Rifa(string[] participantes, int premios)

            {
            int Ruleta;
            int PosParticipante1, PosParticipante2, Posparticipante3;
            PosParticipante2 = -1;
            Posparticipante3 = -1;

            Ruleta = Aleatorio(1, participantes.Length);
            PosParticipante1 = Ruleta;
            Console.WriteLine("\n");
            Console.WriteLine("\t\t *** GRAN RIFA ***\n");
            Console.WriteLine("\t\t *** RESULTADOS ***\n");
            Console.Write($"\tSorteo 1 Tombola {Ruleta} ");
            Console.WriteLine($"\tEl Ganador Es: {participantes[Ruleta]}");

            

            do
            {
                Ruleta = Aleatorio(1, participantes.Length);

                if (Ruleta != PosParticipante1)
                {

                    Console.Write($"\tSorteo 2 Tombola {Ruleta} ");
                    PosParticipante2 = Ruleta;
                    Console.WriteLine($"\tEl Ganador Es: {participantes[Ruleta]}");
                   
                }

            } while (Ruleta != PosParticipante2);

            do
            {
                Ruleta = Aleatorio(1, participantes.Length);

                if (Ruleta != PosParticipante1 && Ruleta != PosParticipante2)
                {

                    Console.Write($"\tSorteo 2 Tombola {Ruleta} ");
                  Posparticipante3 = Ruleta;
                    Console.WriteLine($"\tEl Ganador Es: {participantes[Ruleta]}");
                 
                }

            } while (Ruleta != Posparticipante3);
        }
    }
        }
    


