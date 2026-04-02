public enum Cor
{
    Vermelho,
    Azul,
    Verde,
    Amarelo,
    Especial
}

public enum TipoCarta
{
    Numero,
    MaisDois,
    Inverter,
    Bloquear,
    CorCoringa,
    MaisQuatro
}

public class Carta
{
    public Cor Cor { get; set; }
    public TipoCarta Tipo { get; set; }
    public int Valor { get; set; } // usado para cartas numéricas
}