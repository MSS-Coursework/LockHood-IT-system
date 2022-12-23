CREATE TABLE Ceo (

id INT primary key NOT NULL IDENTITY(1,1),
name varchar(50) NOT NULL,
email VARCHAR(50) NOT NULL,
contact int NOT NULL,
);

CREATE TABLE external_contractor(

id INT primary key NOT NULL IDENTITY(1,1),
name varchar(50) NOT NULL,
email VARCHAR(50) NOT NULL,
contact int NOT NULL,
);

CREATE TABLE inventory(

id INT primary key NOT NULL IDENTITY(1,1),
material_name varchar(50) NOT NULL,
quantity int NOT NULL,

);

CREATE TABLE login(

id INT primary key NOT NULL IDENTITY(1,1),
email varchar(50),
password varchar(50),

);

CREATE TABLE general_manager(

id INT primary key NOT NULL IDENTITY(1,1),
name varchar(50) NOT NULL,
email varchar(50),
contact int NOT NULL,

);

CREATE TABLE department(

id INT primary key NOT NULL IDENTITY(1,1),
name varchar(50) NOT NULL,
manager_id INT FOREIGN KEY REFERENCES general_manager(id)

);

CREATE TABLE supervisor(

id INT primary key NOT NULL IDENTITY(1,1),
name varchar(50) NOT NULL,
email varchar(50),
department_id INT FOREIGN KEY REFERENCES department(id)

);

CREATE TABLE department_head(

id INT primary key NOT NULL IDENTITY(1,1),
name varchar(50) NOT NULL,
email varchar(50),
department_id INT FOREIGN KEY REFERENCES department(id)

);

CREATE TABLE workshop(

id INT primary key NOT NULL IDENTITY(1,1),
name varchar(50) NOT NULL,
supervisor_id INT FOREIGN KEY REFERENCES supervisor(id),
department_id INT FOREIGN KEY REFERENCES department(id)

);

CREATE TABLE materials(

id INT primary key NOT NULL IDENTITY(1,1),
name varchar(50) NOT NULL,
quantity INT NOT NULL,
workshop_id INT FOREIGN KEY REFERENCES workshop(id)

);

CREATE TABLE employee(

id INT primary key NOT NULL IDENTITY(1,1),
name varchar(50) NOT NULL,
role varchar(50) NOT NULL,
workshop_id INT FOREIGN KEY REFERENCES workshop(id)

);

CREATE TABLE task(

id INT primary key NOT NULL IDENTITY(1,1),
name varchar(50) NOT NULL,
status varchar(50) NOT NULL,
date date NOT NULL,
head_id INT FOREIGN KEY REFERENCES department_head(id),
workshop_id INT FOREIGN KEY REFERENCES workshop(id),
department_id INT FOREIGN KEY REFERENCES department(id)

);

CREATE TABLE sub_task(

id INT primary key NOT NULL IDENTITY(1,1),
name varchar(50) NOT NULL,
status varchar(50) NOT NULL,
date date NOT NULL,
head_id INT FOREIGN KEY REFERENCES department_head(id),
workshop_id INT FOREIGN KEY REFERENCES workshop(id),
department_id INT FOREIGN KEY REFERENCES department(id),
employee INT FOREIGN KEY REFERENCES employee(id)

);

CREATE TABLE requests(

id INT primary key NOT NULL IDENTITY(1,1),
quantity INT NOT NULL,
material_name varchar(50) NOT NULL,
inventory_id INT FOREIGN KEY REFERENCES inventory(id),
workshop_id INT FOREIGN KEY REFERENCES workshop(id)

);