using System;
using Delivery.Companies;
using Delivery.Consumable;

namespace Delivery
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculator = new Calculator();
            var Order = new Order[]
            {
                new Order("У.Пушкина", "Вася", new SimpleFirm(1000)),
                new Order("У.Колотушкина", "Коля", new GoldSecret(1000, true)),
                new Order("У.Ленина", "Антон", new GoldSecret(1000, false)),
                new Order("У.Пролетарская", "Леша", new MagicColor(1000, new ColorBox(Color.Green))),
                new Order("У.Коли Мяготина", "Петя", new MagicColor(1000, new ColorBox(Color.Green, new ColoredRibbon(Color.Pink))))
            };

            foreach(var element in Order)
            {
                Console.WriteLine($"{element.ReceiverName} c {element.DeliveryAddress} должен заплотить {calculator.PriceCaculator(new SimpleFirm(1000))}");
            }

        }
    }
}
