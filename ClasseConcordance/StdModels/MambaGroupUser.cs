using System;
using System.Collections.Generic;

#nullable disable

namespace ClasseConcordance.StdModels
{
    public partial class MambaGroupUser
    {
        public MambaGroupUser()
        {
            MambaGuAcces = new HashSet<MambaGuAcce>();
            MambaUtilisateurs = new HashSet<MambaUtilisateur>();
            ParamAffectationDevices = new HashSet<ParamAffectationDevice>();
        }

        public int CodeGroupUser { get; set; }
        public string IntituleGroupUser { get; set; }
        public bool? IsvisibleUser { get; set; }
        public bool Sync { get; set; }
        public bool? SyncPush { get; set; }
        public string CodeEcole { get; set; }

        public virtual ICollection<MambaGuAcce> MambaGuAcces { get; set; }
        public virtual ICollection<MambaUtilisateur> MambaUtilisateurs { get; set; }
        public virtual ICollection<ParamAffectationDevice> ParamAffectationDevices { get; set; }
    }
}
