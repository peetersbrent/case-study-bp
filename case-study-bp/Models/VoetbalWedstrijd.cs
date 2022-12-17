using System;

namespace case_study_bp.Models
{
    public class VoetbalWedstrijd
    {
        public string wedstrijdnummers { get; set; }

        public string starttijdwedstrijd { get; set; }
        public string matchbeschrijving { get; set; }

        public string Thuisploeg { get; set; }

        public string Uitploeg { get; set; }

        public string Assistenten { get; set; }

        public dynamic speelveldFoto { get; set; }

        public dynamic Truitjethuisploeg { get; set; }

        public dynamic Truitjeuitploeg { get; set; }

        public dynamic route { get; set; }

        public int Standthuisploeg { get; set; }

        public int Standuitploeg { get; set; }

        public int Blokken1 { get; set; }
        public int Blokken2 { get; set; }

    }
}