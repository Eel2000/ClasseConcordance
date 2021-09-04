using System;
using System.Collections.Generic;

#nullable disable

namespace ClasseConcordance.KlasModels
{
    public partial class Note
    {
        public string Code { get; set; }
        public decimal? NoteObtenue { get; set; }
        public string CodeCours { get; set; }
        public string CodeEleve { get; set; }
        public string CodeSolutionEvaluation { get; set; }
        public int? CodeAnneeScolaire { get; set; }
        public string CodeEcole { get; set; }
        public bool? EstActif { get; set; }
        public string CodePeriode { get; set; }
        public string Commentaire { get; set; }
        public Guid Rowguid { get; set; }

        public virtual Cour CodeCoursNavigation { get; set; }
        public virtual Elefe CodeEleveNavigation { get; set; }
        public virtual PeriodeScolaire CodePeriodeNavigation { get; set; }
        public virtual SolutionEvaluation CodeSolutionEvaluationNavigation { get; set; }
    }
}
