using System;
using System.Collections.Generic;

#nullable disable

namespace ClasseConcordance.KlasModels
{
    public partial class Class
    {
        public Class()
        {
            Parcours = new HashSet<Parcour>();
        }

        public string Code { get; set; }
        public string Intitule { get; set; }
        public string IntituleCourt { get; set; }
        public string CodeEcole { get; set; }
        public string Virtualclass { get; set; }
        public string Whatsappgroup { get; set; }
        public int? SectionOption { get; set; }
        public bool? IsPrivate { get; set; }
        public string Owner { get; set; }
        public Guid Rowguid { get; set; }
        public string CodeClassStandard { get; set; }

        public virtual ICollection<Parcour> Parcours { get; set; }
    }
}
