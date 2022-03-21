using System;
using System.Collections.Generic;
using System.Text;

namespace ApiFunction
{
    public static class Vars
    {
        public static string ApiAddress { get; set; }
        public static string Language { get; set; } = "TR";
        public static string Environment { get; set; }
        public static int Take { get; set; }
        public static string Consumer { get; set; }
        public static bool IsMultiLanguageAvailable { get; set; }
    }
}
