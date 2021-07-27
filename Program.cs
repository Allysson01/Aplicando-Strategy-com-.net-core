using PadraoStrategyNaPratica.ComStrategy;
using PadraoStrategyNaPratica.ComStrategy.Interface;
using PadraoStrategyNaPratica.SemStrategy;
using System;
using System.Collections.Generic;

namespace PadraoStrategyNaPratica
{
    class Program
    {
        static void Main(string[] args)
        {
            var carro = new Carro("Mustang", "10/05/2001", Cores.Perola, Categoria.Carga);

            Console.WriteLine("Dados do carro:");
            Console.WriteLine($"Modelo: {carro.Nome} | Data fabricação: {carro.DataFabricacao}");
            Console.WriteLine("----------------------");

            #region método sem strategy
            var verificar = new VerificaDados();
            var resultadoSemStrategy = verificar.DefineValorCarro(carro);

            Console.WriteLine($"Valor pago de aluguel para esse veículo: R${resultadoSemStrategy.Valor}");
            #endregion método sem strategy

            #region método com strategy
            var validadores = new List<IValidador>
            {
                new CorPerolizada(),
                new CategoriaCarga(),
                new CategoriaPasseio(),
                new CategoriaUtilitario(),
                new MenosDeCinco(),
                new EntreCincoESete(),
                new MaisAntigo(),
            };

            var validador = new ValidadorEstrategia(validadores);

            var resultadoComStrategy = validador.RetornaValorCarro(carro);

            Console.WriteLine($"Valor pago de aluguel para esse veículo2: R${resultadoComStrategy.Valor}");
            #endregion método com strategy            

            Console.Read();
        }
    }
}
