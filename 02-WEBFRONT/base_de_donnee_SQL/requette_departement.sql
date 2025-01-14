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
FROM employes natural join departements   GROUP BY employes.deptno;


