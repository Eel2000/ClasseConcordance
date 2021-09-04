using System;
using System.Collections.Generic;

#nullable disable

namespace ClasseConcordance.KlasModels
{
    public partial class Horaire
    {
        public string Code { get; set; }
        public DateTime DateEdition { get; set; }
        public string CodeClasse { get; set; }
        public string Cours { get; set; }
        public string CodeEcole { get; set; }
        public string Jour { get; set; }
        public DateTime DateJour { get; set; }
        public bool? EstActif { get; set; }
        public int TypeHoraire { get; set; }
    }
}
