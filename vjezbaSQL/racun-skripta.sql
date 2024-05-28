use master;
go
drop database if exists racun;
go
create database racun;
go
use racun;

create table racun(
sifra int not null,
redniBroj int,
datum datetime,
kupac varchar(100),
placeno bit
);

create table stavkeRacuna(
sifra int not null,
racun int,
artikl varchar(255),
cijena decimal (18,2),
kolicina int,
popust decimal (5,2)
);
