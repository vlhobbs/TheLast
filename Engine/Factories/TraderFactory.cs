using System;
using System.Collections.Generic;
using System.Linq;
using Engine.Models;

namespace Engine.Factories
{
    public class TraderFactory
    {
        private static readonly List<Trader> _traders = new List<Trader>();

        static TraderFactory()
        {
            Trader hospitalVendingMachine = new Trader("Hospital Vending Machine");
            hospitalVendingMachine.AddItemToInventory(ItemFactory.CreateGameItem(1001));

            AddTraderToList(hospitalVendingMachine);
        }

        public static Trader GetTraderByName(string name)
        {
            return _traders.FirstOrDefault(t => t.Name == name);
        }

        private static void AddTraderToList(Trader trader)
        {
            if (_traders.Any(t => t.Name == trader.Name))
            {
                throw new ArgumentException($"There is already a trader named '{trader.Name}'");
            }

            _traders.Add(trader);
        }
    }
}