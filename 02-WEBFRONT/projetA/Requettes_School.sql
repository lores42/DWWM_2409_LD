use school;

-- 1 Écrivez une requête SQL pour lister tous les étudiants inscrits au cours "Data Science".




-- 2 Écrivez une requête SQL pour trouver tous les cours qui ont plus de 3 crédits.
select course_name
from cours
where credit > 3;


-- 3 Écrivez une requête SQL pour obtenir le nom de l'enseignant et ses cours 
-- (en incluant le nom du cours et les crédits), et triez-les par le nom de l'enseignant.
select teacher_name, course_name, credit
from enseignants
natural join cours
group by teacher_name, course_name, credit
order by teacher_name asc;


-- 4 Écrivez une requête SQL pour lister les étudiants inscrits à plus d'un cours.
select 


-- 5 Écrivez une requête SQL pour trouver la moyenne des crédits par cours.



-- 6 Écrivez une requête SQL pour trouver l'enseignant qui enseigne le cours "Machine Learning".




-- 7 Écrivez une requête SQL pour lister tous les étudiants et leurs enseignants, avec le nom du cours auquel ils sont inscrits (vous devez joindre les tables étudiants, cours, et enseignants).



-- 8 Écrivez une requête SQL pour trouver tous les cours enseignés par des enseignants du département "Informatique".



-- 9 Écrivez une requête SQL pour obtenir les noms de tous les étudiants inscrits à un cours enseigné par "Prof. Johnson".



-- 10 Écrivez une requête SQL pour lister les étudiants et le nombre de crédits qu'ils ont accumulés, en supposant que chaque étudiant est inscrit à un seul cours à la fois.
