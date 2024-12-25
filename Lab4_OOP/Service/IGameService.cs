﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_OOP.Service
{
    public interface IGameService
    {
        void PlayGame(string player1, string player2, bool isWin, string gameType);

        void ShowAllGames();
        void DeleteGame(int gameId);


    }
}
