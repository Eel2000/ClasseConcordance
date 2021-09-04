using System;
using System.Collections.Generic;

#nullable disable

namespace ClasseConcordance.StdModels
{
    public partial class BukuDelibeCoursSansEchec
    {
        public string CodeParamDelibe { get; set; }
        public string CodeCours { get; set; }
        public string CodeEcole { get; set; }
        public string CodeDelibeCoursSansEchec { get; set; }
        public bool Sync { get; set; }
        public bool? SyncPush { get; set; }

        public virtual GlobalEcole CodeEcoleNavigation { get; set; }
        public virtual ParamDelibe CodeParamDelibeNavigation { get; set; }
    }
}
