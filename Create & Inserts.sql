DROP TABLE IF EXISTS ProductSale;
DROP TABLE IF EXISTS Sale;
DROP TABLE IF EXISTS Product;
DROP TABLE IF EXISTS Employee;
DROP TABLE IF EXISTS Customer;

CREATE TABLE Customer(
         ID               INT             NOT NULL AUTO_INCREMENT,
         FirstName             VARCHAR(30)     NOT NULL,
        LastName              VARCHAR(30)     NOT NULL,
         CardNumber              VARCHAR(16)     NOT NULL,
    PhoneNumber        VARCHAR(15)     NOT NULL,
    Email            VARCHAR(50)     NOT NULL,
    Password        VARCHAR(50)     NOT NULL,
    Address        VARCHAR(50)     NOT NULL,
    City            VARCHAR(50)     NOT NULL,
    State            VARCHAR(2)         NOT NULL,
    Zip            INT            NOT NULL,
    Active            TINYINT(1)         NOT NULL,
    CreateDate        DATE             NOT NULL,
    LastUpdate        TIMESTAMP        NOT NULL DEFAULT CURRENT_TIMESTAMP,
    CONSTRAINT CustomerPK PRIMARY KEY (ID));

CREATE TABLE Employee(
         ID              INT             NOT NULL AUTO_INCREMENT,
         FirstName             VARCHAR(50)    NOT NULL,
        LastName              VARCHAR(50)    NOT NULL,
    Role            VARCHAR(1)        NOT NULL,
    PhoneNumber        VARCHAR(10)    NOT NULL,
    Email            VARCHAR(50)    NOT NULL,
    Password        VARCHAR(50)    NOT NULL,
    Active            TINYINT(1)         NOT NULL,
    DateofHire        DATE            NOT NULL,
    CreateDate        DATE            NOT NULL,    
    LeaveDate        DATE,
    CONSTRAINT EmployeePK PRIMARY KEY (ID));

CREATE TABLE Product(
    ID            INT            NOT NULL AUTO_INCREMENT,
    Name            VARCHAR(50)    NOT NULL,
    Description        VARCHAR(50)    NOT NULL,
    Price            DECIMAL(4,2)        NOT NULL,
    Active            TINYINT(1)                NOT NULL,
    CreateDate        DATE            NOT NULL,
    LastUpdate        TIMESTAMP        NOT NULL DEFAULT CURRENT_TIMESTAMP,
    CONSTRAINT ProductPK PRIMARY KEY (ID));

CREATE TABLE Sale(
         ID               INT             NOT NULL AUTO_INCREMENT,
             Discount              DECIMAL(4,2),
         TaxAmount              DECIMAL(4,2)        NOT NULL,
     Active              TINYINT(1)         NOT NULL,
    CreateDate          DATE             NOT NULL,
    LastUpdate          TIMESTAMP        NOT NULL,
    CustomerID        INT            NOT NULL,
    EmployeeID        INT            NOT NULL,
    CONSTRAINT SalePK PRIMARY KEY (ID),
    CONSTRAINT SaleFK1 FOREIGN KEY (CustomerID) REFERENCES 
Customer(ID),
CONSTRAINT SaleFK2 FOREIGN KEY (EmployeeID) REFERENCES 
Employee(ID));

CREATE TABLE ProductSale(
    ProductID        INT            NOT NULL,
    SaleID            INT            NOT NULL,
    Price            INT            NOT NULL,
    Quantity        INT            NOT NULL,
    CONSTRAINT ProductSalePK PRIMARY KEY (ProductID, SaleID),
    CONSTRAINT ProductSaleFK1 FOREIGN KEY (ProductID) REFERENCES Product(ID),
    CONSTRAINT ProductSaleFK2 FOREIGN KEY (SaleID) REFERENCES Sale(ID));


