﻿using System;
using System.Collections.Generic;

#nullable disable

namespace ClasseConcordance.KlasModels
{
    public partial class AspNetUserClaim
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string ClaimType { get; set; }
        public string ClaimValue { get; set; }
        public Guid Rowguid { get; set; }

        public virtual AspNetUser User { get; set; }
    }
}