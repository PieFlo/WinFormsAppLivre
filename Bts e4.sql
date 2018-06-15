CREATE TABLE Collections
(
    id_collection int not null IDENTITY,
    nom varchar(25) null,
	constraint PK_COLLECTIONS primary key (id_collection)
)

ALTER TABLE Livres
ADD numero_tome int null;

ALTER TABLE Livres
ADD id_collection int null;

alter table Livres
   add constraint FK_LIVRES_APPARTIENT_COLLECTIONS foreign key (id_collection)
      references Collections (id_collection)

	 ALTER TABLE livres
ALTER COLUMN titre varchar(50);




 insert into livres (titre, numero_tome, id_collection) 
 values
 ('Le Secret de l''Espadon T1', 1, 4),
 ('Le Secret de l''Espadon T2', 2, 4),
 ('Le Secret de l''Espadon T3', 3, 4),
 ('Le mystère de la grande pyramide T1', 4, 4),
 ('Le mystère de la grande pyramide T2', 5, 4),
 ('La marque jaune', 6, 4),
 ('L''énigme de l''Atlantide', 7, 4),
 ('S.O.S. météores', 8, 4),
 ('Le Piège diabolique', 9, 4);

  insert into Collections (nom) 
 values
 ('One Piece'),
 ('Sin City'),
 ('Carbon Modifié'),
 ('Blake et Mortimer');


UPDATE Livres SET titre = 'The hard goodbye', numero_tome = 1, id_collection= 2 WHERE id_livre = 3 ;
 select * from livres
select * from collections
select * from users

select distinct nom, titre, numero_tome from collections c, livres l, ventes v where l.id_collection = c.id_collection and v.id_livre = l.id_livre and etape_vente = 'indisponible' and id_vendeur = 1;

insert into ventes (id_acheteur, id_livre, id_vendeur, prix, etape_vente, etat_livre)
	values (null, 11, 1, null, 'indisponible', null);

	select distinct nom, titre, numero_tome from collections c, livres l, ventes v where l.id_collection = c.id_collection and v.id_livre = l.id_livre and etape_vente = 'indisponible' and id_vendeur = 1;

	select * from ventes where id_vendeur = 1;

	select distinct titre, numero_tome from collections c, livres l, ventes v where  and v.id_livre = l.id_livre and id_vendeur = 1 
	
