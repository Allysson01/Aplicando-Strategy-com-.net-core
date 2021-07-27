using PadraoStrategyNaPratica.ComStrategy.Interface;

namespace PadraoStrategyNaPratica.ComStrategy
{
    public class CategoriaPasseio : IValidador
    {
        public bool ValidoPara(Carro carro)
        {
            return carro.CategoriaPasseio;
        }

        public int AddValor(Carro carro)
        {
            return 100;
        }
    }
}
