drop database if exists school ;
create database if not exists school ;

use school;

CREATE table etudiants
(student_id int primary key,
name varchar(100),
dob date,
enrollment_date date);
  
  insert into etudiants
  ( student_id, name, dob, enrollment_date)
  
 values
  (1,"Alice","2001-05-12","2020-09-01"),
  (2,"Bob","2002-08-21","2021-01-15"),
  (3,"Charlie","2000-08-21","2019-08-20"),
  (4,"Diana","2003-11-03","2022-03-22"),
  (5,"Emily","2001-06-22","2020-09-01"),
  (6,"Frank","2001-12-14","2019-05-17"),
  (7,"Grace","2002-02-10","2021-07-01");
  
	create  table enseignants
	(teacher_id int primary key,
	teacher_name varchar(100),
	department varchar(100)
    );
    
	insert into enseignants
	(teacher_id,teacher_name,department)
	values
	(1,"Dr.Smith","Informatique"),
	(2,"Prof.Johnson","Technomogie de l'information"),
	(3,"Dr.Green","Intelligence Artificielle"),
	(4,"Dr.Adams","Informatique"),
	(5,"Prof.Lee","Informatique");

	create table cours
	(course_id int primary key,
	course_name varchar(100),
    teacher_id int,
	foreign key cours(teacher_id) references enseignants(teacher_id),
	credit int);
	 
	 insert into cours
	 (course_id,course_name,teacher_id,credit)
	values 
	(101,"Data Sience",1,3),
	(102,"Web Development",2,4),
	(103,"Machine Learning",1,3),
	(104,"Artificial Intelligence",3,3),
	(105,"Database Management",4,4);
