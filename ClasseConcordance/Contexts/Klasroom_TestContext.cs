using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using ClasseConcordance.KlasModels;

#nullable disable

namespace ClasseConcordance.Contexts
{
    public partial class Klasroom_TestContext : DbContext
    {
        public Klasroom_TestContext()
        {
        }

        public Klasroom_TestContext(DbContextOptions<Klasroom_TestContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AnneeScolaire> AnneeScolaires { get; set; }
        public virtual DbSet<AspNetRole> AspNetRoles { get; set; }
        public virtual DbSet<AspNetRoleClaim> AspNetRoleClaims { get; set; }
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; }
        public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUserRole> AspNetUserRoles { get; set; }
        public virtual DbSet<AspNetUserToken> AspNetUserTokens { get; set; }
        public virtual DbSet<AttachedFile> AttachedFiles { get; set; }
        public virtual DbSet<Class> Classes { get; set; }
        public virtual DbSet<Cour> Cours { get; set; }
        public virtual DbSet<CoursClasse> CoursClasses { get; set; }
        public virtual DbSet<Ecole> Ecoles { get; set; }
        public virtual DbSet<Elefe> Eleves { get; set; }
        public virtual DbSet<Evaluation> Evaluations { get; set; }
        public virtual DbSet<Horaire> Horaires { get; set; }
        public virtual DbSet<Lecon> Lecons { get; set; }
        public virtual DbSet<Note> Notes { get; set; }
        public virtual DbSet<Option> Options { get; set; }
        public virtual DbSet<Parcour> Parcours { get; set; }
        public virtual DbSet<Parent> Parents { get; set; }
        public virtual DbSet<ParentsElefe> ParentsEleves { get; set; }
        public virtual DbSet<PeriodeScolaire> PeriodeScolaires { get; set; }
        public virtual DbSet<Presence> Presences { get; set; }
        public virtual DbSet<Professeur> Professeurs { get; set; }
        public virtual DbSet<ProfesseursCour> ProfesseursCours { get; set; }
        public virtual DbSet<Resultat> Resultats { get; set; }
        public virtual DbSet<ResultatElefe> ResultatEleves { get; set; }
        public virtual DbSet<Section> Sections { get; set; }
        public virtual DbSet<SectionOption> SectionOptions { get; set; }
        public virtual DbSet<SolutionEvaluation> SolutionEvaluations { get; set; }
        public virtual DbSet<Sysdiagram> Sysdiagrams { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // #warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                //                 optionsBuilder.UseSqlServer("Data Source=5.189.167.38;Initial Catalog=Klasroom_Test;User ID=sa;Password=elo--@srvK11");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Configuration manquante.");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<AnneeScolaire>(entity =>
            {
                entity.HasKey(e => e.Code)
                    .HasName("PK_ANNEE");

                entity.Property(e => e.Code)
                    .ValueGeneratedNever()
                    .HasColumnName("CODE");

                entity.Property(e => e.CodeEcole)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_ECOLE");

                entity.Property(e => e.DateCreation)
                    .HasColumnType("datetime")
                    .HasColumnName("DATE_CREATION");

                entity.Property(e => e.Debut)
                    .HasColumnType("datetime")
                    .HasColumnName("DEBUT");

                entity.Property(e => e.EstActif).HasColumnName("EST_ACTIF");

                entity.Property(e => e.Fin)
                    .HasColumnType("datetime")
                    .HasColumnName("FIN");

                entity.Property(e => e.Initule)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("INITULE");
            });

            modelBuilder.Entity<AspNetRole>(entity =>
            {

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.NormalizedName).HasMaxLength(256);

            });

