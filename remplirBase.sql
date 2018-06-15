INSERT INTO PAYS(ID_PAYS, nom_pays)--ok
 VALUES
 (0, 'France'),
  (1, 'Maroc');
 
 --select * from pays

INSERT INTO villes (ID_PAYS, nom_VILLE, CODE_POSTAL)--ok
 VALUES
 (0, 'Aucune', 00000),
 (0, 'Paris', 75000),
 (0, 'Marseille', 13000),
 (0, 'Lyon', 69000),
 (0, 'Montpellier', 34000)
 (1, 'Marrakech', 40000);

--select * from villes

 INSERT INTO USERS(ID_VILLE, username, mdp, email, nom, prenom, DATE_NAISSANCE, ADRESSE, PORTE_MONNAIS, IS_ADMIN)
 VALUES
 (0, 'pieflo', 'password', 'pf.poujol@gmail.com', 'Poujol', 'Pierre-Florent', '19950309', '585 chemin du mas de jaumes', 9999, 1),
 (0, 'dylanoux', 'password', 'sdf@epsi.fr', null, null, null, null, 0, 0),
 (0, 'prof', 'password', 'prof@montpellier-epsi.fr', null, null, null, null, 0, 0),
 (1, 'adri', 'password', 'adri.meniel@gmail.com', 'Meniel', 'Adrien', '19950309', '87 rue de la tuile', 100, 0),
 (5, 'momo', 'password', 'sdf@epsi.fr', 'Nunute', 'Mohamed', '19950309', '87 rue de sgrgh', 100, 0);

 -- select * from users;
 --DELETE FROM users WHERE id_user = 9

 insert into Auteurs(nom_auteur, prenom)
 values
 ('Tolkien', 'J.R.R'),
 ('Oda', 'Eiichirō'),
 ('Miller', 'Frank');
 
 insert into livres (titre) 
 values
 ('Bilbo le Hobbit'),
 ('One Piece T1'),
 ('Sin City T1'),
 ('Carbon Modifié T1');

 --select * from livres;

  insert into ventes (id_acheteur, id_livre, id_vendeur, prix, etape_vente, etat_livre) -- etats : comme neuf, très bon état, bon état, état correct, mauvais état
 values																					-- etapes : disponible, demandé, validé, finalisé
 (null, 3, 1, 8, 'disponible', 'très bon état' ),
 (null, 1, 1, 5, 'disponible', 'bon état' ),
 (null, 1, 2, 3, 'disponible', 'mauvais état' ),
 (null, 2, 2, 15, 'disponible', 'comme neuf' );

-- select * from ventes;
-- select * from users

/* insert into ventes (id_acheteur, id_livre, id_vendeur, prix, etape_vente, etat_livre) -- etats : comme neuf, très bon état, bon état, état correct, mauvais état
 values																					-- etapes : disponible, demandé, validé, finalisé
 (10, 1, 11, 8, 'finalisé', ' bon état' );
 */
 insert into ecrit (ID_AUTEUR ,ID_LIVRE)
 values
 (3, 3),
 (1, 1),
 (2, 2);

 insert into Categories(nom_cat)
 values
 ('Roman'),
 ('Manga'),
 ('Comics'),
 ('BD'),
 ('Light-Novel');

 select * from Categories

 insert into CorrespCat(ID_CAT ,ID_LIVRE)
 values
 (3, 3),
 (1, 1),
 (2, 2)
  (1, 8);

  insert into CorrespCat(ID_CAT ,ID_LIVRE)
 values
 (1, 8);

 insert into Genres(nom_genre)
 values
 ('Fantasy'),
 ('Action'),
 ('Aventure'),
 ('Science-fiction'),
 ('Polar'),
 ('Thriller'),
 ('Classique'),
 ('Erotique'),
 ('Fantastique'),
 ('Policier'),
 ('Jeunesse'),
 ('Horreur'),
 ('Historique'),
 ('Thriller'),
 ('Western');

 -- select * from genres;

  insert into CorrespGenre(ID_GENRE,ID_LIVRE) 
 values
 (1, 1),
 (2, 2),
 (3, 2),
 (5, 3),
 (6, 3);

 /*
 select titre, nom_auteur, prenom, nom_cat as categorie, nom_GENRE as genre
 from livres l, auteurs a, categories c, genres g, ecrit e, CORRESPCAT cc, CORRESPGENRE cg 
 WHERE l.ID_LIVRE=e.ID_LIVRE AND e.ID_AUTEUR=a.ID_AUTEUR and l.ID_LIVRE=cc.ID_LIVRE and c.ID_CAT=cc.ID_CAT and l.ID_LIVRE=cg.ID_LIVRE and cg.ID_GENRE=g.ID_GENRE;

 select titre, username as vendeur
 from Ventes v, Livres l, Users u where v.id_livre=l.id_livre and v.id_vendeur = u.id_user
 */

 --PROCEDURES
 
 CREATE PROCEDURE procInsertUser @Username  varchar(25), @Mdp  varchar(25), @Email varchar(25) AS
	DECLARE  @DBUsername varchar(25),  @DBEmail varchar(25), @exist bit
	SET @exist = 0
	SET @Email = LOWER(@Email)
	DECLARE CurAlreadyExist cursor for select username, email from Users
	OPEN CurAlreadyExist
	fetch next from CurAlreadyExist into @DBUsername, @DBEmail 
	while @@FETCH_STATUS=0
	BEGIN
		IF @DBUsername = @Username
		BEGIN
			print 'Le nom d''utilisateur renseigné est déjà utilisé.'
			set @exist = 1
			BREAK
		END
		ELSE IF @DBEmail = @Email
		BEGIN
			print 'L''adresse email renseigné est déjà utilisé'
			set @exist = 1
			BREAK
		END
		ELSE
			fetch next from CurAlreadyExist into @DBUsername, @DBEmail 
	END
	close CurAlreadyExist 
	deallocate CurAlreadyExist
	IF @exist = 0
	BEGIN
		INSERT INTO USERS(ID_VILLE, username, mdp, email, nom, prenom, DATE_NAISSANCE, ADRESSE, PORTE_MONNAIS, IS_ADMIN)--ok
		VALUES
		(0, @Username, @Mdp, @Email, null, null, null, null, 0, 0);
	END
	RETURN @exist

 
