use master;
go
alter database vjezba5 set single_user with rollback immediate;
go
drop database if exists vjezba5;
go
create database vjezba5 collate Croatian_CI_AS;
go
use vjezba5;