using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace VatrogasnoDrustvo.Bridge
{
    /// <summary>
    /// Klasa za slanje JSON objekata prema serverskoj skripti (PHP)
    /// </summary>
    class Sender
    {
        WebClient webClient;

        public Sender()
        {
            webClient = new WebClient();
            webClient.Headers[HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded";
        }

        /// <summary>
        /// Metoda za slanje podataka i zaprimanje odgovora (POST metoda prema serveru)
        /// </summary>
        /// <param name="toSend">Podaci koji se šalju (atributi objekta)</param>
        /// <param name="URI">URL na koji se šalje</param>
        /// <returns>Odgovor servera na POST</returns>
        public string Send(object toSend, string URI)
        {
            JsonSerializerSettings settings = new JsonSerializerSettings() //opcije za konverter
            {
                Converters = new List<JsonConverter> {
                    new Newtonsoft.Json.Converters.StringEnumConverter() //omogućeno konvertiranje pobrojenja u string
                }
            };

            return webClient.UploadString(URI, "obj=" + JsonConvert.SerializeObject(toSend, Formatting.None, settings));
        }

        /// <summary>
        /// Metoda za primanje podataka (GET metoda prema serveru)
        /// </summary>
        /// <param name="URI">URL na kojeg se šalje</param>
        /// <returns>Lista objekata konvertirana iz JSON formata</returns>
        public string Receive(string URI)
        {
            return webClient.DownloadString(URI);
        }
    }
}
