USE mini_faq;

INSERT INTO users
 (user_lastname, user_firstname, user_email)
VALUES
( "Rabbit", "Zora", "zorb@example.com"),
(" Patchouli", "Édouard", "Patchouli@example.fr"),
( "Satiti", "Eva", "eva.stt@example.com");

INSERT INTO categories
(category_name, category_description, category_order)
VALUES
("Base de données", "Les question relatives aux base de données", 2),
("SQL", "Les questions sur le langage SQL", 3),
("NoSQL", "Les questions sur l'approche NoSQL", 4),
("PHP", "Les questions relatives à PHP", 1);

INSERT INTO questions
 (question_id, question_date, question_label, question_response, user_id)
 VALUES
 (1, "2024-11-23", "Dans MySQL, quel type de données permet de stocker des valeurs numériques dont le maximuml est 127?", "Le type TINYINT stocke des valeurs numériques comprise entre -128 et 127", 3),
 (2, "2024-11-23", "Quels sont les principaux serveurs SQL gratuits ?", "MySQL", "MariaDB", "PostgreSQL", "SQLlte", 2),
 (3, "2024-11-27", "Que signifie le sigle SGBDR?", "Système de Gestion de Base de Donnée Relationelles", 1),
 (4, "2024-12-05", "Que signifie le sigle SQL?", "Strucred Query Language !", 2),
 (5, "2024-12-05", "Que signifie le sigle noSQL?", "Not Only SQL!", 3);

INSERT INTO categories_questions
(question_id, category_name)
VALUES
(1, "Base de données"),
(1, "SQL"),
(2, "Base de données"),
(2, "SQL"),
(3, "Base de données"),
(4, "Base de données"),
(4, "SQL"),
(5, "Base de données"),
(5, "NoSQL");