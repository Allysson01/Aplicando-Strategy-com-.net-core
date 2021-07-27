using System;

namespace PadraoStrategyNaPratica
{
    public class Carro
    {
        public Carro(string nome, string dataFabricacao, Cores cor, Categoria categoria)
        {
            Nome = nome;
            DataFabricacao = dataFabricacao;
            CorPerolizada = cor == Cores.Perola;
            Categoria = categoria;
        }

        public string Nome { get; }

        public string DataFabricacao { get; }

        public Categoria Categoria { get; }

        public bool CategoriaCarga { get => Categoria == Categoria.Carga; }
        public bool CategoriaUtilitario { get => Categoria == Categoria.Utilitario; }
        public bool CategoriaPasseio { get => Categoria == Categoria.Passeio; }
        public bool MenosCincoAnos { get => DateTime.Now.Year - Convert.ToDateTime(DataFabricacao).Year <= 5; }

        public bool EntreCincoESete {
            get => DateTime.Now.Year - Convert.ToDateTime(DataFabricacao).Year > 5
            && DateTime.Now.Year - Convert.ToDateTime(DataFabricacao).Year <= 7;
        }

        public bool MaisAntigo { get => DateTime.Now.Year - Convert.ToDateTime(DataFabricacao).Year > 7; }

        public bool CorPerolizada { get; }

        public int Valor { get; private set; }


        public void InformarValor(int valor)
        {
            Valor = valor;
        }

    }
}
