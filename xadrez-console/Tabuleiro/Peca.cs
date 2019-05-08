namespace tabuleiro
{
    abstract class Peca
    {
        public Posicao posicao { get; set; }
        public Cor cor { get; protected set; } //so pode ser alterada por ela mesmo ou pela subclasse
        public int qteMovimentos { get; protected set; } //get = acessada
        public Tabuleiro tab { get; protected set; }

        public Peca (Tabuleiro tab, Cor cor)
        {
            this.posicao = null;
            this.tab = tab;
            this.cor = cor;
            this.qteMovimentos = 0;
        }

        public void incrementarQteMovimentos()
        {
            qteMovimentos++;
        }

        public bool existeMovimentosPossiveis()
        {
            bool[,] mat = movimentosPossveis();
            for (int i=0; i< tab.linhas; i++){
                for (int j=0; j<tab.colunas; j++)
                {
                    if (mat[i, j])
                    {
                        return true;
                    }
                }

            }
            return false;

        }

        public bool podeMoverPara(Posicao pos)
        {
            return movimentosPossveis()[pos.linha, pos.coluna]; 
        }

        public abstract bool[,] movimentosPossveis();
    }
    
}
