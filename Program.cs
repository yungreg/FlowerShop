using System;
using System.Collections.Generic;


namespace flowershop
{
    class Program
    {
        static void Main(string[] args)
        {
            // We need a list that contains Roses and Pink Roses
            List<IMothersDayFlower> MakeMothersDayArrangement()
            {
                List<IMothersDayFlower> arrangemnent1 = new List<IMothersDayFlower>()
                {
                    new PinkRose() {StemLength=8},
                    new PinkRose() {StemLength=13},
                    new PinkRose() {StemLength=3},
                    new PinkRose() {StemLength=8}
                };
                return arrangemnent1;
            };
            // we nbeed a lkist here that contains NIghtShades and Black Roses
            List<IBirthdayFlower> MakeBirthdayArrangement()
            {
                List<IBirthdayFlower> arrangemnent2 = new List<IBirthdayFlower>()
                {
                  new NightShade() {Color="red"},
                  new NightShade() {Color="blue"},
                  new NightShade() {Color="pyyyyurrrple"},
                  new NightShade() {Color="pyyyyurrrple"},
                };
                return arrangemnent2;
            }
        }
    }
};

