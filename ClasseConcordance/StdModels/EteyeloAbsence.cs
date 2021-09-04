using System;
using System.Collections.Generic;

#nullable disable

namespace ClasseConcordance.StdModels
{
    public partial class EteyeloAbsence
    {
        public int CodeAbsence { get; set; }
        public string JustificationAbsence { get; set; }
        public string MotifAbsence { get; set; }
        public DateTime Date { get; set; }
        public string EloCodeEleve { get; set; }
        public bool Sync { get; set; }
        public bool? SyncPush { get; set; }
        public string CodeEcole { get; set; }

        public virtual InscriptionEleve EloCodeEleveNavigation { get; set; }
    }
}
