USE mini_faq;

-- 1 Sélectionner tous les utilisateurs (identifiant, nom, prénom, email).

SELECT user_lastname, user_firstname, user_email
FROM users;

-- 2 Sélectionner toutes les questions (date, intitulé, réponse, identifiant utilisateur) triées par date de la plus ancienne à la plus récente.

SELECT question_id, question_date, question_label, question_response, user_id
FROM questions;

-- 3 Sélectionner les questions (identifiant, date, intitulé, réponse) de l’utilisateur n°2.

SELECT question_id, question_date, question_label, question_response
FROM questions 
WHERE user_id = 2;

-- 4 Sélectionner les questions (date, intitulé, réponse, identifiant utilisateur) de l’utilisateur Eva Satiti.

SELECT question_id, question_date, question_label, question_response, questions.user_id,user_lastname
FROM questions inner join users on users.user_id=questions.user_id
WHERE questions.user_id = (SELECT user_id FROM users WHERE user_lastname = "satiti" and user_firstname = "eva");



-- 5 Sélectionner les questions (identifiant, date, intitulé, réponse, identifiant utilisateur) dont l’intitulé contient “SQL”. Le résultat est trié par le titre et par ordre décroissant.

SELECT question_id, question_date, question_label, question_response, user_id
FROM questions
WHERE question_response like "%SQL%";

-- 6 Sélectionner les catégories (nom, description) sans question associée.

SELECT category_name, category_description
FROM categories INNER JOIN categories_questions
on catergories.category_name = categories_questions.category_name
WHERE categories.category_name NOT IN (SELECT DISTINCT categories_questions.category_name FROM categories_questions);
SELECT DISTINCT categories_questions.category_name FROM categories_questions;
-- 7 Sélectionner les questions triées par titre (ordre alphabétique) avec le nom et prénom de l’auteur (nécessite une jointure).

-- 8 Sélectionner les catégories (nom) avec, pour chaque catégorie le nombre de questions associées (nécessite une jointure).