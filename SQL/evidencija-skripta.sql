use master;
go
drop database if exists evidencija;
go
create database evidencija collate Croatian_CI_AS;
go

use evidencija;

create table projekt(
sifra int not null primary key identity(1,1),
naziv varchar(100) not null,
klijent varchar(100) not null
);

create table zadatak(
sifra int not null primary key identity(1,1),
pocetak datetime,
zavrsetak datetime,
projekt int,
opis varchar(255)
);

create table djelatnik(
sifra int not null primary key identity(1,1),
ime varchar(20) not null,
prezime varchar(20) not null,
email varchar(50) not null
);

create table evidencija_rada(
sifra int not null primary key identity(1,1),
vrijeme_pocetka datetime,
vrijeme_zavrsetka datetime,
zadatak int,
djelatnik int
);

alter table zadatak add foreign key (projekt) references projekt(sifra);
alter table evidencija_rada add foreign key (zadatak) references zadatak(sifra);
alter table evidencija_rada add foreign key (djelatnik) references djelatnik(sifra);