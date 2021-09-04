using System;
using System.Collections.Generic;

#nullable disable

namespace ClasseConcordance.StdModels
{
    public partial class EteyeloBulletin
    {
        public string CodeBulletin { get; set; }
        public int? MaximaGen { get; set; }
        public decimal? TotalNote { get; set; }
        public decimal? Pourcentage { get; set; }
        public int? Place { get; set; }
        public int? NbrEleves { get; set; }
        public string EloCodePeriode { get; set; }
        public string Application { get; set; }
        public string Conduite { get; set; }
        public string Sanction { get; set; }
        public string EloCodeEleve { get; set; }
        public int? CodeAnnee { get; set; }
        public string CodeLocalClasse { get; set; }
        public string NotesObtenues { get; set; }
        public bool Sync { get; set; }
        public bool? SyncPush { get; set; }
        public string CodeEcole { get; set; }

        public virtual ParamAnneeScolaire CodeAnneeNavigation { get; set; }
        public virtual InscriptionEleve EloCodeEleveNavigation { get; set; }
        public virtual GlobalPeriodeScolaire EloCodePeriodeNavigation { get; set; }
    }
}
