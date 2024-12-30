/*INSERER LE JEU D'ESSAI DANS LA TABLE FILMS
Sous langage : DML /LMD
Data Manipulation des données
Principales instructions :
INSERT / Ajouter des nouvelles données dans la table
UPDATE : Mettre à jourdes données existante dans une table
DELETE :Suprimer des données existantes dans une table
TRUNCATE :VIDER une table
*/

-- Sélectionner la base de données
USE videos;

-- DELETE FROM realisateur; -- suprime toute les données de la table realisateur


TRUNCATE TABLE film_acteur; -- vider la table film_acteur et réinitialise l'auto incrément
TRUNCATE TABLE acteur; -- vider la table acteur et réinitialise l'auto_incrément
TRUNCATE TABLE realistaeur; -- vider la table realisateur


/* Insertion des données dans la table "realisateur" */

INSERT INTO realisateur
VALUES
(NULL, "Besson", "Luc"),
(NULL, "Spielber", "Steven"),
(NULL, "Carpenter", "Jhon");

INSERT INTO acteur
(acteur_nom, acteur_prenom)
VALUES
("Jean", "réno"),
("Mel", "Gibson"),
("Tom", "Holland"),
("Eva", "Green"),
("Emma", "Watson");

