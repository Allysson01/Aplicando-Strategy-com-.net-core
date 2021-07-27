namespace PadraoStrategyNaPratica
{
    public class ValorCarro
    {
        public ValorCarro(Carro carro)
        {
            Carro = Carro;
            Valor = 0;
        }

        public Carro Carro { get; }

        public int Valor { get; private set; }

        internal void AdicionaValorAoCarro(int valor)
        {
            Valor += valor;
        }
    }
}
