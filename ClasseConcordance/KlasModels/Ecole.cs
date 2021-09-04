using System;
using System.Collections.Generic;

#nullable disable

namespace ClasseConcordance.KlasModels
{
    public partial class Ecole
    {
        public string Code { get; set; }
        public string Nom { get; set; }
        public string NomCourt { get; set; }
        public string Email { get; set; }
        public string Telephone { get; set; }
        public string Adresse { get; set; }
        public string Logo { get; set; }
        public string ProfilEcole { get; set; }
        public string Domaine { get; set; }
        public int? TypeEcole { get; set; }
        public Guid Rowguid { get; set; }
    }
}
