using System;
using System.Collections.Generic;

#nullable disable

namespace ClasseConcordance.StdModels
{
    public partial class ParamTaux
    {
        public ParamTaux()
        {
            FinanceCaisses = new HashSet<FinanceCaisse>();
            FinancePaiements = new HashSet<FinancePaiement>();
        }

        public string CodeTaux { get; set; }
        public string DeviseDepart { get; set; }
        public decimal? Valeur { get; set; }
        public DateTime? DateCreation { get; set; }
        public bool? EstActif { get; set; }
        public string CodeEcole { get; set; }
        public string DeviseArrivee { get; set; }
        public bool Sync { get; set; }
        public bool? SyncPush { get; set; }

        public virtual ICollection<FinanceCaisse> FinanceCaisses { get; set; }
        public virtual ICollection<FinancePaiement> FinancePaiements { get; set; }
    }
}
