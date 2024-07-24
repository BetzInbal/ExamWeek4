using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mivdak.Configuration
{
    internal static class AppConfiguration
    {
        public static string KetubahPath => Path.Combine(
            Directory.GetCurrentDirectory(),
            "KetubahDate.Xml"
            );
    }
}
