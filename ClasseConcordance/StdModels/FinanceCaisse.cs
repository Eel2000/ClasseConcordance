using System;
using System.Collections.Generic;

#nullable disable

namespace ClasseConcordance.StdModels
{
    public partial class FinanceCaisse
    {
        public string CodeCaisse { get; set; }
        public string CodeUtilisateur { get; set; }
        public string CodeCompte { get; set; }
        public decimal? SoldeOuverture { get; set; }
        public string Operation { get; set; }
        public string Motif { get; set; }
        public decimal? Montant { get; set; }
        public decimal? Solde { get; set; }
        public string Benificiaire { get; set; }
        public DateTime? DateCreation { get; set; }
        public decimal? MontantReel { get; set; }
        public byte[] Signature { get; set; }
        public string CodeEcole { get; set; }
        public int? CodeAnneeScolaire { get; set; }
        public string CodeTaux { get; set; }
        public string CodeDevise { get; set; }
        public bool Sync { get; set; }
        public bool? SyncPush { get; set; }
        public string CodePaiement { get; set; }

        public virtual ParamAnneeScolaire CodeAnneeScolaireNavigation { get; set; }
        public virtual ParamCompte CodeCompteNavigation { get; set; }
        public virtual ParamDevise CodeDeviseNavigation { get; set; }
        public virtual GlobalEcole CodeEcoleNavigation { get; set; }
        public virtual ParamTaux CodeTauxNavigation { get; set; }
        public virtual MambaUtilisateur CodeUtilisateurNavigation { get; set; }
    }
}
