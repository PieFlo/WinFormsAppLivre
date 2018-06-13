/*==============================================================*/
/* Nom de SGBD :  Microsoft SQL Server 2014                     */
/* Date de création :  19/04/2018 11:44:47                      */
/*==============================================================*/


if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('CorrespCat') and o.name = 'FK_CORRESPC_CORRESPCA_LIVRES')
alter table CorrespCat
   drop constraint FK_CORRESPC_CORRESPCA_LIVRES
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('CorrespCat') and o.name = 'FK_CORRESPC_CORRESPCA_CATEGORI')
alter table CorrespCat
   drop constraint FK_CORRESPC_CORRESPCA_CATEGORI
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('CorrespGenre') and o.name = 'FK_CORRESPO_CORRESPON_LIVRE2')
alter table CorrespGenre
   drop constraint FK_CORRESPO_CORRESPON_LIVRE2
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('CorrespGenre') and o.name = 'FK_CORRESPG_CORRESPGE_GENRES')
alter table CorrespGenre
   drop constraint FK_CORRESPG_CORRESPGE_GENRES
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Ecrit') and o.name = 'FK_ECRIT_ECRIT_LIVRES')
alter table Ecrit
   drop constraint FK_ECRIT_ECRIT_LIVRES
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Ecrit') and o.name = 'FK_ECRIT_ECRIT2_AUTEURS')
alter table Ecrit
   drop constraint FK_ECRIT_ECRIT2_AUTEURS
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Users') and o.name = 'FK_USERS_HABITE_VILLES')
alter table Users
   drop constraint FK_USERS_HABITE_VILLES
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Ventes') and o.name = 'FK_VENTES_ACHETE_USERS')
alter table Ventes
   drop constraint FK_VENTES_ACHETE_USERS
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Ventes') and o.name = 'FK_VENTES_VEND_USERS')
alter table Ventes
   drop constraint FK_VENTES_VEND_USERS
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Ventes') and o.name = 'FK_VENTES_VENDU_LIVRES')
alter table Ventes
   drop constraint FK_VENTES_VENDU_LIVRES
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Villes') and o.name = 'FK_VILLES_APPARTIEN_PAYS')
alter table Villes
   drop constraint FK_VILLES_APPARTIEN_PAYS
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Auteurs')
            and   type = 'U')
   drop table Auteurs
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Categories')
            and   type = 'U')
   drop table Categories
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('CorrespCat')
            and   name  = 'CORRESPOND_CAT_FK'
            and   indid > 0
            and   indid < 255)
   drop index CorrespCat.CORRESPOND_CAT_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('CorrespCat')
            and   name  = 'CORRESPOND_CAT2_FK'
            and   indid > 0
            and   indid < 255)
   drop index CorrespCat.CORRESPOND_CAT2_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('CorrespCat')
            and   type = 'U')
   drop table CorrespCat
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('CorrespGenre')
            and   name  = 'CORRESPOND_GENRE_FK'
            and   indid > 0
            and   indid < 255)
   drop index CorrespGenre.CORRESPOND_GENRE_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('CorrespGenre')
            and   name  = 'CORRESPOND_GENRE2_FK'
            and   indid > 0
            and   indid < 255)
   drop index CorrespGenre.CORRESPOND_GENRE2_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('CorrespGenre')
            and   type = 'U')
   drop table CorrespGenre
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('Ecrit')
            and   name  = 'ECRIT_FK'
            and   indid > 0
            and   indid < 255)
   drop index Ecrit.ECRIT_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('Ecrit')
            and   name  = 'ECRIT2_FK'
            and   indid > 0
            and   indid < 255)
   drop index Ecrit.ECRIT2_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Ecrit')
            and   type = 'U')
   drop table Ecrit
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Genres')
            and   type = 'U')
   drop table Genres
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Livres')
            and   type = 'U')
   drop table Livres
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Pays')
            and   type = 'U')
   drop table Pays
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('Users')
            and   name  = 'HABITE_FK'
            and   indid > 0
            and   indid < 255)
   drop index Users.HABITE_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Users')
            and   type = 'U')
   drop table Users
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('Ventes')
            and   name  = 'VEND_FK'
            and   indid > 0
            and   indid < 255)
   drop index Ventes.VEND_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('Ventes')
            and   name  = 'VENTU_FK'
            and   indid > 0
            and   indid < 255)
   drop index Ventes.VENTU_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('Ventes')
            and   name  = 'ACHETE_FK'
            and   indid > 0
            and   indid < 255)
   drop index Ventes.ACHETE_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Ventes')
            and   type = 'U')
   drop table Ventes
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('Villes')
            and   name  = 'APPARTIENT_FK'
            and   indid > 0
            and   indid < 255)
   drop index Villes.APPARTIENT_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Villes')
            and   type = 'U')
   drop table Villes
