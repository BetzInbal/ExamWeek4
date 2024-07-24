using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Mivdak.Models;
using static Mivdak.Configuration.AppConfiguration;

namespace Mivdak.Service
{
    internal static class KetubahService
    {
        public static void CriateXSMLifNotExists()
        {
            if (!File.Exists(KetubahPath))
            {
                XDocument document = new(); //XDocument.Parse
                XElement root = new XElement("Queries");
                document.Add(root);
                document.Save(KetubahPath);
            }
        }


        public static string? insertandGatRes(DAteKetubah dm)
        {

            XDocument document = XDocument.Load(KetubahPath);
            XElement? root =document.Descendants("Queries").FirstOrDefault();
            if (root == null) return null;
            string result = GetStringDate(dm);
            XElement XEres = new("Result",result);
            XElement XEdm = ConvertToXelment(dm, XEres);
            root.Add(XEdm);
            document.Save(KetubahPath);
            return result;

        }

        public static string GetStringDate(DAteKetubah dm)
        {
            string Day = GetStringDay(dm.day);
            string DayMonth = GetStringDayMonth(dm.mday, dm.month);
            string Year = GetStringYear(dm.year);
            return $"{Day} {DayMonth} {Year} ";
        }


        static XElement ConvertToXelment(DAteKetubah dm, XElement res)
        {
            return new("Query", new XElement("Day", dm.day), new XElement("DayMonth", dm.mday),
                new XElement("Month", dm.month), new XElement("Year", dm.year),new XElement ("Result", res)
                );

        }
        public static string GetStringDay(string day)
        {
            string res = day switch
            {
                "ראשון" => "באחד",
                "שני" => "בשני",
                "שלישי" => "בשלישי",
                "רביעי" => "ברביעי",
                "חמישי" => "בחמישי",
                "ששי" => "בששי",

            };
            return res + " בשבת";
        }


        public static string GetStringDayMonth(int dayMonth, string month)
        {
            if (dayMonth == 30)
                return Day30(month);
            string res = dayMonth switch
            {
                1 => "יום אחד",
                2 => "שני ימים", 
                3 => "שלשה ימים",
                4 => "ארבעה ימים",
                5 => "חמשה ימים",
                6 => "ששה ימים",
                7 => "שבעה ימים",
                8 => "שמנה ימים",
                9 => "תשעה ימים",
                10 => "עשרה ימים",
                11 => "אחד עשר יום",
                12 => "שנים עשר יום",
                13 => "שלשה עשר יום",
                14 => "ארבעה עשר יום",
                15 => "חמשה עשר יום",
                16 => "ששה עשר יום",
                17 => "שבעה עשר יום",
                18 => "שמנה עשר יום",
                19 => "תשעה עשר יום",
                20 => "עשרים יום",
                21 => "אחד ועשרים יום",
                22 => "שנים ועשרים יום",
                23 => "שלשה ועשרים יום",
                24 => "ארבע ועשרים יום",
                25 => "חמשה ועשרים יום",
                26 => "ששה ועשרים יום",
                27 => "שבעה ועשרים יום",
                28 => "שמנה ועשרים יום",
                29 => "תשעה ועשרים יום",
            };
            return res + $" לירח {month}";
        }
        public static string Day30(string month)
        {
            List<string> Monthes = ["תשרי", "מרחשוון", "כסלו", "שבט", "אדר", "אדר הראשון",
            "אדר השני", "ניסן", "אייר", "סיון", "תמוז", "אב",
            "אלול"];
            int monthIndex =  Monthes.FindIndex(x => x == month);
            string NextMonth = Monthes[monthIndex + 1];
            if (month == "אדר") NextMonth = "ניסן";
            return $"יום שלשים לחודש {month} שהוא ראש חודש {NextMonth}";

        }

        public static string GetStringYear(string year)
        {
            string res = year switch
            {
                @" תשפ""ד " => "שמנים וארבע",
                @"תשפ""ה" => "שמנים וחמש",
                @" תשפ""ו " => "שמנים ושש",
                @" תשפ""ז " => "שמנים ושבע",
                @" תשפ""ח " => "שמנים ושמנה",
                @" תשפ""ט " => "שמנים ותשע",
                @" תש""צ " => "תשעים",
                @" תשצ""א " => "תשעים ואחת ",
                @" תשצ""ב " => "תשעים ושתים ",
                @" תשצ""ג " => "תשעים ושלש ", 
            };
            return $"בשנת חמשת אלפים ושבע מאות ו{res} לבריאת העולם";
        }
    }
}
