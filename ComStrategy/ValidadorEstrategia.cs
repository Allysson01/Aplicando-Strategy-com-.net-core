using PadraoStrategyNaPratica.ComStrategy.Interface;
using System.Collections.Generic;
using System.Linq;

namespace PadraoStrategyNaPratica.ComStrategy
{
    public class ValidadorEstrategia
    {
        private readonly IEnumerable<IValidador> _validador;

        public ValidadorEstrategia(IEnumerable<IValidador> validador)
        {
            _validador = validador;
        }

        public ValorCarro RetornaValorCarro(Carro carro)
        {
            var valorCarro = new ValorCarro(carro);

            var validadores = _validador.Where(x => x.ValidoPara(carro)).ToList();

            foreach (var item in validadores)
            {
                var valor = item.AddValor(carro);

                valorCarro.AdicionaValorAoCarro(valor);
            }

            return valorCarro;
        }
    }
}
