use master;
go
drop database if exists racun;
go
create database racun collate Croatian_CI_AS;
go
use racun;

create table racun(
sifra int not null primary key identity(1,1),
redniBroj int,
datum datetime,
kupac varchar(100),
placeno bit
);

create table stavkeRacuna(
sifra int not null primary key identity(1,1),
racun int,
artikl varchar(255),
cijena decimal (18,2),
kolicina int,
popust decimal (5,2)
);
alter table stavkeRacuna add foreign key (racun) references racun(sifra);

insert into racun (redniBroj, datum, kupac, placeno) values
(1000, '2024-01-01', 'Perica Periæ', 0),
(1001, '2024-01-01', 'Ivica Iviæ', 0),
(1002, '2024-01-02', 'Kamenko d.o.o.', 1),
(1003, '2024-01-04', 'Dorat j.d.o.o.', 1),
(1004, '2024-01-06', 'Marija Mariæ', 1),
(1005, '2024-01-10', 'Luka Lukiæ', 1);