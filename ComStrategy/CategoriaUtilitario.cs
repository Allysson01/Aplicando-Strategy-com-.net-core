using PadraoStrategyNaPratica.ComStrategy.Interface;

namespace PadraoStrategyNaPratica.ComStrategy
{
    public class CategoriaUtilitario : IValidador
    {
        public bool ValidoPara(Carro carro)
        {
            return carro.CategoriaUtilitario;
        }

        public int AddValor(Carro carro)
        {
            return 150;
        }
    }
}
