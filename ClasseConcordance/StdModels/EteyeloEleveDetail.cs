using System;
using System.Collections.Generic;

#nullable disable

namespace ClasseConcordance.StdModels
{
    public partial class EteyeloEleveDetail
    {
        public EteyeloEleveDetail()
        {
            CommSouscriptions = new HashSet<CommSouscription>();
        }

        public string CodeEleveDetails { get; set; }
        public string EloCodeEleve { get; set; }
        public string ProvinceOrigine { get; set; }
        public string CodeNationalite { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public string AptitudeIntellectuel { get; set; }
        public string NomPere { get; set; }
        public string ProfessionPere { get; set; }
        public string TelephonePere { get; set; }
        public string NomMere { get; set; }
        public string ProfessionMere { get; set; }
        public string TelephoneMere { get; set; }
        public byte[] Photo { get; set; }
        public byte[] Empreinte { get; set; }
        public string CodeCategorieEleve { get; set; }
        public bool? DeuxParentsEnVie { get; set; }
        public bool? PereMort { get; set; }
        public bool? ParentsViventEnsemble { get; set; }
        public string AdresseResidenceParents { get; set; }
        public string LienParenteTuteur { get; set; }
        public string ReligionPratiquee { get; set; }
        public string Paroisse { get; set; }
        public string MaladieFrequente { get; set; }
        public string CE { get; set; }
        public string MoyenTransport { get; set; }
        public bool? MereMort { get; set; }
        public bool Sync { get; set; }
        public bool? SyncPush { get; set; }
        public string CodeEcole { get; set; }

        public virtual ParamEntiteAdministrative CodeNationaliteNavigation { get; set; }
        public virtual InscriptionEleve EloCodeEleveNavigation { get; set; }
        public virtual ICollection<CommSouscription> CommSouscriptions { get; set; }
    }
}
