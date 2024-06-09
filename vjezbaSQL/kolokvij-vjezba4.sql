use master;
go
alter database vjezba4 set single_user with rollback immediate;
go
drop database if exists vjezba4;
go
create database vjezba4 collate Croatian_CI_AS;
go
use vjezba4;

create table punac(
sifra int not null primary key identity(1,1),
treciputa datetime,
majica varchar(46),
jmbag char(11) not null,
novcica decimal(18,7) not null,
maraka decimal(12,6) not null,
ostavljen int not null
);

create table ostavljen(
sifra int not null primary key identity(1,1),
modelnaocala varchar(43),
introvertno bit,
kuna decimal(14,10)
);