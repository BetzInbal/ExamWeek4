using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mivdak.Models
{
    internal static class ListDates
    {
        public static List<string> DaysOfWeek = ["ראשון", "שני", "שלישי", "רביעי", "חמישי", "ששי"];
        public static List<int> DaysOfMonth = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18,
                19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30];

        public static List<string> Monthes = ["תשרי", "מרחשוון", "כסלו", "שבט", "אדר", "אדר הראשון",
            "אדר השני", "ניסן", "אייר", "סיון", "תמוז", "אב",
            "אלול"];

        public static List<string> Years = [@" תשפ""ד ", @"תשפ""ה",@" תשפ""ו ",@" תשפ""ז ",@" תשפ""ח ",
            @" תשפ""ט ", @" תש""צ ",  @" תשצ""א ", @" תשצ""ב ", @" תשצ""ג " ];
        /*               
         * 
         * */
    }
}
