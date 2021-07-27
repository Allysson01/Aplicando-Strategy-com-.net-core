using System;

namespace PadraoStrategyNaPratica.SemStrategy
{
    public class VerificaDados
    {
        public VerificaDados(){}

        public ValorCarro DefineValorCarro(Carro carro)
        {
            var valorCarro = new ValorCarro(carro);

            var dataAtual = DateTime.Now;

            var idadeCarro = dataAtual.Year - Convert.ToDateTime(carro.DataFabricacao).Year;

            if (idadeCarro < 5)
            {
                valorCarro.AdicionaValorAoCarro(100);
            }
            else if(idadeCarro > 5 && idadeCarro < 7)
            {
                valorCarro.AdicionaValorAoCarro(80);
            }
            else
            {
                valorCarro.AdicionaValorAoCarro(50);
            }

            if (carro.CorPerolizada)
            {
                valorCarro.AdicionaValorAoCarro(50);
            }

            if (carro.Categoria == Categoria.Carga)
            {
                valorCarro.AdicionaValorAoCarro(200);
            }

            if (carro.Categoria == Categoria.Utilitario)
            {
                valorCarro.AdicionaValorAoCarro(150);
            }

            if (carro.Categoria == Categoria.Passeio)
            {
                valorCarro.AdicionaValorAoCarro(100);
            }

            return valorCarro;
        }       
    }
}
