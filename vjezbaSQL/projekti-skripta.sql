use master;
go
drop database if exists projekti;
go
create database projekti collate Croatian_CI_AS;
go
use projekti;

create table zaposlenik(
sifra int not null primary key identity(1,1),
nadredjeni int,
ime varchar(45),
prezime varchar(45),
datumrodjenja datetime,
placa decimal (18,2),
odjel int
);

create table projekt(
sifra int not null primary key identity(1,1),
naziv varchar(45),
datumpocetka datetime,
datumkraja datetime
);

create table odjel(
sifra int not null primary key identity(1,1),
naziv varchar(45)
);

create table sudjeluje(
sifra int not null primary key identity(1,1),
zaposlenik int,
projekt int,
datumpristupanja datetime
);

alter table zaposlenik add foreign key (odjel) references odjel(sifra);
alter table zaposlenik add foreign key (nadredjeni) references zaposlenik(sifra);

alter table sudjeluje add foreign key (zaposlenik) references zaposlenik(sifra);
alter table sudjeluje add foreign key (projekt) references projekt(sifra);


--select * from zaposlenik;
--select * from projekt;
--select * from odjel;
--select * from sudjeluje;

insert into odjel (naziv) values
('Prodaja'),
('Marketing'),
('Razvoj');

insert into zaposlenik (nadredjeni,ime,prezime,datumrodjenja,placa,odjel) values
(null,'Pero','Perić','1980-01-01',1588.25,1),
(1,'Ivo','Ivić','1980-01-01',1200.25,2),
(2,'Tonči','Huljić','1980-01-01',1000.25,3);

insert into projekt (naziv) values
('Automobili'),
('Vlakovi'),
('Jedrilice');



insert into sudjeluje (zaposlenik, projekt) values
(1,3),
(2,2),
(3,1);