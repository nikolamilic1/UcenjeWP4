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
dukserica varchar(33),
prviputa datetime not null,
majica varchar(36),
svekar int not null
);

create table punica(
sifra int not null primary key identity(1,1),
hlace varchar(43) not null,
nausnica int not null,
ogrlica int,
vesta varchar(49) not null,
modelnaocala varchar(31) not null,
treciputa datetime not null,
punac int not null
);

create table ostavljena(
sifra int not null primary key identity(1,1),
majica varchar(33),
ogrlica int not null,
carape varchar(44),
stilfrizura varchar(42),
punica int not null
);

create table svekar(
sifra int not null primary key identity(1,1),
bojakose varchar(33),
majica varchar(31),
carape varchar(31) not null,
haljina varchar(43),
narukvica int,
eura decimal(14,5) not null
);

create table svekar_cura(
sifra int not null primary key identity(1,1),
svekar int not null,
cura int not null
);

create table cura(
sifra int not null primary key identity(1,1),
carape varchar(41) not null,
maraka decimal(17,10) not null,
asocijalno bit,
vesta varchar(47) not null
);

