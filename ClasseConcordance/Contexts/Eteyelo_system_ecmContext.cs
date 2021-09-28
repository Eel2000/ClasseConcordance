using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using ClasseConcordance.StdModels;

#nullable disable

namespace ClasseConcordance.Contexts
{
    public partial class Eteyelo_system_ecmContext : DbContext
    {
        public Eteyelo_system_ecmContext()
        {
        }

        public Eteyelo_system_ecmContext(DbContextOptions<Eteyelo_system_ecmContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AspNetRole> AspNetRoles { get; set; }
        public virtual DbSet<AspNetRoleClaim> AspNetRoleClaims { get; set; }
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; }
        public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUserRole> AspNetUserRoles { get; set; }
        public virtual DbSet<AspNetUserToken> AspNetUserTokens { get; set; }
        public virtual DbSet<BukuAppreciation> BukuAppreciations { get; set; }
        public virtual DbSet<BukuConduiteFinale> BukuConduiteFinales { get; set; }
        public virtual DbSet<BukuCour> BukuCours { get; set; }
        public virtual DbSet<BukuDelibeClasse> BukuDelibeClasses { get; set; }
        public virtual DbSet<BukuDelibeCoursSansEchec> BukuDelibeCoursSansEchecs { get; set; }
        public virtual DbSet<BukuDelibeDecisionFinal> BukuDelibeDecisionFinals { get; set; }
        public virtual DbSet<BukuDetailPeriode> BukuDetailPeriodes { get; set; }
        public virtual DbSet<BukuEvaluation> BukuEvaluations { get; set; }
        public virtual DbSet<BukuMention> BukuMentions { get; set; }
        public virtual DbSet<BukuNote> BukuNotes { get; set; }
        public virtual DbSet<BukuPartEvaluation> BukuPartEvaluations { get; set; }
        public virtual DbSet<BukuProportionEchecLeger> BukuProportionEchecLegers { get; set; }
        public virtual DbSet<BukuSysCour> BukuSysCours { get; set; }
        public virtual DbSet<BukuTypeCour> BukuTypeCours { get; set; }
        public virtual DbSet<BukuTypeEvaluation> BukuTypeEvaluations { get; set; }
        public virtual DbSet<CommService> CommServices { get; set; }
        public virtual DbSet<CommSouscription> CommSouscriptions { get; set; }
        public virtual DbSet<CommTarif> CommTarifs { get; set; }
        public virtual DbSet<ComptaClass> ComptaClasses { get; set; }
        public virtual DbSet<ComptaCompte> ComptaComptes { get; set; }
        public virtual DbSet<ComptaEcoleClasse> ComptaEcoleClasses { get; set; }
        public virtual DbSet<ComptaPlansComptable> ComptaPlansComptables { get; set; }
        public virtual DbSet<EteyeloAbsence> EteyeloAbsences { get; set; }
        public virtual DbSet<EteyeloBulletin> EteyeloBulletins { get; set; }
        public virtual DbSet<EteyeloCategorieEleve> EteyeloCategorieEleves { get; set; }
        public virtual DbSet<EteyeloDocument> EteyeloDocuments { get; set; }
        public virtual DbSet<EteyeloEleveDetail> EteyeloEleveDetails { get; set; }
        public virtual DbSet<EteyeloMouvementEleve> EteyeloMouvementEleves { get; set; }
        public virtual DbSet<EteyeloTypeDocument> EteyeloTypeDocuments { get; set; }
        public virtual DbSet<EteyeloTypeMouvement> EteyeloTypeMouvements { get; set; }
        public virtual DbSet<FinanceBanque> FinanceBanques { get; set; }
        public virtual DbSet<FinanceCaisse> FinanceCaisses { get; set; }
        public virtual DbSet<FinanceCommission> FinanceCommissions { get; set; }
        public virtual DbSet<FinanceCompteBancaire> FinanceCompteBancaires { get; set; }
        public virtual DbSet<FinanceCompteEleve> FinanceCompteEleves { get; set; }
        public virtual DbSet<FinanceCompteFrai> FinanceCompteFrais { get; set; }
        public virtual DbSet<FinanceComptePaiement> FinanceComptePaiements { get; set; }
        public virtual DbSet<FinanceCompteTypeFrai> FinanceCompteTypeFrais { get; set; }
        public virtual DbSet<FinanceFacturier> FinanceFacturiers { get; set; }
        public virtual DbSet<FinanceFrai> FinanceFrais { get; set; }
        public virtual DbSet<FinanceFraisRegime> FinanceFraisRegimes { get; set; }
        public virtual DbSet<FinancePaiement> FinancePaiements { get; set; }
        public virtual DbSet<FinancePaiementOnline> FinancePaiementOnlines { get; set; }
        public virtual DbSet<FinanceSituation> FinanceSituations { get; set; }
        public virtual DbSet<GlobalAdresse> GlobalAdresses { get; set; }
        public virtual DbSet<GlobalAffectationAdresse> GlobalAffectationAdresses { get; set; }
        public virtual DbSet<GlobalAffectationClasseAgentCour> GlobalAffectationClasseAgentCours { get; set; }
        public virtual DbSet<GlobalAffectationLocalClasse> GlobalAffectationLocalClasses { get; set; }
        public virtual DbSet<GlobalAgent> GlobalAgents { get; set; }
        public virtual DbSet<GlobalClasse> GlobalClasses { get; set; }
        public virtual DbSet<GlobalCommunique> GlobalCommuniques { get; set; }
        public virtual DbSet<GlobalDegreClasse> GlobalDegreClasses { get; set; }
        public virtual DbSet<GlobalEcole> GlobalEcoles { get; set; }
        public virtual DbSet<GlobalEleveParent> GlobalEleveParents { get; set; }
        public virtual DbSet<GlobalFiliere> GlobalFilieres { get; set; }
        public virtual DbSet<GlobalHeure> GlobalHeures { get; set; }
        public virtual DbSet<GlobalHoraire> GlobalHoraires { get; set; }
        public virtual DbSet<GlobalJour> GlobalJours { get; set; }
        public virtual DbSet<GlobalLocal> GlobalLocals { get; set; }
        public virtual DbSet<GlobalNiveau> GlobalNiveaus { get; set; }
        public virtual DbSet<GlobalOption> GlobalOptions { get; set; }
        public virtual DbSet<GlobalParent> GlobalParents { get; set; }
        public virtual DbSet<GlobalPeriodeScolaire> GlobalPeriodeScolaires { get; set; }
        public virtual DbSet<GlobalPresence> GlobalPresences { get; set; }
        public virtual DbSet<GlobalSection> GlobalSections { get; set; }
        public virtual DbSet<GlobalSysClasse> GlobalSysClasses { get; set; }
        public virtual DbSet<InscriptionEleve> InscriptionEleves { get; set; }
        public virtual DbSet<InscriptionEleveOnline> InscriptionEleveOnlines { get; set; }
        public virtual DbSet<InscriptionParcour> InscriptionParcours { get; set; }
        public virtual DbSet<InscriptionTransfere> InscriptionTransferes { get; set; }
        public virtual DbSet<MambaDroit> MambaDroits { get; set; }
        public virtual DbSet<MambaGroupUser> MambaGroupUsers { get; set; }
        public virtual DbSet<MambaGuAcce> MambaGuAcces { get; set; }
        public virtual DbSet<MambaLog> MambaLogs { get; set; }
        public virtual DbSet<MambaUtilisateur> MambaUtilisateurs { get; set; }
        public virtual DbSet<ParamAffectationDevice> ParamAffectationDevices { get; set; }
        public virtual DbSet<ParamAffectationSignatureDocument> ParamAffectationSignatureDocuments { get; set; }
        public virtual DbSet<ParamAgentFonction> ParamAgentFonctions { get; set; }
        public virtual DbSet<ParamAnneeScolaire> ParamAnneeScolaires { get; set; }
        public virtual DbSet<ParamAntenneEcole> ParamAntenneEcoles { get; set; }
        public virtual DbSet<ParamCommission> ParamCommissions { get; set; }
        public virtual DbSet<ParamCompte> ParamComptes { get; set; }
        public virtual DbSet<ParamDelibe> ParamDelibes { get; set; }
        public virtual DbSet<ParamDevise> ParamDevises { get; set; }
        public virtual DbSet<ParamDocumentParDefaut> ParamDocumentParDefauts { get; set; }
        public virtual DbSet<ParamEntiteAdministrative> ParamEntiteAdministratives { get; set; }
        public virtual DbSet<ParamFaitDelibe> ParamFaitDelibes { get; set; }
        public virtual DbSet<ParamFonction> ParamFonctions { get; set; }
        public virtual DbSet<ParamGlobal> ParamGlobals { get; set; }
        public virtual DbSet<ParamLicence> ParamLicences { get; set; }
        public virtual DbSet<ParamMamba> ParamMambas { get; set; }
        public virtual DbSet<ParamModePaiement> ParamModePaiements { get; set; }
        public virtual DbSet<ParamOrdreFrai> ParamOrdreFrais { get; set; }
        public virtual DbSet<ParamPay> ParamPays { get; set; }
        public virtual DbSet<ParamPeriodicite> ParamPeriodicites { get; set; }
        public virtual DbSet<ParamPrioriteFrai> ParamPrioriteFrais { get; set; }
        public virtual DbSet<ParamRegimePaiement> ParamRegimePaiements { get; set; }
        public virtual DbSet<ParamReseauEnseignement> ParamReseauEnseignements { get; set; }
        public virtual DbSet<ParamSanctionDisciplinaire> ParamSanctionDisciplinaires { get; set; }
        public virtual DbSet<ParamService> ParamServices { get; set; }
        public virtual DbSet<ParamSm> ParamSms { get; set; }
        public virtual DbSet<ParamSystemScolaire> ParamSystemScolaires { get; set; }
        public virtual DbSet<ParamSysteme> ParamSystemes { get; set; }
        public virtual DbSet<ParamTaux> ParamTauxes { get; set; }
        public virtual DbSet<ParamTemplateMessage> ParamTemplateMessages { get; set; }
        public virtual DbSet<ParamTemplateOperationCaisse> ParamTemplateOperationCaisses { get; set; }
        public virtual DbSet<ParamTypeAppreciation> ParamTypeAppreciations { get; set; }
        public virtual DbSet<ParamTypeCommunique> ParamTypeCommuniques { get; set; }
        public virtual DbSet<ParamTypeComplementMessage> ParamTypeComplementMessages { get; set; }
        public virtual DbSet<ParamTypeCompte> ParamTypeComptes { get; set; }
        public virtual DbSet<ParamTypeDelibe> ParamTypeDelibes { get; set; }
        public virtual DbSet<ParamTypeEcole> ParamTypeEcoles { get; set; }
        public virtual DbSet<ParamTypeEntiteAdministrative> ParamTypeEntiteAdministratives { get; set; }
        public virtual DbSet<ParamTypeFrai> ParamTypeFrais { get; set; }
        public virtual DbSet<ParamTypeMention> ParamTypeMentions { get; set; }
        public virtual DbSet<ParamTypePeriode> ParamTypePeriodes { get; set; }
        public virtual DbSet<ParamTypeSignature> ParamTypeSignatures { get; set; }
        public virtual DbSet<RaportPaiementBi> RaportPaiementBis { get; set; }
        public virtual DbSet<SelectMontantApaye> SelectMontantApayes { get; set; }
        public virtual DbSet<Sqlsession> Sqlsessions { get; set; }
        public virtual DbSet<StockCommande> StockCommandes { get; set; }
        public virtual DbSet<StockCommandeDetail> StockCommandeDetails { get; set; }
        public virtual DbSet<UsersLogin> UsersLogins { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=5.189.167.38;Initial Catalog=eteyelo_system_ecm_2022;User ID=sa;Password=elo--@srvK11");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<AspNetRole>(entity =>
            {
                entity.HasIndex(e => e.NormalizedName, "RoleNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedName] IS NOT NULL)");

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.NormalizedName).HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetRoleClaim>(entity =>
            {
                entity.HasIndex(e => e.RoleId, "IX_AspNetRoleClaims_RoleId");

                entity.Property(e => e.RoleId).IsRequired();

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetRoleClaims)
                    .HasForeignKey(d => d.RoleId);
            });

            modelBuilder.Entity<AspNetUser>(entity =>
            {
                entity.HasIndex(e => e.NormalizedEmail, "EmailIndex");

                entity.HasIndex(e => e.NormalizedUserName, "UserNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedUserName] IS NOT NULL)");

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.NormalizedEmail).HasMaxLength(256);

                entity.Property(e => e.NormalizedUserName).HasMaxLength(256);

                entity.Property(e => e.UserName).HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetUserClaim>(entity =>
            {
                entity.HasIndex(e => e.UserId, "IX_AspNetUserClaims_UserId");

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserClaims)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserLogin>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });

