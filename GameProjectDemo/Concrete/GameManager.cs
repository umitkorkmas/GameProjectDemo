using GameProjectDemo.Abstract;
using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Concrete
{
    class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine(game.GameName + " : İsimli oyun eklendi");
        }

        public void Delete(Game game)
        {
            Console.WriteLine(game.GameName + " : İsimli oyun silindi");
        }

        public void Update(Game game)
        {
            Console.WriteLine(game.GameName + " : İsimli oyun güncellendi");
        }
    }
}
