using System;
using System.Collections.Generic;

#nullable disable

namespace ClasseConcordance.StdModels
{
    public partial class ParamTemplateOperationCaisse
    {
        public string CodeTemplateOperationCaisse { get; set; }
        public string CodeEcole { get; set; }
        public string IntituleTemplateOperation { get; set; }
        public bool? Sync { get; set; }
        public bool? SyncPush { get; set; }

        public virtual GlobalEcole CodeEcoleNavigation { get; set; }
    }
}
