using tabuleiro;
using xadrez_console;
using xadrez;

try
{
    PartidaDeXadrez partida = new PartidaDeXadrez();

    while (!partida.Terminada)
    {
        Console.Clear();
        Tela.imprimirTabuleiro(partida.Tab);

        Console.WriteLine();
        Console.Write("Origem: ");
        Posicao origem = Tela.lerPosicaoXadrez().toPosicao();
        Console.Write("Destino: ");
        Posicao destino = Tela.lerPosicaoXadrez().toPosicao();

        partida.executaMovimento(origem, destino);
    }

    Tela.imprimirTabuleiro(partida.Tab);
}
catch (TabuleiroException e)
{
    Console.WriteLine(e.Message);
}