using PadraoStrategyNaPratica.ComStrategy.Interface;

namespace PadraoStrategyNaPratica.ComStrategy
{
    public class CorPerolizada : IValidador
    {
        public bool ValidoPara(Carro carro)
        {
            return carro.CorPerolizada;
        }

        public int AddValor(Carro carro)
        {
            return 50;
        }
    }
}
