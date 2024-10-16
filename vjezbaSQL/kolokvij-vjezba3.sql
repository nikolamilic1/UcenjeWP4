﻿ use master;
 go
--prekidanje konekcija prije dropanja baze
alter database vjezba3 set single_user with rollback immediate;
go
drop database if exists vjezba3;
go
create database vjezba3 collate Croatian_CI_AS;
go
use vjezba3;

create table svekar(
sifra int not null primary key identity(1,1),
novcica decimal(16,8) not null,
suknja varchar(44) not null,
bojakose varchar(36),
prstena int,
narukvica int not null,
cura int not null
);

create table cura(
sifra int not null primary key identity(1,1),
dukserica varchar(49),
maraka decimal (13,7),
drugiputa datetime,
majica varchar(49),
novcica decimal(15,8),
ogrlica int not null
);

create table snasa(
sifra int not null primary key identity(1,1),
introvertno bit,
kuna decimal(15,6) not null,
eura decimal(12,9) not null,
treciputa datetime,
ostavljena int not null
);

create table punica(
sifra int not null primary key identity(1,1),
asocijalno bit,
kratkamajica varchar(44),
kuna decimal (13,8) not null,
vesta varchar(32) not null,
snasa int
);

create table ostavljena(
sifra int not null primary key identity(1,1),
kuna decimal(17,5),
lipa decimal(15,6),
majica varchar(36),
modelnaocala varchar(31) not null,
prijatelj int
);

create table prijatelj(
sifra int not null primary key identity(1,1),
kuna decimal(16,10),
haljina varchar(37),
lipa decimal(13,10),
dukserica varchar(31),
indiferentno bit not null
);

create table prijatelj_brat(
sifra int not null primary key identity(1,1),
prijatelj int not null,
brat int not null
);

create table brat(
sifra int not null primary key identity(1,1),
jmbag char(11),
ogrlica int not null,
estrovertno bit not null
);

alter table svekar add foreign key (cura) references cura(sifra);
alter table punica add foreign key (snasa) references snasa(sifra);
alter table snasa add foreign key (ostavljena) references ostavljena(sifra);
alter table ostavljena add foreign key (prijatelj) references prijatelj(sifra);
alter table prijatelj_brat add foreign key (prijatelj) references prijatelj(sifra);
alter table prijatelj_brat add foreign key (brat) references brat(sifra);


--select * from ostavljena;

insert into ostavljena(kuna,lipa,majica,modelnaocala) values
(500,400,'plava','xoxo'),
(400,300,'šarena','Police'),
(300,200,'žuta','RayBan');

--select * from snasa;

insert into snasa(introvertno,kuna,eura,treciputa,ostavljena) values
(1,100,100,'2010-01-01',1),
(0,200,200,'2020-01-01',2),
(1,400,300,'2024-01-01',3);


--select * from brat;

insert into brat(jmbag,ogrlica,estrovertno) values
('01236547897',1,1),
('55555547897',2,1),
('33336547897',3,1);

--select * from prijatelj;

insert into prijatelj(kuna,indiferentno) values
(100,0),
(1000,1),
(100000,1);

--select * from prijatelj_brat;

insert into prijatelj_brat(prijatelj,brat) values
(1,3),
(2,2),
(3,1);