using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Veeb_MT.Models
{
    public class Kasutaja
    {
        public int Id { get; set; }
        public string Nimi { get; set; }
        public int Parool { get; set; }
        public string Eesnimi { get; set; }
        public string Perenimi { get; set; }

        public Kasutaja(int id, string nimi, int parool, string eesnimi, string perenimi)
        {
            Id = id;
            Nimi = nimi;
            Parool = parool;
            Eesnimi = eesnimi;
            Perenimi = perenimi;
        }
    }

}
