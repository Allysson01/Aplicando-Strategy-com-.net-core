using PadraoStrategyNaPratica.ComStrategy.Interface;

namespace PadraoStrategyNaPratica.ComStrategy
{
    public class MenosDeCinco : IValidador
    {
        public bool ValidoPara(Carro carro)
        {
            return carro.MenosCincoAnos;
        }

        public int AddValor(Carro carro)
        {
            return 100;
        }
    }
}
