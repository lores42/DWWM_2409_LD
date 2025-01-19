USE emp;
set lc_time_names = 'fr_FR';

-- 1. Donner nom, job, numéro et salaire de tous les employés, puis seulement des employés du département 10
SELECT ENAME, JOB, MGR, SAL 
FROM employes
WHERE  deptno =30;

-- 2. Donner nom, job et salaire des employés de type MANAGER dont le salaire est supérieur à 2800
SELECT ENAME, JOB, SAL 
FROM employes
WHERE JOB = "manager" and sal>2800;
-- 3. Donner la liste des MANAGER n'appartenant pas au département 30
SELECT manager
FROM employes
WHERE job= "manager" and  deptno != 30;
-- 4. Liste des employés de salaire compris entre 1200 et 1400
SELECT job, ename, sal
FROM employes
WHERE sal BETWEEN 1200 and 1400;

-- 5 Liste des employés des départements 10 et 30 classés dans l'ordre alphabétique
SELECT ename, job
FROM employes
WHERE deptno in(10,30, 40)
ORDER BY ename;

-- 6. Liste des employés du département 30 classés dans l'ordre des salaires croissants
SELECT ename, sal
FROM employes
WHERE deptno=30 
ORDER BY sal ;

-- 7 Liste de tous les employés classés par emploi et salaires décroissants
SELECT	*
FROM employes
ORDER BY job , sal DESC ;
-- 8. Liste des différents emplois
SELECT distinct job
FROM employes;

-- 9. Donner le nom du département où travaille ALLEN
SELECT d.dname
FROM departements AS d 
join employes AS e	on e.deptno = d.deptno
WHERE e.ename = "allen";

-- 10. Liste des employés avec nom du département, nom, job, salaire classés par noms de départements et par salaires décroissants.
SELECT dname, ename, job, sal
FROM employes inner
join departements on departements.deptno = employes.deptno
ORDER BY dname DESC, sal DESC;

-- 11. Liste des employés vendeurs (SALESMAN) avec affichage de nom, salaire, commissions, salaire + commissions
SELECT  ename, sal, comm, sal+comm
FROM employes
WHERE job = "salesman";

-- 12. Liste des employés du département 20: nom, job, date d'embauche sous forme VEN 28 FEV 1997'
SELECT ename, job, upper(date_format(hiredate, "%a %e %b %Y")) 
FROM employes
WHERE deptno = 20;

-- 13. Donner le salaire le plus élevé par département
SELECT departements.dname, MAX(sal),  employes.deptno
FROM employes 
natural join departements   
GROUP BY employes.deptno;

-- 14. Donner département par département masse salariale, nombre d'employés, salaire moyen par type d'emploi.
SELECT deptno, dname,job, sum(sal+ifnull(comm, 0)) as "masse salariale", round(avg(sal),2) as "salaire moyen", count(empno) as "effectif"
FROM employes
NATURAL JOIN departements
GROUP BY employes.deptno,job;

-- 15. Même question mais on se limite aux sous-ensembles d'au moins 2 employés
SELECT deptno, dname,job, sum(sal+ifnull(comm, 0)) as "masse salariale", round(avg(sal),2) as "salaire moyen", count(empno) as "effectif"
FROM employes
NATURAL JOIN departements
GROUP BY employes.deptno,job    having count(empno) >=2 ;

-- 16. Liste des employés (Nom, département, salaire) de même emploi que JONES
select ename, deptno, sal
FROM employes	
WHERE job = (SELECT job 
from employes
where ename = "jones") and ename != "jones";

-- 17. Liste des employés (nom, salaire) dont le salaire est supérieur à la moyenne globale des salaires
   select ename , sal,  round((SELECT avg(sal)  FROM employes),2) as " salaire moyen" from employes where sal> (SELECT avg(sal)  FROM employes);

CREATE TABLE projet (
num_proj SMALLINT AUTO_INCREMENT,
nom_proj CHAR(5) NOT NULL,
budget_proj DECIMAL(8,2) NOT NULL, CONSTRAINT PK_projet PRIMARY KEY(num_proj)
);

 ALTER TABLE projet AUTO_INCREMENT = 101;

INSERT INTO projet 
(nom_proj, budget_proj)
VALUES
('alpha',96000),
('beta',82000),
('gamma',15000);



ALTER TABLE employes ADD  num_proj SMALLINT;

UPDATE employes SET num_proj = 101
WHERE deptno = 30 AND job = 'salesman';
UPDATE employes SET num_proj= 102
WHERE deptno = 30 and job != "salesman" XOR deptno != 30;
ALTER TABLE employes add CONSTRAINT fk_proj FOREIGN KEY(num_proj) REFERENCES projet(num_proj);


-- 20. Créer une vue comportant tous les employés avec nom, job, nom de département et nom de projet
create view employes_proj
as SELECT employes.ename, employes.job, departements.dname, projet.nom_proj
FROM departements 
NATURAL JOIN employes 
NATURAL JOIN projet;


-- deuxième partie

-- 1. Afficher la liste des managers des départements 20 et 30
SELECT ename, job
FROM employes
WHERE deptno IN(20, 30) and job ="manager";

-- 2. Afficher la liste des employés qui ne sont pas manager et qui ont été embauchés en 81
SELECT ename, job, hiredate
FROM employes
where job != 'manager' and hiredate like '1981%';

-- 3. Afficher la liste des employés ayant une commission
SELECT ename, job, comm
FROM employes
WHERE comm;

-- 4. Afficher la liste des noms, numéros de département, jobs et date d'embauche triés par Numero de Département et JOB les derniers embauches d'abord.
SELECT ename, deptno, job, hiredate
FROM employes
ORDER BY hiredate DESC, deptno , job ;