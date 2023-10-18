USE Developer_Demo;
CREATE TABLE KiaraBussiness(
Id INT PRIMARY KEY,
Name VARCHAR(50),
Gender VARCHAR(50),
City VARCHAR(50),
DateOfBirth DATETIME CHECK (DateOfBirth > '2000-01-01' AND DateOfBirth <GETDATE())  
);

INSERT INTO KiaraBussiness VALUES (1, 'Pranali', 'Female', 'Pune', '2002-04-18');
INSERT INTO KiaraBussiness VALUES (2, 'Prince', 'Male', 'Gaya', '2001-01-11');
INSERT INTO KiaraBussiness VALUES (3, 'Pratik', 'Male', 'Kota', '2006-08-13');
INSERT INTO KiaraBussiness VALUES (4, 'Hritika', 'Female', 'Delhi', '2007-02-01');
INSERT INTO KiaraBussiness VALUES (5, 'Aishwaraya', 'Female', 'Amravati', '2002-08-30');
INSERT INTO KiaraBussiness VALUES (6, 'Madiha', 'Female', 'Solapur', '2003-11-29');

DROP TABLE KiaraBussiness;


