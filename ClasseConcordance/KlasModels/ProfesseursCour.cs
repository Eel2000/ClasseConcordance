using System;
using System.Collections.Generic;

#nullable disable

namespace ClasseConcordance.KlasModels
{
    public partial class ProfesseursCour
    {
        public string Code { get; set; }
        public string CodeProfesseur { get; set; }
        public string CodeCours { get; set; }
        public bool? EstActif { get; set; }
        public string CodeAnneeScolaire { get; set; }
        public string CodeEcole { get; set; }
        

        public virtual Professeur CodeProfesseurNavigation { get; set; }
    }
}
