using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simons_Stef_Ga21.Model
{
    public class Winkel
    {
        public string winkel_id { get; set; }
        public string winkel_name { get; set; }
        public string winkel_address { get; set; }
        public string type { get; set; }
        public string openingsuren { get; set; }
        public string sluitinguren { get; set; }
        public string openingdagen { get; set; }

        public ICollection<Werknemer> Werknemers { get; set; }
        public ICollection<Klant> Klanten { get; set; }
        public ICollection<Product> Producten { get; set; }

        public override string ToString()
        {
            return $"{winkel_name} ({winkel_address})";
        }

        public string WerknemerInfo()
        {
            StringBuilder sb = new StringBuilder();

            if (Werknemers != null && Werknemers.First().werknemer_id != null)
            {
                Werknemers.ToList().ForEach(a => sb.AppendLine($"- {a}"));
            }
        }

        public string KlantInfo()
        {
            StringBuilder sb = new StringBuilder();

            if (Klanten != null && Klanten.First().klant_id != null)
            {
                Klanten.ToList().ForEach(a => sb.AppendLine($"- {a}"));
            }
        }

        public string ProductInfo()
        {
            StringBuilder sb = new StringBuilder();

            if (Producten != null && Producten.First().product_id != null)
            {
                Producten.ToList().ForEach(a => sb.AppendLine($"- {a}"));
            }
        }
    }
}
