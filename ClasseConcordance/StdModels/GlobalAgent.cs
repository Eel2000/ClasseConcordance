using System;
using System.Collections.Generic;

#nullable disable

namespace ClasseConcordance.StdModels
{
    public partial class GlobalAgent
    {
        public GlobalAgent()
        {
            CommSouscriptions = new HashSet<CommSouscription>();
            GlobalAffectationAdresses = new HashSet<GlobalAffectationAdresse>();
            GlobalAffectationClasseAgentCours = new HashSet<GlobalAffectationClasseAgentCour>();
            GlobalPresences = new HashSet<GlobalPresence>();
            ParamAffectationSignatureDocuments = new HashSet<ParamAffectationSignatureDocument>();
            ParamAgentFonctions = new HashSet<ParamAgentFonction>();
        }

        public string EloCodeAgent { get; set; }
        public string Nom { get; set; }
        public string Postnom { get; set; }
        public string Prenom { get; set; }
        public string Sexe { get; set; }
        public DateTime? DateNaissance { get; set; }
        public string LieuNaissance { get; set; }
        public string ProvinceOrigine { get; set; }
        public string CodeNationalite { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public byte[] Photo { get; set; }
        public byte[] Empreinte { get; set; }
        public string Grade { get; set; }
        public bool Sync { get; set; }
        public bool? SyncPush { get; set; }
        public string CodeEcole { get; set; }

        public virtual ParamEntiteAdministrative CodeNationaliteNavigation { get; set; }
        public virtual ICollection<CommSouscription> CommSouscriptions { get; set; }
        public virtual ICollection<GlobalAffectationAdresse> GlobalAffectationAdresses { get; set; }
        public virtual ICollection<GlobalAffectationClasseAgentCour> GlobalAffectationClasseAgentCours { get; set; }
        public virtual ICollection<GlobalPresence> GlobalPresences { get; set; }
        public virtual ICollection<ParamAffectationSignatureDocument> ParamAffectationSignatureDocuments { get; set; }
        public virtual ICollection<ParamAgentFonction> ParamAgentFonctions { get; set; }
    }
}