go

/*==============================================================*/
/* Table : Auteurs                                              */
/*==============================================================*/
create table Auteurs (
   id_auteur            int                  not null IDENTITY,
   nom_auteur           varchar(30)          null,
   prenom               varchar(30)          null,
   constraint PK_AUTEURS primary key (id_auteur)
)
go

/*==============================================================*/
/* Table : Categories                                           */
/*==============================================================*/
create table Categories (
   id_cat               int                  not null IDENTITY,
   nom_cat              varchar(30)          null,
   constraint PK_CATEGORIES primary key (id_cat)
)
go

/*==============================================================*/
/* Table : CorrespCat                                           */
/*==============================================================*/
create table CorrespCat (
   id_cat               int                  not null,
   id_livre             int                  not null,
   constraint PK_CORRESPCAT primary key nonclustered (id_cat, id_livre),
   constraint AK_IDENTIFIER_1_CORRESPC unique (id_cat, id_livre)
)
go

/*==============================================================*/
/* Index : CORRESPOND_CAT2_FK                                   */
/*==============================================================*/




create nonclustered index CORRESPOND_CAT2_FK on CorrespCat (id_cat ASC)
go

/*==============================================================*/
/* Index : CORRESPOND_CAT_FK                                    */
/*==============================================================*/




create nonclustered index CORRESPOND_CAT_FK on CorrespCat (id_livre ASC)
go

/*==============================================================*/
/* Table : CorrespGenre                                         */
/*==============================================================*/
create table CorrespGenre (
   id_genre             int                  not null,
   id_livre             int                  not null,
   constraint PK_CORRESPGENRE primary key nonclustered (id_genre, id_livre),
   constraint AK_IDENTIFIER_1_CORRESPG unique (id_genre, id_livre)
)
go

/*==============================================================*/
/* Index : CORRESPOND_GENRE2_FK                                 */
/*==============================================================*/




create nonclustered index CORRESPOND_GENRE2_FK on CorrespGenre (id_genre ASC)
go

/*==============================================================*/
/* Index : CORRESPOND_GENRE_FK                                  */
/*==============================================================*/




create nonclustered index CORRESPOND_GENRE_FK on CorrespGenre (id_livre ASC)
go

/*==============================================================*/
/* Table : Ecrit                                                */
/*==============================================================*/
create table Ecrit (
   id_auteur            int                  not null,
   id_livre             int                  not null,
   constraint PK_ECRIT primary key nonclustered (id_auteur, id_livre),
   constraint AK_IDENTIFIER_1_ECRIT unique clustered (id_auteur, id_livre)
)
go

/*==============================================================*/
/* Index : ECRIT2_FK                                            */
/*==============================================================*/




create nonclustered index ECRIT2_FK on Ecrit (id_auteur ASC)
go

/*==============================================================*/
/* Index : ECRIT_FK                                             */
/*==============================================================*/




create nonclustered index ECRIT_FK on Ecrit (id_livre ASC)
go

/*==============================================================*/
/* Table : Genres                                               */
/*==============================================================*/
create table Genres (
   id_genre             int                  not null IDENTITY,
   nom_genre            varchar(30)          null,
   constraint PK_GENRES primary key (id_genre)
)
go

/*==============================================================*/
/* Table : Livres                                               */
/*==============================================================*/
create table Livres (
   id_livre             int                  not null IDENTITY,
   titre                varchar(30)          null,
   constraint PK_LIVRES primary key (id_livre)
)
go

