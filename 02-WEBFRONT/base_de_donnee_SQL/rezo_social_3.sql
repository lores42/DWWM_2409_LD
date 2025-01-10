-- Sélectionner nom utilisateur et l'email.
SELECT nom_utilisateur, email
FROM utilisateur;

-- Sélectionner pub-titre, pub_date, pub_contenu, id.
SELECT pub_titre, pub_date, pub_contenu, id
FROM publication
ORDER BY pub_date desc;

SELECT pub_titre, pub_id, pub_contenu 
FROM publication
WHERE pub_titre LIKE"%a%"
ORDER BY pub_titre DESC;

SELECT id, nom_utilisateur, email
FROM utilisateur
WHERE email LIKE "%com";

 -- Version sans joiture
 SELECT * FROM publication, utilisateur 
 WHERE publication.id = utilisateur.id
 ORDER BY publication.pub_titre; 
 
 SELECT * FROM publication
 INNER JOIN utilisateur ON publication.id = utilisateur.id
 ORDER BY publication.pub_titre;