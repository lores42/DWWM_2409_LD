DROP DATABASE IF EXISTS ecf_legumos_dasylva;
CREATE DATABASE IF NOT EXISTS ecf_legumos_dasylva;

use ecf_legumos_dasylva;

CREATE TABLE Vegetables
(
Id INT PRIMARY KEY,
Name VARCHAR(50) NOT NULL,
Variety varchar(50) NOT NULL,
PrimaryColor VARCHAR(50) NOT NULL,
LifeTime SMALLINT NOT NULL ,
Fresh BOOLEAN NOT NULL DEFAULT(0)
);

INSERT INTO Vegetables
(Id, Name, Variety, PrimaryColor, LifeTime, Fresh)

VALUES
(1,"apple","golden","green",90,0),
(2,"banana","cavendish","yellow",10,0),
(3,"bleuberries","bleucrop","green",8,1),
(4,"cabbage","broccoli","green",60,0),
(5,"carrot","de Colmar","orange",60,0),
(6,"cherry","moreau","darkred",20,0),
(7,"coconut","palmyre","brown",30,0),
(8,"grape","aladin","green",10,1),
(9,"kiwi","hayward","green",40,1),
(10,"lemon","eureka","green",30,0),
(11,"onion","Stuttgart","white",90,0);

CREATE TABLE Sales 
(
SaleId INT PRIMARY KEY,
Id INT, 
FOREIGN KEY (Id) REFERENCES Vegetables(Id),
SaleDate DATE NOT NULL,
SaleWeight  INT  NOT NULL,
SaleUnitPrice FLOAT(5.2) NOT NULL ,
SaleActive BOOLEAN NOT NULL DEFAULT(0)
);

INSERT INTO Sales
(SaleId, Id, SaleDate, SaleWeight, SaleUnitPrice, SaleActive)

VALUES
(101,1,"2025-01-28",2,2.5,1),
(102,2,"2025-01-28",2,3.99,0),
(103,7,"2025-01-28",1,3.95,1),
(104,1,"2025-01-28",3,2.5,1),
(105,11,"2025-01-28",2,1.25,0);