/*==============================================================*/
/* Table : Pays                                                 */
/*==============================================================*/
create table Pays (
   id_pays              int                  not null,
   nom_pays             varchar(30)          null,
   constraint PK_PAYS primary key (id_pays)
)
go

/*==============================================================*/
/* Table : Users                                                */
/*==============================================================*/
create table Users (
   id_user              int                  not null IDENTITY,
   id_ville             int                  not null,
   username             varchar(25)          null,
   mdp                  varchar(25)          null,
   email                varchar(25)          null,
   nom					varchar(25)			 null,
   prenom				varchar(25)			 null,
   date_naissance       datetime             null,
   adresse              varchar(50)          null,
   porte_monnais        int                  null,
   is_admin             bit                  null,
   constraint PK_USERS primary key (id_user)
)
go

/*==============================================================*/
/* Index : HABITE_FK                                            */
/*==============================================================*/




create nonclustered index HABITE_FK on Users (id_ville ASC)
go

/*==============================================================*/
/* Table : Ventes                                               */
/*==============================================================*/
create table Ventes (
   id_vente             int                  not null IDENTITY,
   id_acheteur          int                  null,
   id_livre             int                  not null,
   id_vendeur           int                  not null,
   prix                 money                null,
   etape_vente          varchar(20)          null,
   etat_livre           varchar(20)          null,
   constraint PK_VENTES primary key nonclustered (id_vente, id_livre, id_vendeur),
   --constraint AK_IDENTIFIER_1_VENTES unique (id_acheteur, id_livre, id_vendeur)
)
go

/*==============================================================*/
/* Index : ACHETE_FK                                            */
/*==============================================================*/




create nonclustered index ACHETE_FK on Ventes (id_acheteur ASC)
go

/*==============================================================*/
/* Index : VENTU_FK                                             */
/*==============================================================*/




create nonclustered index VENTU_FK on Ventes (id_livre ASC)
go

/*==============================================================*/
/* Index : VEND_FK                                              */
/*==============================================================*/




create nonclustered index VEND_FK on Ventes (id_vendeur ASC)
go

/*==============================================================*/
/* Table : Villes                                               */
/*==============================================================*/
create table Villes (
   id_ville             int                  not null IDENTITY(0,1),
   id_pays              int                  not null,
   nom_ville            varchar(20)          null,
   code_postal          varchar(10)          null,
   constraint PK_VILLES primary key (id_ville)
)
go

/*==============================================================*/
/* Index : APPARTIENT_FK                                        */
/*==============================================================*/




create nonclustered index APPARTIENT_FK on Villes (id_pays ASC)
go

alter table CorrespCat
   add constraint FK_CORRESPC_CORRESPCA_LIVRES foreign key (id_livre)
      references Livres (id_livre)
go

alter table CorrespCat
   add constraint FK_CORRESPC_CORRESPCA_CATEGORI foreign key (id_cat)
      references Categories (id_cat)
go

alter table CorrespGenre
   add constraint FK_CORRESPO_CORRESPON_LIVRE2 foreign key (id_livre)
      references Livres (id_livre)
go

alter table CorrespGenre
   add constraint FK_CORRESPG_CORRESPGE_GENRES foreign key (id_genre)
      references Genres (id_genre)
go

alter table Ecrit
   add constraint FK_ECRIT_ECRIT_LIVRES foreign key (id_livre)
      references Livres (id_livre)
go

alter table Ecrit
   add constraint FK_ECRIT_ECRIT2_AUTEURS foreign key (id_auteur)
      references Auteurs (id_auteur)
go

alter table Users
   add constraint FK_USERS_HABITE_VILLES foreign key (id_ville)
      references Villes (id_ville)
go

alter table Ventes
   add constraint FK_VENTES_ACHETE_USERS foreign key (id_acheteur)
      references Users (id_user)
go

alter table Ventes
   add constraint FK_VENTES_VEND_USERS foreign key (id_vendeur)
      references Users (id_user)
go

alter table Ventes
   add constraint FK_VENTES_VENDU_LIVRES foreign key (id_livre)
      references Livres (id_livre)
go

alter table Villes
   add constraint FK_VILLES_APPARTIEN_PAYS foreign key (id_pays)
      references Pays (id_pays)
go

