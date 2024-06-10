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

create table snasa(
sifra int not null primary key identity(1,1),
introvertno bit,
treciputa datetime,
haljina varchar(44) not null,
zena int not null
);

create table becar(
sifra int not null primary key identity(1,1),
novcica decimal(14,8),
kratkamajica varchar(48) not null,
bojaociju varchar(36) not null,
snasa int not null
);

create table prijatelj(
sifra int not null primary key identity(1,1),
eura decimal(16,9),
prstena int not null,
gustoca decimal(16,5),
jmbag char(11) not null,
suknja varchar(47) not null,
becar int not null
);



