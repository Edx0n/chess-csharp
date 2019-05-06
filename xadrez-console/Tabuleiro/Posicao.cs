
namespace tabuleiro
{
    class Posicao
    {
        public int linha {get; set; } //encapsulamento //acessados e alterados por outras classes
        public int coluna {get; set; }

        public Posicao(int linha, int coluna)
        {
            this.linha = linha;
            this.coluna = coluna;
        }

        public void definirValores(int linha, int coluna)
        {
            this.linha = linha;
            this.coluna = coluna;
        }

        public override string ToString() //vc faz o override pra converter o obj pra string
        {
            return linha +
                ", "
                + coluna;
        }
    }
}
