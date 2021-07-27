using PadraoStrategyNaPratica.ComStrategy.Interface;

namespace PadraoStrategyNaPratica.ComStrategy
{
    public class CategoriaCarga : IValidador
    {
        public bool ValidoPara(Carro carro)
        {
            return carro.CategoriaCarga;
        }

        public int AddValor(Carro carro)
        {
            return 200;
        }
    }
}
