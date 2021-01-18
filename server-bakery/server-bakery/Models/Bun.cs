using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;



namespace server_bakery.Models{
    public enum BunType
{
       //Батон
        Loaf=0,
        //Багет
        Baguette = 1,
        //Круассан
        Croissant = 2,
        //Сметанник
        SourCream = 3,
       //Крендель
        Pretzel = 4
    };
    public enum BunStatus
    {
        //в продаже
        OnSell = 0,
        //продано
        Sold = 1,
        //удалено из продажи
        Wasted = 2,

    };
    public class Bun
    {
        public int Id { get; set; }
        public double StartPrice { get; set; }
        //текущая цена
        public double LastPrice { get; set; } 
        public DateTime CreationDate { get; set; } = DateTime.Now;
        public DateTime LastPriceUpdate { get; set; } = DateTime.Now;
        public BunType BunType { get; set; }
        //количество часов до истечения срока годности => выкидываем булочку
        public int ExpTime { get; set; }
        //количество часов до истечения срока продаж => булки станут хуже продаваться
        public int SellTime { get; set; }
        public BunStatus BunStatus { get; set; }
        //количество часов до новой цены
        public virtual int HoursToNextPrice => 1;
        public virtual double NextPrice  => LastPrice * 98 / 100;
}

}