INSERT INTO Customer VALUES(1, 'Jim', 'Bob', '123456789012', '7467489832','BobJ@aol.com', 'badpassword', '1234 address lane', 'Mt.Pleasant', 'MI', 48858, 1, '2020-03-03', current_timestamp());
INSERT INTO Customer VALUES(2, 'Phil', 'Man', '123456789012', '7463429832', 'Philman@gmail.com', 'ohiorox12', '1734 lane lane', 'Akron', 'OH', 45648, 1, '2020-03-05', current_timestamp());
INSERT INTO Customer VALUES(3, 'Tom', 'Doll', '120794189012', '7095329832', 'Tom@gmail.com', 'classicpassword', '1643 Dang Lane', 'Ann Arbor', 'MI', 48108, 1, '2019-03-04', current_timestamp());
INSERT INTO Customer VALUES(4, 'Johhny', 'Smith', '126317589012', '7016389832', 'Johhny@yahoo.com', 'ilovesql', '2674 banana Drive', 'Orlando', 'FL', 12448, 1, '2018-01-04', current_timestamp());
INSERT INTO Customer VALUES(5, 'Joe', 'Sam', '152003753012', '7463441862', 'JoeSam@gmail.com', 'hoosiersrock', '1531 Car road', 'Gary', 'IN', 84216, 1, '2017-12-04', current_timestamp());

INSERT INTO Employee VALUES(6, 'Mary', 'Smith', 'E', '3137989245', 'msmith1@gmail.com', 'mypass123', 1, '2019-02-22', '2019-02-22', '2020-01-02');
INSERT INTO Employee VALUES(7, 'Mark', 'Thelen', 'E', '6164556673', 'mthelen@yahoo.com', 'skyblue1', 1, '2017-04-17', '2017-04-15', '2019-06-04');
INSERT INTO Employee VALUES(8, 'Kendra', 'Brown', 'M', '2481413345', 'kendra.brown@gmail.com', 'mypassword8', 1, '2015-01-19', '2015-01-19', '2020-02-02');
INSERT INTO Employee VALUES(9, 'Kyle', 'Chadwick', 'E', '6163451020', 'chadwick888@hotmail.com', 'red_mustang1', 1, '2018-10-29', '2018-10-28', '2020-03-03');
INSERT INTO Employee VALUES(10, 'Ted', 'Umpsted', 'E', '2481459873', 'teddy_u12@yahoo.com', 'BEARS_fan12', 1, '2019-04-17', '2019-04-17', '2020-01-19');

INSERT INTO Product VALUES(11, 'Pancakes', 'Breakfast Item', '3.99', 1, '2018-06-17', current_timestamp());
INSERT INTO Product VALUES(12, 'Meat Lovers Omelette', 'Breakfast Item', '8.95', 1, '2017-02-05', current_timestamp());
INSERT INTO Product VALUES(13, 'Veggie Skillet', 'Breakfast Item', '9.99', 1, '2019-04-06', current_timestamp());
INSERT INTO Product VALUES(14, 'Eggs Benedict', 'Breakfast Item', '7.00', 1, '2019-07-08', current_timestamp());
INSERT INTO Product VALUES(15, 'French Toast', 'Breakfast Item', '8.50', 1, '2018-06-06', current_timestamp());

INSERT INTO Sale VALUES (16, '5.00', '4.12', 1, '2017-05-15', current_timestamp(), 1, 6);
INSERT INTO Sale VALUES (17, '5.00', '2.15', 1, '2018-07-20', current_timestamp(), 2, 7);
INSERT INTO Sale VALUES (18, '5.00', '7.10', 1, '2018-05-07', current_timestamp(), 3, 8);
INSERT INTO Sale VALUES (19, '5.00', '1.20', 1, '2016-08-22', current_timestamp(), 4, 9);
INSERT INTO Sale VALUES (20, '5.00', '3.90', 1, '2019-09-28', current_timestamp(), 5, 10);


INSERT INTO ProductSale VALUES(11, 16, '3.99', '2');
INSERT INTO ProductSale VALUES(12, 17, '3.99', '1');
INSERT INTO ProductSale VALUES(13, 18, '3.99', '3');
INSERT INTO ProductSale VALUES(14, 19, '3.99', '4');
INSERT INTO ProductSale VALUES(15, 20, '3.99', '2');





