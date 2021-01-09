using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiGateway
{
    public class AppOptions
    {
        public const string SectionName = "App";

        public string Name { get; set; }
        public string GreetingHost { get; set; }
        public string GreetingPort { get; set; }
    }
}
