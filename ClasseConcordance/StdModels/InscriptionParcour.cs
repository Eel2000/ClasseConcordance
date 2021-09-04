using System;
using System.Collections.Generic;

#nullable disable

namespace ClasseConcordance.StdModels
{
    public partial class InscriptionParcour
    {
        public string CodeParcours { get; set; }
        public string CodeAffectationLocalClass { get; set; }
        public string EloCodeEleve { get; set; }
        public int CodeAnnee { get; set; }
        public DateTime DateAffetaction { get; set; }
        public bool? EstActif { get; set; }
        public string EloCodeEcole { get; set; }
        public bool Sync { get; set; }
        public bool? SyncPush { get; set; }
        public DateTime? SubmissionDate { get; set; }
        //public bool? EstNouveau { get; set; }

        public virtual GlobalAffectationLocalClasse CodeAffectationLocalClassNavigation { get; set; }
        public virtual GlobalEcole EloCodeEcoleNavigation { get; set; }
        public virtual InscriptionEleve EloCodeEleveNavigation { get; set; }
    }
}
