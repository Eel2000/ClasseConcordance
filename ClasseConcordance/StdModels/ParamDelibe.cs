using System;
using System.Collections.Generic;

#nullable disable

namespace ClasseConcordance.StdModels
{
    public partial class ParamDelibe
    {
        public ParamDelibe()
        {
            BukuDelibeCoursSansEchecs = new HashSet<BukuDelibeCoursSansEchec>();
        }

        public string CodeParamDelibe { get; set; }
        public string CodeFaitDelibe { get; set; }
        public double PourcentageMin { get; set; }
        public double PourcentageMax { get; set; }
        public int EchecLegerSession1 { get; set; }
        public int? EchecGraveSession1 { get; set; }
        public int? EchecLegerSession2 { get; set; }
        public int? EchecGraveSession2 { get; set; }
        public int CodeParamTypeDelibe { get; set; }
        public int CodeAnnee { get; set; }
        public string Conduite { get; set; }
        public string CodeEcole { get; set; }
        public bool Sync { get; set; }
        public bool? SyncPush { get; set; }

        public virtual GlobalEcole CodeEcoleNavigation { get; set; }
        public virtual ParamTypeDelibe CodeParamTypeDelibeNavigation { get; set; }
        public virtual ICollection<BukuDelibeCoursSansEchec> BukuDelibeCoursSansEchecs { get; set; }
    }
}
