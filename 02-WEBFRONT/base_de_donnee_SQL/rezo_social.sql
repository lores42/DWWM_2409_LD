/* suprimer la base de données si la publication existe*/
DROP DATABASE IF EXISTS rezo_social;

/* crée la base de données si la publication n'existe pas*/
CREATE DATABASE IF NOT EXISTS rezo_social;

/* SELECTIONNER/UTILISER LA BASE DE DONNEES CREE*/
USE rezo_social;

/*crée la table nomée utilisateur*/
CREATE TABLE utilisateur
(
	id INT PRIMARY KEY ,
    nom_utilisateur VARCHAR(100) NOT NULL,
    email VARCHAR(255) NOT NULL
);

/*crée la table nomée publication*/ 
CREATE TABLE publication
(
	pub_id INT PRIMARY KEY AUTO_INCREMENT,
    pub_date DATETIME NOT NULL,
    pub_titre VARCHAR(255),
    pub_contenu TEXT,
    id INT,
    FOREIGN KEY(id) REFERENCES utilisateur(id)
);

/*crée une table aimer*/
CREATE TABLE aimer
(
	id INT,
    pub_id INT,
	PRIMARY KEY (id, pub_id ),
	FOREIGN KEY(id) REFERENCES utilisateur(id),
	FOREIGN KEY(pub_id) REFERENCES publication(pub_id)
);
/* Modifier la table publication et y ajouetr une clé étrangère */
ALTER TABLE publication  ADD FOREIGN KEY (id) REFERENCES utilisateur(id);

ALTER TABLE aimer ADD CONSTRAINT fk_aimer_utilisateur FOREIGN KEY (id) REFERENCES utilisateur (id);