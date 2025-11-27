# sql => structured Query Language;
### Important points or questions will be marked using "#" ###
create database databaseName;   => creating new database
use databaseName;               => selecting the database
create table tableName(
    // defining column name here
)
eg: 
create table userProfile
(
userId int identity(1,1) primary key,
displayName NVarChar(100) not null,
FirstName NVarChar(50) not null,
LastName NVarChar(50) not null,
Email NVarChar(100) not null

fieldName datatype constraints
)

# cluster indexing and non cluster indexing
# primary key and unique key comparison
# use single quote for mention a string


# CRUD Operation
create      -> create, insert into
Read        -> select 
Update      -> update
Delete      -> delete

# Primary key => unique key , refering a row
# foreign key => either null or can have multiple value refering an external table => refers primary key of another table

# DDL : Data Definition Language  :define create modify
structural change
> eg :create, alter, drop, truncate, rename

# DML : Data Manipulation Language: insert, modify, delete, or retrieve
data manipulation
eg: insert, update, delete, select