-- EXECUTE procInsertUser  @Username='STS', @Mdp='test' , @Email='teTSTES@teset.fr';
-- drop proc procInsertUser;
-- select * from users

CREATE PROCEDURE procNewVente @idVendeur int, @idLivre  int, @prix  money, @etat varchar(20), @dispo varchar(30) AS
	insert into ventes (id_acheteur, id_livre, id_vendeur, prix, etape_vente, etat_livre)
	values (null, @idLivre, @idVendeur, @prix, @dispo, @etat);
 
-- EXECUTE procNewVente @idVendeur=3, @idLivre=8, @prix=9.99, @etat='comme neuf';
-- EXECUTE procNewVente @idVendeur=1, @livre='carbon modifié', @prix=99, @etat='bon';
-- drop proc procNewVente;
-- select id_vente, id_acheteur, id_vendeur, titre, prix, etape_vente, etat_livre from ventes v, Livres l where l.id_livre = v.id_livre;
select * from livres;

	CREATE PROC procAchat @idVente int, @idAcheteur int AS
		DECLARE  @prix money, @porte_monnais money, @payable bit
		SET @payable = 0
		SET @porte_monnais = (SELECT porte_monnais FROM Users WHERE id_user = @idAcheteur)
		SET @prix = (SELECT prix FROM Ventes WHERE id_vente = @idVente)
		IF @porte_monnais >= @prix
			BEGIN
				UPDATE Ventes
				SET id_acheteur = @idAcheteur,
				etape_vente = 'demandé'
				WHERE id_vente = @idVente and etape_vente= 'disponible';
				SET @payable = 1
			END
		RETURN @payable

	drop proc procAchat			
-- TRIGGER

CREATE TRIGGER trigUpdateVente ON Ventes AFTER UPDATE AS
	DECLARE @etape varchar(20), @prix money, @id_vendeur int
	SET @etape = (select etape_vente from inserted)
	SET @prix =(select prix from inserted)
	SET @id_vendeur = (select id_vendeur from inserted)
	IF (@etape = 'demandé') -- l'acheteur a fais une promesse d'achat
	BEGIN
		UPDATE Users 
		SET porte_monnais = porte_monnais - @prix
		WHERE id_user = (select id_acheteur from inserted)
	END
	ELSE IF (@etape = 'disponible') --le vendeur a refusé l'achat
	BEGIN
		UPDATE Users 
		SET porte_monnais = porte_monnais + @prix
		WHERE id_user = (select id_acheteur from deleted)
	END
	ELSE IF (@etape = 'validé') --le vendeur a confirmé l'achat
	BEGIN
		UPDATE Users 
		SET porte_monnais = porte_monnais + @prix
		WHERE id_user = @id_vendeur
	END

