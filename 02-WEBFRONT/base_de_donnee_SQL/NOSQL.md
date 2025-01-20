1. Donner nom, job, numéro et salaire de tous les employés, puis seulement des employés du département 10
db.emp.find({},{_id:0,ename:1,job:1,sal:1})

1.puis seulement des employés du département 10
db.emp.find({deptno:{$eq:10},deptno:{$eq:30}},{_id:0,ename:1,job:1,sal:1,deptno:1})

2. Donner nom, job et salaire des employés de type MANAGER dont le salaire est supérieur à 2800
db.emp.find({job:{$eq:"MANAGER"},sal:{$gt:2800}},{ename:1,job:1,sal:1,_id:0})

3. Donner la liste des MANAGER n'appartenant pas au département 30
db.emp.find({deptno:{$ne:30},job:{$eq:"MANAGER"}},{_id:0,job:1,ename:1,})

4. Liste des employés de salaire compris entre 1200 et 1400
db.emp.find({sal:{$it:1200},sal:{$gt:1400}},{_id:0,ename:1,job:1,sal:1})

5. Liste des employés des départements 10 et 30 classés dans l'ordre alphabétique