using Contentful.Core.Models;
using System;

namespace case_study_bp.Models
{
    public class History
    {
        public string thuisploeg { get; set; }

        public string uitploeg { get; set; }

        public int spelers { get; set; }

        public int staff { get; set; }

        public int publiek { get; set; }

        public dynamic thuislogo { get; set; }

        public dynamic uitlogo { get; set; }

        public Document wedstrijd { get; set; }

        public string wedstrijdnummers { get; set; }
    }
}
