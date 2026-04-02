using System.Collections.Generic;
using UNO.UNO;

public class Jogo
{
    public List<Jogador> Jogadores { get; set; } = new List<Jogador>();
    public Baralho Baralho { get; set; } = new Baralho();
    public List<Carta> PilhaDescarte { get; set; } = new List<Carta>();

    public int JogadorAtualIndex { get; set; }
    public bool SentidoHorario { get; set; } = true;

    public Jogador JogadorAtual => Jogadores[JogadorAtualIndex];

    public void ProximoJogador()
    {
        if (SentidoHorario)
            JogadorAtualIndex = (JogadorAtualIndex + 1) % Jogadores.Count;
        else
            JogadorAtualIndex = (JogadorAtualIndex - 1 + Jogadores.Count) % Jogadores.Count;
    }
}