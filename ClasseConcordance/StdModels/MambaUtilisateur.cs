using System;
using System.Collections.Generic;

#nullable disable

namespace ClasseConcordance.StdModels
{
    public partial class MambaUtilisateur
    {
        public MambaUtilisateur()
        {
            FinanceCaisses = new HashSet<FinanceCaisse>();
            FinanceCompteEleves = new HashSet<FinanceCompteEleve>();
            FinancePaiements = new HashSet<FinancePaiement>();
            MambaLogs = new HashSet<MambaLog>();
        }

        public string CodeUtilisateur { get; set; }
        public string Username { get; set; }
        public string Pwd { get; set; }
        public string MessageRappelPwd { get; set; }
        public DateTime? DateCreation { get; set; }
        public int? CodeGroupUser { get; set; }
        public string CodeAgentFonction { get; set; }
        public bool? EstActif { get; set; }
        public DateTime? DateExpiration { get; set; }
        public bool? EstDateExpiration { get; set; }
        public bool? ActifPortail { get; set; }
        public bool Sync { get; set; }
        public bool? SyncPush { get; set; }
        public string CodeEcole { get; set; }

        public virtual ParamAgentFonction CodeAgentFonctionNavigation { get; set; }
        public virtual MambaGroupUser CodeGroupUserNavigation { get; set; }
        public virtual ICollection<FinanceCaisse> FinanceCaisses { get; set; }
        public virtual ICollection<FinanceCompteEleve> FinanceCompteEleves { get; set; }
        public virtual ICollection<FinancePaiement> FinancePaiements { get; set; }
        public virtual ICollection<MambaLog> MambaLogs { get; set; }
    }
}
