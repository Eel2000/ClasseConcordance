using System;
using System.Collections.Generic;

#nullable disable

namespace ClasseConcordance.KlasModels
{
    public partial class Cour
    {
        public Cour()
        {
            CoursClasses = new HashSet<CoursClasse>();
            Evaluations = new HashSet<Evaluation>();
            Notes = new HashSet<Note>();
        }

        public string Code { get; set; }
        public string Intitule { get; set; }
        public string IntituleCourt { get; set; }
        public int CodeAnneeScolaire { get; set; }
        public string CodeEcole { get; set; }
        

        public virtual ICollection<CoursClasse> CoursClasses { get; set; }
        public virtual ICollection<Evaluation> Evaluations { get; set; }
        public virtual ICollection<Note> Notes { get; set; }
    }
}
