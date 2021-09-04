using System;
using System.Collections.Generic;

#nullable disable

namespace ClasseConcordance.StdModels
{
    public partial class ParamFonction
    {
        public ParamFonction()
        {
            ParamAgentFonctions = new HashSet<ParamAgentFonction>();
        }

        public string CodeFonction { get; set; }
        public string IntituleFonction { get; set; }
        public string CodeService { get; set; }
        public bool? IsvisibleUser { get; set; }
        public string CodeEcole { get; set; }
        public bool Sync { get; set; }
        public bool? SyncPush { get; set; }

        public virtual GlobalEcole CodeEcoleNavigation { get; set; }
        public virtual ParamService CodeServiceNavigation { get; set; }
        public virtual ICollection<ParamAgentFonction> ParamAgentFonctions { get; set; }
    }
}
