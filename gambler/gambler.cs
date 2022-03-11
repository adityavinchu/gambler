using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gambler
{
    public class gambler
    {
        public void Game()
        {
            Random random = new Random();
            const int EVERYDAY_STAKE = 100;
            const int EVERY_GAME = 1;
            const int GAME_REPETATION = 50;
            const int WIN = 1, LOOSE = 0;
            int MoneyLeft = 100;

            int repetation = random.Next(0, 2);
            switch (repetation)
            {
                case LOOSE:
                    MoneyLeft -= EVERY_GAME;
                    break;
                case WIN:
                    MoneyLeft += EVERY_GAME;
                    break;
            }
        }
    }
}
