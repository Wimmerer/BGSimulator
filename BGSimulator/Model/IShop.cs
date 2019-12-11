﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BGSimulator.Model
{
    public interface IShop
    {
        void Roll(Player player, bool free = false);
        void Mulligen(Player player);
        void Sell(IMinion minionBase);
    }
}
