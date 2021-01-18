using server_bakery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace server_bakery
{
    public static class SampleData
    {
        public static void Initialize(ApplicationContext context)
        {
            if (!context.Buns.Any())
            {
                context.Buns.AddRange(
                    new Bun
                    {
                        
                        StartPrice = 20.50,
                        LastPrice = 20.50,
                        ExpTime = 24,
                        SellTime = 5,
                        BunType = BunType.Loaf

                    },
                    new Bun
                    {
                        StartPrice = 30.50,
                        LastPrice = 30.50,
                        ExpTime = 20,
                        SellTime = 6,
                        BunType = BunType.SourCream,
                        BunStatus=BunStatus.OnSell

                    },
                    new Bun
                    {
                        StartPrice = 10.50,
                        LastPrice = 10.50,
                        ExpTime = 36,
                        SellTime = 10,
                        BunType = BunType.Pretzel,
                        BunStatus = BunStatus.OnSell

                    },
                    new Bun
                    {
                        StartPrice = 20.50,
                        LastPrice = 20.50,
                        ExpTime = 24,
                        SellTime = 5,
                        BunType = BunType.Loaf,
                        BunStatus = BunStatus.OnSell
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
        
    

