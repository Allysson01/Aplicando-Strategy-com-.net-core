namespace PadraoStrategyNaPratica.ComStrategy.Interface
{
    public interface IValidador
    {
        int AddValor(Carro carro);
        bool ValidoPara(Carro carro);
    }
}
