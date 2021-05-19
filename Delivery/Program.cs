using System;
using System.Collections.Generic;
using Delivery.Companies;
using Delivery.Consumable;
using Delivery.Calculators;

namespace Delivery
{
    class Program
    {
        static void Main(string[] args)
        {
            var Storage = new List<Order>();
            var calculator = new Calculator(new ICalculator[]
            {
                new GSCalculator(),
                new MCCalculator(),
                new SFCalculator()
            });

            var Order = new Order[]
            {
                new Order("У.Пушкина", "Вася", new SimpleFirm(1000)),
                new Order("У.Колотушкина", "Коля", new GoldSecret(1000, true)),
                new Order("У.Ленина", "Антон", new GoldSecret(1000, false)),
                new Order("У.Пролетарская", "Леша", new MagicColor(1000, new ColorBox(Color.White),true, new ColoredRibbon(Color.Black))),
                new Order("У.Коли Мяготина", "Петя", new MagicColor(1000,new ColorBox(Color.Green), false))
            };
            
            foreach(var element in Order)
            { 
                Storage.Add(element);
                Console.WriteLine($"{element.ReceiverName} c {element.DeliveryAddress} должен заплатить {calculator.PriceCalculator(element.Company)}");
            }
        }
    }
}
