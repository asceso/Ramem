using System;
using UrlParser.Parsers;

namespace UrlParser
{
    class Program
    {
        static void Main(string[] args)
        {
            FirstNameParser firstNames = new FirstNameParser();
            #region MaleNames
            firstNames.GetParsed(@"https://abvgdee.ru/imena/muzhskie/na-bukvu-a", true, "FirstNamesMaleA.json");
            firstNames.GetParsed(@"https://abvgdee.ru/imena/muzhskie/na-bukvu-b", true, "FirstNamesMaleB.json");
            firstNames.GetParsed(@"https://abvgdee.ru/imena/muzhskie/na-bukvu-v", true, "FirstNamesMaleV.json");
            firstNames.GetParsed(@"https://abvgdee.ru/imena/muzhskie/na-bukvu-g", true, "FirstNamesMaleG.json");
            firstNames.GetParsed(@"https://abvgdee.ru/imena/muzhskie/na-bukvu-d", true, "FirstNamesMaleD.json");
            firstNames.GetParsed(@"https://abvgdee.ru/imena/muzhskie/na-bukvu-e", true, "FirstNamesMaleE.json");
            firstNames.GetParsed(@"https://abvgdee.ru/imena/muzhskie/na-bukvu-zh", true, "FirstNamesMaleZH.json");
            firstNames.GetParsed(@"https://abvgdee.ru/imena/muzhskie/na-bukvu-z", true, "FirstNamesMaleZ.json");
            firstNames.GetParsed(@"https://abvgdee.ru/imena/muzhskie/na-bukvu-k", true, "FirstNamesMaleK.json");
            firstNames.GetParsed(@"https://abvgdee.ru/imena/muzhskie/na-bukvu-l", true, "FirstNamesMaleL.json");
            firstNames.GetParsed(@"https://abvgdee.ru/imena/muzhskie/na-bukvu-m", true, "FirstNamesMaleM.json");
            firstNames.GetParsed(@"https://abvgdee.ru/imena/muzhskie/na-bukvu-n", true, "FirstNamesMaleN.json");
            firstNames.GetParsed(@"https://abvgdee.ru/imena/muzhskie/na-bukvu-o", true, "FirstNamesMaleO.json");
            firstNames.GetParsed(@"https://abvgdee.ru/imena/muzhskie/na-bukvu-p", true, "FirstNamesMaleP.json");
            firstNames.GetParsed(@"https://abvgdee.ru/imena/muzhskie/na-bukvu-r", true, "FirstNamesMaleR.json");
            firstNames.GetParsed(@"https://abvgdee.ru/imena/muzhskie/na-bukvu-s", true, "FirstNamesMaleS.json");
            firstNames.GetParsed(@"https://abvgdee.ru/imena/muzhskie/na-bukvu-t", true, "FirstNamesMaleT.json");
            firstNames.GetParsed(@"https://abvgdee.ru/imena/muzhskie/na-bukvu-f", true, "FirstNamesMaleF.json");
            firstNames.GetParsed(@"https://abvgdee.ru/imena/muzhskie/na-bukvu-h", true, "FirstNamesMaleH.json");
            firstNames.GetParsed(@"https://abvgdee.ru/imena/muzhskie/na-bukvu-ch", true, "FirstNamesMaleCH.json");
            firstNames.GetParsed(@"https://abvgdee.ru/imena/muzhskie/na-bukvu-sh", true, "FirstNamesMaleSH.json");
            firstNames.GetParsed(@"https://abvgdee.ru/imena/muzhskie/na-bukvu-ee", true, "FirstNamesMaleEE.json");
            firstNames.GetParsed(@"https://abvgdee.ru/imena/muzhskie/na-bukvu-yu", true, "FirstNamesMaleYU.json");
            firstNames.GetParsed(@"https://abvgdee.ru/imena/muzhskie/na-bukvu-ya", true, "FirstNamesMaleYA.json");
            #endregion
            #region FemaleNames
            firstNames.GetParsed(@"https://abvgdee.ru/imena/zhenskie/na-bukvu-a", false, "FirstNamesFemaleA.json");
            firstNames.GetParsed(@"https://abvgdee.ru/imena/zhenskie/na-bukvu-b", false, "FirstNamesFemaleB.json");
            firstNames.GetParsed(@"https://abvgdee.ru/imena/zhenskie/na-bukvu-v", false, "FirstNamesFemaleV.json");
            firstNames.GetParsed(@"https://abvgdee.ru/imena/zhenskie/na-bukvu-g", false, "FirstNamesFemaleG.json");
            firstNames.GetParsed(@"https://abvgdee.ru/imena/zhenskie/na-bukvu-d", false, "FirstNamesFemaleD.json");
            firstNames.GetParsed(@"https://abvgdee.ru/imena/zhenskie/na-bukvu-e", false, "FirstNamesFemaleE.json");
            firstNames.GetParsed(@"https://abvgdee.ru/imena/zhenskie/na-bukvu-zh", false, "FirstNamesFemaleZH.json");
            firstNames.GetParsed(@"https://abvgdee.ru/imena/zhenskie/na-bukvu-z", false, "FirstNamesFemaleZ.json");
            firstNames.GetParsed(@"https://abvgdee.ru/imena/zhenskie/na-bukvu-k", false, "FirstNamesFemaleK.json");
            firstNames.GetParsed(@"https://abvgdee.ru/imena/zhenskie/na-bukvu-l", false, "FirstNamesFemaleL.json");
            firstNames.GetParsed(@"https://abvgdee.ru/imena/zhenskie/na-bukvu-m", false, "FirstNamesFemaleM.json");
            firstNames.GetParsed(@"https://abvgdee.ru/imena/zhenskie/na-bukvu-n", false, "FirstNamesFemaleN.json");
            firstNames.GetParsed(@"https://abvgdee.ru/imena/zhenskie/na-bukvu-o", false, "FirstNamesFemaleO.json");
            firstNames.GetParsed(@"https://abvgdee.ru/imena/zhenskie/na-bukvu-p", false, "FirstNamesFemaleP.json");
            firstNames.GetParsed(@"https://abvgdee.ru/imena/zhenskie/na-bukvu-r", false, "FirstNamesFemaleR.json");
            firstNames.GetParsed(@"https://abvgdee.ru/imena/zhenskie/na-bukvu-s", false, "FirstNamesFemaleS.json");
            firstNames.GetParsed(@"https://abvgdee.ru/imena/zhenskie/na-bukvu-t", false, "FirstNamesFemaleT.json");
            firstNames.GetParsed(@"https://abvgdee.ru/imena/zhenskie/na-bukvu-u", false, "FirstNamesFemaleU.json");
            firstNames.GetParsed(@"https://abvgdee.ru/imena/zhenskie/na-bukvu-f", false, "FirstNamesFemaleF.json");
            firstNames.GetParsed(@"https://abvgdee.ru/imena/zhenskie/na-bukvu-h", false, "FirstNamesFemaleH.json");
            firstNames.GetParsed(@"https://abvgdee.ru/imena/zhenskie/na-bukvu-ch", false, "FirstNamesFemaleCH.json");
            firstNames.GetParsed(@"https://abvgdee.ru/imena/zhenskie/na-bukvu-sh", false, "FirstNamesFemaleSH.json");
            firstNames.GetParsed(@"https://abvgdee.ru/imena/zhenskie/na-bukvu-ee", false, "FirstNamesFemaleEE.json");
            firstNames.GetParsed(@"https://abvgdee.ru/imena/zhenskie/na-bukvu-yu", false, "FirstNamesFemaleYU.json");
            firstNames.GetParsed(@"https://abvgdee.ru/imena/zhenskie/na-bukvu-ya", false, "FirstNamesFemaleYA.json");
            #endregion

            SecondNamesParser secondNames = new SecondNamesParser();
            secondNames.GetParsed(@"https://wiki-linki.ru/Page/108504", "SecondNames.json");

            //Sucess
            Console.WriteLine("Parsed success press any key to exit");
            Console.ReadKey();
        }
    }
}
