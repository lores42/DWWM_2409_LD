/* supprimer la base de donnees si elle exixste*/
DROP DATABASE IF EXISTS mini_faq;

/* créer la base de donnée si elle n'existe pas */
CREATE DATABASE mini_faq;

/* utiliser / sélectionner la base de donnée foire_aux_questions */
USE mini_faq;

/* crée la table utilisateur */
CREATE TABLE users
(
user_id INT PRIMARY KEY AUTO_INCREMENT,
user_email VARCHAR(128) NOT NULL UNIQUE,
user_lastname VARCHAR(50) NOT NULL,
user_firstname VARCHAR(50) NOT NULL
);

/* crée la table categories  */
CREATE TABLE categories
(
category_name VARCHAR(100) NOT NULL PRIMARY KEY,
category_description VARCHAR(255),
category_order TINYINT NOT NULL
);

/* crée la table questions */
CREATE TABLE questions
(
question_id INT PRIMARY KEY AUTO_INCREMENT,
question_date DATE NOT NULL,
question_label VARCHAR(255) NOT NULL,
question_response TEXT NOT NULL,
user_id int
);

/*crée la table categories_questions */
CREATE TABLE categories_questions
(
category_name VARCHAR(100) NOT NULL,
question_id INT 
);

/* Modifier la table publication et y ajouter la clé étrangère */
ALTER TABLE questions ADD FOREIGN KEY (user_id) REFERENCES users(user_id);
 
/* CONTRAINTES */
ALTER TABLE categories_questions ADD CONSTRAINT fk_categories_questions_questions FOREIGN KEY(question_id) REFERENCES questions(question_id);
ALTER TABLE categories_questions ADD CONSTRAINT fk_categories_questions_categories FOREIGN KEY(category_name) REFERENCES categories(category_name);
