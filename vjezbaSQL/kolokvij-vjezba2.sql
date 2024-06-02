use master;
go
drop database if exists vjezba2;
go
create database vjezba2 collate Croatian_CI_AS;
go
use vjezba2;

create table cura (
sifra int not null primary key identity(1,1),
haljina varchar(33) not null,
drugiputa datetime not null,
suknja varchar(38),
narukvica int,
introvertno bit,
majica varchar(40) not null,
decko int
);

create table brat(
sifra int not null primary key identity(1,1),
suknja varchar(47),
ogrlica int not null,
asocijalno bit not null,
neprijatelj int not null
);

create table neprijatelj(
sifra int not null primary key identity(1,1),
majica varchar(32),
haljina varchar(43) not null,
lipa decimal(16,8),
modelnaocala varchar(49) not null,
kuna decimal(12,6) not null,
jmbag char(11),
cura int
);

create table decko(
sifra int not null primary key identity(1,1),
indiferentno bit,
vesta varchar(34),
asocijalno bit not null
);

create table decko_zarucnica(
sifra int not null primary key identity(1,1),
decko int not null,
zarucnica int not null
);

create table zarucnica(
sifra int primary key identity(1,1),
narukvica int,
bojakose varchar(37) not null,
novcica decimal(15,9),
lipa decimal(15,8) not null,
indiferentno bit not null
);

create table prijatelj(
sifra int not null primary key identity(1,1),
modelnaocala varchar(37),
treciputa datetime not null,
ekstrovertno bit not null,
privputa datetime,
svekar int not null
);

create table svekar(
sifra int not null primary key identity(1,1),
stilfrizura varchar(48),
ogrlica int not null,
asocijalno bit not null
);

alter table prijatelj add foreign key (svekar) references svekar(sifra);
alter table brat add foreign key (neprijatelj) references neprijatelj(sifra);
alter table neprijatelj add foreign key (cura) references cura(sifra);
alter table cura add foreign key (decko) references decko(sifra);
alter table decko_zarucnica add foreign key (decko) references decko(sifra);
alter table decko_zarucnica add foreign key (zarucnica) references zarucnica(sifra);


--select * from decko;

insert into decko(indiferentno,vesta,asocijalno) values
(1,'zelena',1),
(0,'crvena',0),
(1,'žuta',1);

--select * from cura;

insert into cura (haljina,drugiputa,suknja,narukvica,introvertno,majica,decko) values
('zelena','2012-01-02','crna',5,1,'sportska',3),
('crvena','2015-08-31','šarena',6,0,'slim-fit',2),
('žuta','2020-12-10','toèkasta',7,1,'kratka',1);

--select * from neprijatelj;

insert into neprijatelj(majica,haljina,lipa,modelnaocala,kuna,jmbag,cura) values
('bijela','šarena',100.00,'Police',200.00,'01235231014',4),
('crna','dugaèka',300.00,'XOX',900.00,'82310149876',2),
('žuta','kratka',700.00,'RayBan',9900.00,'99935231014',3);


--U tablicu zarucnica treba unijeti podatke kako bi se decko_zarucnica mogla unijeti

--select * from decko_zarucnica;

--insert into decko_zarucnica(decko) values
--(1),
--(2),
--(3);