using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WeightenValues.Web.Models
{
    // #todo Implement more domain specific POCO
    public class WeightedValuesViewModel
    {
        public Dictionary<int, string> Educations { get; set; }
        public Dictionary<int, string> Keywords { get; set; }
        public Dictionary<int, int> EducationKeyword { get; set; }
    }
}