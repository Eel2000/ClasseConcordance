using System;
using System.Collections.Generic;

#nullable disable

namespace ClasseConcordance.StdModels
{
    public partial class ParamSm
    {
        public string CodeSms { get; set; }
        public string Sender { get; set; }
        public string Destinateur { get; set; }
        public string Message { get; set; }
        public DateTime DateCreation { get; set; }
        public bool EtatSend { get; set; }
        public DateTime? DateSend { get; set; }
        public int? NbrMessage { get; set; }
        public int? TailleMessage { get; set; }
        public bool Sync { get; set; }
        public bool? SyncPush { get; set; }
        public string CodeEcole { get; set; }
    }
}
