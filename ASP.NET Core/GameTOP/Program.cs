using System;
using GameTOP.Lib;

namespace GameTOP
{
  class Program
  {
      
    public static void Main(string[] args)
    {
      var ronaldo = new Jogo(new Jogador("Ronaldo"));
      var neymar = new Jogo(new Jogador("Neymar"));
      
      ronaldo.InciarJogo();
      neymar.InciarJogo();
    }
  }
}
