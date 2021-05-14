namespace GameTOP.Lib
{
    public class Jogo
    {
        private readonly IJogador Jogador;

        public Jogo(IJogador jogador){
            this.Jogador = jogador;
        }
        public void InciarJogo(){
            Jogador.Chutar();
            Jogador.Corre();
            Jogador.Passe();
        }
    }
}