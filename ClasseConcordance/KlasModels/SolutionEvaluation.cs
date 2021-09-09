using System;
using System.Collections.Generic;

#nullable disable

namespace ClasseConcordance.KlasModels
{
    public partial class SolutionEvaluation
    {
        public SolutionEvaluation()
        {
            Notes = new HashSet<Note>();
        }

        public string Code { get; set; }
        public string CodeEleve { get; set; }
        public string CodeEvaluation { get; set; }
        public string Contenu { get; set; }
        public string TypeContenu { get; set; }
        public DateTime DateSoumission { get; set; }
        public int CodeAnneeScolaire { get; set; }
        public string CodeEcole { get; set; }
        

        public virtual Elefe CodeEleveNavigation { get; set; }
        public virtual Evaluation CodeEvaluationNavigation { get; set; }
        public virtual ICollection<Note> Notes { get; set; }
    }
}
