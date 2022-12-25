CREATE TABLE ceo (

ID INT primary key NOT NULL IDENTITY(1,1),
Name varchar(50) NOT NULL,
Email VARCHAR(50) NOT NULL,
Contact int NOT NULL,
);

CREATE TABLE contractor(

ID INT primary key NOT NULL IDENTITY(1,1),
Name varchar(50) NOT NULL,
Email VARCHAR(50) NOT NULL,
Contact int NOT NULL,
);

CREATE TABLE inventory(

ID INT primary key NOT NULL IDENTITY(1,1),
Material varchar(50) NOT NULL,
Quantity int NOT NULL,

);

CREATE TABLE login(

ID INT primary key NOT NULL IDENTITY(1,1),
Email varchar(50),
Password varchar(50),
UserType varchar(50),
);

CREATE TABLE manager(

ID INT primary key NOT NULL IDENTITY(1,1),
Name varchar(50) NOT NULL,
Email varchar(50),
Contact int NOT NULL,
);

CREATE TABLE department(

ID INT primary key NOT NULL IDENTITY(1,1),
Name varchar(50) NOT NULL,
Manager_ID INT FOREIGN KEY REFERENCES manager(ID)
);

CREATE TABLE supervisor(

ID INT primary key NOT NULL IDENTITY(1,1),
Name varchar(50) NOT NULL,
Email varchar(50),
Department_ID INT FOREIGN KEY REFERENCES department(ID)
);

CREATE TABLE head(

ID INT primary key NOT NULL IDENTITY(1,1),
Name varchar(50) NOT NULL,
Email varchar(50),
Department_ID INT FOREIGN KEY REFERENCES department(ID)
);

CREATE TABLE workshop(

ID INT primary key NOT NULL IDENTITY(1,1),
Name varchar(50) NOT NULL,
Supervisor_ID INT FOREIGN KEY REFERENCES supervisor(ID),
Department_ID INT FOREIGN KEY REFERENCES department(ID)
);

CREATE TABLE materials(

ID INT primary key NOT NULL IDENTITY(1,1),
Name varchar(50) NOT NULL,
Quantity INT NOT NULL,
Workshop_ID INT FOREIGN KEY REFERENCES workshop(ID)

);

CREATE TABLE employee(

ID INT primary key NOT NULL IDENTITY(1,1),
Name varchar(50) NOT NULL,
Role varchar(50) NOT NULL,
Workshop_ID INT FOREIGN KEY REFERENCES workshop(ID)
);

CREATE TABLE task(

ID INT primary key NOT NULL IDENTITY(1,1),
Name varchar(50) NOT NULL,
Status varchar(50) NOT NULL,
Date date NOT NULL,
Head_ID INT FOREIGN KEY REFERENCES head(ID),
Workshop_ID INT FOREIGN KEY REFERENCES workshop(ID),
Department_ID INT FOREIGN KEY REFERENCES department(ID)
);

CREATE TABLE sub_task(

ID INT primary key NOT NULL IDENTITY(1,1),
Name varchar(50) NOT NULL,
Status varchar(50) NOT NULL,
Date date NOT NULL,
Head_ID INT FOREIGN KEY REFERENCES head(ID),
Workshop_ID INT FOREIGN KEY REFERENCES workshop(ID),
Department_ID INT FOREIGN KEY REFERENCES department(ID),
Employee_ID INT FOREIGN KEY REFERENCES employee(ID)
);

CREATE TABLE requests(

ID INT primary key NOT NULL IDENTITY(1,1),
Quantity INT NOT NULL,
Material varchar(50) NOT NULL,
Inventory_ID INT FOREIGN KEY REFERENCES inventory(ID),
Workshop_ID INT FOREIGN KEY REFERENCES workshop(ID)
);