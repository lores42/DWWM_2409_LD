/*
commentaire
*/
-- commentaire
/*
Création de la base de données
Sous langage : DDL/ LDD
Data langage definition
Langage de définition des données
Principales instruction :
CCREAT = Crée une strcuture ( DATABASE, TABLE, VIEW, TRIGGER, fUNCTION)
ALTER = Modifier une structure existante
DROP = Supprimer une structure existance
*/

/* supprimer la base de donnees si elle exixste*/
DROP DATABASE IF EXISTS videos;

/*CRÉE UNE BASE DE DONNÉE NOMMÉE "videos" SI ELLE N'EXIXSTE PAS*/ 
-- CREAT DATABASE videos;
CREATE DATABASE IF NOT EXISTS videos;

/* SELECTIONNER/UTILISER LA BASE DE DONNEES CREE */
USE video;

/* UTILISER LA BASES DE DONNÉE CRÉE*/
USE videos;

-- les requêtes qui suivent utiliseront 
-- la base de donnée séléctionné ci-dessus

/*
CREE UNE TABLE NNOMMEE "realisateur"*/
CREATE TABLE realisateur
(
	realisateur_id INT PRIMARY KEY AUTO_INCREMENT,
    realisateur_nom VARCHAR(100) NOT NULL,
    realisateur_prenom VARCHAR(100) NOT NULL
);
CREATE TABLE acteur
(
	acteur_id INT PRIMARY KEY AUTO_INCREMENT,
    acteur_nom VARCHAR(100) NOT NULL,
    acteur_prenom VARCHAR(100) NOT NULL,
    PRIMARY KEY (acteur_id, acteur_nom)
);
/*CRÉE UNE TABLE NOMMÉE "film"*/
CREATE TABLE IF NOT EXISTS film
(
	film_id INT AUTO_INCREMENT PRIMARY KEY,
    film_titre VARCHAR(255) NOT NULL,
    film_duree SMALLINT NOT NULL,
    realisateur_id INT,
    PRIMARY KEY (film_id)
);

CREATE TABLE film
(
	film_id INT PRIMARY KEY AUTO_INCREMENT,
    film_titre VARCHAR(255) NOT NULL,
    film_duree SMALLINT NOT NULL,
    PRIMARY KEY (acteur_id, acteur_nom)
);

CREATE TABLE film_acteur
(
	film_id INT,
    acteur_id INT,
    realisateur_id INT,
    PRIMARY KEY (film_id),
    FOREIGN KEY (realisateur_id) REFERENCES realisateur(realisateur_id)
)

/* INSERER LE JEUX D'EASSSAI DANS LA TABLE FILMS*/
INSERT INTO film
VALUES
(NULL, "Léon", 120),
(NULL, "E.T", 90),
(NULL, "ça", 103);

INSERT INTO film
(film_titre, film_duree)
VALUES
("L'EXORCISTE", 240),
("Super Papa", 87),
("Gladiator2", 117);


INSERT INTO film
(film_duree, film_titre)
VALUES
(98,"Loups-Garous");


/* AFFICHER LES DONNÉES */

SELECT * FROM film;

SELECT ilm-id, film_titre from film;
