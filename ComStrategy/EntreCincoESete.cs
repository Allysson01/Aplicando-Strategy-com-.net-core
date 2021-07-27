using PadraoStrategyNaPratica.ComStrategy.Interface;

namespace PadraoStrategyNaPratica.ComStrategy
{
    public class EntreCincoESete : IValidador
    {
        public bool ValidoPara(Carro carro)
        {
            return carro.EntreCincoESete;
        }

        public int AddValor(Carro carro)
        {
            return 80;
        }
    }
}
