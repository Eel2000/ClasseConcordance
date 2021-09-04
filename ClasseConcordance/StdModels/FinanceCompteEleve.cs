using System;
using System.Collections.Generic;

#nullable disable

namespace ClasseConcordance.StdModels
{
    public partial class FinanceCompteEleve
    {
        public string CodeCompteEleve { get; set; }
        public string CodeUtilisateur { get; set; }
        public string CodeFrais { get; set; }
        public string Motif { get; set; }
        public decimal? Montant { get; set; }
        public DateTime? DateCreation { get; set; }
        public decimal? MontantReel { get; set; }
        public string CodeEcole { get; set; }
        public int? CodeAnneeScolaire { get; set; }
        public string CodeTaux { get; set; }
        public string CodeDevise { get; set; }
        public bool? Sync { get; set; }
        public bool? SyncPush { get; set; }
        public string CodeEleve { get; set; }
        public string Operation { get; set; }

        public virtual ParamAnneeScolaire CodeAnneeScolaireNavigation { get; set; }
        public virtual ParamDevise CodeDeviseNavigation { get; set; }
        public virtual InscriptionEleve CodeEleveNavigation { get; set; }
        public virtual FinanceFrai CodeFraisNavigation { get; set; }
        public virtual MambaUtilisateur CodeUtilisateurNavigation { get; set; }
    }
}
