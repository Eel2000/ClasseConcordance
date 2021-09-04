using System;
using System.Collections.Generic;

#nullable disable

namespace ClasseConcordance.StdModels
{
    public partial class ParamService
    {
        public ParamService()
        {
            ParamFonctions = new HashSet<ParamFonction>();
        }

        public string CodeService { get; set; }
        public string IntituleService { get; set; }
        public string CodeEcole { get; set; }
        public bool Sync { get; set; }
        public bool? SyncPush { get; set; }

        public virtual GlobalEcole CodeEcoleNavigation { get; set; }
        public virtual ICollection<ParamFonction> ParamFonctions { get; set; }
    }
}
