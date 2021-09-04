using System;
using System.Collections.Generic;

#nullable disable

namespace ClasseConcordance.StdModels
{
    public partial class UsersLogin
    {
        public string CodeUtilisateur { get; set; }
        public string Username { get; set; }
        public string Pwd { get; set; }
        public string MessageRappelPwd { get; set; }
        public DateTime? DateCreation { get; set; }
        public int? CodeGroupUser { get; set; }
        public string CodeAgentFonction { get; set; }
        public bool? EstActif { get; set; }
        public DateTime? DateExpiration { get; set; }
        public bool? EstDateExpiration { get; set; }
        public bool? ActifPortail { get; set; }
        public bool Sync { get; set; }
        public bool? SyncPush { get; set; }
        public string CodeEcole { get; set; }
        public string EloCodeEcole { get; set; }
        public string NomEcole { get; set; }
        public string Domaine { get; set; }
    }
}
