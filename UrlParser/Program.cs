using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrlParser
{
    class Program
    {
        static void Main(string[] args)
        {
            FirstNameParser parser = new FirstNameParser();
            #region MaleNames
            parser.GetParsed(@"https://abvgdee.ru/imena/muzhskie/na-bukvu-a",true,"FirstNamesMaleA.json");
            parser.GetParsed(@"https://abvgdee.ru/imena/muzhskie/na-bukvu-b",true,"FirstNamesMaleB.json");
            parser.GetParsed(@"https://abvgdee.ru/imena/muzhskie/na-bukvu-v", true,"FirstNamesMaleV.json");
            parser.GetParsed(@"https://abvgdee.ru/imena/muzhskie/na-bukvu-g", true,"FirstNamesMaleG.json");
            parser.GetParsed(@"https://abvgdee.ru/imena/muzhskie/na-bukvu-d", true,"FirstNamesMaleD.json");
            parser.GetParsed(@"https://abvgdee.ru/imena/muzhskie/na-bukvu-e", true,"FirstNamesMaleE.json");
            parser.GetParsed(@"https://abvgdee.ru/imena/muzhskie/na-bukvu-zh", true,"FirstNamesMaleZH.json");
            parser.GetParsed(@"https://abvgdee.ru/imena/muzhskie/na-bukvu-z", true,"FirstNamesMaleZ.json");
            parser.GetParsed(@"https://abvgdee.ru/imena/muzhskie/na-bukvu-k", true,"FirstNamesMaleK.json");
            parser.GetParsed(@"https://abvgdee.ru/imena/muzhskie/na-bukvu-l", true,"FirstNamesMaleL.json");
            parser.GetParsed(@"https://abvgdee.ru/imena/muzhskie/na-bukvu-m", true,"FirstNamesMaleM.json");
            parser.GetParsed(@"https://abvgdee.ru/imena/muzhskie/na-bukvu-n", true,"FirstNamesMaleN.json");
            parser.GetParsed(@"https://abvgdee.ru/imena/muzhskie/na-bukvu-o", true,"FirstNamesMaleO.json");
            parser.GetParsed(@"https://abvgdee.ru/imena/muzhskie/na-bukvu-p", true,"FirstNamesMaleP.json");
            parser.GetParsed(@"https://abvgdee.ru/imena/muzhskie/na-bukvu-r", true,"FirstNamesMaleR.json");
            parser.GetParsed(@"https://abvgdee.ru/imena/muzhskie/na-bukvu-s", true,"FirstNamesMaleS.json");
            parser.GetParsed(@"https://abvgdee.ru/imena/muzhskie/na-bukvu-t", true,"FirstNamesMaleT.json");
            parser.GetParsed(@"https://abvgdee.ru/imena/muzhskie/na-bukvu-f", true,"FirstNamesMaleF.json");
            parser.GetParsed(@"https://abvgdee.ru/imena/muzhskie/na-bukvu-h", true,"FirstNamesMaleH.json");
            parser.GetParsed(@"https://abvgdee.ru/imena/muzhskie/na-bukvu-ch", true,"FirstNamesMaleCH.json");
            parser.GetParsed(@"https://abvgdee.ru/imena/muzhskie/na-bukvu-sh", true,"FirstNamesMaleSH.json");
            parser.GetParsed(@"https://abvgdee.ru/imena/muzhskie/na-bukvu-ee", true,"FirstNamesMaleEE.json");
            parser.GetParsed(@"https://abvgdee.ru/imena/muzhskie/na-bukvu-yu", true,"FirstNamesMaleYU.json");
            parser.GetParsed(@"https://abvgdee.ru/imena/muzhskie/na-bukvu-ya", true,"FirstNamesMaleYA.json");
            #endregion
            #region FemaleNames
            parser.GetParsed(@"https://abvgdee.ru/imena/zhenskie/na-bukvu-a", false, "FirstNamesFemaleA.json");
            parser.GetParsed(@"https://abvgdee.ru/imena/zhenskie/na-bukvu-b", false, "FirstNamesFemaleB.json");
            parser.GetParsed(@"https://abvgdee.ru/imena/zhenskie/na-bukvu-v", false, "FirstNamesFemaleV.json");
            parser.GetParsed(@"https://abvgdee.ru/imena/zhenskie/na-bukvu-g", false, "FirstNamesFemaleG.json");
            parser.GetParsed(@"https://abvgdee.ru/imena/zhenskie/na-bukvu-d", false, "FirstNamesFemaleD.json");
            parser.GetParsed(@"https://abvgdee.ru/imena/zhenskie/na-bukvu-e", false, "FirstNamesFemaleE.json");
            parser.GetParsed(@"https://abvgdee.ru/imena/zhenskie/na-bukvu-zh", false, "FirstNamesFemaleZH.json");
            parser.GetParsed(@"https://abvgdee.ru/imena/zhenskie/na-bukvu-z", false, "FirstNamesFemaleZ.json");
            parser.GetParsed(@"https://abvgdee.ru/imena/zhenskie/na-bukvu-k", false, "FirstNamesFemaleK.json");
            parser.GetParsed(@"https://abvgdee.ru/imena/zhenskie/na-bukvu-l", false, "FirstNamesFemaleL.json");
            parser.GetParsed(@"https://abvgdee.ru/imena/zhenskie/na-bukvu-m", false, "FirstNamesFemaleM.json");
            parser.GetParsed(@"https://abvgdee.ru/imena/zhenskie/na-bukvu-n", false, "FirstNamesFemaleN.json");
            parser.GetParsed(@"https://abvgdee.ru/imena/zhenskie/na-bukvu-o", false, "FirstNamesFemaleO.json");
            parser.GetParsed(@"https://abvgdee.ru/imena/zhenskie/na-bukvu-p", false, "FirstNamesFemaleP.json");
            parser.GetParsed(@"https://abvgdee.ru/imena/zhenskie/na-bukvu-r", false, "FirstNamesFemaleR.json");
            parser.GetParsed(@"https://abvgdee.ru/imena/zhenskie/na-bukvu-s", false, "FirstNamesFemaleS.json");
            parser.GetParsed(@"https://abvgdee.ru/imena/zhenskie/na-bukvu-t", false, "FirstNamesFemaleT.json");
            parser.GetParsed(@"https://abvgdee.ru/imena/zhenskie/na-bukvu-u", false, "FirstNamesFemaleU.json");
            parser.GetParsed(@"https://abvgdee.ru/imena/zhenskie/na-bukvu-f", false, "FirstNamesFemaleF.json");
            parser.GetParsed(@"https://abvgdee.ru/imena/zhenskie/na-bukvu-h", false, "FirstNamesFemaleH.json");
            parser.GetParsed(@"https://abvgdee.ru/imena/zhenskie/na-bukvu-ch", false, "FirstNamesFemaleCH.json");
            parser.GetParsed(@"https://abvgdee.ru/imena/zhenskie/na-bukvu-sh", false, "FirstNamesFemaleSH.json");
            parser.GetParsed(@"https://abvgdee.ru/imena/zhenskie/na-bukvu-ee", false, "FirstNamesFemaleEE.json");
            parser.GetParsed(@"https://abvgdee.ru/imena/zhenskie/na-bukvu-yu", false, "FirstNamesFemaleYU.json");
            parser.GetParsed(@"https://abvgdee.ru/imena/zhenskie/na-bukvu-ya", false, "FirstNamesFemaleYA.json");
            #endregion
            Console.WriteLine("Parsed success press any key to exit");
            Console.ReadKey();
        }
    }
}
