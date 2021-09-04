using System;
using System.Collections.Generic;

#nullable disable

namespace ClasseConcordance.StdModels
{
    public partial class ParamAgentFonction
    {
        public ParamAgentFonction()
        {
            MambaUtilisateurs = new HashSet<MambaUtilisateur>();
        }

        public string CodeAgentFonction { get; set; }
        public string CodeFonction { get; set; }
        public string EloCodeAgent { get; set; }
        public bool? EstPrefet { get; set; }
        public bool? EstActif { get; set; }
        public string EloCodeEcole { get; set; }
        public bool Sync { get; set; }
        public bool? SyncPush { get; set; }

        public virtual ParamFonction CodeFonctionNavigation { get; set; }
        public virtual GlobalAgent EloCodeAgentNavigation { get; set; }
        public virtual GlobalEcole EloCodeEcoleNavigation { get; set; }
        public virtual ICollection<MambaUtilisateur> MambaUtilisateurs { get; set; }
    }
}
