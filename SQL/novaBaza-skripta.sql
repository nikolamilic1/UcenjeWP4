use master;
go
drop database if exists novaBaza;
create database novaBaza;
go
use novaBaza;

create table korisnik(
sifra int primary key not null,
ime varchar,
prezime varchar,
oib varchar(11)
);