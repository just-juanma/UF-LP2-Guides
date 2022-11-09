using System;
using System.Collections;

public class Queue
{
    public static void Main(string[] args)
    {
        Queue<string> nombres = new Queue<string>();

        Queue<string> aux = new Queue<string>();

        nombres.Enqueue("Bautista Falopa");
        nombres.Enqueue("JuanG99");
        nombres.Enqueue("Diskoteta");
        nombres.Enqueue("Porno Furios0");
        nombres.Enqueue("Batusai");

        Queue<string> premios = new Queue<string>();

        premios.Enqueue("jugada de la partida");
        premios.Enqueue("un abrazo de la mama de bato");

        List<string> listaPremiados = new List<string>();

        Random rand = new Random();
        int tocador;
        int idx;
        

        for (int i = 0; i < 2; i++)
        {
            tocador = rand.Next(1, nombres.Count);

            idx = nombres.Count;

            for (int j = 0; j < idx; j++)
            {
                if (nombres.Count == tocador)
                {
                    listaPremiados.Add(nombres.Dequeue());
                }
                else
                {
                    aux.Enqueue(nombres.Dequeue());
                }
                    
            }

            idx = aux.Count;

            for(int k = 0; k < idx; k++)
            {
                nombres.Enqueue(aux.Dequeue());
            }

            Console.WriteLine(listaPremiados[i] + ", te ganaste " + premios.Dequeue());
        }



    }
}