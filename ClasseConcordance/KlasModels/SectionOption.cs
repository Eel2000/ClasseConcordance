using System;
using System.Collections.Generic;

#nullable disable

namespace ClasseConcordance.KlasModels
{
    public partial class SectionOption
    {
        public int Code { get; set; }
        public string CodeSection { get; set; }
        public string CodeOption { get; set; }
        public Guid Rowguid { get; set; }
    }
}
