using System;
using Delivery.Companies;
using Delivery.Consumable;
using Delivery.Calculators;

namespace Delivery
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculator = new Calculator();
            var studio = new Studio(new Storage("У.Пушкина", "Вася", new SimpleFirm(1000)), calculator);
            
            var Order = new Order[]
            {
                new Order("У.Пушкина", "Вася", new SimpleFirm(1000)),
                new Order("У.Колотушкина", "Коля", new GoldSecret(1000, true)),
                new Order("У.Ленина", "Антон", new GoldSecret(1000, false)),
                new Order("У.Пролетарская", "Леша", new MagicColor(1000, new ColorBox(Color.Black, false))),
                new Order("У.Коли Мяготина", "Петя", new MagicColor(1000, new ColorBox(Color.Green, true, new ColoredRibbon(Color.Pink))))
            };

            foreach(var element in Order)
            {
                Console.WriteLine($"{element.ReceiverName} c {element.DeliveryAddress} должен заплатить {calculator.PriceCaculator(element.Company)}")
            }
        }
    }
}
