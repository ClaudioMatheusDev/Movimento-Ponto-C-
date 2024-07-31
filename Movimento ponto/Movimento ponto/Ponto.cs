using System;

public class Ponto
{
    private int x;
    private int y;

    public Ponto(int xInicial, int yInicial)
    {
        x = xInicial;
        y = yInicial;
    }

    public void MoverEsquerda(int quantidade)
    {
        x -= quantidade;
    }

    public void MoverDireita(int quantidade)
    {
        x += quantidade;
    }

    public void MoverCima(int quantidade)
    {
        y += quantidade;
    }

    public void MoverBaixo(int quantidade)
    {
        y -= quantidade;
    }

    public void ExibirCoordenadas()
    {
        Console.WriteLine("Coordenadas finais do ponto: \n" + "x: " + x + "\n" + "y: " + y);
    }
}
