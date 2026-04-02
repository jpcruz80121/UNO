using System;
using System.Collections.Generic;
using System.Text;

namespace UNO.UNO
{
    using System.Collections.Generic;

    public class Jogador
    {
        public string Nome { get; set; }
        public List<Carta> Mao { get; set; } = new List<Carta>();
        public int Pontos { get; set; }
        public bool EhBot { get; set; }
    }
}
