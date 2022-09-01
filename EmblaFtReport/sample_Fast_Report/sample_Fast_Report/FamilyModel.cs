using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample_Fast_Report
{
    internal class FamilyModel
    {
        public class Child
        {
            public int id { get; set; }
            public string name { get; set; }
            public int generation { get; set; }
            public object children { get; set; }
            public string imageURL { get; set; }
        }

        public class ExWife
        {
            public string name { get; set; }
            public string wifeImg { get; set; }
            public string description { get; set; }
            public List<Child> children { get; set; }
        }

        public class Family
        {
            public int id { get; set; }
            public string name { get; set; }
            public int generation { get; set; }
            public int age { get; set; }
            public string city { get; set; }
            public string sex { get; set; }
            public List<MarriedWife> marriedWife { get; set; }
            public List<ExWife> exWife { get; set; }
            public string imageURL { get; set; }
            public string description { get; set; }
        }

        public class MarriedWife
        {
            public string name { get; set; }
            public string wifeImg { get; set; }
            public string description { get; set; }
            public List<Child> children { get; set; }
        }

        public class Root
        {
            public List<Family> Family { get; set; }
        }


    }
}
