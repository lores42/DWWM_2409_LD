USE ecf_legumos_dasylva;

-- 1 Sélectionner toutes les informations des légumes triès par nom de légume (ASC)
SELECT Id, Name, Variety, PrimaryColor, LifeTime, Fresh
FROM Vegetables
ORDER BY  Name ;

-- 2 Sélectionner les nom et les prix des légumes. Pour chaque variété de légume, afficher
--   le nombre de ventes ainsi que le poids total vendu. Les légumes sont triés par nombre de ventes.
SELECT Name, SaleUnitPrice "Prix", SaleWeight "Poids",  SaleActive "vendu", SaleWeight
FROM Vegetables
NATURAL JOIN  Sales
WHERE  SaleActive ; 

/*3 Sélectionner les nom, la variété, la couleur, le prix au kilo des légumes
   a. dont le nom contient la chaine << on >> 
   ou b. dont la couleur est verte.*/

SELECT Name  "Non en anglais", Variety  "Variétée", PrimaryColor  "Couleur du fruit ou du légume", SaleUnitPrice  "Prix au kilo"
FROM Vegetables
NATURAL JOIN sales
WHERE Name like "%on%" or PrimaryColor = "green";



/* 4 Sélectionner les légumes avec pour chaque légumme:
a. Son nom.
b. sa variété.
c. La somme totale des ventes pour la variété de ce légume. 
d. Le poids moyen d'une vente.
e. Le poids et le prix de la vente la plus élevée.*/

SELECT Name, Variety, MAX(SaleWeight) as "Poids le plus élevé", MAX(SaleUnitPrice) as "prix le plus élevé" , (round(SUM(SaleWeight*SaleUnitPrice),2)) as "Prix total"
From Vegetables
NATURAL JOIN Sales
GROUP BY Name, Variety ;