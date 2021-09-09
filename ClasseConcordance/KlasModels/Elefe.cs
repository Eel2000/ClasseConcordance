using System;
using System.Collections.Generic;

#nullable disable

namespace ClasseConcordance.KlasModels
{
    public partial class Elefe
    {
        public Elefe()
        {
            Notes = new HashSet<Note>();
            Parcours = new HashSet<Parcour>();
            ParentsEleves = new HashSet<ParentsElefe>();
            SolutionEvaluations = new HashSet<SolutionEvaluation>();
        }

        public string Code { get; set; }
        public string Nom { get; set; }
        public string Postnom { get; set; }
        public string Prenom { get; set; }
        public string Sexe { get; set; }
        public DateTime DateNaissance { get; set; }
        public string LieuNaissance { get; set; }
        public DateTime DateInscription { get; set; }
        public string Matricule { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public string Adresse { get; set; }
        public bool EstActif { get; set; }
        public string CodeEcole { get; set; }
        public bool? SendSms { get; set; }
        public string CodeAuth { get; set; }
        public string CodePwd { get; set; }
        //

        public virtual ICollection<Note> Notes { get; set; }
        public virtual ICollection<Parcour> Parcours { get; set; }
        public virtual ICollection<ParentsElefe> ParentsEleves { get; set; }
        public virtual ICollection<SolutionEvaluation> SolutionEvaluations { get; set; }
    }
}
