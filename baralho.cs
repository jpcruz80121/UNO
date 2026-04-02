using System;
using System.Collections.Generic;

public class Baralho
{
    public List<Carta> Cartas { get; set; } = new List<Carta>();

    public void Embaralhar()
    {
        Random rnd = new Random();
        int n = Cartas.Count;

        while (n > 1)
        {
            n--;
            int k = rnd.Next(n + 1);
            var value = Cartas[k];
            Cartas[k] = Cartas[n];
            Cartas[n] = value;
        }
    }

    public Carta ComprarCarta()
    {
        if (Cartas.Count == 0) return null;

        Carta carta = Cartas[0];
        Cartas.RemoveAt(0);
        return carta;
    }
}
