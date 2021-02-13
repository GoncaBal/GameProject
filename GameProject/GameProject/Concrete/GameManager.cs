using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Abstract;
using GameProject.Entities;

namespace GameProject.Concrete
{
    public class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine(game.GameName+" sepete eklendi. Oyunun fiyatı "+game.GamePrice+" TL");
        }

        public void Delete(Game game)
        {
            Console.WriteLine(game.GameName+" sepetten silindi.");
        }

        public void Update(Game game)
        {
            Console.WriteLine("Sepet güncellendi! Eklenen oyun "+game.GameName);
        }
    }
}
