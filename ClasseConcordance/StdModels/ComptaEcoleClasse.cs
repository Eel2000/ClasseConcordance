using System;
using System.Collections.Generic;

#nullable disable

namespace ClasseConcordance.StdModels
{
    public partial class ComptaEcoleClasse
    {
        public string CodeClasseEcole { get; set; }
        public string CodeClasseCompta { get; set; }
        public string EloCodeEcole { get; set; }
        public int CodeAnnee { get; set; }
        public bool? SyncPush { get; set; }
        public bool? Sync { get; set; }

        public virtual ParamAnneeScolaire CodeAnneeNavigation { get; set; }
        public virtual ComptaClass CodeClasseComptaNavigation { get; set; }
        public virtual GlobalEcole EloCodeEcoleNavigation { get; set; }
    }
}