                entity.HasIndex(e => e.UserId, "IX_AspNetUserLogins_UserId");

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserLogins)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserRole>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId });

                entity.HasIndex(e => e.RoleId, "IX_AspNetUserRoles_RoleId");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.RoleId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserToken>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserTokens)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<BukuAppreciation>(entity =>
            {
                entity.HasKey(e => e.CodeAppreciation);

                entity.ToTable("BUKU_APPRECIATION");

                entity.Property(e => e.CodeAppreciation)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_APPRECIATION");

                entity.Property(e => e.CodeCours)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_COURS");

                entity.Property(e => e.CodeEcole)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_ECOLE");

                entity.Property(e => e.CodeEleve)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("CODE_ELEVE");

                entity.Property(e => e.CodePeriode)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("CODE_PERIODE");

                entity.Property(e => e.CodeTypeAppreciation)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("CODE_TYPE_APPRECIATION");

                entity.Property(e => e.EstValide).HasColumnName("EST_VALIDE");

                entity.Property(e => e.IntituleAppreciation).HasColumnName("INTITULE_APPRECIATION");

                entity.Property(e => e.Sync).HasColumnName("SYNC");

                entity.Property(e => e.SyncPush)
                    .HasColumnName("SYNC_PUSH")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<BukuConduiteFinale>(entity =>
            {
                entity.HasKey(e => e.CodeConduiteFinale)
                    .HasName("PK_BUKU_Conduite_Finale_1");

                entity.ToTable("BUKU_Conduite_Finale");

                entity.Property(e => e.CodeConduiteFinale).HasColumnName("CODE_CONDUITE_FINALE");

                entity.Property(e => e.CodeAnnee).HasColumnName("CODE_ANNEE");

                entity.Property(e => e.CodeEcole)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_ECOLE");

                entity.Property(e => e.Intitule)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("INTITULE");

                entity.Property(e => e.Sync).HasColumnName("SYNC");

                entity.Property(e => e.SyncPush)
                    .HasColumnName("SYNC_PUSH")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ValeurMax).HasColumnName("VALEUR_MAX");

                entity.Property(e => e.ValeurMin).HasColumnName("VALEUR_MIN");
            });

            modelBuilder.Entity<BukuCour>(entity =>
            {
                entity.HasKey(e => e.CodeCours);

                entity.ToTable("BUKU_Cours");

                entity.Property(e => e.CodeCours)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_COURS");

                entity.Property(e => e.CodeAffClasseAgentCours)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_AFF_CLASSE_AGENT_COURS");

                entity.Property(e => e.CodeClasse)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_CLASSE");

                entity.Property(e => e.CodeEcole)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_ECOLE");

                entity.Property(e => e.CodeSysCours)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_SYS_COURS");

                entity.Property(e => e.CodeTypeCours)
                    .HasMaxLength(3)
                    .HasColumnName("CODE_TYPE_COURS")
                    .IsFixedLength(true);

                entity.Property(e => e.IntituleCours)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("INTITULE_COURS");

                entity.Property(e => e.IntituleCoursCourt)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("INTITULE_COURS_COURT");

                entity.Property(e => e.MaximaExamen).HasColumnName("MAXIMA_EXAMEN");

                entity.Property(e => e.MaximaPeriode).HasColumnName("MAXIMA_PERIODE");

                entity.Property(e => e.Ponderation).HasColumnName("PONDERATION");

                entity.Property(e => e.Priorite).HasColumnName("PRIORITE");

                entity.Property(e => e.Sync).HasColumnName("SYNC");

                entity.Property(e => e.SyncPush)
                    .HasColumnName("SYNC_PUSH")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.VolumeHoraire).HasColumnName("VOLUME_HORAIRE");

                entity.HasOne(d => d.CodeAffClasseAgentCoursNavigation)
                    .WithMany(p => p.BukuCours)
                    .HasForeignKey(d => d.CodeAffClasseAgentCours)
                    .HasConstraintName("FK_BUKU_Cours_GLOBAL_Affectation_Classe_Agent_Cours");

                entity.HasOne(d => d.CodeClasseNavigation)
                    .WithMany(p => p.BukuCours)
                    .HasForeignKey(d => d.CodeClasse)
                    .HasConstraintName("FK_BUKU_Cours_GLOBAL_Classe");

                entity.HasOne(d => d.CodeSysCoursNavigation)
                    .WithMany(p => p.BukuCours)
                    .HasForeignKey(d => d.CodeSysCours)
                    .HasConstraintName("FK_BUKU_Cours_BUKU_SYS_Cours");

                entity.HasOne(d => d.CodeTypeCoursNavigation)
                    .WithMany(p => p.BukuCours)
                    .HasForeignKey(d => d.CodeTypeCours)
                    .HasConstraintName("FK_BUKU_Cours_BUKU_Cours_TYPES_COURS");
            });

            modelBuilder.Entity<BukuDelibeClasse>(entity =>
            {
                entity.HasKey(e => e.CodeDelibeClasse);

                entity.ToTable("BUKU_Delibe_Classe");

                entity.Property(e => e.CodeDelibeClasse)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_DELIBE_CLASSE");

                entity.Property(e => e.CodeAnnee).HasColumnName("CODE_ANNEE");

                entity.Property(e => e.CodeClasse)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("CODE_CLASSE");

                entity.Property(e => e.CodeEcole)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_ECOLE");

                entity.Property(e => e.CodeParamDelibe)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_PARAM_DELIBE");

                entity.Property(e => e.EstActif).HasColumnName("EST_ACTIF");

                entity.Property(e => e.Sync).HasColumnName("SYNC");

                entity.Property(e => e.SyncPush)
                    .HasColumnName("SYNC_PUSH")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<BukuDelibeCoursSansEchec>(entity =>
            {
                entity.HasKey(e => e.CodeDelibeCoursSansEchec);

                entity.ToTable("BUKU_Delibe_Cours_Sans_Echec");

                entity.Property(e => e.CodeDelibeCoursSansEchec)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_DELIBE_COURS_SANS_ECHEC");

                entity.Property(e => e.CodeCours)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("CODE_COURS");

                entity.Property(e => e.CodeEcole)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_ECOLE");

                entity.Property(e => e.CodeParamDelibe)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_PARAM_DELIBE");

                entity.Property(e => e.Sync).HasColumnName("SYNC");

                entity.Property(e => e.SyncPush)
                    .HasColumnName("SYNC_PUSH")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.CodeEcoleNavigation)
                    .WithMany(p => p.BukuDelibeCoursSansEchecs)
                    .HasForeignKey(d => d.CodeEcole)
                    .HasConstraintName("FK_BUKU_Delibe_Cours_Sans_Echec_GLOBAL_Ecole");

                entity.HasOne(d => d.CodeParamDelibeNavigation)
                    .WithMany(p => p.BukuDelibeCoursSansEchecs)
                    .HasForeignKey(d => d.CodeParamDelibe)
                    .HasConstraintName("FK_BUKU_Delibe_Cours_Sans_Echec_PARAM_Delibe");
            });

            modelBuilder.Entity<BukuDelibeDecisionFinal>(entity =>
            {
                entity.HasKey(e => e.CodeDelibeDecision);

                entity.ToTable("BUKU_Delibe_Decision_Final");

                entity.Property(e => e.CodeDelibeDecision)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_DELIBE_DECISION");

                entity.Property(e => e.AdmisAuRepechage).HasColumnName("ADMIS_AU_REPECHAGE");

                entity.Property(e => e.CodeAffectationLocalClass)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_AFFECTATION_LOCAL_CLASS");

                entity.Property(e => e.CodeAnnee).HasColumnName("CODE_ANNEE");

                entity.Property(e => e.CodeEcole)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_ECOLE");

                entity.Property(e => e.CodeEleve)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_ELEVE");

                entity.Property(e => e.Decision)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DECISION");

                entity.Property(e => e.Sync).HasColumnName("SYNC");

                entity.Property(e => e.SyncPush)
                    .HasColumnName("SYNC_PUSH")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.CodeAffectationLocalClassNavigation)
                    .WithMany(p => p.BukuDelibeDecisionFinals)
                    .HasForeignKey(d => d.CodeAffectationLocalClass)
                    .HasConstraintName("FK_BUKU_Delibe_Decision_Final_GLOBAL_Affectation_Local_Classe");

                entity.HasOne(d => d.CodeAnneeNavigation)
                    .WithMany(p => p.BukuDelibeDecisionFinals)
                    .HasForeignKey(d => d.CodeAnnee)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_BUKU_Delibe_Decision_Final_PARAM_Annee_Scolaire");

                entity.HasOne(d => d.CodeEcoleNavigation)
                    .WithMany(p => p.BukuDelibeDecisionFinals)
                    .HasForeignKey(d => d.CodeEcole)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_BUKU_Delibe_Decision_Final_GLOBAL_Ecole");

                entity.HasOne(d => d.CodeEleveNavigation)
                    .WithMany(p => p.BukuDelibeDecisionFinals)
                    .HasForeignKey(d => d.CodeEleve)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_BUKU_Delibe_Decision_Final_INSCRIPTION_Eleve");
            });

            modelBuilder.Entity<BukuDetailPeriode>(entity =>
            {
                entity.HasKey(e => e.CodeDetailPeriode)
                    .HasName("PK_Detail_Periode");

                entity.ToTable("BUKU_Detail_Periode");

                entity.Property(e => e.CodeDetailPeriode)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("CODE_DETAIL_PERIODE");

                entity.Property(e => e.CodeAnnee)
                    .IsRequired()
                    .HasMaxLength(5)
                    .HasColumnName("CODE_ANNEE")
                    .IsFixedLength(true);

                entity.Property(e => e.CodeEcole)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_ECOLE");

                entity.Property(e => e.CodePeriode)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_PERIODE");

                entity.Property(e => e.Sync).HasColumnName("SYNC");

                entity.Property(e => e.SyncPush)
                    .HasColumnName("SYNC_PUSH")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.CodeDetailPeriodeNavigation)
                    .WithOne(p => p.BukuDetailPeriode)
                    .HasForeignKey<BukuDetailPeriode>(d => d.CodeDetailPeriode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BUKU_Detail_Periode_PARAM_Annee_Scolaire");

                entity.HasOne(d => d.CodePeriodeNavigation)
                    .WithMany(p => p.BukuDetailPeriodes)
                    .HasForeignKey(d => d.CodePeriode)
                    .HasConstraintName("FK_Detail_Periode_GLOBAL_Periode_Scolaire1");
            });

            modelBuilder.Entity<BukuEvaluation>(entity =>
            {
                entity.HasKey(e => e.CodeEvaluation);

                entity.ToTable("BUKU_Evaluation");

                entity.Property(e => e.CodeEvaluation)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_EVALUATION");

                entity.Property(e => e.CodeAnnee).HasColumnName("CODE_ANNEE");

                entity.Property(e => e.CodeEcole)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_ECOLE");

                entity.Property(e => e.CodeEleve)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_ELEVE");

                entity.Property(e => e.CodePartEvaluation)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_PART_EVALUATION");

                entity.Property(e => e.CodePeriode)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_PERIODE");

                entity.Property(e => e.EstActif).HasColumnName("EST_ACTIF");

                entity.Property(e => e.MaximaEvaluation).HasColumnName("MAXIMA_EVALUATION");

                entity.Property(e => e.NumeroOrdre).HasColumnName("NUMERO_ORDRE");

                entity.Property(e => e.Sync).HasColumnName("SYNC");

                entity.Property(e => e.SyncPush)
                    .HasColumnName("SYNC_PUSH")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Valeur)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("VALEUR");

                entity.HasOne(d => d.CodeAnneeNavigation)
                    .WithMany(p => p.BukuEvaluations)
                    .HasForeignKey(d => d.CodeAnnee)
                    .HasConstraintName("FK_BUKU_Evaluation_PARAM_Annee_Scolaire");

                entity.HasOne(d => d.CodeEleveNavigation)
                    .WithMany(p => p.BukuEvaluations)
                    .HasForeignKey(d => d.CodeEleve)
                    .HasConstraintName("FK_BUKU_Evaluation_INSCRIPTION_Eleve");

                entity.HasOne(d => d.CodePartEvaluationNavigation)
                    .WithMany(p => p.BukuEvaluations)
                    .HasForeignKey(d => d.CodePartEvaluation)
                    .HasConstraintName("FK_BUKU_Evaluation_BUKU_Part_Evaluation");

                entity.HasOne(d => d.CodePeriodeNavigation)
                    .WithMany(p => p.BukuEvaluations)
                    .HasForeignKey(d => d.CodePeriode)
                    .HasConstraintName("FK_BUKU_Evaluation_GLOBAL_Periode_Scolaire");
            });

            modelBuilder.Entity<BukuMention>(entity =>
            {
                entity.HasKey(e => e.CodeMention);

                entity.ToTable("BUKU_Mention");

                entity.Property(e => e.CodeMention)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_MENTION");

                entity.Property(e => e.CodeClasse)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_CLASSE");

                entity.Property(e => e.CodeEcole)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_ECOLE");

                entity.Property(e => e.CodeEleve)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("CODE_ELEVE");

                entity.Property(e => e.CodePeriode)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("CODE_PERIODE");

                entity.Property(e => e.CodeSanction)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_SANCTION")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DateSanction)
                    .HasColumnType("datetime")
                    .HasColumnName("DATE_SANCTION");

                entity.Property(e => e.Sync).HasColumnName("SYNC");

                entity.Property(e => e.SyncPush).HasColumnName("SYNC_PUSH");
            });

            modelBuilder.Entity<BukuNote>(entity =>
            {
                entity.HasKey(e => e.CodeNote);

                entity.ToTable("BUKU_Note");

                entity.Property(e => e.CodeNote)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("CODE_NOTE");

                entity.Property(e => e.CodeAnnee).HasColumnName("CODE_ANNEE");

                entity.Property(e => e.CodeCours)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_COURS");

                entity.Property(e => e.CodeEcole)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_ECOLE");

                entity.Property(e => e.CodeEleve)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_ELEVE");

                entity.Property(e => e.CodeLocalClasse)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_LOCAL_CLASSE");

                entity.Property(e => e.CodePeriode)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_PERIODE");

                entity.Property(e => e.DateCreation)
                    .HasColumnType("datetime")
                    .HasColumnName("DATE_CREATION")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Sync).HasColumnName("SYNC");

                entity.Property(e => e.SyncPush)
                    .HasColumnName("SYNC_PUSH")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Valeur)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("VALEUR");

                entity.HasOne(d => d.CodeAnneeNavigation)
                    .WithMany(p => p.BukuNotes)
                    .HasForeignKey(d => d.CodeAnnee)
                    .HasConstraintName("FK_BUKU_Note_PARAM_Annee_Scolaire");

                entity.HasOne(d => d.CodeCoursNavigation)
                    .WithMany(p => p.BukuNotes)
                    .HasForeignKey(d => d.CodeCours)
                    .HasConstraintName("FK_BUKU_Note_BUKU_Cours");

                entity.HasOne(d => d.CodeEleveNavigation)
                    .WithMany(p => p.BukuNotes)
                    .HasForeignKey(d => d.CodeEleve)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Notes_INSCRIPTION_Eleve");

                entity.HasOne(d => d.CodePeriodeNavigation)
                    .WithMany(p => p.BukuNotes)
                    .HasForeignKey(d => d.CodePeriode)
                    .HasConstraintName("FK_BUKU_Note_GLOBAL_Periode_Scolaire");
            });

            modelBuilder.Entity<BukuPartEvaluation>(entity =>
            {
                entity.HasKey(e => e.CodePartEvaluation)
                    .HasName("PK_Part_Evaluation");

                entity.ToTable("BUKU_Part_Evaluation");

                entity.Property(e => e.CodePartEvaluation)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_PART_EVALUATION");

                entity.Property(e => e.CodeAffectationLocalClass)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_AFFECTATION_LOCAL_CLASS");

                entity.Property(e => e.CodeAnnee).HasColumnName("CODE_ANNEE");

                entity.Property(e => e.CodeCours)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_COURS");

                entity.Property(e => e.CodeEcole)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_ECOLE");

                entity.Property(e => e.CodePeriode)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_PERIODE");

                entity.Property(e => e.CodeTypeEvaluation).HasColumnName("CODE_TYPE_EVALUATION");

                entity.Property(e => e.Part).HasColumnName("PART");

                entity.Property(e => e.Sync).HasColumnName("SYNC");

                entity.Property(e => e.SyncPush)
                    .HasColumnName("SYNC_PUSH")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.CodeAffectationLocalClassNavigation)
                    .WithMany(p => p.BukuPartEvaluations)
                    .HasForeignKey(d => d.CodeAffectationLocalClass)
                    .HasConstraintName("FK_BUKU_Part_Evaluation_GLOBAL_Affectation_Local_Classe");

                entity.HasOne(d => d.CodeAnneeNavigation)
                    .WithMany(p => p.BukuPartEvaluations)
                    .HasForeignKey(d => d.CodeAnnee)
                    .HasConstraintName("FK_BUKU_Part_Evaluation_PARAM_Annee_Scolaire");

                entity.HasOne(d => d.CodeCoursNavigation)
                    .WithMany(p => p.BukuPartEvaluations)
                    .HasForeignKey(d => d.CodeCours)
                    .HasConstraintName("FK_BUKU_Part_Evaluation_BUKU_Cours");

                entity.HasOne(d => d.CodeEcoleNavigation)
                    .WithMany(p => p.BukuPartEvaluations)
                    .HasForeignKey(d => d.CodeEcole)
                    .HasConstraintName("FK_BUKU_Part_Evaluation_GLOBAL_Ecole");

                entity.HasOne(d => d.CodePeriodeNavigation)
                    .WithMany(p => p.BukuPartEvaluations)
                    .HasForeignKey(d => d.CodePeriode)
                    .HasConstraintName("FK_BUKU_Part_Evaluation_GLOBAL_Periode_Scolaire");

                entity.HasOne(d => d.CodeTypeEvaluationNavigation)
                    .WithMany(p => p.BukuPartEvaluations)
                    .HasForeignKey(d => d.CodeTypeEvaluation)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Part_Evaluation_Type_Evaluation");
            });

            modelBuilder.Entity<BukuProportionEchecLeger>(entity =>
            {
                entity.HasKey(e => e.CodeEchecLeger);

                entity.ToTable("BUKU_Proportion_Echec_Leger");

                entity.Property(e => e.CodeEchecLeger).HasColumnName("CODE_ECHEC_LEGER");

                entity.Property(e => e.CodeEcole)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_ECOLE");

                entity.Property(e => e.Libelle)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("LIBELLE");

                entity.Property(e => e.Proportion).HasColumnName("PROPORTION");

                entity.Property(e => e.Sync).HasColumnName("SYNC");

                entity.Property(e => e.SyncPush)
                    .HasColumnName("SYNC_PUSH")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<BukuSysCour>(entity =>
            {
                entity.HasKey(e => e.CodeSysCours);

                entity.ToTable("BUKU_SYS_Cours");

                entity.Property(e => e.CodeSysCours)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_SYS_COURS");

                entity.Property(e => e.CodeTypeCours)
                    .HasMaxLength(3)
                    .HasColumnName("CODE_TYPE_COURS")
                    .IsFixedLength(true);

                entity.Property(e => e.EloCodeEcole)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("ELO_CODE_ECOLE");

                entity.Property(e => e.IntituleSysCours)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("INTITULE_SYS_COURS");

                entity.Property(e => e.Priorite).HasColumnName("PRIORITE");

                entity.Property(e => e.Sync).HasColumnName("SYNC");

                entity.Property(e => e.SyncPush)
                    .HasColumnName("SYNC_PUSH")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.EloCodeEcoleNavigation)
                    .WithMany(p => p.BukuSysCours)
                    .HasForeignKey(d => d.EloCodeEcole)
                    .HasConstraintName("FK_BUKU_SYS_Cours_ECOLE");
            });

            modelBuilder.Entity<BukuTypeCour>(entity =>
            {
                entity.HasKey(e => e.CodeTypeCours);

                entity.ToTable("BUKU_Type_Cours");

                entity.Property(e => e.CodeTypeCours)
                    .HasMaxLength(3)
                    .HasColumnName("CODE_TYPE_COURS")
                    .IsFixedLength(true);

                entity.Property(e => e.CodeEcole)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_ECOLE");

                entity.Property(e => e.IntituleTypeCours)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("INTITULE_TYPE_COURS");

                entity.Property(e => e.Sync).HasColumnName("SYNC");

                entity.Property(e => e.SyncPush)
                    .HasColumnName("SYNC_PUSH")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<BukuTypeEvaluation>(entity =>
            {
                entity.HasKey(e => e.CodeTypeEvaluation)
                    .HasName("PK_Type_Note");

                entity.ToTable("BUKU_Type_Evaluation");

                entity.Property(e => e.CodeTypeEvaluation).HasColumnName("CODE_TYPE_EVALUATION");

                entity.Property(e => e.CodeAffClasseAgentCours)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_AFF_CLASSE_AGENT_COURS");

                entity.Property(e => e.EloCodeEcole)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("ELO_CODE_ECOLE");

                entity.Property(e => e.EstExamen).HasColumnName("EST_EXAMEN");

                entity.Property(e => e.IntituleTypeEvaluation)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("INTITULE_TYPE__EVALUATION");

                entity.Property(e => e.Sync).HasColumnName("SYNC");

                entity.Property(e => e.SyncPush)
                    .HasColumnName("SYNC_PUSH")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.CodeAffClasseAgentCoursNavigation)
                    .WithMany(p => p.BukuTypeEvaluations)
                    .HasForeignKey(d => d.CodeAffClasseAgentCours)
                    .HasConstraintName("FK_BUKU_Type_Evaluation_GLOBAL_Affectation_Classe_Agent_Cours");

                entity.HasOne(d => d.EloCodeEcoleNavigation)
                    .WithMany(p => p.BukuTypeEvaluations)
                    .HasForeignKey(d => d.EloCodeEcole)
                    .HasConstraintName("FK_BUKU_Type_Evaluation_GLOBAL_Ecole");
            });

            modelBuilder.Entity<CommService>(entity =>
            {
                entity.HasKey(e => e.CodeService)
                    .HasName("PK__COMM_Ser__AD0ED18E3726238F");

                entity.ToTable("COMM_Service");

                entity.Property(e => e.CodeService)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CODE_SERVICE");

                entity.Property(e => e.CodeEcole)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_ECOLE");

                entity.Property(e => e.CodeServiceMere)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CODE_SERVICE_MERE");

                entity.Property(e => e.IntituleService)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("INTITULE_SERVICE");

                entity.Property(e => e.Sync).HasColumnName("SYNC");

                entity.Property(e => e.SyncPush)
                    .HasColumnName("SYNC_PUSH")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.CodeServiceMereNavigation)
                    .WithMany(p => p.InverseCodeServiceMereNavigation)
                    .HasForeignKey(d => d.CodeServiceMere)
                    .HasConstraintName("FK__COMM_Serv__CODE___390E6C01");
            });

            modelBuilder.Entity<CommSouscription>(entity =>
            {
                entity.HasKey(e => e.CodeSouscription)
                    .HasName("PK__COMM_Sou__84F455A233D4B598");

                entity.ToTable("COMM_Souscription");

                entity.Property(e => e.CodeSouscription)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_SOUSCRIPTION");

                entity.Property(e => e.CodeAgent)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_AGENT");

                entity.Property(e => e.CodeEcole)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_ECOLE");

                entity.Property(e => e.CodeParent)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_PARENT");

                entity.Property(e => e.CodeTarif)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_TARIF");

                entity.Property(e => e.DebutSouscription)
                    .HasColumnType("datetime")
                    .HasColumnName("DEBUT_SOUSCRIPTION");

                entity.Property(e => e.Etat).HasColumnName("ETAT");

                entity.Property(e => e.FinSouscritption)
                    .HasColumnType("datetime")
                    .HasColumnName("FIN_SOUSCRITPTION");

                entity.Property(e => e.MontantDu).HasColumnName("MONTANT_DU");

                entity.Property(e => e.Quantite).HasColumnName("QUANTITE");

                entity.Property(e => e.Sync).HasColumnName("SYNC");

                entity.Property(e => e.SyncPush)
                    .HasColumnName("SYNC_PUSH")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.CodeAgentNavigation)
                    .WithMany(p => p.CommSouscriptions)
                    .HasForeignKey(d => d.CodeAgent)
                    .HasConstraintName("FK__COMM_Sous__CODE___740F363E");

                entity.HasOne(d => d.CodeParentNavigation)
                    .WithMany(p => p.CommSouscriptions)
                    .HasForeignKey(d => d.CodeParent)
                    .HasConstraintName("FK__COMM_Sous__CODE___438BFA74");

                entity.HasOne(d => d.CodeTarifNavigation)
                    .WithMany(p => p.CommSouscriptions)
                    .HasForeignKey(d => d.CodeTarif)
                    .HasConstraintName("FK__COMM_Sous__CODE___457442E6");
            });

            modelBuilder.Entity<CommTarif>(entity =>
            {
                entity.HasKey(e => e.CodeTarif)
                    .HasName("PK__COMM_Tar__1C59DF9F3BEAD8AC");

                entity.ToTable("COMM_Tarif");

                entity.Property(e => e.CodeTarif)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_TARIF");

                entity.Property(e => e.CodeEcole)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_ECOLE");

                entity.Property(e => e.CodePeriodicite)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("CODE_PERIODICITE");

                entity.Property(e => e.CodeService)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CODE_SERVICE");

                entity.Property(e => e.Etat).HasColumnName("ETAT");

                entity.Property(e => e.Montant).HasColumnName("MONTANT");

                entity.Property(e => e.Sync).HasColumnName("SYNC");

                entity.Property(e => e.SyncPush)
                    .HasColumnName("SYNC_PUSH")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.CodePeriodiciteNavigation)
                    .WithMany(p => p.CommTarifs)
                    .HasForeignKey(d => d.CodePeriodicite)
                    .HasConstraintName("FK__COMM_Tari__CODE___3DD3211E");

                entity.HasOne(d => d.CodeServiceNavigation)
                    .WithMany(p => p.CommTarifs)
                    .HasForeignKey(d => d.CodeService)
                    .HasConstraintName("FK__COMM_Tari__CODE___3EC74557");
            });

            modelBuilder.Entity<ComptaClass>(entity =>
            {
                entity.HasKey(e => e.CodeClasseCompta)
                    .HasName("PK_CLASSE_COMPTA");

                entity.ToTable("COMPTA_Classes");

                entity.Property(e => e.CodeClasseCompta)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_CLASSE_COMPTA");

                entity.Property(e => e.CodeEcole)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_ECOLE");

                entity.Property(e => e.CodePlanCompta)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_PLAN_COMPTA");

                entity.Property(e => e.IntituleClasse)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("INTITULE_CLASSE");

                entity.Property(e => e.NumClasse).HasColumnName("NUM_CLASSE");

                entity.Property(e => e.Sync)
                    .HasColumnName("SYNC")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SyncPush)
                    .HasColumnName("SYNC_PUSH")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.CodePlanComptaNavigation)
                    .WithMany(p => p.ComptaClasses)
                    .HasForeignKey(d => d.CodePlanCompta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COMPTA_Classes_COMPTA_Plans_Comptables");
            });

            modelBuilder.Entity<ComptaCompte>(entity =>
            {
                entity.HasKey(e => e.CodeCompte);

                entity.ToTable("COMPTA_Comptes");

                entity.Property(e => e.CodeCompte)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_COMPTE");

                entity.Property(e => e.CodeClasseCompta)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_CLASSE_COMPTA");

                entity.Property(e => e.CodeComptePere)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_COMPTE_PERE");

                entity.Property(e => e.CodeEcole)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_ECOLE");

                entity.Property(e => e.Intitule)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("INTITULE");

                entity.Property(e => e.Sync)
                    .HasColumnName("SYNC")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SyncPush)
                    .HasColumnName("SYNC_PUSH")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.CodeClasseComptaNavigation)
                    .WithMany(p => p.ComptaComptes)
                    .HasForeignKey(d => d.CodeClasseCompta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COMPTA_Comptes_COMPTA_Classes");

                entity.HasOne(d => d.CodeComptePereNavigation)
                    .WithMany(p => p.InverseCodeComptePereNavigation)
                    .HasForeignKey(d => d.CodeComptePere)
                    .HasConstraintName("FK_COMPTA_Comptes_COMPTA_Comptes");
            });

            modelBuilder.Entity<ComptaEcoleClasse>(entity =>
            {
                entity.HasKey(e => e.CodeClasseEcole)
                    .HasName("PK_COMPTA_ECOLE_CLASSE");

                entity.ToTable("COMPTA_Ecole_Classe");

                entity.Property(e => e.CodeClasseEcole)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_CLASSE_ECOLE");

                entity.Property(e => e.CodeAnnee).HasColumnName("CODE_ANNEE");

                entity.Property(e => e.CodeClasseCompta)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_CLASSE_COMPTA");

                entity.Property(e => e.EloCodeEcole)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("ELO_CODE_ECOLE");

                entity.Property(e => e.Sync)
                    .HasColumnName("SYNC")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SyncPush)
                    .HasColumnName("SYNC_PUSH")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.CodeAnneeNavigation)
                    .WithMany(p => p.ComptaEcoleClasses)
                    .HasForeignKey(d => d.CodeAnnee)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COMPTA_Ecole_Classe_PARAM_Annee_Scolaire");

                entity.HasOne(d => d.CodeClasseComptaNavigation)
                    .WithMany(p => p.ComptaEcoleClasses)
                    .HasForeignKey(d => d.CodeClasseCompta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COMPTA_Ecole_Classe_COMPTA_Classes");

                entity.HasOne(d => d.EloCodeEcoleNavigation)
                    .WithMany(p => p.ComptaEcoleClasses)
                    .HasForeignKey(d => d.EloCodeEcole)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COMPTA_Ecole_Classe_GLOBAL_Ecole");
            });

            modelBuilder.Entity<ComptaPlansComptable>(entity =>
            {
                entity.HasKey(e => e.CodePlanCompta)
                    .HasName("PK_COMPTA_PLAN_COMPTABLE");

                entity.ToTable("COMPTA_Plans_Comptables");

                entity.Property(e => e.CodePlanCompta)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_PLAN_COMPTA");

                entity.Property(e => e.CodeEcole)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_ECOLE");

                entity.Property(e => e.IntitulePlanCompta)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("INTITULE_PLAN_COMPTA");

                entity.Property(e => e.Sync)
                    .HasColumnName("SYNC")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SyncPush)
                    .HasColumnName("SYNC_PUSH")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<EteyeloAbsence>(entity =>
            {
                entity.HasKey(e => e.CodeAbsence);

                entity.ToTable("ETEYELO_Absences");

                entity.Property(e => e.CodeAbsence).HasColumnName("CODE_ABSENCE");

                entity.Property(e => e.CodeEcole)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_ECOLE");

                entity.Property(e => e.Date)
                    .HasColumnType("date")
                    .HasColumnName("DATE");

                entity.Property(e => e.EloCodeEleve)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("ELO_CODE_ELEVE");

                entity.Property(e => e.JustificationAbsence)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("JUSTIFICATION_ABSENCE");

                entity.Property(e => e.MotifAbsence)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("MOTIF_ABSENCE");

                entity.Property(e => e.Sync).HasColumnName("SYNC");

                entity.Property(e => e.SyncPush)
                    .HasColumnName("SYNC_PUSH")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.EloCodeEleveNavigation)
                    .WithMany(p => p.EteyeloAbsences)
                    .HasForeignKey(d => d.EloCodeEleve)
                    .HasConstraintName("FK_Absences_INSCRIPTION_Eleve");
            });

            modelBuilder.Entity<EteyeloBulletin>(entity =>
            {
                entity.HasKey(e => e.CodeBulletin)
                    .HasName("PK_BULLETIN");

                entity.ToTable("ETEYELO_Bulletin");

                entity.Property(e => e.CodeBulletin)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_BULLETIN");

                entity.Property(e => e.Application)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("APPLICATION");

                entity.Property(e => e.CodeAnnee).HasColumnName("CODE_ANNEE");

                entity.Property(e => e.CodeEcole)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_ECOLE");

                entity.Property(e => e.CodeLocalClasse)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_LOCAL_CLASSE");

                entity.Property(e => e.Conduite)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("CONDUITE");

                entity.Property(e => e.EloCodeEleve)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("ELO_CODE_ELEVE");

                entity.Property(e => e.EloCodePeriode)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("ELO_CODE_PERIODE");

                entity.Property(e => e.MaximaGen).HasColumnName("MAXIMA_GEN");

                entity.Property(e => e.NbrEleves).HasColumnName("NBR_ELEVES");

                entity.Property(e => e.NotesObtenues)
                    .HasColumnType("text")
                    .HasColumnName("NOTES_OBTENUES");

                entity.Property(e => e.Place).HasColumnName("PLACE");

                entity.Property(e => e.Pourcentage)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("POURCENTAGE");

                entity.Property(e => e.Sanction)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SANCTION");

                entity.Property(e => e.Sync).HasColumnName("SYNC");

                entity.Property(e => e.SyncPush)
                    .HasColumnName("SYNC_PUSH")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TotalNote)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("TOTAL_NOTE");

                entity.HasOne(d => d.CodeAnneeNavigation)
                    .WithMany(p => p.EteyeloBulletins)
                    .HasForeignKey(d => d.CodeAnnee)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_ETEYELO_Bulletin_PARAM_Annee_Scolaire");

                entity.HasOne(d => d.EloCodeEleveNavigation)
                    .WithMany(p => p.EteyeloBulletins)
                    .HasForeignKey(d => d.EloCodeEleve)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_ETEYELO_Bulletin_INSCRIPTION_Eleve");

                entity.HasOne(d => d.EloCodePeriodeNavigation)
                    .WithMany(p => p.EteyeloBulletins)
                    .HasForeignKey(d => d.EloCodePeriode)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_ETEYELO_Bulletin_ETEYELO_Bulletin");
            });

            modelBuilder.Entity<EteyeloCategorieEleve>(entity =>
            {
                entity.HasKey(e => e.CodeCategorie)
                    .HasName("PK_CALASSA_Categorie_Eleve");

                entity.ToTable("ETEYELO_Categorie_Eleve");

                entity.Property(e => e.CodeCategorie)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_CATEGORIE");

                entity.Property(e => e.CodeEcole)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_ECOLE");

                entity.Property(e => e.IntituleCategorie)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("INTITULE_CATEGORIE");

                entity.Property(e => e.Sync).HasColumnName("SYNC");

                entity.Property(e => e.SyncPush)
                    .HasColumnName("SYNC_PUSH")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<EteyeloDocument>(entity =>
            {
                entity.HasKey(e => e.CodeDocument)
                    .HasName("PK_CALASSA_Document");

                entity.ToTable("ETEYELO_Document");

                entity.Property(e => e.CodeDocument)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_DOCUMENT");

                entity.Property(e => e.CodeEcole)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_ECOLE");

                entity.Property(e => e.CodeTypeDocument)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_TYPE_DOCUMENT");

                entity.Property(e => e.DateCreation)
                    .HasColumnType("datetime")
                    .HasColumnName("DATE_CREATION");

                entity.Property(e => e.EloCodeEleve)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("ELO_CODE_ELEVE");

                entity.Property(e => e.FichierDocument).HasColumnName("FICHIER_DOCUMENT");

                entity.Property(e => e.IntituleDocument)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("INTITULE_DOCUMENT");

                entity.Property(e => e.Sync).HasColumnName("SYNC");

                entity.Property(e => e.SyncPush)
                    .HasColumnName("SYNC_PUSH")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.CodeTypeDocumentNavigation)
                    .WithMany(p => p.EteyeloDocuments)
                    .HasForeignKey(d => d.CodeTypeDocument)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CALASSA_Document_CALASSA_Type_Document");

                entity.HasOne(d => d.EloCodeEleveNavigation)
                    .WithMany(p => p.EteyeloDocuments)
                    .HasForeignKey(d => d.EloCodeEleve)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ETEYELO_Document_INSCRIPTION_Eleve");
            });

            modelBuilder.Entity<EteyeloEleveDetail>(entity =>
            {
                entity.HasKey(e => e.CodeEleveDetails)
                    .HasName("PK_CALASSA_ELEVE_DETAILS");

                entity.ToTable("ETEYELO_Eleve_Details");

                entity.Property(e => e.CodeEleveDetails)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_ELEVE_DETAILS");

                entity.Property(e => e.AdresseResidenceParents)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ADRESSE_RESIDENCE_PARENTS");

                entity.Property(e => e.AptitudeIntellectuel)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("APTITUDE_INTELLECTUEL");

                entity.Property(e => e.CE)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("C_E");

                entity.Property(e => e.CodeCategorieEleve)
                    .HasColumnType("text")
                    .HasColumnName("CODE_CATEGORIE_ELEVE");

                entity.Property(e => e.CodeEcole)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_ECOLE");

                entity.Property(e => e.CodeNationalite)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CODE_NATIONALITE");

                entity.Property(e => e.DeuxParentsEnVie).HasColumnName("DEUX_PARENTS_EN_VIE");

                entity.Property(e => e.EloCodeEleve)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("ELO_CODE_ELEVE");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.Empreinte).HasColumnName("EMPREINTE");

                entity.Property(e => e.LienParenteTuteur)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("LIEN_PARENTE_TUTEUR");

                entity.Property(e => e.MaladieFrequente)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("MALADIE_FREQUENTE");

                entity.Property(e => e.MereMort)
                    .HasColumnName("MERE_MORT")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MoyenTransport)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("MOYEN_TRANSPORT");

                entity.Property(e => e.NomMere)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("NOM_MERE");

                entity.Property(e => e.NomPere)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("NOM_PERE");

                entity.Property(e => e.ParentsViventEnsemble).HasColumnName("PARENTS_VIVENT_ENSEMBLE");

                entity.Property(e => e.Paroisse)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("PAROISSE");

                entity.Property(e => e.PereMort).HasColumnName("PERE_MORT");

                entity.Property(e => e.Photo).HasColumnName("PHOTO");

                entity.Property(e => e.ProfessionMere)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("PROFESSION_MERE");

                entity.Property(e => e.ProfessionPere)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("PROFESSION_PERE");

                entity.Property(e => e.ProvinceOrigine)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("PROVINCE_ORIGINE");

                entity.Property(e => e.ReligionPratiquee)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("RELIGION_PRATIQUEE");

                entity.Property(e => e.Sync).HasColumnName("SYNC");

                entity.Property(e => e.SyncPush)
                    .HasColumnName("SYNC_PUSH")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Telephone)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("TELEPHONE");

                entity.Property(e => e.TelephoneMere)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("TELEPHONE_MERE");

                entity.Property(e => e.TelephonePere)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("TELEPHONE_PERE");

                entity.HasOne(d => d.CodeNationaliteNavigation)
                    .WithMany(p => p.EteyeloEleveDetails)
                    .HasForeignKey(d => d.CodeNationalite)
                    .HasConstraintName("FK_ETEYELO_Eleve_Details_PARAM_Entite_Administrative");

                entity.HasOne(d => d.EloCodeEleveNavigation)
                    .WithMany(p => p.EteyeloEleveDetails)
                    .HasForeignKey(d => d.EloCodeEleve)
                    .HasConstraintName("FK_ETEYELO_Eleve_Details_INSCRIPTION_Eleve");
            });

            modelBuilder.Entity<EteyeloMouvementEleve>(entity =>
            {
                entity.HasKey(e => e.CodeMouvement)
                    .HasName("PK_CALASSA_Mouvement_Eleve");

                entity.ToTable("ETEYELO_Mouvement_Eleve");

                entity.Property(e => e.CodeMouvement)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_MOUVEMENT");

                entity.Property(e => e.CodeAnnee).HasColumnName("CODE_ANNEE");

                entity.Property(e => e.CodeEcole)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_ECOLE");

                entity.Property(e => e.CodeTypeMouvement).HasColumnName("CODE_TYPE_MOUVEMENT");

                entity.Property(e => e.DateMouvement)
                    .HasColumnType("datetime")
                    .HasColumnName("DATE_MOUVEMENT");

                entity.Property(e => e.EloCodeEleve)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("ELO_CODE_ELEVE");

                entity.Property(e => e.Motif)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("MOTIF");

                entity.Property(e => e.Sync).HasColumnName("SYNC");

                entity.Property(e => e.SyncPush)
                    .HasColumnName("SYNC_PUSH")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.CodeAnneeNavigation)
                    .WithMany(p => p.EteyeloMouvementEleves)
                    .HasForeignKey(d => d.CodeAnnee)
                    .HasConstraintName("FK_ETEYELO_Mouvement_Eleve_PARAM_Annee_Scolaire");

                entity.HasOne(d => d.CodeEcoleNavigation)
                    .WithMany(p => p.EteyeloMouvementEleves)
                    .HasForeignKey(d => d.CodeEcole)
                    .HasConstraintName("FK_ETEYELO_Mouvement_Eleve_GLOBAL_Ecole");

                entity.HasOne(d => d.CodeTypeMouvementNavigation)
                    .WithMany(p => p.EteyeloMouvementEleves)
                    .HasForeignKey(d => d.CodeTypeMouvement)
                    .HasConstraintName("FK_ETEYELO_Mouvement_Eleve_ETEYELO_Type_Mouvement");

                entity.HasOne(d => d.EloCodeEleveNavigation)
                    .WithMany(p => p.EteyeloMouvementEleves)
                    .HasForeignKey(d => d.EloCodeEleve)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CALASSA_Mouvement_Eleve_CALASSA_Eleve_Details");
            });

            modelBuilder.Entity<EteyeloTypeDocument>(entity =>
            {
                entity.HasKey(e => e.CodeTypeDocument)
                    .HasName("PK_CALASSA_Type_Document");

                entity.ToTable("ETEYELO_Type_Document");

                entity.Property(e => e.CodeTypeDocument)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_TYPE_DOCUMENT");

                entity.Property(e => e.CodeEcole)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_ECOLE");

                entity.Property(e => e.IntituleTypeDocument)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("INTITULE_TYPE_DOCUMENT");

                entity.Property(e => e.Sync).HasColumnName("SYNC");

                entity.Property(e => e.SyncPush)
                    .HasColumnName("SYNC_PUSH")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<EteyeloTypeMouvement>(entity =>
            {
                entity.HasKey(e => e.CodeTypeMouvement);

                entity.ToTable("ETEYELO_Type_Mouvement");

                entity.Property(e => e.CodeTypeMouvement)
                    .ValueGeneratedNever()
                    .HasColumnName("CODE_TYPE_MOUVEMENT");

                entity.Property(e => e.CodeEcole)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_ECOLE");

                entity.Property(e => e.Intitule)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("INTITULE");

                entity.Property(e => e.Sync).HasColumnName("SYNC");

                entity.Property(e => e.SyncPush)
                    .HasColumnName("SYNC_PUSH")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<FinanceBanque>(entity =>
            {
                entity.HasKey(e => e.CodeBanque)
                    .HasName("PK_Finance_Banque");

                entity.ToTable("FINANCE_Banque");

                entity.Property(e => e.CodeBanque)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_BANQUE");

                entity.Property(e => e.CodeEcole)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_ECOLE");

                entity.Property(e => e.CodeSwift)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CODE_SWIFT");

                entity.Property(e => e.EstValide).HasColumnName("EST_VALIDE");

                entity.Property(e => e.IntituleBanque)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("INTITULE_BANQUE");

                entity.Property(e => e.Sync).HasColumnName("SYNC");

                entity.Property(e => e.SyncPush).HasColumnName("SYNC_PUSH");
            });

            modelBuilder.Entity<FinanceCaisse>(entity =>
            {
                entity.HasKey(e => e.CodeCaisse);

                entity.ToTable("FINANCE_Caisse");

                entity.Property(e => e.CodeCaisse)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_CAISSE");

                entity.Property(e => e.Benificiaire)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("BENIFICIAIRE");

                entity.Property(e => e.CodeAnneeScolaire).HasColumnName("CODE_ANNEE_SCOLAIRE");

                entity.Property(e => e.CodeCompte)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_COMPTE");

                entity.Property(e => e.CodeDevise)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_DEVISE");

                entity.Property(e => e.CodeEcole)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_ECOLE");

                entity.Property(e => e.CodePaiement)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_PAIEMENT");

                entity.Property(e => e.CodeTaux)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_TAUX");

                entity.Property(e => e.CodeUtilisateur)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CODE_UTILISATEUR");

                entity.Property(e => e.DateCreation)
                    .HasColumnType("datetime")
                    .HasColumnName("DATE_CREATION");

                entity.Property(e => e.Montant)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("MONTANT");

                entity.Property(e => e.MontantReel)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("MONTANT_REEL");

                entity.Property(e => e.Motif)
                    .IsUnicode(false)
                    .HasColumnName("MOTIF");

                entity.Property(e => e.Operation)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("OPERATION");

                entity.Property(e => e.Signature).HasColumnName("SIGNATURE");

                entity.Property(e => e.Solde)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("SOLDE");

                entity.Property(e => e.SoldeOuverture)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("SOLDE_OUVERTURE");

                entity.Property(e => e.Sync).HasColumnName("SYNC");

                entity.Property(e => e.SyncPush)
                    .HasColumnName("SYNC_PUSH")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.CodeAnneeScolaireNavigation)
                    .WithMany(p => p.FinanceCaisses)
                    .HasForeignKey(d => d.CodeAnneeScolaire)
                    .HasConstraintName("FK_FINANCE_Caisse_PARAM_Annee_Scolaire");

                entity.HasOne(d => d.CodeCompteNavigation)
                    .WithMany(p => p.FinanceCaisses)
                    .HasForeignKey(d => d.CodeCompte)
                    .HasConstraintName("FK_FINANCE_Caisse_PARAM_COMPTE");

                entity.HasOne(d => d.CodeDeviseNavigation)
                    .WithMany(p => p.FinanceCaisses)
                    .HasForeignKey(d => d.CodeDevise)
                    .HasConstraintName("FK_FINANCE_Caisse_PARAM_Devise");

                entity.HasOne(d => d.CodeEcoleNavigation)
                    .WithMany(p => p.FinanceCaisses)
                    .HasForeignKey(d => d.CodeEcole)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_FINANCE_Caisse_GLOBAL_Ecole");

                entity.HasOne(d => d.CodeTauxNavigation)
                    .WithMany(p => p.FinanceCaisses)
                    .HasForeignKey(d => d.CodeTaux)
                    .HasConstraintName("FK_FINANCE_Caisse_PARAM_Taux");

                entity.HasOne(d => d.CodeUtilisateurNavigation)
                    .WithMany(p => p.FinanceCaisses)
                    .HasForeignKey(d => d.CodeUtilisateur)
                    .HasConstraintName("FK_FINANCE_Caisse_MAMBA_Utilisateur");
            });

            modelBuilder.Entity<FinanceCommission>(entity =>
            {
                entity.HasKey(e => e.CodeFinCommission);

                entity.ToTable("FINANCE_Commission");

                entity.Property(e => e.CodeFinCommission)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_FIN_COMMISSION");

                entity.Property(e => e.CodeCommission)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_COMMISSION");

                entity.Property(e => e.CodeEcole)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_ECOLE");

                entity.Property(e => e.CodePaiement)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_PAIEMENT");

                entity.Property(e => e.DateOperation)
                    .HasColumnType("datetime")
                    .HasColumnName("DATE_OPERATION");

                entity.Property(e => e.Sync)
                    .HasColumnName("SYNC")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SyncPush).HasColumnName("SYNC_PUSH");

                entity.Property(e => e.Valeur)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("VALEUR");

                entity.HasOne(d => d.CodeCommissionNavigation)
                    .WithMany(p => p.FinanceCommissions)
                    .HasForeignKey(d => d.CodeCommission)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_FINANCE_Commission_PARAM_Commission");
            });

            modelBuilder.Entity<FinanceCompteBancaire>(entity =>
            {
                entity.HasKey(e => e.CodeCompteBancaire)
                    .HasName("PK_Finance_Compte_Bancaire");

                entity.ToTable("FINANCE_Compte_Bancaire");

                entity.Property(e => e.CodeCompteBancaire)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_COMPTE_BANCAIRE");

                entity.Property(e => e.CodeBanque)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_BANQUE");

                entity.Property(e => e.CodeDevise)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_DEVISE");

                entity.Property(e => e.CodeEcole)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_ECOLE");

                entity.Property(e => e.EstValide).HasColumnName("EST_VALIDE");

                entity.Property(e => e.IntituleCompteBancaire)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("INTITULE_COMPTE_BANCAIRE");

                entity.Property(e => e.NumeroCompte)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NUMERO_COMPTE");

                entity.Property(e => e.Sync).HasColumnName("SYNC");

                entity.Property(e => e.SyncPush).HasColumnName("SYNC_PUSH");

                entity.HasOne(d => d.CodeBanqueNavigation)
                    .WithMany(p => p.FinanceCompteBancaires)
                    .HasForeignKey(d => d.CodeBanque)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Finance_Compte_Bancaire_Finance_Banque");

                entity.HasOne(d => d.CodeDeviseNavigation)
                    .WithMany(p => p.FinanceCompteBancaires)
                    .HasForeignKey(d => d.CodeDevise)
                    .HasConstraintName("FK_Finance_Compte_Bancaire_PARAM_Devise");

                entity.HasOne(d => d.CodeEcoleNavigation)
                    .WithMany(p => p.FinanceCompteBancaires)
                    .HasForeignKey(d => d.CodeEcole)
                    .HasConstraintName("FK_Finance_Compte_Bancaire_GLOBAL_Ecole");
            });

            modelBuilder.Entity<FinanceCompteEleve>(entity =>
            {
                entity.HasKey(e => e.CodeCompteEleve);

                entity.ToTable("FINANCE_Compte_Eleve");

                entity.Property(e => e.CodeCompteEleve)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_COMPTE_ELEVE");

                entity.Property(e => e.CodeAnneeScolaire).HasColumnName("CODE_ANNEE_SCOLAIRE");

                entity.Property(e => e.CodeDevise)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_DEVISE");

                entity.Property(e => e.CodeEcole)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_ECOLE");

                entity.Property(e => e.CodeEleve)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_ELEVE");

                entity.Property(e => e.CodeFrais)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_FRAIS");

                entity.Property(e => e.CodeTaux)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_TAUX");

                entity.Property(e => e.CodeUtilisateur)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CODE_UTILISATEUR");

                entity.Property(e => e.DateCreation)
                    .HasColumnType("datetime")
                    .HasColumnName("DATE_CREATION");

                entity.Property(e => e.Montant)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("MONTANT");

                entity.Property(e => e.MontantReel)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("MONTANT_REEL");

                entity.Property(e => e.Motif)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("MOTIF");

                entity.Property(e => e.Operation)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("OPERATION");

                entity.Property(e => e.Sync).HasColumnName("SYNC");

                entity.Property(e => e.SyncPush).HasColumnName("SYNC_PUSH");

                entity.HasOne(d => d.CodeAnneeScolaireNavigation)
                    .WithMany(p => p.FinanceCompteEleves)
                    .HasForeignKey(d => d.CodeAnneeScolaire)
                    .HasConstraintName("FK_FINANCE_Compte_Eleve_PARAM_Annee_Scolaire");

                entity.HasOne(d => d.CodeDeviseNavigation)
                    .WithMany(p => p.FinanceCompteEleves)
                    .HasForeignKey(d => d.CodeDevise)
                    .HasConstraintName("FK_FINANCE_Compte_Eleve_PARAM_Devise");

                entity.HasOne(d => d.CodeEleveNavigation)
                    .WithMany(p => p.FinanceCompteEleves)
                    .HasForeignKey(d => d.CodeEleve)
                    .HasConstraintName("FK_FINANCE_Compte_Eleve_INSCRIPTION_Eleve");

                entity.HasOne(d => d.CodeFraisNavigation)
                    .WithMany(p => p.FinanceCompteEleves)
                    .HasForeignKey(d => d.CodeFrais)
                    .HasConstraintName("FK_FINANCE_Compte_Eleve_FINANCE_Frais");

                entity.HasOne(d => d.CodeUtilisateurNavigation)
                    .WithMany(p => p.FinanceCompteEleves)
                    .HasForeignKey(d => d.CodeUtilisateur)
                    .HasConstraintName("FK_FINANCE_Compte_Eleve_MAMBA_Utilisateur");
            });

            modelBuilder.Entity<FinanceCompteFrai>(entity =>
            {
                entity.HasKey(e => e.CodeCompteFrais)
                    .HasName("PK_FINANCE_Compte_Frais_");

                entity.ToTable("FINANCE_Compte_Frais");

                entity.Property(e => e.CodeCompteFrais)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_COMPTE_FRAIS");

                entity.Property(e => e.CodeAnneeScolaire).HasColumnName("CODE_ANNEE_SCOLAIRE");

                entity.Property(e => e.CodeCompte)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_COMPTE");

                entity.Property(e => e.CodeEcole)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_ECOLE");

                entity.Property(e => e.CodeFrais)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_FRAIS");

                entity.Property(e => e.DateAffectation)
                    .HasColumnType("datetime")
                    .HasColumnName("DATE_AFFECTATION")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EstActif).HasColumnName("EST_ACTIF");

                entity.Property(e => e.PartPourcentage)
                    .HasColumnType("decimal(18, 7)")
                    .HasColumnName("PART_POURCENTAGE");

                entity.Property(e => e.Sync).HasColumnName("SYNC");

                entity.Property(e => e.SyncPush)
                    .HasColumnName("SYNC_PUSH")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.CodeAnneeScolaireNavigation)
                    .WithMany(p => p.FinanceCompteFrais)
                    .HasForeignKey(d => d.CodeAnneeScolaire)
                    .HasConstraintName("FK_FINANCE_Compte_Type_Frais_PARAM_Annee_Scolaire_");

                entity.HasOne(d => d.CodeCompteNavigation)
                    .WithMany(p => p.FinanceCompteFrais)
                    .HasForeignKey(d => d.CodeCompte)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FINANCE_Compte_Frais_PARAM_Compte_");

                entity.HasOne(d => d.CodeFraisNavigation)
                    .WithMany(p => p.FinanceCompteFrais)
                    .HasForeignKey(d => d.CodeFrais)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FINANCE_Compte_Frais_FINANCE_Frais_");
            });

            modelBuilder.Entity<FinanceComptePaiement>(entity =>
            {
                entity.HasKey(e => e.Code)
                    .HasName("PK_FINANCE_COMPTE_PAIEMENT");

                entity.ToTable("FINANCE_Compte_Paiement");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .HasColumnName("CODE");

                entity.Property(e => e.CodeAnneeScolaire)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("CODE_ANNEE_SCOLAIRE");

                entity.Property(e => e.CodeDevise)
                    .HasMaxLength(50)
                    .HasColumnName("CODE_DEVISE");

                entity.Property(e => e.CodeEcole)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("CODE_ECOLE");

                entity.Property(e => e.CodeEleve)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("CODE_ELEVE");

                entity.Property(e => e.CodeTaux)
                    .HasMaxLength(50)
                    .HasColumnName("CODE_TAUX");

                entity.Property(e => e.CodeTypeFrais)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("CODE_TYPE_FRAIS");

                entity.Property(e => e.DatePaiement)
                    .HasColumnType("datetime")
                    .HasColumnName("DATE_PAIEMENT");

                entity.Property(e => e.MontantPaye).HasColumnName("MONTANT_PAYE");

                entity.Property(e => e.MontantReelPaye).HasColumnName("MONTANT_REEL_PAYE");
            });

            modelBuilder.Entity<FinanceCompteTypeFrai>(entity =>
            {
                entity.HasKey(e => e.CodeCompteTypeFrais)
                    .HasName("PK_FINANCE_Compte_Frais");

                entity.ToTable("FINANCE_Compte_Type_Frais");

                entity.Property(e => e.CodeCompteTypeFrais)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_COMPTE_TYPE_FRAIS");

                entity.Property(e => e.CodeAnneeScolaire).HasColumnName("CODE_ANNEE_SCOLAIRE");

                entity.Property(e => e.CodeCompte)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_COMPTE");

                entity.Property(e => e.CodeEcole)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_ECOLE");

                entity.Property(e => e.CodeTypeFrais)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_TYPE_FRAIS");

                entity.Property(e => e.DateAffectation)
                    .HasColumnType("datetime")
                    .HasColumnName("DATE_AFFECTATION")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EstActif).HasColumnName("EST_ACTIF");

                entity.Property(e => e.PartPourcentage)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("PART_POURCENTAGE");

                entity.Property(e => e.Sync).HasColumnName("SYNC");

                entity.Property(e => e.SyncPush)
                    .HasColumnName("SYNC_PUSH")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.CodeAnneeScolaireNavigation)
                    .WithMany(p => p.FinanceCompteTypeFrais)
                    .HasForeignKey(d => d.CodeAnneeScolaire)
                    .HasConstraintName("FK_FINANCE_Compte_Type_Frais_PARAM_Annee_Scolaire");

                entity.HasOne(d => d.CodeCompteNavigation)
                    .WithMany(p => p.FinanceCompteTypeFrais)
                    .HasForeignKey(d => d.CodeCompte)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FINANCE_Compte_Frais_PARAM_Compte");

                entity.HasOne(d => d.CodeTypeFraisNavigation)
                    .WithMany(p => p.FinanceCompteTypeFrais)
                    .HasForeignKey(d => d.CodeTypeFrais)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FINANCE_Compte_Frais_PARAM_Type_Frais");
            });

            modelBuilder.Entity<FinanceFacturier>(entity =>
            {
                entity.HasKey(e => e.CodeFacturier);

                entity.ToTable("FINANCE_Facturier");

                entity.HasIndex(e => e.NumeroFacturier, "UNIQUE_FACTURIER")
                    .IsUnique();

                entity.Property(e => e.CodeFacturier)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_FACTURIER");

                entity.Property(e => e.CodeAnneeScolaire)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_ANNEE_SCOLAIRE");

                entity.Property(e => e.CodeFrais)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_FRAIS");

                entity.Property(e => e.EloCodeEleve)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("ELO_CODE_ELEVE");

                entity.Property(e => e.NumeroFacturier)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("NUMERO_FACTURIER");

                entity.Property(e => e.Sync).HasColumnName("SYNC");

                entity.Property(e => e.SyncPush).HasColumnName("SYNC_PUSH");

                entity.HasOne(d => d.EloCodeEleveNavigation)
                    .WithMany(p => p.FinanceFacturiers)
                    .HasForeignKey(d => d.EloCodeEleve)
                    .HasConstraintName("FK_FINANCE_Facturier_INSCRIPTION_Eleve");
            });

            modelBuilder.Entity<FinanceFrai>(entity =>
            {
                entity.HasKey(e => e.CodeFrais)
                    .HasName("PK_FINCAS_Frais");

                entity.ToTable("FINANCE_Frais");

                entity.Property(e => e.CodeFrais)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_FRAIS");

                entity.Property(e => e.CodeAnneeScolaire).HasColumnName("CODE_ANNEE_SCOLAIRE");

                entity.Property(e => e.CodeArticle)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_ARTICLE");

                entity.Property(e => e.CodeCategorie)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_CATEGORIE");

                entity.Property(e => e.CodeClasse)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_CLASSE");

                entity.Property(e => e.CodePk)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_PK");

                entity.Property(e => e.CodeTypeFrais)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_TYPE_FRAIS");

                entity.Property(e => e.DateCreation)
                    .HasColumnType("datetime")
                    .HasColumnName("DATE_CREATION")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DebutPaiement)
                    .HasColumnType("date")
                    .HasColumnName("DEBUT_PAIEMENT");

                entity.Property(e => e.EloCodeEcole)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("ELO_CODE_ECOLE");

                entity.Property(e => e.EstActif)
                    .HasColumnName("EST_ACTIF")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.EstPayableMultiple)
                    .HasColumnName("EST_PAYABLE_MULTIPLE")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FinPaiement)
                    .HasColumnType("date")
                    .HasColumnName("FIN_PAIEMENT");

                entity.Property(e => e.IntituleFrais)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("INTITULE_FRAIS");

                entity.Property(e => e.MontantAPayer).HasColumnName("MONTANT_A_PAYER");

                entity.Property(e => e.RetardPaiement)
                    .HasColumnType("date")
                    .HasColumnName("RETARD_PAIEMENT");

                entity.Property(e => e.Sync).HasColumnName("SYNC");

                entity.Property(e => e.SyncPush)
                    .HasColumnName("SYNC_PUSH")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.CodeAnneeScolaireNavigation)
                    .WithMany(p => p.FinanceFrais)
                    .HasForeignKey(d => d.CodeAnneeScolaire)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FINANCE_Frais_PARAM_Annee_Scolaire");

                entity.HasOne(d => d.CodeCategorieNavigation)
                    .WithMany(p => p.FinanceFrais)
                    .HasForeignKey(d => d.CodeCategorie)
                    .HasConstraintName("FK_FINANCE_Frais_ETEYELO_Categorie_Eleve");

                entity.HasOne(d => d.CodeClasseNavigation)
                    .WithMany(p => p.FinanceFrais)
                    .HasForeignKey(d => d.CodeClasse)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FINANCE_Frais_GLOBAL_Classe");

                entity.HasOne(d => d.CodeTypeFraisNavigation)
                    .WithMany(p => p.FinanceFrais)
                    .HasForeignKey(d => d.CodeTypeFrais)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FINCAS_Frais_FINCAS_Type_Frais");

                entity.HasOne(d => d.EloCodeEcoleNavigation)
                    .WithMany(p => p.FinanceFrais)
                    .HasForeignKey(d => d.EloCodeEcole)
                    .HasConstraintName("FK_FINANCE_Frais_GLOBAL_Ecole");
            });

            modelBuilder.Entity<FinanceFraisRegime>(entity =>
            {
                entity.HasKey(e => e.CodeFraisClasseRegime);

                entity.ToTable("FINANCE_Frais_Regime");

                entity.Property(e => e.CodeFraisClasseRegime)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_FRAIS_CLASSE_REGIME");

                entity.Property(e => e.CodeClasse)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_CLASSE");

                entity.Property(e => e.CodeEcole)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_ECOLE");

                entity.Property(e => e.CodeFrais)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_FRAIS");

                entity.Property(e => e.CodeRegimePaiement)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_REGIME_PAIEMENT");

                entity.Property(e => e.EstValide).HasColumnName("EST_VALIDE");

                entity.Property(e => e.Sync).HasColumnName("SYNC");

                entity.Property(e => e.SyncPush).HasColumnName("SYNC_PUSH");

                entity.HasOne(d => d.CodeClasseNavigation)
                    .WithMany(p => p.FinanceFraisRegimes)
                    .HasForeignKey(d => d.CodeClasse)
                    .HasConstraintName("FK_FINANCE_Frais_Regime_GLOBAL_Classe");

                entity.HasOne(d => d.CodeFraisNavigation)
                    .WithMany(p => p.FinanceFraisRegimes)
                    .HasForeignKey(d => d.CodeFrais)
                    .HasConstraintName("FK_FINANCE_Frais_Regime_FINANCE_Frais");

                entity.HasOne(d => d.CodeRegimePaiementNavigation)
                    .WithMany(p => p.FinanceFraisRegimes)
                    .HasForeignKey(d => d.CodeRegimePaiement)
                    .HasConstraintName("FK_FINANCE_Frais_Regime_PARAM_Regime_Paiement");
            });

            modelBuilder.Entity<FinancePaiement>(entity =>
            {
                entity.HasKey(e => e.CodePaiement)
                    .HasName("PK_FINCAS_PAIEMENT");

                entity.ToTable("FINANCE_Paiement");

                entity.Property(e => e.CodePaiement)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_PAIEMENT");

                entity.Property(e => e.CodeAnneeScolaire).HasColumnName("CODE_ANNEE_SCOLAIRE");

                entity.Property(e => e.CodeCompteBancaire)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_COMPTE_BANCAIRE");

                entity.Property(e => e.CodeDevise)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_DEVISE");

                entity.Property(e => e.CodeEcole)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_ECOLE");

                entity.Property(e => e.CodeFrais)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_FRAIS");

                entity.Property(e => e.CodeModePaiement)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_MODE_PAIEMENT");

                entity.Property(e => e.CodeRegimePaiement)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_REGIME_PAIEMENT");

                entity.Property(e => e.CodeStatut)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_STATUT");

                entity.Property(e => e.CodeTaux)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_TAUX");

                entity.Property(e => e.CodeUtilisateur)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CODE_UTILISATEUR");

                entity.Property(e => e.DatePaiement)
                    .HasColumnType("datetime")
                    .HasColumnName("DATE_PAIEMENT");

                entity.Property(e => e.EloCodeEleve)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("ELO_CODE_ELEVE");

                entity.Property(e => e.EstImprime).HasColumnName("EST_IMPRIME");

                entity.Property(e => e.EstValide).HasColumnName("EST_VALIDE");

                entity.Property(e => e.MontantPaye).HasColumnName("MONTANT_PAYE");

                entity.Property(e => e.MontantReelPaye).HasColumnName("MONTANT_REEL_PAYE");

                entity.Property(e => e.NumeroBordereau)
                    .HasMaxLength(175)
                    .IsUnicode(false)
                    .HasColumnName("NUMERO_BORDEREAU");

                entity.Property(e => e.NumeroRecu)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("NUMERO_RECU");

                entity.Property(e => e.Observation)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("OBSERVATION");

                entity.Property(e => e.Porteur)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PORTEUR");

                entity.Property(e => e.RelationAvecPorteur)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RELATION_AVEC_PORTEUR");

                entity.Property(e => e.Sync).HasColumnName("SYNC");

                entity.Property(e => e.SyncPush)
                    .HasColumnName("SYNC_PUSH")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.CodeAnneeScolaireNavigation)
                    .WithMany(p => p.FinancePaiements)
                    .HasForeignKey(d => d.CodeAnneeScolaire)
                    .HasConstraintName("FK_FINANCE_Paiement_PARAM_Annee_Scolaire");

                entity.HasOne(d => d.CodeEcoleNavigation)
                    .WithMany(p => p.FinancePaiements)
                    .HasForeignKey(d => d.CodeEcole)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_FINANCE_Paiement_GLOBAL_Ecole");

                entity.HasOne(d => d.CodeModePaiementNavigation)
                    .WithMany(p => p.FinancePaiements)
                    .HasForeignKey(d => d.CodeModePaiement)
                    .HasConstraintName("FK_FINANCE_Paiement_PARAM_Mode_Paiement");

                entity.HasOne(d => d.CodeRegimePaiementNavigation)
                    .WithMany(p => p.FinancePaiements)
                    .HasForeignKey(d => d.CodeRegimePaiement)
                    .HasConstraintName("FK_FINANCE_Paiement_PARAM_Regime_Paiement");

                entity.HasOne(d => d.CodeTauxNavigation)
                    .WithMany(p => p.FinancePaiements)
                    .HasForeignKey(d => d.CodeTaux)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_FINCAS_Paiement_PARAM_Taux");

                entity.HasOne(d => d.CodeUtilisateurNavigation)
                    .WithMany(p => p.FinancePaiements)
                    .HasForeignKey(d => d.CodeUtilisateur)
                    .HasConstraintName("FK_FINANCE_Paiement_MAMBA_Utilisateur");

                entity.HasOne(d => d.EloCodeEleveNavigation)
                    .WithMany(p => p.FinancePaiements)
                    .HasForeignKey(d => d.EloCodeEleve)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FINCAS_Paiement_INSCRIPTION_Eleve");
            });

            modelBuilder.Entity<FinancePaiementOnline>(entity =>
            {
                entity.HasKey(e => e.CodePaimentOnline);

                entity.ToTable("FINANCE_Paiement_Online");

                entity.Property(e => e.CodePaimentOnline)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_PAIMENT_ONLINE");

                entity.Property(e => e.CodeEcole)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_ECOLE");

                entity.Property(e => e.CodePaiement)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_PAIEMENT");

                entity.Property(e => e.EstEffectif).HasColumnName("EST_EFFECTIF");

                entity.Property(e => e.Fournisseur)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("FOURNISSEUR");

                entity.Property(e => e.InfosPaiement)
                    .HasColumnType("text")
                    .HasColumnName("INFOS_PAIEMENT");
            });

            modelBuilder.Entity<FinanceSituation>(entity =>
            {
                entity.HasKey(e => e.CodeSituation)
                    .HasName("PK_FINCAS_Situation");

                entity.ToTable("FINANCE_Situation");

                entity.Property(e => e.CodeSituation)
                    .ValueGeneratedNever()
                    .HasColumnName("CODE_SITUATION");

                entity.Property(e => e.CodeEcole)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_ECOLE");

                entity.Property(e => e.CodeFrais)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_FRAIS");

                entity.Property(e => e.DateMaj)
                    .HasColumnType("date")
                    .HasColumnName("DATE_MAJ");

                entity.Property(e => e.EloCodeEleve)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("ELO_CODE_ELEVE");

                entity.Property(e => e.EstSolde).HasColumnName("EST_SOLDE");

                entity.Property(e => e.MontantDu).HasColumnName("MONTANT_DU");

                entity.Property(e => e.MontantPaye).HasColumnName("MONTANT_PAYE");

                entity.Property(e => e.Sync).HasColumnName("SYNC");

                entity.Property(e => e.SyncPush)
                    .HasColumnName("SYNC_PUSH")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.EloCodeEleveNavigation)
                    .WithMany(p => p.FinanceSituations)
                    .HasForeignKey(d => d.EloCodeEleve)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FINCAS_Situation_INSCRIPTION_Eleve");
            });

            modelBuilder.Entity<GlobalAdresse>(entity =>
            {
                entity.HasKey(e => e.EloCodeAdresse)
                    .HasName("PK_ADRESSE");

                entity.ToTable("GLOBAL_Adresse");

                entity.Property(e => e.EloCodeAdresse)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("ELO_CODE_ADRESSE");

                entity.Property(e => e.CodeEcole)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_ECOLE");

                entity.Property(e => e.Intitule)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("INTITULE");

                entity.Property(e => e.Sync).HasColumnName("SYNC");

                entity.Property(e => e.SyncPush)
                    .HasColumnName("SYNC_PUSH")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Ville)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("VILLE");

                entity.HasOne(d => d.VilleNavigation)
                    .WithMany(p => p.GlobalAdresses)
                    .HasForeignKey(d => d.Ville)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ADRESSE_ENTITE_ADMINISTRATIVE");
            });

            modelBuilder.Entity<GlobalAffectationAdresse>(entity =>
            {
                entity.HasKey(e => e.EloCodeAffAdresse);

                entity.ToTable("GLOBAL_Affectation_Adresse");

                entity.Property(e => e.EloCodeAffAdresse)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("ELO_CODE_AFF_ADRESSE");

                entity.Property(e => e.EloCodeAdresse)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("ELO_CODE_ADRESSE");

                entity.Property(e => e.EloCodeAgent)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("ELO_CODE_AGENT");

                entity.Property(e => e.EloCodeEcole)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("ELO_CODE_ECOLE");

                entity.Property(e => e.EloCodeEleve)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("ELO_CODE_ELEVE");

                entity.Property(e => e.EstActif)
                    .IsRequired()
                    .HasColumnName("EST_ACTIF")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Sync).HasColumnName("SYNC");

                entity.Property(e => e.SyncPush)
                    .HasColumnName("SYNC_PUSH")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.EloCodeAdresseNavigation)
                    .WithMany(p => p.GlobalAffectationAdresses)
                    .HasForeignKey(d => d.EloCodeAdresse)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GLOBAL_Affectation_Adresse_GLOBAL_Adresse");

                entity.HasOne(d => d.EloCodeAgentNavigation)
                    .WithMany(p => p.GlobalAffectationAdresses)
                    .HasForeignKey(d => d.EloCodeAgent)
                    .HasConstraintName("FK_GLOBAL_Affectation_Adresse_PARAM_Enseignant");

                entity.HasOne(d => d.EloCodeEcoleNavigation)
                    .WithMany(p => p.GlobalAffectationAdresses)
                    .HasForeignKey(d => d.EloCodeEcole)
                    .HasConstraintName("FK_GLOBAL_Affectation_Adresse_GLOBAL_Ecole");

                entity.HasOne(d => d.EloCodeEleveNavigation)
                    .WithMany(p => p.GlobalAffectationAdresses)
                    .HasForeignKey(d => d.EloCodeEleve)
                    .HasConstraintName("FK_GLOBAL_Affectation_Adresse_INSCRIPTION_Eleve");
            });

            modelBuilder.Entity<GlobalAffectationClasseAgentCour>(entity =>
            {
                entity.HasKey(e => e.CodeAffClasseAgentCours)
                    .HasName("PK_GLOBAL_Affectation_Classe_Agent");

                entity.ToTable("GLOBAL_Affectation_Classe_Agent_Cours");

                entity.Property(e => e.CodeAffClasseAgentCours)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_AFF_CLASSE_AGENT_COURS");

                entity.Property(e => e.CodeAffectationLocalClasse)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_AFFECTATION_LOCAL_CLASSE");

                entity.Property(e => e.CodeAnneeScolaire).HasColumnName("CODE_ANNEE_SCOLAIRE");

                entity.Property(e => e.CodeCours)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_COURS");

                entity.Property(e => e.DateCreation)
                    .HasColumnType("datetime")
                    .HasColumnName("DATE_CREATION");

                entity.Property(e => e.EloCodeAgent)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("ELO_CODE_AGENT");

                entity.Property(e => e.EloCodeEcole)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("ELO_CODE_ECOLE");

                entity.Property(e => e.EstActif).HasColumnName("EST_ACTIF");

                entity.Property(e => e.Sync).HasColumnName("SYNC");

                entity.Property(e => e.SyncPush)
                    .HasColumnName("SYNC_PUSH")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.CodeAffectationLocalClasseNavigation)
                    .WithMany(p => p.GlobalAffectationClasseAgentCours)
                    .HasForeignKey(d => d.CodeAffectationLocalClasse)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Affectation_Classe_Agent__Local_Classe");

                entity.HasOne(d => d.CodeAnneeScolaireNavigation)
                    .WithMany(p => p.GlobalAffectationClasseAgentCours)
                    .HasForeignKey(d => d.CodeAnneeScolaire)
                    .HasConstraintName("FK_GLOBAL_Affectation_Classe_Agent_Cours_PARAM_Annee_Scolaire");

                entity.HasOne(d => d.CodeCoursNavigation)
                    .WithMany(p => p.GlobalAffectationClasseAgentCours)
                    .HasForeignKey(d => d.CodeCours)
                    .HasConstraintName("FK_GLOBAL_Affectation_Classe_Agent_BUKU_Cours");

                entity.HasOne(d => d.EloCodeAgentNavigation)
                    .WithMany(p => p.GlobalAffectationClasseAgentCours)
                    .HasForeignKey(d => d.EloCodeAgent)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_GLOBAL_Affectation_Classe_Agent_GLOBAL_Agent");

                entity.HasOne(d => d.EloCodeEcoleNavigation)
                    .WithMany(p => p.GlobalAffectationClasseAgentCours)
                    .HasForeignKey(d => d.EloCodeEcole)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_GLOBAL_Affectation_Classe_Agent_Cours_GLOBAL_Ecole");
            });

            modelBuilder.Entity<GlobalAffectationLocalClasse>(entity =>
            {
                entity.HasKey(e => e.CodeAffectationLocalClass);

                entity.ToTable("GLOBAL_Affectation_Local_Classe");

                entity.Property(e => e.CodeAffectationLocalClass)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_AFFECTATION_LOCAL_CLASS");

                entity.Property(e => e.CodeAnneeScolaire).HasColumnName("CODE_ANNEE_SCOLAIRE");

                entity.Property(e => e.CodeClasse)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_CLASSE");

                entity.Property(e => e.CodeLocal)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_LOCAL");

                entity.Property(e => e.EloCodeEcole)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("ELO_CODE_ECOLE");

                entity.Property(e => e.EstActif).HasColumnName("EST_ACTIF");

                entity.Property(e => e.Intitule)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("INTITULE");

                entity.Property(e => e.IntituleCourt)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("INTITULE_COURT");

                entity.Property(e => e.Sync).HasColumnName("SYNC");

                entity.Property(e => e.SyncPush)
                    .HasColumnName("SYNC_PUSH")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.CodeAnneeScolaireNavigation)
                    .WithMany(p => p.GlobalAffectationLocalClasses)
                    .HasForeignKey(d => d.CodeAnneeScolaire)
                    .HasConstraintName("FK_GLOBAL_Affectation_Local_Classe_PARAM_Annee_Scolaire");

                entity.HasOne(d => d.CodeClasseNavigation)
                    .WithMany(p => p.GlobalAffectationLocalClasses)
                    .HasForeignKey(d => d.CodeClasse)
                    .HasConstraintName("FK_GLOBAL_Affectation_Local_Classe_GLOBAL_Classe1");

                entity.HasOne(d => d.CodeLocalNavigation)
                    .WithMany(p => p.GlobalAffectationLocalClasses)
                    .HasForeignKey(d => d.CodeLocal)
                    .HasConstraintName("FK_GLOBAL_Affectation_Local_Classe_GLOBAL_Classe");

                entity.HasOne(d => d.EloCodeEcoleNavigation)
                    .WithMany(p => p.GlobalAffectationLocalClasses)
                    .HasForeignKey(d => d.EloCodeEcole)
                    .HasConstraintName("FK_GLOBAL_Affectation_Local_Classe_GLOBAL_Ecole");
            });

            modelBuilder.Entity<GlobalAgent>(entity =>
            {
                entity.HasKey(e => e.EloCodeAgent)
                    .HasName("PK_PARAM_ENSEIGNANT");

                entity.ToTable("GLOBAL_Agent");

                entity.Property(e => e.EloCodeAgent)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("ELO_CODE_AGENT");

                entity.Property(e => e.CodeEcole)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_ECOLE");

                entity.Property(e => e.CodeNationalite)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CODE_NATIONALITE");

                entity.Property(e => e.DateNaissance)
                    .HasColumnType("date")
                    .HasColumnName("DATE_NAISSANCE");

                entity.Property(e => e.Email)
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.Empreinte).HasColumnName("EMPREINTE");

                entity.Property(e => e.Grade)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GRADE");

                entity.Property(e => e.LieuNaissance)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("LIEU_NAISSANCE");

                entity.Property(e => e.Nom)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("NOM");

                entity.Property(e => e.Photo).HasColumnName("PHOTO");

                entity.Property(e => e.Postnom)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("POSTNOM");

                entity.Property(e => e.Prenom)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PRENOM");

                entity.Property(e => e.ProvinceOrigine)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("PROVINCE_ORIGINE");

                entity.Property(e => e.Sexe)
                    .HasMaxLength(1)
                    .HasColumnName("SEXE")
                    .IsFixedLength(true);

                entity.Property(e => e.Sync).HasColumnName("SYNC");

                entity.Property(e => e.SyncPush)
                    .HasColumnName("SYNC_PUSH")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Telephone)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("TELEPHONE");

                entity.HasOne(d => d.CodeNationaliteNavigation)
                    .WithMany(p => p.GlobalAgents)
                    .HasForeignKey(d => d.CodeNationalite)
                    .HasConstraintName("FK_GLOBAL_Agent_PARAM_Entite_Administrative");
            });

            modelBuilder.Entity<GlobalClasse>(entity =>
            {
                entity.HasKey(e => e.CodeClasse)
                    .HasName("PK_INSCRIPTION_CLASSE");

                entity.ToTable("GLOBAL_Classe");

                entity.Property(e => e.CodeClasse)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_CLASSE");

                entity.Property(e => e.CodeEcole)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_ECOLE");

                entity.Property(e => e.CodeFiliere)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_FILIERE");

                entity.Property(e => e.CodeTypeEcole).HasColumnName("CODE_TYPE_ECOLE");

                entity.Property(e => e.IntituleClasse)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("INTITULE_CLASSE");

                entity.Property(e => e.IntituleClasseCourt)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("INTITULE_CLASSE_COURT");

                entity.Property(e => e.Sync).HasColumnName("SYNC");

                entity.Property(e => e.SyncPush)
                    .HasColumnName("SYNC_PUSH")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SysClasse)
                    .IsRequired()
                    .HasMaxLength(7)
                    .HasColumnName("SYS_CLASSE")
                    .IsFixedLength(true);

                entity.HasOne(d => d.CodeEcoleNavigation)
                    .WithMany(p => p.GlobalClasses)
                    .HasForeignKey(d => d.CodeEcole)
                    .HasConstraintName("FK_GLOBAL_Classe_GLOBAL_Ecole");

                entity.HasOne(d => d.CodeFiliereNavigation)
                    .WithMany(p => p.GlobalClasses)
                    .HasForeignKey(d => d.CodeFiliere)
                    .HasConstraintName("FK_GLOBAL_Classe_GLOBAL_Filiere");

                entity.HasOne(d => d.SysClasseNavigation)
                    .WithMany(p => p.GlobalClasses)
                    .HasForeignKey(d => d.SysClasse)
                    .HasConstraintName("FK_GLOBAL_Classe_GLOBAL_SYS_Classe");
            });

            modelBuilder.Entity<GlobalCommunique>(entity =>
            {
                entity.HasKey(e => e.CodeCommunique);

                entity.ToTable("GLOBAL_Communique");

                entity.Property(e => e.CodeCommunique)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_COMMUNIQUE");

                entity.Property(e => e.CodeClasse)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_CLASSE");

                entity.Property(e => e.CodeEcole)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_ECOLE");

                entity.Property(e => e.CodeTypeComm).HasColumnName("CODE_TYPE_COMM");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasColumnName("DATE");

                entity.Property(e => e.EloCodeEleve)
                    .HasMaxLength(50)
                    .HasColumnName("ELO_CODE_ELEVE");

                entity.Property(e => e.Message)
                    .IsUnicode(false)
                    .HasColumnName("MESSAGE");

                entity.Property(e => e.Objet)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("OBJET");

                entity.Property(e => e.Sync).HasColumnName("SYNC");

                entity.Property(e => e.SyncPush)
                    .HasColumnName("SYNC_PUSH")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.CodeClasseNavigation)
                    .WithMany(p => p.GlobalCommuniques)
                    .HasForeignKey(d => d.CodeClasse)
                    .HasConstraintName("FK_GLOBAL_Communique_GLOBAL_Classe");

                entity.HasOne(d => d.CodeEcoleNavigation)
                    .WithMany(p => p.GlobalCommuniques)
                    .HasForeignKey(d => d.CodeEcole)
                    .HasConstraintName("FK_GLOBAL_Communique_GLOBAL_Ecole");

                entity.HasOne(d => d.CodeTypeCommNavigation)
                    .WithMany(p => p.GlobalCommuniques)
                    .HasForeignKey(d => d.CodeTypeComm)
                    .HasConstraintName("FK_GLOBAL_Communique_PARAM_Type_Communique");
            });

            modelBuilder.Entity<GlobalDegreClasse>(entity =>
            {
                entity.HasKey(e => e.CodeDegreClasse);

                entity.ToTable("GLOBAL_Degre_Classe");

                entity.Property(e => e.CodeDegreClasse).HasColumnName("CODE_DEGRE_CLASSE");

                entity.Property(e => e.ClasseOrientation).HasColumnName("CLASSE_ORIENTATION");

                entity.Property(e => e.CodeEcole)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_ECOLE");

                entity.Property(e => e.IntituleDegreClasse)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("INTITULE_DEGRE_CLASSE");

                entity.Property(e => e.Sync).HasColumnName("SYNC");

                entity.Property(e => e.SyncPush)
                    .HasColumnName("SYNC_PUSH")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<GlobalEcole>(entity =>
            {
                entity.HasKey(e => e.EloCodeEcole)
                    .HasName("PK_ECOLE");

                entity.ToTable("GLOBAL_Ecole");

                entity.Property(e => e.EloCodeEcole)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("ELO_CODE_ECOLE");

                entity.Property(e => e.CodeAntenne)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("CODE_ANTENNE");

                entity.Property(e => e.CodeEcoleMere)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_ECOLE_MERE");

                entity.Property(e => e.CodePays)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("CODE_PAYS");

                entity.Property(e => e.CodeReseauEnseignement).HasColumnName("CODE_RESEAU_ENSEIGNEMENT");

                entity.Property(e => e.CodeSysScolaire)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_SYS_SCOLAIRE");

                entity.Property(e => e.CodeTypeEcole).HasColumnName("CODE_TYPE_ECOLE");

                entity.Property(e => e.ConString).HasColumnName("CON_STRING");

                entity.Property(e => e.Domaine)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("DOMAINE");

                entity.Property(e => e.EloCodeEcoleCourt)
                    .HasMaxLength(10)
                    .HasColumnName("ELO_CODE_ECOLE_COURT")
                    .IsFixedLength(true);

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.EstSuperieure)
                    .HasColumnName("EST_SUPERIEURE")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Logo).HasColumnName("LOGO");

                entity.Property(e => e.NomEcole)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("NOM_ECOLE");

                entity.Property(e => e.NomEcoleCourt)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("NOM_ECOLE_COURT");

                entity.Property(e => e.NumeroSernie)
                    .HasMaxLength(13)
                    .HasColumnName("NUMERO_SERNIE")
                    .IsFixedLength(true);

                entity.Property(e => e.Prefixe)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PREFIXE");

                entity.Property(e => e.ProfilEcole)
                    .HasColumnType("text")
                    .HasColumnName("PROFIL_ECOLE");

                entity.Property(e => e.Sceau).HasColumnName("SCEAU");

                entity.Property(e => e.Signatures)
                    .HasColumnType("text")
                    .HasColumnName("SIGNATURES");

                entity.Property(e => e.Sync).HasColumnName("SYNC");

                entity.Property(e => e.SyncPush)
                    .HasColumnName("SYNC_PUSH")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Telephone)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("TELEPHONE");

                entity.HasOne(d => d.CodeAntenneNavigation)
                    .WithMany(p => p.GlobalEcoles)
                    .HasForeignKey(d => d.CodeAntenne)
                    .HasConstraintName("FK_GLOBAL_Ecole_PARAM_Antenne_Ecole");

                entity.HasOne(d => d.CodePaysNavigation)
                    .WithMany(p => p.GlobalEcoles)
                    .HasForeignKey(d => d.CodePays)
                    .HasConstraintName("FK_GLOBAL_Ecole_PARAM_PAYS");

                entity.HasOne(d => d.CodeReseauEnseignementNavigation)
                    .WithMany(p => p.GlobalEcoles)
                    .HasForeignKey(d => d.CodeReseauEnseignement)
                    .HasConstraintName("FK_GLOBAL_Ecole_PARAM_Reseau_Enseignement");

                entity.HasOne(d => d.CodeSysScolaireNavigation)
                    .WithMany(p => p.GlobalEcoles)
                    .HasForeignKey(d => d.CodeSysScolaire)
                    .HasConstraintName("FK_GLOBAL_Ecole_PARAM_Sytem_Scolaire");

                entity.HasOne(d => d.CodeTypeEcoleNavigation)
                    .WithMany(p => p.GlobalEcoles)
                    .HasForeignKey(d => d.CodeTypeEcole)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_GLOBAL_Ecole_PARAM_TYPE_ECOLE");
            });

            modelBuilder.Entity<GlobalEleveParent>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.ToTable("GLOBAL_Eleve_Parent");

                entity.Property(e => e.Code)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE");

                entity.Property(e => e.CodeEcole)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_ECOLE");

                entity.Property(e => e.CodeEleve)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_ELEVE");

                entity.Property(e => e.CodeParent)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_PARENT");

                entity.Property(e => e.Sync).HasColumnName("SYNC");

                entity.Property(e => e.SyncPush)
                    .HasColumnName("SYNC_PUSH")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.CodeEleveNavigation)
                    .WithMany(p => p.GlobalEleveParents)
                    .HasForeignKey(d => d.CodeEleve)
                    .HasConstraintName("FK_GLOBAL_Eleve_Parent_INSCRIPTION_Eleve");

                entity.HasOne(d => d.CodeParentNavigation)
                    .WithMany(p => p.GlobalEleveParents)
                    .HasForeignKey(d => d.CodeParent)
                    .HasConstraintName("FK_GLOBAL_Eleve_Parent_GLOBAL_PARENT");
            });

            modelBuilder.Entity<GlobalFiliere>(entity =>
            {
                entity.HasKey(e => e.CodeFiliere);

                entity.ToTable("GLOBAL_Filiere");

                entity.Property(e => e.CodeFiliere)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_FILIERE");

                entity.Property(e => e.CodeEcole)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_ECOLE");

                entity.Property(e => e.EstActif)
                    .HasColumnName("EST_ACTIF")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IntituleFiliere)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("INTITULE_FILIERE");

                entity.Property(e => e.Sync).HasColumnName("SYNC");

                entity.Property(e => e.SyncPush)
                    .HasColumnName("SYNC_PUSH")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<GlobalHeure>(entity =>
            {
                entity.HasKey(e => e.CodeHeure);

                entity.ToTable("GLOBAL_Heures");

                entity.Property(e => e.CodeHeure)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_HEURE");

                entity.Property(e => e.CodeEcole)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_ECOLE");

                entity.Property(e => e.Debut)
                    .HasColumnType("datetime")
                    .HasColumnName("DEBUT");

                entity.Property(e => e.Fin)
                    .HasColumnType("datetime")
                    .HasColumnName("FIN");

                entity.Property(e => e.Intitule)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("INTITULE");

                entity.Property(e => e.Sync).HasColumnName("SYNC");

                entity.Property(e => e.SyncPush)
                    .HasColumnName("SYNC_PUSH")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.CodeEcoleNavigation)
                    .WithMany(p => p.GlobalHeures)
                    .HasForeignKey(d => d.CodeEcole)
                    .HasConstraintName("FK_GLOBAL_Heures_GLOBAL_Ecole");
            });

            modelBuilder.Entity<GlobalHoraire>(entity =>
            {
                entity.HasKey(e => e.CodeHoraire);

                entity.ToTable("GLOBAL_Horaire");

                entity.Property(e => e.CodeHoraire)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_HORAIRE");

                entity.Property(e => e.CodeAffLocalCours)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_AFF_LOCAL_COURS");

                entity.Property(e => e.CodeEcole)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_ECOLE");

                entity.Property(e => e.CodeHeure)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_HEURE");

                entity.Property(e => e.CodeJour).HasColumnName("CODE_JOUR");

                entity.Property(e => e.EstActif).HasColumnName("EST_ACTIF");

                entity.Property(e => e.Sync).HasColumnName("SYNC");

                entity.Property(e => e.SyncPush)
                    .HasColumnName("SYNC_PUSH")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.CodeAffLocalCoursNavigation)
                    .WithMany(p => p.GlobalHoraires)
                    .HasForeignKey(d => d.CodeAffLocalCours)
                    .HasConstraintName("FK_GLOBAL_Horaire_GLOBAL_Affectation_Classe_Agent_Cours");

                entity.HasOne(d => d.CodeHeureNavigation)
                    .WithMany(p => p.GlobalHoraires)
                    .HasForeignKey(d => d.CodeHeure)
                    .HasConstraintName("FK_GLOBAL_Horaire_GLOBAL_Heures");

                entity.HasOne(d => d.CodeJourNavigation)
                    .WithMany(p => p.GlobalHoraires)
                    .HasForeignKey(d => d.CodeJour)
                    .HasConstraintName("FK_GLOBAL_Horaire_GLOBAL_Jours");
            });

            modelBuilder.Entity<GlobalJour>(entity =>
            {
                entity.HasKey(e => e.CodeJour);

                entity.ToTable("GLOBAL_Jours");

                entity.Property(e => e.CodeJour)
                    .ValueGeneratedNever()
                    .HasColumnName("CODE_JOUR");

                entity.Property(e => e.CodeEcole)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_ECOLE");

                entity.Property(e => e.Intitule)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("INTITULE");

                entity.Property(e => e.Sync).HasColumnName("SYNC");

                entity.Property(e => e.SyncPush)
                    .HasColumnName("SYNC_PUSH")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<GlobalLocal>(entity =>
            {
                entity.HasKey(e => e.CodeLocal);

                entity.ToTable("GLOBAL_Local");

                entity.Property(e => e.CodeLocal)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_LOCAL");

                entity.Property(e => e.EloCodeEcole)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("ELO_CODE_ECOLE");

                entity.Property(e => e.IntituleLocal)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("INTITULE_LOCAL");

                entity.Property(e => e.Localisation)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("LOCALISATION");

                entity.Property(e => e.NombrePlace).HasColumnName("NOMBRE_PLACE");

                entity.Property(e => e.Sync).HasColumnName("SYNC");

                entity.Property(e => e.SyncPush)
                    .HasColumnName("SYNC_PUSH")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.EloCodeEcoleNavigation)
                    .WithMany(p => p.GlobalLocals)
                    .HasForeignKey(d => d.EloCodeEcole)
                    .HasConstraintName("FK_GLOBAL_Local_GLOBAL_Ecole");
            });

            modelBuilder.Entity<GlobalNiveau>(entity =>
            {
                entity.HasKey(e => e.CodeNiveau)
                    .HasName("PK_GLOBAL_NIVEAU");

                entity.ToTable("GLOBAL_Niveau");

                entity.Property(e => e.CodeNiveau)
                    .ValueGeneratedNever()
                    .HasColumnName("CODE_NIVEAU");

                entity.Property(e => e.IntituleNiveau)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("INTITULE_NIVEAU");
            });

            modelBuilder.Entity<GlobalOption>(entity =>
            {
                entity.HasKey(e => e.CodeOption);

                entity.ToTable("GLOBAL_Option");

                entity.Property(e => e.CodeOption)
                    .HasMaxLength(7)
                    .HasColumnName("CODE_OPTION")
                    .IsFixedLength(true);

                entity.Property(e => e.CodeEcole)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_ECOLE");

                entity.Property(e => e.CodeSection)
                    .HasMaxLength(5)
                    .HasColumnName("CODE_SECTION")
                    .IsFixedLength(true);

                entity.Property(e => e.IntituleOption)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("INTITULE_OPTION");

                entity.Property(e => e.Sync).HasColumnName("SYNC");

                entity.Property(e => e.SyncPush)
                    .HasColumnName("SYNC_PUSH")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.CodeSectionNavigation)
                    .WithMany(p => p.GlobalOptions)
                    .HasForeignKey(d => d.CodeSection)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_GLOBAL_Option_GLOBAL_Section");
            });

            modelBuilder.Entity<GlobalParent>(entity =>
            {
                entity.HasKey(e => e.CodeParent)
                    .HasName("PK__GLOBAL_P__2334EB620ADD8CFD");

                entity.ToTable("GLOBAL_Parent");

                entity.Property(e => e.CodeParent)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_PARENT");

                entity.Property(e => e.Actif).HasColumnName("ACTIF");

                entity.Property(e => e.Adresse)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ADRESSE");

                entity.Property(e => e.CodeEcole)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_ECOLE");

                entity.Property(e => e.Email)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.Login)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("LOGIN");

                entity.Property(e => e.Nom)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("NOM");

                entity.Property(e => e.NotifyPushId)
                    .HasMaxLength(50)
                    .HasColumnName("NOTIFY_PUSH_ID");

                entity.Property(e => e.Password)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("PASSWORD");

                entity.Property(e => e.Pin)
                    .HasMaxLength(50)
                    .HasColumnName("PIN");

                entity.Property(e => e.Postnom)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("POSTNOM");

                entity.Property(e => e.Prenom)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("PRENOM");

                entity.Property(e => e.Sexe)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SEXE");

                entity.Property(e => e.Sync).HasColumnName("SYNC");

                entity.Property(e => e.SyncPush).HasColumnName("SYNC_PUSH");

                entity.Property(e => e.Telephone)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("TELEPHONE");
            });

            modelBuilder.Entity<GlobalPeriodeScolaire>(entity =>
            {
                entity.HasKey(e => e.CodePeriode);

                entity.ToTable("GLOBAL_Periode_Scolaire");

                entity.Property(e => e.CodePeriode)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_PERIODE");

                entity.Property(e => e.CodeAnnee).HasColumnName("CODE_ANNEE");

                entity.Property(e => e.CodeEcole)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_ECOLE");

                entity.Property(e => e.CodeTypeEcole).HasColumnName("CODE_TYPE_ECOLE");

                entity.Property(e => e.CodeTypePeriode)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_TYPE_PERIODE");

                entity.Property(e => e.DebutPeriode)
                    .HasColumnType("date")
                    .HasColumnName("DEBUT_PERIODE");

                entity.Property(e => e.EstActif).HasColumnName("EST_ACTIF");

                entity.Property(e => e.FinPeriode)
                    .HasColumnType("date")
                    .HasColumnName("FIN_PERIODE");

                entity.Property(e => e.IntitulePeriode)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("INTITULE_PERIODE");

                entity.Property(e => e.NiveauPeriode).HasColumnName("NIVEAU_PERIODE");

                entity.Property(e => e.Sync).HasColumnName("SYNC");

                entity.Property(e => e.SyncPush)
                    .HasColumnName("SYNC_PUSH")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.VisibleUtilisateur)
                    .HasColumnName("VISIBLE_UTILISATEUR")
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.CodeAnneeNavigation)
                    .WithMany(p => p.GlobalPeriodeScolaires)
                    .HasForeignKey(d => d.CodeAnnee)
                    .HasConstraintName("FK_GLOBAL_Periode_Scolaire_PARAM_Annee_Scolaire");

                entity.HasOne(d => d.CodeTypeEcoleNavigation)
                    .WithMany(p => p.GlobalPeriodeScolaires)
                    .HasForeignKey(d => d.CodeTypeEcole)
                    .HasConstraintName("FK_GLOBAL_Periode_Scolaire_PARAM_Type_Ecole");

                entity.HasOne(d => d.CodeTypePeriodeNavigation)
                    .WithMany(p => p.GlobalPeriodeScolaires)
                    .HasForeignKey(d => d.CodeTypePeriode)
                    .HasConstraintName("FK_GLOBAL_Periode_Scolaire_PARAM_Type_Periode");
            });

            modelBuilder.Entity<GlobalPresence>(entity =>
            {
                entity.HasKey(e => e.CodePresence)
                    .HasName("PK_PRESENCE");

                entity.ToTable("GLOBAL_Presence");

                entity.Property(e => e.CodePresence)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_PRESENCE");

                entity.Property(e => e.CodeClasse)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_CLASSE");

                entity.Property(e => e.CodeCours)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_COURS");

                entity.Property(e => e.CodeEcole)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_ECOLE");

                entity.Property(e => e.CodePeriode)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_PERIODE");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasColumnName("DATE");

                entity.Property(e => e.EloCodeAgent)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("ELO_CODE_AGENT");

                entity.Property(e => e.EloCodeEleve)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("ELO_CODE_ELEVE");

                entity.Property(e => e.JustificationAbsence)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("JUSTIFICATION_ABSENCE");

                entity.Property(e => e.MotifAbsence)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("MOTIF_ABSENCE");

                entity.Property(e => e.Presence).HasColumnName("PRESENCE");

                entity.Property(e => e.Sync).HasColumnName("SYNC");

                entity.Property(e => e.SyncPush)
                    .HasColumnName("SYNC_PUSH")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.CodeClasseNavigation)
                    .WithMany(p => p.GlobalPresences)
                    .HasForeignKey(d => d.CodeClasse)
                    .HasConstraintName("FK_GLOBAL_Presence_GLOBAL_Presence_CLASSE");

                entity.HasOne(d => d.CodeCoursNavigation)
                    .WithMany(p => p.GlobalPresences)
                    .HasForeignKey(d => d.CodeCours)
                    .HasConstraintName("FK_GLOBAL_Presence_BUKU_Cours");

                entity.HasOne(d => d.CodePeriodeNavigation)
                    .WithMany(p => p.GlobalPresences)
                    .HasForeignKey(d => d.CodePeriode)
                    .HasConstraintName("FK_GLOBAL_Presence_GLOBAL_Periode_Scolaire");

                entity.HasOne(d => d.EloCodeAgentNavigation)
                    .WithMany(p => p.GlobalPresences)
                    .HasForeignKey(d => d.EloCodeAgent)
                    .HasConstraintName("FK_GLOBAL_Presence_GLOBAL_Agent");

                entity.HasOne(d => d.EloCodeEleveNavigation)
                    .WithMany(p => p.GlobalPresences)
                    .HasForeignKey(d => d.EloCodeEleve)
                    .HasConstraintName("FK_GLOBAL_Presence_INSCRIPTION_Eleve");
            });

            modelBuilder.Entity<GlobalSection>(entity =>
            {
                entity.HasKey(e => e.CodeSection);

                entity.ToTable("GLOBAL_Section");

                entity.Property(e => e.CodeSection)
                    .HasMaxLength(5)
                    .HasColumnName("CODE_SECTION")
                    .IsFixedLength(true);

                entity.Property(e => e.CodeEcole)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_ECOLE");

                entity.Property(e => e.CodeNiveau).HasColumnName("CODE_NIVEAU");

                entity.Property(e => e.IntituleSection)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("INTITULE_SECTION");

                entity.Property(e => e.Sync).HasColumnName("SYNC");

                entity.Property(e => e.SyncPush)
                    .HasColumnName("SYNC_PUSH")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.CodeNiveauNavigation)
                    .WithMany(p => p.GlobalSections)
                    .HasForeignKey(d => d.CodeNiveau)
                    .HasConstraintName("FK_GLOBAL_Section_GLOBAL_Niveau");
            });

            modelBuilder.Entity<GlobalSysClasse>(entity =>
            {
                entity.HasKey(e => e.CodeSysClasse)
                    .HasName("PK_GLOBAL_SYS_CLASSE");

                entity.ToTable("GLOBAL_SYS_Classe");

                entity.Property(e => e.CodeSysClasse)
                    .HasMaxLength(7)
                    .HasColumnName("CODE_SYS_CLASSE")
                    .IsFixedLength(true);

                entity.Property(e => e.CodeDegreClasse).HasColumnName("CODE_DEGRE_CLASSE");

                entity.Property(e => e.CodeEcole)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_ECOLE");

                entity.Property(e => e.CodeOption)
                    .HasMaxLength(7)
                    .HasColumnName("CODE_OPTION")
                    .IsFixedLength(true);

                entity.Property(e => e.Sync).HasColumnName("SYNC");

                entity.Property(e => e.SyncPush)
                    .HasColumnName("SYNC_PUSH")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.CodeOptionNavigation)
                    .WithMany(p => p.GlobalSysClasses)
                    .HasForeignKey(d => d.CodeOption)
                    .HasConstraintName("FK_GLOBAL_SYS_Classe_GLOBAL_SYS_Classe");
            });

            modelBuilder.Entity<InscriptionEleve>(entity =>
            {
                entity.HasKey(e => e.EloCodeEleve);

                entity.ToTable("INSCRIPTION_Eleve");

                entity.Property(e => e.EloCodeEleve)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("ELO_CODE_ELEVE");

                entity.Property(e => e.ClasseSolliciter)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CLASSE_SOLLICITER");

                entity.Property(e => e.CodeSysClasse)
                    .HasMaxLength(10)
                    .HasColumnName("CODE_SYS_CLASSE")
                    .IsFixedLength(true);

                entity.Property(e => e.DateInscription)
                    .HasColumnType("datetime")
                    .HasColumnName("DATE_INSCRIPTION");

                entity.Property(e => e.DateNaissance)
                    .HasColumnType("date")
                    .HasColumnName("DATE_NAISSANCE");

                entity.Property(e => e.EcoleProvenance)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ECOLE_PROVENANCE");

                entity.Property(e => e.EloCodeEcole)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("ELO_CODE_ECOLE");

                entity.Property(e => e.EstActif)
                    .HasColumnName("EST_ACTIF")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.LieuNaissance)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("LIEU_NAISSANCE");

                entity.Property(e => e.Matricule)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("MATRICULE");

                entity.Property(e => e.Nom)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("NOM");

                entity.Property(e => e.NumeroPermanent)
                    .HasMaxLength(50)
                    .HasColumnName("NUMERO_PERMANENT")
                    .IsFixedLength(true);

                entity.Property(e => e.NumeroSernieEleve)
                    .HasMaxLength(50)
                    .HasColumnName("NUMERO_SERNIE_ELEVE")
                    .IsFixedLength(true);

                entity.Property(e => e.Postnom)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("POSTNOM");

                entity.Property(e => e.PourcentageAnneePassee)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("POURCENTAGE_ANNEE_PASSEE");

                entity.Property(e => e.Prenom)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("PRENOM");

                entity.Property(e => e.Sexe)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasColumnName("SEXE")
                    .IsFixedLength(true);

                entity.Property(e => e.Sync).HasColumnName("SYNC");

                entity.Property(e => e.SyncPush)
                    .HasColumnName("SYNC_PUSH")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.EloCodeEcoleNavigation)
                    .WithMany(p => p.InscriptionEleves)
                    .HasForeignKey(d => d.EloCodeEcole)
                    .HasConstraintName("FK_INSCRIPTION_Eleve_GLOBAL_Ecole");
            });

            modelBuilder.Entity<InscriptionEleveOnline>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("INSCRIPTION_Eleve_Online");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CODE");

                entity.Property(e => e.CodeClasse)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CODE_CLASSE");

                entity.Property(e => e.CodeEcole)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CODE_ECOLE");

                entity.Property(e => e.DateSoumission)
                    .HasColumnType("date")
                    .HasColumnName("DATE_SOUMISSION");

                entity.Property(e => e.EstAccepter)
                    .IsRequired()
                    .HasColumnName("EST_ACCEPTER")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.EstEffectif).HasColumnName("EST_EFFECTIF");

                entity.Property(e => e.EstValide).HasColumnName("EST_VALIDE");

                entity.Property(e => e.Facturier)
                    .HasMaxLength(10)
                    .HasColumnName("FACTURIER");

                entity.Property(e => e.InfoPayment).HasColumnName("INFO_PAYMENT");

                entity.Property(e => e.InscriptionInfo)
                    .IsRequired()
                    .HasColumnName("INSCRIPTION_INFO");
            });

            modelBuilder.Entity<InscriptionParcour>(entity =>
            {
                entity.HasKey(e => e.CodeParcours)
                    .HasName("PK_INSCRIPTION_PARCOURS");

                entity.ToTable("INSCRIPTION_Parcours");

                entity.Property(e => e.CodeParcours)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_PARCOURS");

                entity.Property(e => e.CodeAffectationLocalClass)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_AFFECTATION_LOCAL_CLASS");

                entity.Property(e => e.CodeAnnee).HasColumnName("CODE_ANNEE");

                entity.Property(e => e.DateAffetaction)
                    .HasColumnType("date")
                    .HasColumnName("DATE_AFFETACTION");

                entity.Property(e => e.EloCodeEcole)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("ELO_CODE_ECOLE");

                entity.Property(e => e.EloCodeEleve)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("ELO_CODE_ELEVE");

                entity.Property(e => e.EstActif)
                    .IsRequired()
                    .HasColumnName("EST_ACTIF")
                    .HasDefaultValueSql("((1))");

                //entity.Property(e => e.EstNouveau).HasColumnName("EST_NOUVEAU");

                entity.Property(e => e.SubmissionDate).HasColumnType("datetime");

                entity.Property(e => e.Sync).HasColumnName("SYNC");

                entity.Property(e => e.SyncPush)
                    .HasColumnName("SYNC_PUSH")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.CodeAffectationLocalClassNavigation)
                    .WithMany(p => p.InscriptionParcours)
                    .HasForeignKey(d => d.CodeAffectationLocalClass)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_INSCRIPTION_Parcours_GLOBAL_Classe");

                entity.HasOne(d => d.EloCodeEcoleNavigation)
                    .WithMany(p => p.InscriptionParcours)
                    .HasForeignKey(d => d.EloCodeEcole)
                    .HasConstraintName("FK_INSCRIPTION_Parcours_GLOBAL_Ecole");

                entity.HasOne(d => d.EloCodeEleveNavigation)
                    .WithMany(p => p.InscriptionParcours)
                    .HasForeignKey(d => d.EloCodeEleve)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_INSCRIPTION_Parcours_INSCRIPTION_Eleve");
            });

            modelBuilder.Entity<InscriptionTransfere>(entity =>
            {
                entity.HasKey(e => e.CodeTransfere);

                entity.ToTable("INSCRIPTION_Transfere");

                entity.Property(e => e.CodeTransfere)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_TRANSFERE");

                entity.Property(e => e.CodeEcole)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_ECOLE");

                entity.Property(e => e.EloCodeEleve)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("ELO_CODE_ELEVE");

                entity.Property(e => e.EloCodeEleveForeign)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("ELO_CODE_ELEVE_FOREIGN");

                entity.Property(e => e.Motif)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasColumnName("MOTIF");

                entity.Property(e => e.Sync).HasColumnName("SYNC");

                entity.Property(e => e.SyncPush)
                    .HasColumnName("SYNC_PUSH")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.EloCodeEleveNavigation)
                    .WithMany(p => p.InscriptionTransferes)
                    .HasForeignKey(d => d.EloCodeEleve)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_INSCRIPTION_Transfere_INSCRIPTION_Eleve");
            });

            modelBuilder.Entity<MambaDroit>(entity =>
            {
                entity.HasKey(e => e.CodeDroit)
                    .HasName("PK_Table_1");

                entity.ToTable("MAMBA_Droit");

                entity.Property(e => e.CodeDroit)
                    .ValueGeneratedNever()
                    .HasColumnName("CODE_DROIT");

                entity.Property(e => e.CodeEcole)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_ECOLE");

                entity.Property(e => e.IntituleDroit)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("INTITULE_DROIT");

                entity.Property(e => e.Sync).HasColumnName("SYNC");

                entity.Property(e => e.SyncPush)
                    .HasColumnName("SYNC_PUSH")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<MambaGroupUser>(entity =>
            {
                entity.HasKey(e => e.CodeGroupUser);

                entity.ToTable("MAMBA_Group_User");

                entity.Property(e => e.CodeGroupUser).HasColumnName("CODE_GROUP_USER");

                entity.Property(e => e.CodeEcole)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_ECOLE");

                entity.Property(e => e.IntituleGroupUser)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("INTITULE_GROUP_USER");

                entity.Property(e => e.IsvisibleUser)
                    .HasColumnName("ISVISIBLE_USER")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Sync).HasColumnName("SYNC");

                entity.Property(e => e.SyncPush)
                    .HasColumnName("SYNC_PUSH")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<MambaGuAcce>(entity =>
            {
                entity.HasKey(e => e.CodeGuAcces);

                entity.ToTable("MAMBA_Gu_Acces");

                entity.Property(e => e.CodeGuAcces)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_GU_ACCES");

                entity.Property(e => e.CodeDroit).HasColumnName("CODE_DROIT");

                entity.Property(e => e.CodeEcole)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_ECOLE");

                entity.Property(e => e.CodeGroupUser).HasColumnName("CODE_GROUP_USER");

                entity.Property(e => e.Sync).HasColumnName("SYNC");

                entity.Property(e => e.SyncPush)
                    .HasColumnName("SYNC_PUSH")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.CodeDroitNavigation)
                    .WithMany(p => p.MambaGuAcces)
                    .HasForeignKey(d => d.CodeDroit)
                    .HasConstraintName("FK_MAMBA_Gu_Acces_MAMBA_Droit");

                entity.HasOne(d => d.CodeGroupUserNavigation)
                    .WithMany(p => p.MambaGuAcces)
                    .HasForeignKey(d => d.CodeGroupUser)
                    .HasConstraintName("FK_MAMBA_Gu_Acces_MAMBA_Group_User");
            });

            modelBuilder.Entity<MambaLog>(entity =>
            {
                entity.HasKey(e => e.CodeLog);

                entity.ToTable("MAMBA_Log");

                entity.Property(e => e.CodeLog).HasColumnName("CODE_LOG");

                entity.Property(e => e.CodeEcole)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_ECOLE");

                entity.Property(e => e.CodeOperation)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CODE_OPERATION");

                entity.Property(e => e.CodeUtilisateur)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CODE_UTILISATEUR");

                entity.Property(e => e.DateLog)
                    .HasColumnType("datetime")
                    .HasColumnName("DATE_LOG")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.NomEcole)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NOM_ECOLE");

                entity.Property(e => e.Sync).HasColumnName("SYNC");

                entity.Property(e => e.SyncPush)
                    .HasColumnName("SYNC_PUSH")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TablesAffecter)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TABLES_AFFECTER");

                entity.Property(e => e.Value)
                    .HasColumnType("text")
                    .HasColumnName("VALUE");

                entity.HasOne(d => d.CodeUtilisateurNavigation)
                    .WithMany(p => p.MambaLogs)
                    .HasForeignKey(d => d.CodeUtilisateur)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_MAMBA_Log_MAMBA_Utilisateur");
            });

            modelBuilder.Entity<MambaUtilisateur>(entity =>
            {
                entity.HasKey(e => e.CodeUtilisateur);

                entity.ToTable("MAMBA_Utilisateur");

                entity.Property(e => e.CodeUtilisateur)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CODE_UTILISATEUR");

                entity.Property(e => e.ActifPortail).HasColumnName("ACTIF_PORTAIL");

                entity.Property(e => e.CodeAgentFonction)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_AGENT_FONCTION");

                entity.Property(e => e.CodeEcole)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_ECOLE");

                entity.Property(e => e.CodeGroupUser).HasColumnName("CODE_GROUP_USER");

                entity.Property(e => e.DateCreation)
                    .HasColumnType("datetime")
                    .HasColumnName("DATE_CREATION")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateExpiration)
                    .HasColumnType("date")
                    .HasColumnName("DATE_EXPIRATION");

                entity.Property(e => e.EstActif).HasColumnName("EST_ACTIF");

                entity.Property(e => e.EstDateExpiration).HasColumnName("EST_DATE_EXPIRATION");

                entity.Property(e => e.MessageRappelPwd)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("MESSAGE_RAPPEL_PWD");

                entity.Property(e => e.Pwd)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("PWD");

                entity.Property(e => e.Sync).HasColumnName("SYNC");

                entity.Property(e => e.SyncPush)
                    .HasColumnName("SYNC_PUSH")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Username)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("USERNAME");

                entity.HasOne(d => d.CodeAgentFonctionNavigation)
                    .WithMany(p => p.MambaUtilisateurs)
                    .HasForeignKey(d => d.CodeAgentFonction)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_MAMBA_Utilisateur_PARAM_Agent_Fonction");

                entity.HasOne(d => d.CodeGroupUserNavigation)
                    .WithMany(p => p.MambaUtilisateurs)
                    .HasForeignKey(d => d.CodeGroupUser)
                    .HasConstraintName("FK_MAMBA_Utilisateur_MAMBA_Group_User1");
            });

            modelBuilder.Entity<ParamAffectationDevice>(entity =>
            {
                entity.HasKey(e => e.CodeAffDevice)
                    .HasName("PK_PARAM_AFFECTATION_DEVICE");

                entity.ToTable("PARAM_Affectation_Device");

                entity.Property(e => e.CodeAffDevice)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_AFF_DEVICE");

                entity.Property(e => e.AdresseMac)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("ADRESSE_MAC");

                entity.Property(e => e.CodeClasse)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_CLASSE");

                entity.Property(e => e.CodeEcole)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_ECOLE");

                entity.Property(e => e.CodeGu).HasColumnName("CODE_GU");

                entity.Property(e => e.Sync).HasColumnName("SYNC");

                entity.Property(e => e.SyncPush)
                    .HasColumnName("SYNC_PUSH")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.CodeClasseNavigation)
                    .WithMany(p => p.ParamAffectationDevices)
                    .HasForeignKey(d => d.CodeClasse)
                    .HasConstraintName("FK_PARAM_Affectation_Device_GLOBAL_Affectation_Local_Classe");

                entity.HasOne(d => d.CodeGuNavigation)
                    .WithMany(p => p.ParamAffectationDevices)
                    .HasForeignKey(d => d.CodeGu)
                    .HasConstraintName("FK_PARAM_Affectation_Device_MAMBA_Group_User");
            });

            modelBuilder.Entity<ParamAffectationSignatureDocument>(entity =>
            {
                entity.HasKey(e => e.CodeAffecSignatureDoc);

                entity.ToTable("PARAM_Affectation_Signature_Document");

                entity.Property(e => e.CodeAffecSignatureDoc)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_AFFEC_SIGNATURE_DOC");

                entity.Property(e => e.Actif).HasColumnName("ACTIF");

                entity.Property(e => e.CodeAgent)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_AGENT");

                entity.Property(e => e.CodeEcole)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_ECOLE");

                entity.Property(e => e.CodeSignature).HasColumnName("CODE_SIGNATURE");

                entity.Property(e => e.CodeTypeDocument)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_TYPE_DOCUMENT");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasColumnName("DATE");

                entity.Property(e => e.Sync).HasColumnName("SYNC");

                entity.Property(e => e.SyncPush)
                    .HasColumnName("SYNC_PUSH")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.CodeAgentNavigation)
                    .WithMany(p => p.ParamAffectationSignatureDocuments)
                    .HasForeignKey(d => d.CodeAgent)
                    .HasConstraintName("FK_PARAM_Affectation_Signature_Document_PARAM_Affectation_Signature_Document");

                entity.HasOne(d => d.CodeEcoleNavigation)
                    .WithMany(p => p.ParamAffectationSignatureDocuments)
                    .HasForeignKey(d => d.CodeEcole)
                    .HasConstraintName("FK_PARAM_Affectation_Signature_Document_GLOBAL_Ecole");

                entity.HasOne(d => d.CodeSignatureNavigation)
                    .WithMany(p => p.ParamAffectationSignatureDocuments)
                    .HasForeignKey(d => d.CodeSignature)
                    .HasConstraintName("FK_PARAM_Affectation_Signature_Document_PARAM_Type_Signature");

                entity.HasOne(d => d.CodeTypeDocumentNavigation)
                    .WithMany(p => p.ParamAffectationSignatureDocuments)
                    .HasForeignKey(d => d.CodeTypeDocument)
                    .HasConstraintName("FK_PARAM_Affectation_Signature_Document_ETEYELO_Type_Document");
            });

            modelBuilder.Entity<ParamAgentFonction>(entity =>
            {
                entity.HasKey(e => e.CodeAgentFonction);

                entity.ToTable("PARAM_Agent_Fonction");

                entity.Property(e => e.CodeAgentFonction)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_AGENT_FONCTION");

                entity.Property(e => e.CodeFonction)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_FONCTION");

                entity.Property(e => e.EloCodeAgent)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("ELO_CODE_AGENT");

                entity.Property(e => e.EloCodeEcole)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("ELO_CODE_ECOLE");

                entity.Property(e => e.EstActif)
                    .IsRequired()
                    .HasColumnName("EST_ACTIF")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.EstPrefet)
                    .HasColumnName("EST_PREFET")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Sync).HasColumnName("SYNC");

                entity.Property(e => e.SyncPush)
                    .HasColumnName("SYNC_PUSH")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.CodeFonctionNavigation)
                    .WithMany(p => p.ParamAgentFonctions)
                    .HasForeignKey(d => d.CodeFonction)
                    .HasConstraintName("FK_PARAM_Agent_Fonction_PARAM_Fonction");

                entity.HasOne(d => d.EloCodeAgentNavigation)
                    .WithMany(p => p.ParamAgentFonctions)
                    .HasForeignKey(d => d.EloCodeAgent)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PARAM_Agent_Fonction_GLOBAL_Agent");

                entity.HasOne(d => d.EloCodeEcoleNavigation)
                    .WithMany(p => p.ParamAgentFonctions)
                    .HasForeignKey(d => d.EloCodeEcole)
                    .HasConstraintName("FK_PARAM_Agent_Fonction_GLOBAL_Ecole");
            });

            modelBuilder.Entity<ParamAnneeScolaire>(entity =>
            {
                entity.HasKey(e => e.CodeAnnee);

                entity.ToTable("PARAM_Annee_Scolaire");

                entity.Property(e => e.CodeAnnee).HasColumnName("CODE_ANNEE");

                entity.Property(e => e.CodeEcole)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_ECOLE");

                entity.Property(e => e.DateCreation)
                    .HasColumnType("datetime")
                    .HasColumnName("DATE_CREATION")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Debut)
                    .HasColumnType("date")
                    .HasColumnName("DEBUT");

                entity.Property(e => e.EstActif)
                    .HasColumnName("EST_ACTIF")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Fin)
                    .HasColumnType("date")
                    .HasColumnName("FIN");

                entity.Property(e => e.IntituleAnneeScolaire)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("INTITULE_ANNEE_SCOLAIRE");

                entity.Property(e => e.Sync).HasColumnName("SYNC");

                entity.Property(e => e.SyncPush)
                    .HasColumnName("SYNC_PUSH")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<ParamAntenneEcole>(entity =>
            {
                entity.HasKey(e => e.CodeAntenne);

                entity.ToTable("PARAM_Antenne_Ecole");

                entity.Property(e => e.CodeAntenne)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("CODE_ANTENNE");

                entity.Property(e => e.CodeEcole)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_ECOLE");

                entity.Property(e => e.IntituleAntenne)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("INTITULE_ANTENNE");

                entity.Property(e => e.Sync).HasColumnName("SYNC");

                entity.Property(e => e.SyncPush)
                    .HasColumnName("SYNC_PUSH")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<ParamCommission>(entity =>
            {
                entity.HasKey(e => e.CodeCommission);

                entity.ToTable("PARAM_Commission");

                entity.Property(e => e.CodeCommission)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_COMMISSION");

                entity.Property(e => e.CodeDevise)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_DEVISE");

                entity.Property(e => e.CodeEcole)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_ECOLE");

                entity.Property(e => e.EstActif)
                    .HasColumnName("EST_ACTIF")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Montant).HasColumnName("MONTANT");

                entity.Property(e => e.MontantReel).HasColumnName("MONTANT_REEL");

                entity.Property(e => e.Nom)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("NOM");

                entity.Property(e => e.Sync)
                    .HasColumnName("SYNC")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SyncPush)
                    .HasColumnName("SYNC_PUSH")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Taux)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("TAUX");
            });

            modelBuilder.Entity<ParamCompte>(entity =>
            {
                entity.HasKey(e => e.CodeCompte)
                    .HasName("PK_PARAM_COMPTE");

                entity.ToTable("PARAM_Compte");

                entity.Property(e => e.CodeCompte)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_COMPTE");

                entity.Property(e => e.CodeEcole)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_ECOLE");

                entity.Property(e => e.CodeFrais)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_FRAIS");

                entity.Property(e => e.CodeTypeCompte).HasColumnName("CODE_TYPE_COMPTE");

                entity.Property(e => e.DateCreation)
                    .HasColumnType("datetime")
                    .HasColumnName("DATE_CREATION")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EstActif)
                    .HasColumnName("EST_ACTIF")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IntituleCompte)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("INTITULE_COMPTE");

                entity.Property(e => e.Part)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("PART");

                entity.Property(e => e.Sync).HasColumnName("SYNC");

                entity.Property(e => e.SyncPush)
                    .HasColumnName("SYNC_PUSH")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Type)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TYPE");

                entity.HasOne(d => d.CodeFraisNavigation)
                    .WithMany(p => p.ParamComptes)
                    .HasForeignKey(d => d.CodeFrais)
                    .HasConstraintName("FK_PARAM_Compte_FINANCE_Frais");

                entity.HasOne(d => d.CodeTypeCompteNavigation)
                    .WithMany(p => p.ParamComptes)
                    .HasForeignKey(d => d.CodeTypeCompte)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_PARAM_COMPTE_PARAM_Type_Compte");
            });

            modelBuilder.Entity<ParamDelibe>(entity =>
            {
                entity.HasKey(e => e.CodeParamDelibe);

                entity.ToTable("PARAM_Delibe");

                entity.Property(e => e.CodeParamDelibe)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_PARAM_DELIBE");

                entity.Property(e => e.CodeAnnee).HasColumnName("CODE_ANNEE");

                entity.Property(e => e.CodeEcole)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_ECOLE");

                entity.Property(e => e.CodeFaitDelibe)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_FAIT_DELIBE");

                entity.Property(e => e.CodeParamTypeDelibe).HasColumnName("CODE_PARAM_TYPE_DELIBE");

                entity.Property(e => e.Conduite)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CONDUITE");

                entity.Property(e => e.EchecGraveSession1).HasColumnName("ECHEC_GRAVE_SESSION1");

                entity.Property(e => e.EchecGraveSession2).HasColumnName("ECHEC_GRAVE_SESSION2");

                entity.Property(e => e.EchecLegerSession1).HasColumnName("ECHEC_LEGER_SESSION1");

                entity.Property(e => e.EchecLegerSession2).HasColumnName("ECHEC_LEGER_SESSION2");

                entity.Property(e => e.PourcentageMax).HasColumnName("POURCENTAGE_MAX");

                entity.Property(e => e.PourcentageMin).HasColumnName("POURCENTAGE_MIN");

                entity.Property(e => e.Sync).HasColumnName("SYNC");

                entity.Property(e => e.SyncPush)
                    .HasColumnName("SYNC_PUSH")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.CodeEcoleNavigation)
                    .WithMany(p => p.ParamDelibes)
                    .HasForeignKey(d => d.CodeEcole)
                    .HasConstraintName("FK_PARAM_Delibe_GLOBAL_Ecole");

                entity.HasOne(d => d.CodeParamTypeDelibeNavigation)
                    .WithMany(p => p.ParamDelibes)
                    .HasForeignKey(d => d.CodeParamTypeDelibe)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PARAM_Delibe_PARAM_Type_Delibe");
            });

            modelBuilder.Entity<ParamDevise>(entity =>
            {
                entity.HasKey(e => e.CodePk)
                    .HasName("PK_PARAM_Devise_1");

                entity.ToTable("PARAM_Devise");

                entity.Property(e => e.CodePk)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_PK");

                entity.Property(e => e.CodeDevise)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_DEVISE");

                entity.Property(e => e.CodeEcole)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_ECOLE");

                entity.Property(e => e.Intitule)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("INTITULE");

                entity.Property(e => e.ParDefaut).HasColumnName("PAR_DEFAUT");

                entity.Property(e => e.Pays)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("PAYS");

                entity.Property(e => e.Symbole)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SYMBOLE");

                entity.Property(e => e.Sync).HasColumnName("SYNC");

                entity.Property(e => e.SyncPush).HasColumnName("SYNC_PUSH");
            });

            modelBuilder.Entity<ParamDocumentParDefaut>(entity =>
            {
                entity.HasKey(e => e.CodeDocumentParDefaut)
                    .HasName("PK_PARAM_DOCUMENT_PAR_DEFAUT");

                entity.ToTable("PARAM_Document_Par_Defaut");

                entity.Property(e => e.CodeDocumentParDefaut).HasColumnName("CODE_DOCUMENT_PAR_DEFAUT");

                entity.Property(e => e.CodeEcole)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_ECOLE");

                entity.Property(e => e.CodeTypeDocument)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_TYPE_DOCUMENT");

                entity.Property(e => e.IntituleDocumentParDefaut)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("INTITULE_DOCUMENT_PAR_DEFAUT");

                entity.Property(e => e.Sync).HasColumnName("SYNC");

                entity.Property(e => e.SyncPush)
                    .HasColumnName("SYNC_PUSH")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.CodeTypeDocumentNavigation)
                    .WithMany(p => p.ParamDocumentParDefauts)
                    .HasForeignKey(d => d.CodeTypeDocument)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_PARAM_DOCUMENT_PAR_DEFAUT_ETEYELO_Type_Document");
            });

            modelBuilder.Entity<ParamEntiteAdministrative>(entity =>
            {
                entity.HasKey(e => e.CodeEntiteAdministrative)
                    .HasName("PK_ENTITE_ADMINISTRATIVE");

                entity.ToTable("PARAM_Entite_Administrative");

                entity.Property(e => e.CodeEntiteAdministrative)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CODE_ENTITE_ADMINISTRATIVE");

                entity.Property(e => e.Autres)
                    .HasColumnType("text")
                    .HasColumnName("AUTRES");

                entity.Property(e => e.CodeEcole)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_ECOLE");

                entity.Property(e => e.CodeEntiteAdministrativeMere)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CODE_ENTITE_ADMINISTRATIVE_MERE");

                entity.Property(e => e.CodeTypeEntiteAdministrative)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("CODE_TYPE_ENTITE_ADMINISTRATIVE");

                entity.Property(e => e.Denomination)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DENOMINATION");

                entity.Property(e => e.DenominationHabitant)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DENOMINATION_HABITANT");

                entity.Property(e => e.Entite)
                    .IsRequired()
                    .HasMaxLength(75)
                    .IsUnicode(false)
                    .HasColumnName("ENTITE");

                entity.Property(e => e.Sync).HasColumnName("SYNC");

                entity.Property(e => e.SyncPush)
                    .HasColumnName("SYNC_PUSH")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.CodeEntiteAdministrativeMereNavigation)
                    .WithMany(p => p.InverseCodeEntiteAdministrativeMereNavigation)
                    .HasForeignKey(d => d.CodeEntiteAdministrativeMere)
                    .HasConstraintName("FK_PARAM_Entite_Administrative_PARAM_Entite_Administrative");

                entity.HasOne(d => d.CodeTypeEntiteAdministrativeNavigation)
                    .WithMany(p => p.ParamEntiteAdministratives)
                    .HasForeignKey(d => d.CodeTypeEntiteAdministrative)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ENTITE_ADMINISTRATIVE_TYPE_ENTITE_ADMINISTRATIVE1");
            });

            modelBuilder.Entity<ParamFaitDelibe>(entity =>
            {
                entity.HasKey(e => e.CodeFaitDelibe)
                    .HasName("PK_PARAM_Type_Decision_Delibe");

                entity.ToTable("PARAM_Fait_Delibe");

                entity.Property(e => e.CodeFaitDelibe)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_FAIT_DELIBE");

                entity.Property(e => e.CodeEcole)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_ECOLE");

                entity.Property(e => e.Decision)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("DECISION");

                entity.Property(e => e.DecisionAbregee)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("DECISION_ABREGEE");

                entity.Property(e => e.Priorite).HasColumnName("PRIORITE");

                entity.Property(e => e.Sync).HasColumnName("SYNC");

                entity.Property(e => e.SyncPush).HasColumnName("SYNC_PUSH");

                entity.HasOne(d => d.CodeEcoleNavigation)
                    .WithMany(p => p.ParamFaitDelibes)
                    .HasForeignKey(d => d.CodeEcole)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_PARAM_Type_Decision_Delibe_GLOBAL_Ecole");
            });

            modelBuilder.Entity<ParamFonction>(entity =>
            {
                entity.HasKey(e => e.CodeFonction);

                entity.ToTable("PARAM_Fonction");

                entity.Property(e => e.CodeFonction)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_FONCTION");

                entity.Property(e => e.CodeEcole)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_ECOLE");

                entity.Property(e => e.CodeService)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_SERVICE");

                entity.Property(e => e.IntituleFonction)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("INTITULE_FONCTION");

                entity.Property(e => e.IsvisibleUser)
                    .HasColumnName("ISVISIBLE_USER")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Sync).HasColumnName("SYNC");

                entity.Property(e => e.SyncPush)
                    .HasColumnName("SYNC_PUSH")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.CodeEcoleNavigation)
                    .WithMany(p => p.ParamFonctions)
                    .HasForeignKey(d => d.CodeEcole)
                    .HasConstraintName("FK_PARAM_Fonction_GLOBAL_Ecole");

                entity.HasOne(d => d.CodeServiceNavigation)
                    .WithMany(p => p.ParamFonctions)
                    .HasForeignKey(d => d.CodeService)
                    .HasConstraintName("FK_PARAM_Fonction_PARAM_Fonction");
            });

            modelBuilder.Entity<ParamGlobal>(entity =>
            {
                entity.HasKey(e => e.CodePk)
                    .HasName("PK_PARAM_GLOBAL_1");

                entity.ToTable("PARAM_GLOBAL");

                entity.Property(e => e.CodePk).HasColumnName("CODE_PK");

                entity.Property(e => e.CodeEcole)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_ECOLE");

                entity.Property(e => e.Key)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("KEY");

                entity.Property(e => e.Value)
                    .HasColumnType("text")
                    .HasColumnName("VALUE");
            });

            modelBuilder.Entity<ParamLicence>(entity =>
            {
                entity.HasKey(e => e.CodeEcole);

                entity.ToTable("Param_licences");

                entity.Property(e => e.CodeEcole)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ParamMamba>(entity =>
            {
                entity.HasKey(e => e.CodeMac);

                entity.ToTable("PARAM_MAMBA");

                entity.Property(e => e.CodeMac)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CODE_MAC");

                entity.Property(e => e.CodeEcole)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_ECOLE");

                entity.Property(e => e.EstValide).HasColumnName("EST_VALIDE");

                entity.Property(e => e.EstValideLicence)
                    .HasColumnType("text")
                    .HasColumnName("EST_VALIDE_LICENCE");

                entity.Property(e => e.NomEcole)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NOM_ECOLE");

                entity.Property(e => e.Quota)
                    .HasColumnType("text")
                    .HasColumnName("QUOTA");

                entity.Property(e => e.Sync).HasColumnName("SYNC");

                entity.Property(e => e.SyncPush)
                    .HasColumnName("SYNC_PUSH")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<ParamModePaiement>(entity =>
            {
                entity.HasKey(e => e.CodeModePaiement);

                entity.ToTable("PARAM_Mode_Paiement");

                entity.Property(e => e.CodeModePaiement)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_MODE_PAIEMENT");

                entity.Property(e => e.CodeEcole)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_ECOLE");

                entity.Property(e => e.EstValide).HasColumnName("EST_VALIDE");

                entity.Property(e => e.IntituleModePaiement)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("INTITULE_MODE_PAIEMENT");

                entity.Property(e => e.Sync).HasColumnName("SYNC");

                entity.Property(e => e.SyncPush).HasColumnName("SYNC_PUSH");
            });

            modelBuilder.Entity<ParamOrdreFrai>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.ToTable("PARAM_ORDRE_FRAIS");

                entity.Property(e => e.Code)
                    .HasMaxLength(30)
                    .HasColumnName("CODE");

                entity.Property(e => e.Intitule)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("INTITULE")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<ParamPay>(entity =>
            {
                entity.HasKey(e => e.CodePays);

                entity.ToTable("PARAM_PAYS");

                entity.Property(e => e.CodePays)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("CODE_PAYS");

                entity.Property(e => e.CodeEcole)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_ECOLE");

                entity.Property(e => e.CodeEntiteAdministrative)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CODE_ENTITE_ADMINISTRATIVE");

                entity.Property(e => e.ProfilPays)
                    .HasColumnType("text")
                    .HasColumnName("PROFIL_PAYS");

                entity.Property(e => e.Sync)
                    .HasColumnName("SYNC")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SyncPush)
                    .HasColumnName("SYNC_PUSH")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.CodeEntiteAdministrativeNavigation)
                    .WithMany(p => p.ParamPays)
                    .HasForeignKey(d => d.CodeEntiteAdministrative)
                    .HasConstraintName("FK_PARAM_PAYS_PARAM_Entite_Administrative");
            });

            modelBuilder.Entity<ParamPeriodicite>(entity =>
            {
                entity.HasKey(e => e.CodePeriodicite)
                    .HasName("PK__PARAM_Pe__A2C06DE442E1EEFE");

                entity.ToTable("PARAM_Periodicite");

                entity.Property(e => e.CodePeriodicite)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("CODE_PERIODICITE");

                entity.Property(e => e.CodeEcole)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_ECOLE");

                entity.Property(e => e.Intitule)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("INTITULE");

                entity.Property(e => e.NombreSms).HasColumnName("NOMBRE_SMS");

                entity.Property(e => e.Sync).HasColumnName("SYNC");

                entity.Property(e => e.SyncPush)
                    .HasColumnName("SYNC_PUSH")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Valeur)
                    .HasColumnName("VALEUR")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<ParamPrioriteFrai>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PARAM_PRIORITE_FRAIS");

                entity.Property(e => e.CodeFrais)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("CODE_FRAIS");

                entity.Property(e => e.CodeOrdreFrais)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("CODE_ORDRE_FRAIS");

                entity.Property(e => e.ParamDate)
                    .HasColumnType("datetime")
                    .HasColumnName("PARAM_DATE");
            });

            modelBuilder.Entity<ParamRegimePaiement>(entity =>
            {
                entity.HasKey(e => e.CodeRegimePaiement)
                    .HasName("PK_PARAM_Affectation_Type_Frais");

                entity.ToTable("PARAM_Regime_Paiement");

                entity.Property(e => e.CodeRegimePaiement)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_REGIME_PAIEMENT");

                entity.Property(e => e.CodeAnneeScolaire).HasColumnName("CODE_ANNEE_SCOLAIRE");

                entity.Property(e => e.CodeCategorieEleve)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_CATEGORIE_ELEVE");

                entity.Property(e => e.CodeEcole)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_ECOLE");

                entity.Property(e => e.DateAffectation)
                    .HasColumnType("datetime")
                    .HasColumnName("DATE_AFFECTATION");

                entity.Property(e => e.EstActif).HasColumnName("EST_ACTIF");

                entity.Property(e => e.Intitule)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("INTITULE");

                entity.Property(e => e.MontantPaiement).HasColumnName("MONTANT_PAIEMENT");

                entity.Property(e => e.PourcentagePaiement)
                    .HasColumnType("decimal(18, 7)")
                    .HasColumnName("POURCENTAGE_PAIEMENT")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Sync).HasColumnName("SYNC");

                entity.Property(e => e.SyncPush)
                    .HasColumnName("SYNC_PUSH")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.CodeAnneeScolaireNavigation)
                    .WithMany(p => p.ParamRegimePaiements)
                    .HasForeignKey(d => d.CodeAnneeScolaire)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PARAM_Affectation_Type_Frais_PARAM_Annee_Scolaire");

                entity.HasOne(d => d.CodeCategorieEleveNavigation)
                    .WithMany(p => p.ParamRegimePaiements)
                    .HasForeignKey(d => d.CodeCategorieEleve)
                    .HasConstraintName("FK_PARAM_Affectation_Type_Frais_ETEYELO_Categorie_Eleve");
            });

            modelBuilder.Entity<ParamReseauEnseignement>(entity =>
            {
                entity.HasKey(e => e.CodeReseau);

                entity.ToTable("PARAM_Reseau_Enseignement");

                entity.Property(e => e.CodeReseau)
                    .ValueGeneratedNever()
                    .HasColumnName("CODE_RESEAU");

                entity.Property(e => e.AbreviationReseau)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("ABREVIATION_RESEAU");

                entity.Property(e => e.CodeEcole)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_ECOLE");

                entity.Property(e => e.IntituleReseau)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("INTITULE_RESEAU");

                entity.Property(e => e.Sync).HasColumnName("SYNC");

                entity.Property(e => e.SyncPush)
                    .HasColumnName("SYNC_PUSH")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<ParamSanctionDisciplinaire>(entity =>
            {
                entity.HasKey(e => e.CodeSanction)
                    .HasName("PK_PARAM_SANCTION_DISCIPLINAIRE");

                entity.ToTable("PARAM_Sanction_Disciplinaire");

                entity.Property(e => e.CodeSanction)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_SANCTION");

                entity.Property(e => e.CodeEcole)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_ECOLE");

                entity.Property(e => e.Libelle)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("LIBELLE");

                entity.Property(e => e.Sync).HasColumnName("SYNC");

                entity.Property(e => e.SyncPush)
                    .HasColumnName("SYNC_PUSH")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Valeur).HasColumnName("VALEUR");
            });

            modelBuilder.Entity<ParamService>(entity =>
            {
                entity.HasKey(e => e.CodeService);

                entity.ToTable("PARAM_Service");

                entity.Property(e => e.CodeService)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_SERVICE");

                entity.Property(e => e.CodeEcole)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_ECOLE");

                entity.Property(e => e.IntituleService)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("INTITULE_SERVICE");

                entity.Property(e => e.Sync).HasColumnName("SYNC");

                entity.Property(e => e.SyncPush)
                    .HasColumnName("SYNC_PUSH")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.CodeEcoleNavigation)
                    .WithMany(p => p.ParamServices)
                    .HasForeignKey(d => d.CodeEcole)
                    .HasConstraintName("FK_PARAM_Service_GLOBAL_Ecole");
            });

            modelBuilder.Entity<ParamSm>(entity =>
            {
                entity.HasKey(e => e.CodeSms);

                entity.ToTable("PARAM_SMS");

                entity.Property(e => e.CodeSms)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_SMS");

                entity.Property(e => e.CodeEcole)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_ECOLE");

                entity.Property(e => e.DateCreation)
                    .HasColumnType("datetime")
                    .HasColumnName("DATE_CREATION")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateSend)
                    .HasColumnType("datetime")
                    .HasColumnName("DATE_SEND");

                entity.Property(e => e.Destinateur)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasColumnName("DESTINATEUR");

                entity.Property(e => e.EtatSend).HasColumnName("ETAT_SEND");

                entity.Property(e => e.Message)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasColumnName("MESSAGE");

                entity.Property(e => e.NbrMessage).HasColumnName("NBR_MESSAGE");

                entity.Property(e => e.Sender)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("SENDER");

                entity.Property(e => e.Sync).HasColumnName("SYNC");

                entity.Property(e => e.SyncPush)
                    .HasColumnName("SYNC_PUSH")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TailleMessage).HasColumnName("TAILLE_MESSAGE");
            });

            modelBuilder.Entity<ParamSystemScolaire>(entity =>
            {
                entity.HasKey(e => e.CodeSysScolaire)
                    .HasName("PK_PARAM_Sytem_Scolaire");

                entity.ToTable("PARAM_System_Scolaire");

                entity.Property(e => e.CodeSysScolaire)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_SYS_SCOLAIRE");

                entity.Property(e => e.CodeEcole)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_ECOLE");

                entity.Property(e => e.Intitule)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("INTITULE");

                entity.Property(e => e.Sync).HasColumnName("SYNC");

                entity.Property(e => e.SyncPush).HasColumnName("SYNC_PUSH");
            });

            modelBuilder.Entity<ParamSysteme>(entity =>
            {
                entity.HasKey(e => e.CodeParam)
                    .HasName("PK_PARAM_SYSTEM");

                entity.ToTable("PARAM_Systeme");

                entity.Property(e => e.CodeParam)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_PARAM");

                entity.Property(e => e.CodeSysClasse)
                    .IsRequired()
                    .HasMaxLength(7)
                    .HasColumnName("CODE_SYS_CLASSE")
                    .IsFixedLength(true);

                entity.Property(e => e.EloCodeEcole)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("ELO_CODE_ECOLE");

                entity.Property(e => e.EstActif)
                    .HasColumnName("EST_ACTIF")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Sync).HasColumnName("SYNC");

                entity.Property(e => e.SyncPush)
                    .HasColumnName("SYNC_PUSH")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.CodeSysClasseNavigation)
                    .WithMany(p => p.ParamSystemes)
                    .HasForeignKey(d => d.CodeSysClasse)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PARAM_SYSTEM_GLOBAL_SYS_Classe");

                entity.HasOne(d => d.EloCodeEcoleNavigation)
                    .WithMany(p => p.ParamSystemes)
                    .HasForeignKey(d => d.EloCodeEcole)
                    .HasConstraintName("FK_PARAM_SYSTEM_GLOBAL_Ecole");
            });

            modelBuilder.Entity<ParamTaux>(entity =>
            {
                entity.HasKey(e => e.CodeTaux);

                entity.ToTable("PARAM_Taux");

                entity.Property(e => e.CodeTaux)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_TAUX");

                entity.Property(e => e.CodeEcole)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_ECOLE");

                entity.Property(e => e.DateCreation)
                    .HasColumnType("datetime")
                    .HasColumnName("DATE_CREATION");

                entity.Property(e => e.DeviseArrivee)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("DEVISE_ARRIVEE");

                entity.Property(e => e.DeviseDepart)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("DEVISE_DEPART")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EstActif)
                    .HasColumnName("EST_ACTIF")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Sync).HasColumnName("SYNC");

                entity.Property(e => e.SyncPush)
                    .HasColumnName("SYNC_PUSH")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Valeur)
                    .HasColumnType("decimal(18, 10)")
                    .HasColumnName("VALEUR");
            });

            modelBuilder.Entity<ParamTemplateMessage>(entity =>
            {
                entity.HasKey(e => e.CodeTemplateMessage);

                entity.ToTable("PARAM_Template_Message");

                entity.Property(e => e.CodeTemplateMessage).HasColumnName("CODE_TEMPLATE_MESSAGE");

                entity.Property(e => e.CodeEcole)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_ECOLE");

                entity.Property(e => e.MessageTemplate)
                    .IsUnicode(false)
                    .HasColumnName("MESSAGE_TEMPLATE");

                entity.Property(e => e.Sync).HasColumnName("SYNC");

                entity.Property(e => e.SyncPush)
                    .HasColumnName("SYNC_PUSH")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TitreDuMessage)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TITRE_DU_MESSAGE");
            });

            modelBuilder.Entity<ParamTemplateOperationCaisse>(entity =>
            {
                entity.HasKey(e => e.CodeTemplateOperationCaisse);

                entity.ToTable("PARAM_Template_Operation_Caisse");

                entity.Property(e => e.CodeTemplateOperationCaisse)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_TEMPLATE_OPERATION_CAISSE");

                entity.Property(e => e.CodeEcole)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_ECOLE");

                entity.Property(e => e.IntituleTemplateOperation)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("INTITULE_TEMPLATE_OPERATION");

                entity.Property(e => e.Sync)
                    .HasColumnName("SYNC")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SyncPush)
                    .HasColumnName("SYNC_PUSH")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.CodeEcoleNavigation)
                    .WithMany(p => p.ParamTemplateOperationCaisses)
                    .HasForeignKey(d => d.CodeEcole)
                    .HasConstraintName("FK_PARAM_Template_Operation_Caisse_GLOBAL_Ecole");
            });

            modelBuilder.Entity<ParamTypeAppreciation>(entity =>
            {
                entity.HasKey(e => e.CodeTypeAppreciation)
                    .HasName("PK_PARAM_Appreciation");

                entity.ToTable("PARAM_Type_Appreciation");

                entity.Property(e => e.CodeTypeAppreciation)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_TYPE_APPRECIATION");

                entity.Property(e => e.CodeEcole)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_ECOLE");

                entity.Property(e => e.IntituleAbregeAppreciation)
                    .HasMaxLength(10)
                    .HasColumnName("INTITULE_ABREGE_APPRECIATION");

                entity.Property(e => e.IntituleAppreciation)
                    .HasMaxLength(30)
                    .HasColumnName("INTITULE_APPRECIATION");

                entity.Property(e => e.Sync).HasColumnName("SYNC");

                entity.Property(e => e.SyncPush)
                    .HasColumnName("SYNC_PUSH")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Valeur)
                    .HasColumnName("VALEUR")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<ParamTypeCommunique>(entity =>
            {
                entity.HasKey(e => e.CodeTypeComm);

                entity.ToTable("PARAM_Type_Communique");

                entity.Property(e => e.CodeTypeComm)
                    .ValueGeneratedNever()
                    .HasColumnName("CODE_TYPE_COMM");

                entity.Property(e => e.CodeEcole)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_ECOLE");

                entity.Property(e => e.Intitule)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("INTITULE");

                entity.Property(e => e.Sync).HasColumnName("SYNC");

                entity.Property(e => e.SyncPush)
                    .HasColumnName("SYNC_PUSH")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<ParamTypeComplementMessage>(entity =>
            {
                entity.HasKey(e => e.CodeTypeComplementMessage);

                entity.ToTable("PARAM_Type_Complement_Message");

                entity.Property(e => e.CodeTypeComplementMessage).HasColumnName("CODE_TYPE_COMPLEMENT_MESSAGE");

                entity.Property(e => e.CodeEcole)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_ECOLE");

                entity.Property(e => e.Intitule)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("INTITULE");

                entity.Property(e => e.Sync).HasColumnName("SYNC");

                entity.Property(e => e.SyncPush)
                    .HasColumnName("SYNC_PUSH")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<ParamTypeCompte>(entity =>
            {
                entity.HasKey(e => e.CodeTypeCompte);

                entity.ToTable("PARAM_Type_Compte");

                entity.Property(e => e.CodeTypeCompte).HasColumnName("CODE_TYPE_COMPTE");

                entity.Property(e => e.CodeEcole)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_ECOLE");

                entity.Property(e => e.Details)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("DETAILS");

                entity.Property(e => e.IntituleCompte)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("INTITULE_COMPTE");

                entity.Property(e => e.PossederPart).HasColumnName("POSSEDER_PART");

                entity.Property(e => e.Sync).HasColumnName("SYNC");

                entity.Property(e => e.SyncPush)
                    .HasColumnName("SYNC_PUSH")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<ParamTypeDelibe>(entity =>
            {
                entity.HasKey(e => e.CodeParamTypeDelibe);

                entity.ToTable("PARAM_Type_Delibe");

                entity.Property(e => e.CodeParamTypeDelibe)
                    .ValueGeneratedNever()
                    .HasColumnName("CODE_PARAM_TYPE_DELIBE");

                entity.Property(e => e.CodeAnnee).HasColumnName("CODE_ANNEE");

                entity.Property(e => e.CodeEcole)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_ECOLE");

                entity.Property(e => e.Intitule)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("INTITULE");

                entity.Property(e => e.Sync).HasColumnName("SYNC");

                entity.Property(e => e.SyncPush)
                    .HasColumnName("SYNC_PUSH")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<ParamTypeEcole>(entity =>
            {
                entity.HasKey(e => e.CodeTypeEcole)
                    .HasName("PK_PARAM_TYPE_ECOLE");

                entity.ToTable("PARAM_Type_Ecole");

                entity.Property(e => e.CodeTypeEcole).HasColumnName("CODE_TYPE_ECOLE");

                entity.Property(e => e.CodeEcole)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_ECOLE");

                entity.Property(e => e.IntituleTypeEcole)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("INTITULE_TYPE_ECOLE");

                entity.Property(e => e.Sync).HasColumnName("SYNC");

                entity.Property(e => e.SyncPush)
                    .HasColumnName("SYNC_PUSH")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<ParamTypeEntiteAdministrative>(entity =>
            {
                entity.HasKey(e => e.CodeTypeEntiteAdministrative)
                    .HasName("PK_TYPE_ENTITE_ADMINISTRATIVE");

                entity.ToTable("PARAM_Type_Entite_Administrative");

                entity.Property(e => e.CodeTypeEntiteAdministrative)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("CODE_TYPE_ENTITE_ADMINISTRATIVE");

                entity.Property(e => e.CodeEcole)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_ECOLE");

                entity.Property(e => e.DenominationAutorite)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DENOMINATION_AUTORITE");

                entity.Property(e => e.LibelleTypeEntite)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LIBELLE_TYPE_ENTITE");

                entity.Property(e => e.NiveauEntite).HasColumnName("NIVEAU_ENTITE");

                entity.Property(e => e.Sync).HasColumnName("SYNC");

                entity.Property(e => e.SyncPush)
                    .HasColumnName("SYNC_PUSH")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<ParamTypeFrai>(entity =>
            {
                entity.HasKey(e => e.CodeTypeFrais)
                    .HasName("PK_FINCAS_Type_Frais");

                entity.ToTable("PARAM_Type_Frais");

                entity.Property(e => e.CodeTypeFrais)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_TYPE_FRAIS");

                entity.Property(e => e.CodeAnneeScolaire).HasColumnName("CODE_ANNEE_SCOLAIRE");

                entity.Property(e => e.EloCodeEcole)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("ELO_CODE_ECOLE");

                entity.Property(e => e.EstActif)
                    .HasColumnName("EST_ACTIF")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.EstInscription).HasColumnName("EST_INSCRIPTION");

                entity.Property(e => e.EstReinscription).HasColumnName("EST_REINSCRIPTION");

                entity.Property(e => e.IntituleTypeFrais)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("INTITULE_TYPE_FRAIS");

                entity.Property(e => e.Sync).HasColumnName("SYNC");

                entity.Property(e => e.SyncPush)
                    .HasColumnName("SYNC_PUSH")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.CodeAnneeScolaireNavigation)
                    .WithMany(p => p.ParamTypeFrais)
                    .HasForeignKey(d => d.CodeAnneeScolaire)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_PARAM_Type_Frais_PARAM_Annee_Scolaire");

                entity.HasOne(d => d.EloCodeEcoleNavigation)
                    .WithMany(p => p.ParamTypeFrais)
                    .HasForeignKey(d => d.EloCodeEcole)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_PARAM_Type_Frais_GLOBAL_Ecole");
            });

            modelBuilder.Entity<ParamTypeMention>(entity =>
            {
                entity.HasKey(e => e.CodeTypeMention);

                entity.ToTable("PARAM_TYPE_MENTION");

                entity.Property(e => e.CodeTypeMention)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_TYPE_MENTION");

                entity.Property(e => e.CodeEcole)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_ECOLE");

                entity.Property(e => e.IntituleAbregeMention)
                    .HasMaxLength(10)
                    .HasColumnName("INTITULE_ABREGE_MENTION");

                entity.Property(e => e.IntituleMention)
                    .HasMaxLength(30)
                    .HasColumnName("INTITULE_MENTION");

                entity.Property(e => e.Sync).HasColumnName("SYNC");

                entity.Property(e => e.SyncPush)
                    .HasColumnName("SYNC_PUSH")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ValeurMax)
                    .HasColumnName("VALEUR_MAX")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ValeurMin)
                    .HasColumnName("VALEUR_MIN")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<ParamTypePeriode>(entity =>
            {
                entity.HasKey(e => e.CodeTypePeriode)
                    .HasName("PK_GLOBAL_Type_Periode");

                entity.ToTable("PARAM_Type_Periode");

                entity.Property(e => e.CodeTypePeriode)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_TYPE_PERIODE");

                entity.Property(e => e.CodeEcole)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_ECOLE");

                entity.Property(e => e.Intitule)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("INTITULE");

                entity.Property(e => e.Sync).HasColumnName("SYNC");

                entity.Property(e => e.SyncPush)
                    .HasColumnName("SYNC_PUSH")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<ParamTypeSignature>(entity =>
            {
                entity.HasKey(e => e.CodeTypeSignature);

                entity.ToTable("PARAM_Type_Signature");

                entity.Property(e => e.CodeTypeSignature).HasColumnName("CODE_TYPE_SIGNATURE");

                entity.Property(e => e.CodeEcole)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_ECOLE");

                entity.Property(e => e.Intitule)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("INTITULE");

                entity.Property(e => e.Sync).HasColumnName("SYNC");

                entity.Property(e => e.SyncPush)
                    .HasColumnName("SYNC_PUSH")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<RaportPaiementBi>(entity =>
            {
                entity.HasKey(e => e.CodePaiement)
                    .HasName("PK__Raport_P__D212042F4119A21D");

                entity.ToTable("Raport_Paiement_BI");

                entity.Property(e => e.CodePaiement)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("CODE_PAIEMENT");

                entity.Property(e => e.CodeFrais)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("CODE_FRAIS");

                entity.Property(e => e.DatePaiement)
                    .HasColumnType("datetime")
                    .HasColumnName("DATE_PAIEMENT");

                entity.Property(e => e.DeviseDuFrais)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("DEVISE_DU_FRAIS");

                entity.Property(e => e.DeviseDuPayer)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("DEVISE_DU_PAYER");

                entity.Property(e => e.Direction)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("DIRECTION");

                entity.Property(e => e.Ecole)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("ECOLE");

                entity.Property(e => e.EloCodeEleve)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("ELO_CODE_ELEVE");

                entity.Property(e => e.EstActifFrais).HasColumnName("EST_ACTIF_FRAIS");

                entity.Property(e => e.EtatEleve)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("ETAT_ELEVE");

                entity.Property(e => e.FullnameEleve)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("FULLNAME_ELEVE");

                entity.Property(e => e.InfoTauxAppliquerPaiement)
                    .HasColumnName("INFO_TAUX_APPLIQUER_PAIEMENT")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IntituleAnneeScolaire)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("INTITULE_ANNEE_SCOLAIRE");

                entity.Property(e => e.IntituleCategorieEleve)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("INTITULE_CATEGORIE_ELEVE");

                entity.Property(e => e.IntituleClasse)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("INTITULE_CLASSE");

                entity.Property(e => e.IntituleFrais)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("INTITULE_FRAIS")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.IntituleTypeFrais)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("INTITULE_TYPE_FRAIS")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MontantDu)
                    .HasColumnName("MONTANT_DU")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MontantFrais)
                    .HasColumnName("MONTANT_FRAIS")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MontantPaye)
                    .HasColumnName("MONTANT_PAYE")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MontantReelPaye)
                    .HasColumnName("MONTANT_REEL_PAYE")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PostnomEleve)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("POSTNOM_ELEVE");

                entity.Property(e => e.PrenomEleve)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("PRENOM_ELEVE");

                entity.Property(e => e.SexeEleve)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SEXE_ELEVE");
            });

            modelBuilder.Entity<SelectMontantApaye>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("selectMontantApaye");

                entity.Property(e => e.Actif1).HasColumnName("actif1");

                entity.Property(e => e.Actif2).HasColumnName("actif2");

                entity.Property(e => e.CodeAnneeScolaire).HasColumnName("CODE_ANNEE_SCOLAIRE");

                entity.Property(e => e.CodeClasse)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_CLASSE");

                entity.Property(e => e.CodeEleve)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("codeEleve");

                entity.Property(e => e.CodeFrais)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_FRAIS");

                entity.Property(e => e.CodeTypeFrais)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_TYPE_FRAIS");

                entity.Property(e => e.Codecategorie)
                    .HasColumnType("text")
                    .HasColumnName("codecategorie");

                entity.Property(e => e.EloCodeEcole)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("ELO_CODE_ECOLE");

                entity.Property(e => e.IntituleFrais)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("INTITULE_FRAIS");

                entity.Property(e => e.MontantAPayer).HasColumnName("MONTANT_A_PAYER");

                entity.Property(e => e.TotalApayeAvecReduct)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("totalApayeAvecReduct");

                entity.Property(e => e.TotalApayeSansReduct)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("totalApayeSansReduct");
            });

            modelBuilder.Entity<Sqlsession>(entity =>
            {
                entity.ToTable("SQLSessions");

                entity.Property(e => e.Id).HasMaxLength(449);

                entity.Property(e => e.Value).IsRequired();
            });

            modelBuilder.Entity<StockCommande>(entity =>
            {
                entity.HasKey(e => e.CodeCommande);

                entity.ToTable("STOCK_Commandes");

                entity.Property(e => e.CodeCommande)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_COMMANDE");

                entity.Property(e => e.CodeFournisseur)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_FOURNISSEUR");

                entity.Property(e => e.DateCommande)
                    .HasColumnType("datetime")
                    .HasColumnName("DATE_COMMANDE");

                entity.Property(e => e.DateReception)
                    .HasColumnType("datetime")
                    .HasColumnName("DATE_RECEPTION");

                entity.Property(e => e.EloCodeEcole)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("ELO_CODE_ECOLE");

                entity.Property(e => e.Observation)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("OBSERVATION");

                entity.Property(e => e.Servie).HasColumnName("SERVIE");

                entity.Property(e => e.Sync).HasColumnName("SYNC");

                entity.Property(e => e.SyncPush).HasColumnName("SYNC_PUSH");
            });

            modelBuilder.Entity<StockCommandeDetail>(entity =>
            {
                entity.HasKey(e => e.CodeCommandeDetail)
                    .HasName("PK_STOCK_Commandes_Details");

                entity.ToTable("STOCK_Commande_Details");

                entity.Property(e => e.CodeCommandeDetail)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_COMMANDE_DETAIL");

                entity.Property(e => e.CodeArticle)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_ARTICLE");

                entity.Property(e => e.CodeCommande)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_COMMANDE");

                entity.Property(e => e.EloCodeEcole)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("ELO_CODE_ECOLE");

                entity.Property(e => e.Quantite).HasColumnName("QUANTITE");

                entity.Property(e => e.Sync).HasColumnName("SYNC");

                entity.Property(e => e.SyncPush).HasColumnName("SYNC_PUSH");
            });

            modelBuilder.Entity<UsersLogin>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("users_login");

                entity.Property(e => e.ActifPortail).HasColumnName("ACTIF_PORTAIL");

                entity.Property(e => e.CodeAgentFonction)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_AGENT_FONCTION");

                entity.Property(e => e.CodeEcole)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_ECOLE");

                entity.Property(e => e.CodeGroupUser).HasColumnName("CODE_GROUP_USER");

                entity.Property(e => e.CodeUtilisateur)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CODE_UTILISATEUR");

                entity.Property(e => e.DateCreation)
                    .HasColumnType("datetime")
                    .HasColumnName("DATE_CREATION");

                entity.Property(e => e.DateExpiration)
                    .HasColumnType("date")
                    .HasColumnName("DATE_EXPIRATION");

                entity.Property(e => e.Domaine)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("DOMAINE");

                entity.Property(e => e.EloCodeEcole)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("ELO_CODE_ECOLE");

                entity.Property(e => e.EstActif).HasColumnName("EST_ACTIF");

                entity.Property(e => e.EstDateExpiration).HasColumnName("EST_DATE_EXPIRATION");

                entity.Property(e => e.MessageRappelPwd)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("MESSAGE_RAPPEL_PWD");

                entity.Property(e => e.NomEcole)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("NOM_ECOLE");

                entity.Property(e => e.Pwd)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("PWD");

                entity.Property(e => e.Sync).HasColumnName("SYNC");

                entity.Property(e => e.SyncPush).HasColumnName("SYNC_PUSH");

                entity.Property(e => e.Username)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("USERNAME");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
