using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projektarbete_azure.Models
{
    public class RichardsModel
    {
        public RichardsModel(List<CatResponse> catFacts, string catUrl)
        {
            CatFacts = catFacts;
            CatUrl = catUrl;
        }
        public List<CatResponse> CatFacts { get; set; }
        public string CatUrl { get; set; }
    }
}
