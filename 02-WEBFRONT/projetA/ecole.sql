DROP DATABASE  IF EXISTS ecole;
CREATE DATABASE IF NOT EXISTS ecole;

USE ecole;


CREATE TABLE etudiants
(student_ID INT PRIMARY KEY,
name varchar(100),
dob date,
age INT,
enrollment_date DATE,
course_name varchar(100),
course_id INT,
FOREIGN KEY (course_id) REFERENCES cours(course_id),
marks INT
);



INSERT INTO etudiants
(student_ID, name, dob, age, enrollment_date, course_name, course_id, marks)
VALUES
(1, "Alice", "2001-05-12", 23, "2020-09-01", "DS", 101, 67),
(2, "Bob","2002-08-21",22,"2021-01-15","DWWM", 102, 78),
(3, "Charlie","2000-02-10",24,"2019-08-20","AI", 104, 89),
(4, "Diana","2003-11-03",21,"2022-03-22","DBMS", 105, 69),
(5, "Emily","2001-06-22",24,"2020-09-01","AI", 104, 57),
(6, "Frank","2001-12-14",23,"2019-05-17","DS", 101, 51),
(7, "Grace","2002-02-10",22,"2021-07-01","ML", 103, 92);


CREATE TABLE enseignants
(teacher_ID INT PRIMARY KEY,
teacher_name VARCHAR(100),
departement VARCHAR(100)
);

INSERT INTO enseignants
(teacher_id, teacher_name, departement)

VALUES
(1, "Dr.Smith", "Informatique"),
(2, "Prof.Johnson", "Technologie de l'information"),
(3, "Dr.Green", "Intelligence Artificielle"),
(4, "Dr.Adams", "Informatique"),
(5, "Prof.lee", "Informatique");

CREATE TABLE cours
(course_id INT PRIMARY KEY,
course_name varchar(100),
teacher_id INT,
FOREIGN KEY(teacher_id) REFERENCES enseignants(teacher_id)
);


INSERT INTO cours
(course_id, course_name,teacher_id )

VALUES
(101, "DS", 1),
(102, "DWWM",2),
(103, "ML",1),
(104, "AI",3),
(105, "DBMS",4);


-- Écrivez une requête SQL pour lister tous les étudiants de plus de 22ans "

SELECT *
FROM etudiants
WHERE age > 22;

-- Ecrivez une requettes pour les étudiants qui on plus de 85 en cours

SELECT *
FROM etudiants
WHERE marks > 85;

-- Écrivez une requête SQL pour obtenir le nom de l'enseignant et ses cours 
-- (en incluant le nom du cours ), et triez-les par le nom de l'enseignant.

SELECT teacher_name, departement
FROM enseignants
ORDER BY teacher_name ASC;

-- moyenne des ages des étudiants

SELECT ROUND (AVG(age),0 ) AS moyenne_age 
FROM etudiants;
 
 -- ecrire une requettes pour affiché les cours identique des élèves 
 
 SELECT etudiants.name, etudiants.student_ID, etudiants.age, COUNT(DISTINCT etudiants.course_id) AS course_count
 FROM etudiants
 JOIN cours
 ON etudiants.course_id = cours.course_id
 GROUP BY etudiants.name, etudiants.student_ID, etudiants.age
 HAVING COUNT(DISTINCT etudiants.course_id) > 1;
 
-- Écrivez une requête SQL pour trouver l'enseignant qui enseigne le cours "Machine Learning".

SELECT teacher_name
FROM enseignants
JOIN  cours
ON enseignants.teacher_id = cours.teacher_id
WHERE cours.course_name = "ML";

-- Écrivez une requête SQL pour lister tous les étudiants et leurs enseignants, avec le nom du cours 
-- auquel ils sont inscrits (vous devez joindre les tables étudiants, cours, et enseignants).

SELECT  e.name, t.teacher_name, c.course_name
FROM etudiants AS e
INNER JOIN cours AS c ON c.course_name = e.course_name
INNER JOIN enseignants AS t ON t.teacher_id = c.teacher_id;

-- Écrivez une requête SQL pour trouver tous les cours enseignés par des enseignants du département "Informatique".

SELECT t.teacher_name, c.course_name
FROM enseignants AS t
JOIN cours AS c ON c.teacher_id = t.teacher_id
WHERE t.departement = "Informatique";

-- Écrivez une requête SQL pour obtenir les noms de tous les étudiants inscrits à un cours enseigné par "Prof. Johnson".

SELECT e.name 
FROM etudiants AS e
JOIN cours AS c ON c.course_id = e.course_id
JOIN enseignants AS t on t.teacher_id = c.teacher_id
WHERE t.teacher_name = "Prof.Johnson";

-- Écrivez une requête SQL pour lister les étudiants et le nombre de notes qu'ils ont accumulés.

SELECT name, marks
FROM etudiants;

ALTER TABLE etudiants 
ADD adresse VARCHAR(100) DEFAULT "paris";

ALTER TABLE etudiants 
DROP COLUMN adresse ;

SELECT*
FROM enseignants;

SET SQL_SAFE_UPDATES = 0;

UPDATE etudiants
SET adresse = "mulhouse"
WHERE name = "Bob";

UPDATE etudiants
SET adresse = "starsbourg"
WHERE adresse ="paris";

DELETE FROM enseignants
WHERE teacher_name = "Prof.lee";
