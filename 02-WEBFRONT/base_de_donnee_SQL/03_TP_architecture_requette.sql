USE db_architecte;
set lc_time_names = 'fr_FR';

/* 1. Sélectionner l'identifiant, le nom de tous les clients dont le numéro de téléphone commence par '04' */
SELECT  client_ref, client_nom, client_telephone
FROM clients
WHERE client_telephone like '04%';
/* 2. Sélectionner l'identifiant, le nom et le type de tous les clients qui sont des particuliers */
SELECT client_ref, client_nom, type_client_libelle
FROM clients
JOIN type_clients ON clients.type_client_id = type_clients.type_client_id
WHERE type_client_libelle="Particulier";

/* 3. Sélectionner l'identifiant, le nom et le type de tous les clients qui ne sont pas des particuliers */
SELECT client_ref, client_nom, type_client_libelle
FROM clients
JOIN type_clients ON clients.type_client_id = type_clients.type_client_id
WHERE type_client_libelle !="Particulier";

/* 4. Sélectionner les projets qui ont été livrés en retard */
SELECT *
FROM projets 
WHERE projet_date_fin_prevue < projet_date_fin_effective;

/* 5. Sélectionner la date de dépôt, la date de fin prévue, les superficies, le prix de tous les projets 
    avec le nom du client et le nom de l'architecte associés au projet */
SELECT  projet_date_depot, projet_date_fin_prevue, projet_superficie_totale, projet_superficie_batie, projet_prix, client_nom, employes.emp_nom, fonctions.fonction_nom
FROM projets
INNER JOIN clients ON clients.client_ref = projets.client_ref
INNER JOIN employes ON employes.emp_matricule=projets.emp_matricule
INNER JOIN fonctions ON fonctions.fonction_id=employes.fonction_id
WHERE fonctions.fonction_nom="Architecte";

/* 6. Sélectionner tous les projets (dates, superficies, prix) avec le nombre d'intervenants autres que le client et l'architecte */

SELECT participer.projet_ref, projet_date_depot, projet_superficie_totale, projet_prix, COUNT(particulier.emp_matricule)
FROM projets	
JOIN participer ON participer.projet_ref = projets.projet_ref 
GROUP BY participer.projet_ref
ORDER BY participer.projet_ref DESC; 

/* 7. Sélectionner les types de projets avec, pour chacun d'entre eux, le nombre de projets associés et le prix moyen pratiqué */


/* 8. Sélectionner les types de travaux avec, pour chacun d'entre eux, la superficie du projet la pls grande */


/* 9. Sélectionner l'ensembles des projets (dates, prix) avec les informations du client (nom, telephone, adresse), le type de travaux et le type de projet. */


/* 10. Sélectionner les projets dont l'adresse est identique au client associé */