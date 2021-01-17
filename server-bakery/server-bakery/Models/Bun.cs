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
    public  class Bun
    {
        public int Id { get; set; }
        public double StartPrice { get; set; }
        public double LastPrice { get; set; }
        public DateTime CreationDate { get; set; }
        public BunType BunType { get; set; }
        public int ExpTime { get; set; }
        public int SellTime { get; set; }
        public BunStatus BunStatus { get; set; }

    }
}
