using tabuleiro;

namespace xadrez
{
    class Torre : Peca  //criação objeto rei
    {
        public Torre(Tabuleiro tab, Cor cor) : base(tab, cor)
        {

        }
        public override string ToString()
        {
            return "T";
        }
    }
}
