using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simons_Stef_Ga21.Model
{
    public class Product
    {
        public string product_id { get; set; }
        public string product_name { get; set; }
        public DateTime vervaldatum { get; set; }
        public string type { get; set; }

        public ICollection<Winkel> Winkels { get; set; }
    }
}
