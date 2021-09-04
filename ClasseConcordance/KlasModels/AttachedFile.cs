using System;
using System.Collections.Generic;

#nullable disable

namespace ClasseConcordance.KlasModels
{
    public partial class AttachedFile
    {
        public int Id { get; set; }
        public string IdDocument { get; set; }
        public string AttachedFileUrl { get; set; }
        public string AttachedFileSize { get; set; }
        public bool IsActive { get; set; }
        public bool IsLesson { get; set; }
        public Guid Rowguid { get; set; }
    }
}
