using ShoeShopConsole.Classes.Shoes;
using ShoeShopConsole.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoeShopConsole.Classes
{
    internal class DBService:IDataService
    {
        public List<IShoe> GetShoes()
        {
            return new List<IShoe>()
            {
                new SportShoes(1,"Gel-Rocket 11","Asics",3099m,CushioningLevel.MediumPlus,false),
                new Sneackers(1,"180 Tones","Puma",3420m,ClosureType.LaceUp,HeightType.Low),
                new Sandals(1,"Classic Sandal","Crocs",1690m,StrapType.Slides,true),
                new HikingBoots(1,"Terrex Eastrail","Adidas",4490m,0.4f,true),
                new HighHeels(1,"Kabail","Guess",8399m,HeelsType.AnkleStrap,8.5f),
                new SportShoes(2,"Ozweego","Adidas",3799m,CushioningLevel.Medium,false),
                new Sneackers(2,"Air Force 1","Nike",6999m,ClosureType.LaceUp,HeightType.Mid),
                new Sandals(2,"Mono Hilfiger Beach","Tommy Hilfiger",1890m,StrapType.FlipFlops,true),
                new HikingBoots(2,"Cortina Valley","Timberland",8999m,0.6f,true),
                new HighHeels(2,"Rhinnae","Guess",6790m,HeelsType.Platforms,10f),
            };
        }
    }
}
