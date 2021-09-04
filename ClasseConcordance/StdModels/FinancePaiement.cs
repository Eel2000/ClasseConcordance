using System;
using System.Collections.Generic;

#nullable disable

namespace ClasseConcordance.StdModels
{
    public partial class FinancePaiement
    {
        public string CodePaiement { get; set; }
        public string EloCodeEleve { get; set; }
        public string CodeFrais { get; set; }
        public double MontantPaye { get; set; }
        public DateTime DatePaiement { get; set; }
        public string Porteur { get; set; }
        public string RelationAvecPorteur { get; set; }
        public string Observation { get; set; }
        public bool? EstValide { get; set; }
        public bool? EstImprime { get; set; }
        public string CodeTaux { get; set; }
        public string CodeRegimePaiement { get; set; }
        public string NumeroRecu { get; set; }
        public string CodeEcole { get; set; }
        public int? CodeAnneeScolaire { get; set; }
        public double? MontantReelPaye { get; set; }
        public string NumeroBordereau { get; set; }
        public string CodeDevise { get; set; }
        public string CodeUtilisateur { get; set; }
        public string CodeModePaiement { get; set; }
        public string CodeCompteBancaire { get; set; }
        public bool Sync { get; set; }
        public bool? SyncPush { get; set; }
        public string CodeStatut { get; set; }

        public virtual ParamAnneeScolaire CodeAnneeScolaireNavigation { get; set; }
        public virtual GlobalEcole CodeEcoleNavigation { get; set; }
        public virtual ParamModePaiement CodeModePaiementNavigation { get; set; }
        public virtual ParamRegimePaiement CodeRegimePaiementNavigation { get; set; }
        public virtual ParamTaux CodeTauxNavigation { get; set; }
        public virtual MambaUtilisateur CodeUtilisateurNavigation { get; set; }
        public virtual InscriptionEleve EloCodeEleveNavigation { get; set; }
    }
}
