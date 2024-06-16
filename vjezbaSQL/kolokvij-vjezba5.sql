use master;
go
alter database vjezba5 set single_user with rollback immediate;
go
drop database if exists vjezba5;
go
create database vjezba5 collate Croatian_CI_AS;
go
use vjezba5;

create table mladic(
sifra int not null primary key identity(1,1),
kratkamajica varchar(48) not null,
haljina varchar(30) not null,
asocijalno bit,
zarucnik int
);

create table zarucnik(
sifra int not null primary key identity(1,1),
jmbag char(11),
lipa decimal(12,8),
indiferentno bit not null
);

create table punac(
sifra int not null primary key identity(1,1),
);

create table punica(
sifra int not null primary key identity(1,1),
);

create table ostavljena(
sifra int not null primary key identity(1,1),
);

create table svekar(
sifra int not null primary key identity(1,1),
);

create table svekar_cura(
sifra int not null primary key identity(1,1),
);

create table cura(
sifra int not null primary key identity(1,1),
);

