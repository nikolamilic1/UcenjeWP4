use master;
go
drop database if exists ispit;
go
create database ispit;
go

use ispit;

create table ispitni_rok(
sifra int not null primary key identity(1,1),
predmet varchar(100),
vrstaIspita varchar(100),
datum datetime,
pristupio bit
);

create table pristupnici(
sifra int not null primary key identity(1,1),
ispitnirok int,
student varchar(100),
brojbodova int
);

alter table Pristupnici add foreign key (ispitnirok) references ispitni_rok(sifra);
