using System;
using System.Collections.Generic;

#nullable disable

namespace ClasseConcordance.StdModels
{
    public partial class GlobalParent
    {
        public GlobalParent()
        {
            GlobalEleveParents = new HashSet<GlobalEleveParent>();
        }

        public string CodeParent { get; set; }
        public string Nom { get; set; }
        public string Postnom { get; set; }
        public string Prenom { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Sexe { get; set; }
        public string Telephone { get; set; }
        public string Adresse { get; set; }
        public bool? Actif { get; set; }
        public bool Sync { get; set; }
        public bool SyncPush { get; set; }
        public string CodeEcole { get; set; }
        public string Email { get; set; }
        public string NotifyPushId { get; set; }
        public string Pin { get; set; }

        public virtual ICollection<GlobalEleveParent> GlobalEleveParents { get; set; }
    }
}
