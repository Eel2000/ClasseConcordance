using System;
using System.Collections.Generic;

#nullable disable

namespace ClasseConcordance.KlasModels
{
    public partial class PeriodeScolaire
    {
        public PeriodeScolaire()
        {
            Evaluations = new HashSet<Evaluation>();
            Notes = new HashSet<Note>();
        }

        public string Code { get; set; }
        public string Intitule { get; set; }
        public string IntituleCourt { get; set; }
        public DateTime? Debut { get; set; }
        public DateTime? Fin { get; set; }
        public bool EstActif { get; set; }
        public int CodeAnneeScolaire { get; set; }
        public string CodeEcole { get; set; }
        

        public virtual ICollection<Evaluation> Evaluations { get; set; }
        public virtual ICollection<Note> Notes { get; set; }
    }
}
