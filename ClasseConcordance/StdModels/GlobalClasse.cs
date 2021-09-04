using System;
using System.Collections.Generic;

#nullable disable

namespace ClasseConcordance.StdModels
{
    public partial class GlobalClasse
    {
        public GlobalClasse()
        {
            BukuCours = new HashSet<BukuCour>();
            FinanceFrais = new HashSet<FinanceFrai>();
            FinanceFraisRegimes = new HashSet<FinanceFraisRegime>();
            GlobalAffectationLocalClasses = new HashSet<GlobalAffectationLocalClasse>();
            GlobalCommuniques = new HashSet<GlobalCommunique>();
        }

        public string CodeClasse { get; set; }
        public string IntituleClasse { get; set; }
        public string IntituleClasseCourt { get; set; }
        public string SysClasse { get; set; }
        public string CodeEcole { get; set; }
        public string CodeFiliere { get; set; }
        public bool Sync { get; set; }
        public bool? SyncPush { get; set; }
        public int? CodeTypeEcole { get; set; }

        public virtual GlobalEcole CodeEcoleNavigation { get; set; }
        public virtual GlobalFiliere CodeFiliereNavigation { get; set; }
        public virtual GlobalSysClasse SysClasseNavigation { get; set; }
        public virtual ICollection<BukuCour> BukuCours { get; set; }
        public virtual ICollection<FinanceFrai> FinanceFrais { get; set; }
        public virtual ICollection<FinanceFraisRegime> FinanceFraisRegimes { get; set; }
        public virtual ICollection<GlobalAffectationLocalClasse> GlobalAffectationLocalClasses { get; set; }
        public virtual ICollection<GlobalCommunique> GlobalCommuniques { get; set; }
    }
}
