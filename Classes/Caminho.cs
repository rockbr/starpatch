using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace starpatch.Classes
{
    public class Caminho
    {
        [JsonProperty("caminhoMod")]
        public string CaminhoMod { get; set; }

        [JsonProperty("caminhoSaida")]
        public string CaminhoSaida { get; set; }

        [JsonProperty("caminhoPatch")]
        public List<string> CaminhoPatch { get; set; }
    }
}
