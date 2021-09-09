using System;
using System.Collections.Generic;

#nullable disable

namespace ClasseConcordance.KlasModels
{
    public partial class Evaluation
    {
        public Evaluation()
        {
            SolutionEvaluations = new HashSet<SolutionEvaluation>();
        }

        public string Code { get; set; }
        public string Intitule { get; set; }
        public string Contenu { get; set; }
        public string TypeContenu { get; set; }
        public string TypeEvaluation { get; set; }
        public DateTime? DatePublication { get; set; }
        public DateTime? DateLimite { get; set; }
        public int CodeAnneeScolaire { get; set; }
        public string CodeEcole { get; set; }
        public string CodeCours { get; set; }
        public string CodePeriode { get; set; }
        public int? Maxima { get; set; }
        public bool? EstPubliee { get; set; }
        

        public virtual Cour CodeCoursNavigation { get; set; }
        public virtual PeriodeScolaire CodePeriodeNavigation { get; set; }
        public virtual ICollection<SolutionEvaluation> SolutionEvaluations { get; set; }
    }
}
