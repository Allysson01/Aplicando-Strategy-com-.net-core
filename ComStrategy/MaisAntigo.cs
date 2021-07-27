using PadraoStrategyNaPratica.ComStrategy.Interface;

namespace PadraoStrategyNaPratica.ComStrategy
{
    public class MaisAntigo : IValidador
    {
        public bool ValidoPara(Carro carro)
        {
            return carro.MaisAntigo;
        }

        public int AddValor(Carro carro)
        {
            return 50;
        }
    }
}