            modelBuilder.Entity<AspNetRoleClaim>(entity =>
            {
                entity.Property(e => e.RoleId)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetRoleClaims)
                    .HasForeignKey(d => d.RoleId);
            });

            modelBuilder.Entity<AspNetUser>(entity =>
            {
                entity.Property(e => e.Actif)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0),(0)))");

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.NormalizedEmail).HasMaxLength(256);

                entity.Property(e => e.NormalizedUserName).HasMaxLength(256);

                entity.Property(e => e.UserName).HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetUserClaim>(entity =>
            {

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserClaims)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserLogin>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });

                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.ProviderKey).HasMaxLength(128);

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserLogins)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserRole>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId });


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


                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.Name).HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserTokens)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AttachedFile>(entity =>
            {
                entity.Property(e => e.AttachedFileSize)
                    .IsRequired()
                    .HasMaxLength(80);

                entity.Property(e => e.AttachedFileUrl)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.IdDocument)
                    .IsRequired()
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<Class>(entity =>
            {
                entity.HasKey(e => e.Code)
                    .HasName("PK_CLASSE");

                entity.Property(e => e.Code)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE");

                entity.Property(e => e.CodeEcole)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_ECOLE");

                entity.Property(e => e.Intitule)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("INTITULE");

                entity.Property(e => e.IntituleCourt)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("INTITULE_COURT");

                entity.Property(e => e.Owner).HasMaxLength(30);

                entity.Property(e => e.SectionOption).HasColumnName("SECTION_OPTION");

                entity.Property(e => e.Virtualclass).HasColumnName("VIRTUALCLASS");

                entity.Property(e => e.Whatsappgroup).HasColumnName("WHATSAPPGROUP");

                entity.Property(e => e.CodeClassStandard).HasColumnName("CODE_CLASS_STANDARD");
            });

            modelBuilder.Entity<Cour>(entity =>
            {
                entity.HasKey(e => e.Code)
                    .HasName("PK_COURS");

                entity.Property(e => e.Code)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE");

                entity.Property(e => e.CodeAnneeScolaire).HasColumnName("CODE_ANNEE_SCOLAIRE");

                entity.Property(e => e.CodeEcole)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_ECOLE");

                entity.Property(e => e.Intitule)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("INTITULE");

                entity.Property(e => e.IntituleCourt)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("INTITULE_COURT");
            });

            modelBuilder.Entity<CoursClasse>(entity =>
            {
                entity.HasKey(e => e.Code)
                    .HasName("PK_COURS_CLASSE");

                entity.ToTable("Cours_Classe");

                entity.Property(e => e.Code)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE");

                entity.Property(e => e.CodeAnneeScolaire).HasColumnName("CODE_ANNEE_SCOLAIRE");

                entity.Property(e => e.CodeClasse)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_CLASSE");

                entity.Property(e => e.CodeCours)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_COURS");

                entity.Property(e => e.CodeEcole)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_ECOLE");

                entity.Property(e => e.EstActif).HasColumnName("EST_ACTIF");

                entity.HasOne(d => d.CodeCoursNavigation)
                    .WithMany(p => p.CoursClasses)
                    .HasForeignKey(d => d.CodeCours)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COURS_CLASSE_COURS");
            });

            modelBuilder.Entity<Ecole>(entity =>
            {
                entity.HasKey(e => e.Code)
                    .HasName("PK_ECOLE");

                entity.Property(e => e.Code)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE");

                entity.Property(e => e.Adresse)
                    .IsUnicode(false)
                    .HasColumnName("ADRESSE");

                entity.Property(e => e.Domaine)
                    .HasMaxLength(10)
                    .HasColumnName("DOMAINE");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.Logo)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("LOGO");

                entity.Property(e => e.Nom)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("NOM");

                entity.Property(e => e.NomCourt)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("NOM_COURT");

                entity.Property(e => e.ProfilEcole).HasColumnName("PROFIL_ECOLE");

                entity.Property(e => e.Telephone)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("TELEPHONE");

                entity.Property(e => e.TypeEcole).HasColumnName("TYPE_ECOLE");

                entity.Property(e => e.CodeStandard).HasColumnName("CODE_STANDARD");
            });

            modelBuilder.Entity<Elefe>(entity =>
            {
                entity.HasKey(e => e.Code)
                    .HasName("PK_ELEVE");

                entity.Property(e => e.Code)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE");

                entity.Property(e => e.Adresse)
                    .IsUnicode(false)
                    .HasColumnName("ADRESSE");

                entity.Property(e => e.CodeAuth)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CODE_AUTH");

                entity.Property(e => e.CodeEcole)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_ECOLE");

                entity.Property(e => e.CodePwd)
                    .HasMaxLength(20)
                    .HasColumnName("CODE_PWD");

                entity.Property(e => e.DateInscription)
                    .HasColumnType("datetime")
                    .HasColumnName("DATE_INSCRIPTION");

                entity.Property(e => e.DateNaissance)
                    .HasColumnType("datetime")
                    .HasColumnName("DATE_NAISSANCE");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.EstActif).HasColumnName("EST_ACTIF");

                entity.Property(e => e.LieuNaissance)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LIEU_NAISSANCE");

                entity.Property(e => e.Matricule)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MATRICULE");

                entity.Property(e => e.Nom)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NOM");

                entity.Property(e => e.Postnom)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("POSTNOM");

                entity.Property(e => e.Prenom)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PRENOM");

                entity.Property(e => e.SendSms).HasColumnName("SEND_SMS");

                entity.Property(e => e.Sexe)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SEXE");

                entity.Property(e => e.Telephone)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TELEPHONE");
            });

            modelBuilder.Entity<Evaluation>(entity =>
            {
                entity.HasKey(e => e.Code)
                    .HasName("PK_EVALUATION");

                entity.Property(e => e.Code)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE");

                entity.Property(e => e.CodeAnneeScolaire).HasColumnName("CODE_ANNEE_SCOLAIRE");

                entity.Property(e => e.CodeCours)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_COURS");

                entity.Property(e => e.CodeEcole)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_ECOLE");

                entity.Property(e => e.CodePeriode)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_PERIODE");

                entity.Property(e => e.Contenu).HasColumnName("CONTENU");

                entity.Property(e => e.DateLimite)
                    .HasColumnType("datetime")
                    .HasColumnName("DATE_LIMITE");

                entity.Property(e => e.DatePublication)
                    .HasColumnType("datetime")
                    .HasColumnName("DATE_PUBLICATION");

                entity.Property(e => e.EstPubliee).HasColumnName("EST_PUBLIEE");

                entity.Property(e => e.Intitule)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("INTITULE");

                entity.Property(e => e.Maxima).HasColumnName("MAXIMA");

                entity.Property(e => e.TypeContenu)
                    .HasMaxLength(50)
                    .HasColumnName("TYPE_CONTENU");

                entity.Property(e => e.TypeEvaluation)
                    .HasMaxLength(50)
                    .HasColumnName("TYPE_EVALUATION");

                entity.HasOne(d => d.CodeCoursNavigation)
                    .WithMany(p => p.Evaluations)
                    .HasForeignKey(d => d.CodeCours)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Evaluations_Cours");

                entity.HasOne(d => d.CodePeriodeNavigation)
                    .WithMany(p => p.Evaluations)
                    .HasForeignKey(d => d.CodePeriode)
                    .HasConstraintName("FK_EVALUATION_PERIODE_SCOLAIRE");
            });

            modelBuilder.Entity<Horaire>(entity =>
            {
                entity.HasKey(e => e.Code)
                    .HasName("PK_HORAIRE");

                entity.Property(e => e.Code).HasColumnName("CODE");

                entity.Property(e => e.CodeClasse)
                    .IsRequired()
                    .HasColumnName("CODE_CLASSE");

                entity.Property(e => e.CodeEcole)
                    .IsRequired()
                    .HasColumnName("CODE_ECOLE")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.DateEdition).HasColumnName("DATE_EDITION");

                entity.Property(e => e.DateJour)
                    .HasColumnName("DATE_JOUR")
                    .HasDefaultValueSql("('0001-01-01T00:00:00.0000000')");

                entity.Property(e => e.EstActif)
                    .IsRequired()
                    .HasColumnName("ESt_ACTIF")
                    .HasDefaultValueSql("(CONVERT([bit],(0),0))");

                entity.Property(e => e.Jour)
                    .IsRequired()
                    .HasColumnName("JOUR")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.TypeHoraire).HasColumnName("TYPE_HORAIRE");
            });

            modelBuilder.Entity<Lecon>(entity =>
            {
                entity.HasKey(e => e.Code)
                    .HasName("PK_LECON");

                entity.Property(e => e.Code)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE");

                entity.Property(e => e.CodeAnneeScolaire).HasColumnName("CODE_ANNEE_SCOLAIRE");

                entity.Property(e => e.CodeCours)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_COURS");

                entity.Property(e => e.CodeEcole)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_ECOLE");

                entity.Property(e => e.Contenu)
                    .IsUnicode(false)
                    .HasColumnName("CONTENU");

                entity.Property(e => e.DerniereModification)
                    .HasColumnType("datetime")
                    .HasColumnName("DERNIERE_MODIFICATION");

                entity.Property(e => e.EstPubliee).HasColumnName("EST_PUBLIEE");

                entity.Property(e => e.Illustration)
                    .IsUnicode(false)
                    .HasColumnName("ILLUSTRATION");

                entity.Property(e => e.Intitule)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("INTITULE");

                entity.Property(e => e.TypeContenu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TYPE_CONTENU");
            });

            modelBuilder.Entity<Note>(entity =>
            {
                entity.HasKey(e => e.Code)
                    .HasName("PK_NOTE");

                entity.Property(e => e.Code)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE");

                entity.Property(e => e.CodeAnneeScolaire).HasColumnName("CODE_ANNEE_SCOLAIRE");

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

                entity.Property(e => e.CodePeriode)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_PERIODE");

                entity.Property(e => e.CodeSolutionEvaluation)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_SOLUTION_EVALUATION");

                entity.Property(e => e.Commentaire).HasColumnName("COMMENTAIRE");

                entity.Property(e => e.EstActif).HasColumnName("EST_ACTIF");

                entity.Property(e => e.NoteObtenue)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("NOTE_OBTENUE");

                entity.HasOne(d => d.CodeCoursNavigation)
                    .WithMany(p => p.Notes)
                    .HasForeignKey(d => d.CodeCours)
                    .HasConstraintName("FK_NOTE_COURS");

                entity.HasOne(d => d.CodeEleveNavigation)
                    .WithMany(p => p.Notes)
                    .HasForeignKey(d => d.CodeEleve)
                    .HasConstraintName("FK_NOTE_ELEVE");

                entity.HasOne(d => d.CodePeriodeNavigation)
                    .WithMany(p => p.Notes)
                    .HasForeignKey(d => d.CodePeriode)
                    .HasConstraintName("FK_NOTE_PERIODE_SCOLAIRE");

                entity.HasOne(d => d.CodeSolutionEvaluationNavigation)
                    .WithMany(p => p.Notes)
                    .HasForeignKey(d => d.CodeSolutionEvaluation)
                    .HasConstraintName("FK_NOTE_SOLUTION_EVALUATION");
            });

            modelBuilder.Entity<Option>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Option1)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("Option");
            });

            modelBuilder.Entity<Parcour>(entity =>
            {
                entity.HasKey(e => e.Code)
                    .HasName("PK_PARCOURS");

                entity.Property(e => e.Code)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE");

                entity.Property(e => e.CodeAnneeScolaire).HasColumnName("CODE_ANNEE_SCOLAIRE");

                entity.Property(e => e.CodeClasse)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_CLASSE");

                entity.Property(e => e.CodeEcole)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_ECOLE");

                entity.Property(e => e.CodeEleve)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_ELEVE");

                entity.Property(e => e.DateAffectation)
                    .HasColumnType("datetime")
                    .HasColumnName("DATE_AFFECTATION");

                entity.Property(e => e.EstActif).HasColumnName("EST_ACTIF");

                entity.HasOne(d => d.CodeClasseNavigation)
                    .WithMany(p => p.Parcours)
                    .HasForeignKey(d => d.CodeClasse)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PARCOURS_CLASSE");

                entity.HasOne(d => d.CodeEleveNavigation)
                    .WithMany(p => p.Parcours)
                    .HasForeignKey(d => d.CodeEleve)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PARCOURS_ELEVE");
            });

            modelBuilder.Entity<Parent>(entity =>
            {
                entity.HasKey(e => e.Code)
                    .HasName("PK_PARENT");

                entity.Property(e => e.Code)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE");

                entity.Property(e => e.Adresse)
                    .IsUnicode(false)
                    .HasColumnName("ADRESSE");

                entity.Property(e => e.CodeEcole)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_ECOLE");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.EstActif).HasColumnName("EST_ACTIF");

                entity.Property(e => e.Nom)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NOM");

                entity.Property(e => e.Postnom)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("POSTNOM");

                entity.Property(e => e.Prenom)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PRENOM");

                entity.Property(e => e.Sexe)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SEXE");

                entity.Property(e => e.Telephone)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TELEPHONE");
            });

            modelBuilder.Entity<ParentsElefe>(entity =>
            {
                entity.HasKey(e => e.Code)
                    .HasName("PK_PARENT_ELEVE");

                entity.ToTable("Parents_Eleves");

                entity.Property(e => e.Code)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE");

                entity.Property(e => e.CodeEcole)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_ECOLE");

                entity.Property(e => e.CodeEleve)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_ELEVE");

                entity.Property(e => e.CodeParent)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_PARENT");

                entity.HasOne(d => d.CodeEleveNavigation)
                    .WithMany(p => p.ParentsEleves)
                    .HasForeignKey(d => d.CodeEleve)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PARENT_ELEVE_ELEVE");

                entity.HasOne(d => d.CodeParentNavigation)
                    .WithMany(p => p.ParentsEleves)
                    .HasForeignKey(d => d.CodeParent)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PARENT_ELEVE_PARENT");
            });

            modelBuilder.Entity<PeriodeScolaire>(entity =>
            {
                entity.HasKey(e => e.Code)
                    .HasName("PK_PERIODE_SCOLAIRE");

                entity.Property(e => e.Code)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE");

                entity.Property(e => e.CodeAnneeScolaire).HasColumnName("CODE_ANNEE_SCOLAIRE");

                entity.Property(e => e.CodeEcole)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_ECOLE");

                entity.Property(e => e.Debut)
                    .HasColumnType("datetime")
                    .HasColumnName("DEBUT");

                entity.Property(e => e.EstActif).HasColumnName("EST_ACTIF");

                entity.Property(e => e.Fin)
                    .HasColumnType("datetime")
                    .HasColumnName("FIN");

                entity.Property(e => e.Intitule)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("INTITULE");

                entity.Property(e => e.IntituleCourt)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("INTITULE_COURT");
            });

            modelBuilder.Entity<Presence>(entity =>
            {
                entity.HasKey(e => e.Code)
                    .HasName("PK_PRESENCE");

                entity.Property(e => e.Code).HasColumnName("CODE");

                entity.Property(e => e.CodeClasse)
                    .IsRequired()
                    .HasColumnName("CODE_CLASSE");

                entity.Property(e => e.CodeEcole)
                    .IsRequired()
                    .HasColumnName("CODE_ECOLE");

                entity.Property(e => e.CodeEleve)
                    .IsRequired()
                    .HasColumnName("CODE_ELEVE");

                entity.Property(e => e.Date).HasColumnName("DATE");

                entity.Property(e => e.EnRetard).HasColumnName("EN_RETARD");

                entity.Property(e => e.EstPresent).HasColumnName("EST_PRESENT");

                entity.Property(e => e.Justification).HasColumnName("JUSTIFICATION");

                entity.Property(e => e.MotifAbsence).HasColumnName("MOTIF_ABSENCE");
            });

            modelBuilder.Entity<Professeur>(entity =>
            {
                entity.HasKey(e => e.Code)
                    .HasName("PK_PROFESSEUR");

                entity.Property(e => e.Code)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE");

                entity.Property(e => e.Adresse)
                    .IsRequired()
                    .HasMaxLength(400)
                    .HasColumnName("ADRESSE")
                    .IsFixedLength(true);

                entity.Property(e => e.CodeAuth)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CODE_AUTH");

                entity.Property(e => e.CodeEcole)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_ECOLE");

                entity.Property(e => e.CodePwd)
                    .HasMaxLength(20)
                    .HasColumnName("CODE_PWD");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .HasColumnName("EMAIL")
                    .IsFixedLength(true);

                entity.Property(e => e.EstActif).HasColumnName("EST_ACTIF");

                entity.Property(e => e.Nom)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("NOM")
                    .IsFixedLength(true);

                entity.Property(e => e.Postnom)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("POSTNOM")
                    .IsFixedLength(true);

                entity.Property(e => e.Prenom)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("PRENOM")
                    .IsFixedLength(true);

                entity.Property(e => e.SendSms).HasColumnName("SEND_SMS");

                entity.Property(e => e.Sexe)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("SEXE")
                    .IsFixedLength(true);

                entity.Property(e => e.Telephone)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("TELEPHONE")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<ProfesseursCour>(entity =>
            {
                entity.HasKey(e => e.Code)
                    .HasName("PK_PROFESSEUR_COURS");

                entity.ToTable("Professeurs_Cours");

                entity.Property(e => e.Code)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE");

                entity.Property(e => e.CodeAnneeScolaire)
                    .HasMaxLength(10)
                    .HasColumnName("CODE_ANNEE_SCOLAIRE")
                    .IsFixedLength(true);

                entity.Property(e => e.CodeCours)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_COURS");

                entity.Property(e => e.CodeEcole)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_ECOLE");

                entity.Property(e => e.CodeProfesseur)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_PROFESSEUR");

                entity.Property(e => e.EstActif).HasColumnName("EST_ACTIF");

                entity.HasOne(d => d.CodeProfesseurNavigation)
                    .WithMany(p => p.ProfesseursCours)
                    .HasForeignKey(d => d.CodeProfesseur)
                    .HasConstraintName("FK_PROFESSEUR_COURS_PROFESSEUR");
            });

            modelBuilder.Entity<Resultat>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.Property(e => e.CodeClasse)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CodePeriode)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CodeProfesseur)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.KeyResultat)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ResultatElefe>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.Property(e => e.CodeEleve)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Link)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Section>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.Property(e => e.Code).HasMaxLength(30);

                entity.Property(e => e.Section1)
                    .HasMaxLength(150)
                    .HasColumnName("Section");
            });

            modelBuilder.Entity<SectionOption>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.Property(e => e.Code).HasColumnName("CODE");

                entity.Property(e => e.CodeOption)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_OPTION");

                entity.Property(e => e.CodeSection)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_SECTION");
            });

            modelBuilder.Entity<SolutionEvaluation>(entity =>
            {
                entity.HasKey(e => e.Code)
                    .HasName("PK_SOLUTION_EVALUATION");

                entity.ToTable("Solution_Evaluations");

                entity.Property(e => e.Code)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE");

                entity.Property(e => e.CodeAnneeScolaire).HasColumnName("CODE_ANNEE_SCOLAIRE");

                entity.Property(e => e.CodeEcole)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_ECOLE");

                entity.Property(e => e.CodeEleve)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_ELEVE");

                entity.Property(e => e.CodeEvaluation)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CODE_EVALUATION");

                entity.Property(e => e.Contenu)
                    .IsUnicode(false)
                    .HasColumnName("CONTENU");

                entity.Property(e => e.DateSoumission)
                    .HasColumnType("datetime")
                    .HasColumnName("DATE_SOUMISSION");

                entity.Property(e => e.TypeContenu)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("TYPE_CONTENU");

                entity.HasOne(d => d.CodeEleveNavigation)
                    .WithMany(p => p.SolutionEvaluations)
                    .HasForeignKey(d => d.CodeEleve)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SOLUTION_EVALUATION_ELEVE");

                entity.HasOne(d => d.CodeEvaluationNavigation)
                    .WithMany(p => p.SolutionEvaluations)
                    .HasForeignKey(d => d.CodeEvaluation)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SOLUTION_EVALUATION_EVALUATION");
            });

            modelBuilder.Entity<Sysdiagram>(entity =>
            {
                entity.HasKey(e => e.DiagramId)
                    .HasName("PK__sysdiagr__C2B05B615812160E");

                entity.ToTable("sysdiagrams");

                entity.HasIndex(e => new { e.PrincipalId, e.Name }, "UK_principal_name")
                    .IsUnique();

                entity.Property(e => e.DiagramId).HasColumnName("diagram_id");

                entity.Property(e => e.Definition).HasColumnName("definition");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("name");

                entity.Property(e => e.PrincipalId).HasColumnName("principal_id");

                entity.Property(e => e.Version).HasColumnName("version");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
