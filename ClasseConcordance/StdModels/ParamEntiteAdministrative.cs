using System;
using System.Collections.Generic;

#nullable disable

namespace ClasseConcordance.StdModels
{
    public partial class ParamEntiteAdministrative
    {
        public ParamEntiteAdministrative()
        {
            EteyeloEleveDetails = new HashSet<EteyeloEleveDetail>();
            GlobalAdresses = new HashSet<GlobalAdresse>();
            GlobalAgents = new HashSet<GlobalAgent>();
            InverseCodeEntiteAdministrativeMereNavigation = new HashSet<ParamEntiteAdministrative>();
            ParamPays = new HashSet<ParamPay>();
        }

        public string CodeEntiteAdministrative { get; set; }
        public string CodeTypeEntiteAdministrative { get; set; }
        public string Denomination { get; set; }
        public string Entite { get; set; }
        public string DenominationHabitant { get; set; }
        public string CodeEntiteAdministrativeMere { get; set; }
        public bool Sync { get; set; }
        public bool? SyncPush { get; set; }
        public string Autres { get; set; }
        public string CodeEcole { get; set; }

        public virtual ParamEntiteAdministrative CodeEntiteAdministrativeMereNavigation { get; set; }
        public virtual ParamTypeEntiteAdministrative CodeTypeEntiteAdministrativeNavigation { get; set; }
        public virtual ICollection<EteyeloEleveDetail> EteyeloEleveDetails { get; set; }
        public virtual ICollection<GlobalAdresse> GlobalAdresses { get; set; }
        public virtual ICollection<GlobalAgent> GlobalAgents { get; set; }
        public virtual ICollection<ParamEntiteAdministrative> InverseCodeEntiteAdministrativeMereNavigation { get; set; }
        public virtual ICollection<ParamPay> ParamPays { get; set; }
    }
}
