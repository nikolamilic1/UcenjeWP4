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

create table zena(
sifra int not null primary key identity (1,1),
suknja varchar(39) not null,
lipa decimal(18,7),
prstena int not null
);

create table zena_mladic(
sifra int not null primary key identity(1,1),
zena int not null,
mladic int not null
);

create table mladic(
sifra int not null primary key identity(1,1),
kuna decimal(15,9),
lipa decimal(18,5),
nausnica int,
stilfrizura varchar(49),
vesta varchar(34) not null
);

alter table punac add foreign key (ostavljen) references ostavljen(sifra);
alter table becar add foreign key (snasa) references snasa(sifra);
alter table prijatelj add foreign key (becar) references becar(sifra);
alter table snasa add foreign key (zena) references zena(sifra);
alter table zena_mladic add foreign key (zena) references zena(sifra);
alter table zena_mladic add foreign key (mladic) references mladic(sifra);

--select * from mladic;

insert into mladic(vesta) values
('crna'),
('plava'),
('siva');

--select * from zena;

insert into zena(suknja,prstena) values
('zelena',1),
('žuta',2),
('šarena',3);

--select * from snasa;

insert into snasa(introvertno,treciputa,haljina,zena) values
(1,'2023-12-12','šarena',1),
(0,'2020-02-12','crna',1),
(1,'2015-05-12','siva',1);

--select * from becar;

insert into becar(novcica,kratkamajica,bojaociju,snasa) values
(1200,'prekratka','plava',1),
(1500,'omiljena','zelena',2),
(1900,'bilokakva','crna',3);

--select * from zena_mladic;

insert into zena_mladic(zena,mladic) values
(1,3),
(2,2),
(3,1);