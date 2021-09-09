using System;
using System.Collections.Generic;

#nullable disable

namespace ClasseConcordance.KlasModels
{
    public partial class Parent
    {
        public Parent()
        {
            ParentsEleves = new HashSet<ParentsElefe>();
        }

        public string Code { get; set; }
        public string Nom { get; set; }
        public string Postnom { get; set; }
        public string Prenom { get; set; }
        public string Sexe { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public string Adresse { get; set; }
        public bool EstActif { get; set; }
        public string CodeEcole { get; set; }
        //

        public virtual ICollection<ParentsElefe> ParentsEleves { get; set; }
    }
}