-- DROP TRIGGER trigUpdateVente
/* 
-- etape 1
UPDATE Ventes
SET id_acheteur = 1,
	etape_vente = 'demandé'
WHERE id_vente = 4 and etape_vente= 'disponible';

-- etape 2 refus
UPDATE Ventes
SET etape_vente = 'disponible',
	id_acheteur = NULL
WHERE id_vente = 4 and etape_vente= 'demandé';

-- etape 2 accepté
UPDATE Ventes
SET etape_vente = 'validé'
WHERE id_vente = 4 and etape_vente= 'demandé';

select id_vente, id_acheteur, id_vendeur, titre, prix, etape_vente, etat_livre from ventes v, Livres l where l.id_livre = v.id_livre;
select id_user, username, porte_monnais from users;
*/




---------------------------------

select count(id_vente) as 'Nbr de roman acheté par adrien' 
from ventes, users, Categories, CorrespCat, Livres
where prenom = 'Adrien' and etape_vente = 'finalisé' and nom_cat = 'Roman' 
and Ventes.id_acheteur = Users.id_user and Livres.id_livre = Ventes.id_livre and Livres.id_livre = CorrespCat.id_livre and CorrespCat.id_cat = Categories.id_cat;

insert into ventes (id_acheteur, id_livre, id_vendeur, prix, etape_vente, etat_livre)
 values	
 (10, 1, 11, 8, 'finalisé', ' bon état' );
 
select * from ventes
select * from users
select * from Livres, Categories, CorrespCat where Livres.id_livre = CorrespCat.id_livre and CorrespCat.id_cat = Categories.id_cat;

-- Livres en vente (disponible à l'achat) au Maroc

select id_vente, titre as 'livre dispo à la vente', username as 'vendeur', nom_pays as 'pays du vendeur' from Ventes, Users, pays, Villes, livres
where etape_vente = 'disponible' and nom_pays = 'Maroc' and Ventes.id_vendeur = Users.id_user and ventes.id_livre = Livres.id_livre and users.id_ville = Villes.id_ville and pays.id_pays = Villes.id_pays;

insert into ventes (id_acheteur, id_livre, id_vendeur, prix, etape_vente, etat_livre) -- etats : comme neuf, très bon état, bon état, état correct, mauvais état
 values																					-- etapes : disponible, demandé, validé, finalisé
 (null, 2, 11, 8, 'disponible', 'bon état' );

-- Livres mis en vente dans les catégories des livres acheté par Adrien 

select distinct nom_cat 
from users, Categories, ventes, Livres, CorrespCat
where prenom = 'Adrien' and Ventes.id_acheteur = Users.id_user and Livres.id_livre = Ventes.id_livre and Livres.id_livre = CorrespCat.id_livre and CorrespCat.id_cat = Categories.id_cat;

select distinct titre from ventes, Livres, CorrespCat, Categories
where Livres.id_livre = Ventes.id_livre and Livres.id_livre = CorrespCat.id_livre and CorrespCat.id_cat = Categories.id_cat 
and nom_cat in	(
				select distinct nom_cat 
				from users, Categories, ventes, Livres, CorrespCat
				where prenom = 'Adrien' and Ventes.id_acheteur = Users.id_user and Livres.id_livre = Ventes.id_livre and Livres.id_livre = CorrespCat.id_livre and CorrespCat.id_cat = Categories.id_cat
				);

insert into ventes (id_acheteur, id_livre, id_vendeur, prix, etape_vente, etat_livre)
 values	
 (10, 4, 11, 8, 'finalisé', ' bon état' );

 select id_acheteur username from ventes, users where id_acheteur = id_user OR id_acheteur IS NULL

 select * from users


SELECT titre, prix, etat_livre,  etape_vente, id_vente, l.id_livre FROM Ventes v, Livres l, Users 
                                                        WHERE v.id_livre = l.id_livre AND v.id_vendeur = id_user
                                                         and id_vendeur = 2

SELECT titre, prix, etat_livre, acheteur.username, etape_vente, id_vente, l.id_livre FROM Ventes v, Livres l, Users vendeur, Users acheteur
                                                        WHERE v.id_livre = l.id_livre AND v.id_acheteur = acheteur.id_user and v.id_vendeur = vendeur.id_user
                                                         and id_vendeur = 1

CREATE PROC listMySale @idVendeur
SELECT titre, prix, etat_livre, acheteur.username, etape_vente, id_vente, l.id_livre 
FROM Ventes v, Livres l, Users vendeur, Users acheteur
WHERE v.id_livre = l.id_livre AND v.id_acheteur = vendeur.id_user 
and v.id_vendeur = acheteur.id_user and id_vendeur = @id_vendeur


select * from ventes

UPDATE Ventes SET etape_vente = 'validé' WHERE id_vente = 21 and etape_vente = 'finalisé';