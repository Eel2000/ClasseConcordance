using System;
using System.Collections.Generic;

#nullable disable

namespace ClasseConcordance.StdModels
{
    public partial class ParamSanctionDisciplinaire
    {
        public string CodeSanction { get; set; }
        public string Libelle { get; set; }
        public int Valeur { get; set; }
        public string CodeEcole { get; set; }
        public bool Sync { get; set; }
        public bool? SyncPush { get; set; }
    }
}
