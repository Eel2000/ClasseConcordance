using System;
using System.Collections.Generic;

#nullable disable

namespace ClasseConcordance.StdModels
{
    public partial class EteyeloMouvementEleve
    {
        public string CodeMouvement { get; set; }
        public string EloCodeEleve { get; set; }
        public int? CodeTypeMouvement { get; set; }
        public string Motif { get; set; }
        public DateTime? DateMouvement { get; set; }
        public string CodeEcole { get; set; }
        public int? CodeAnnee { get; set; }
        public bool Sync { get; set; }
        public bool? SyncPush { get; set; }

        public virtual ParamAnneeScolaire CodeAnneeNavigation { get; set; }
        public virtual GlobalEcole CodeEcoleNavigation { get; set; }
        public virtual EteyeloTypeMouvement CodeTypeMouvementNavigation { get; set; }
        public virtual InscriptionEleve EloCodeEleveNavigation { get; set; }
    }
}
