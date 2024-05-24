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
naziv varchar(100) not null,
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



--INSERT DJELATNIKA

insert into djelatnik (ime,prezime,email) values
('Pero','Peri�','pero.peric@gmail.com'),
('Ivan','Ivi�','ivan.ivic@gmail.com'),
('Jozo','Jozi�','jozo.jozicgmail.com'),
('Lucija','Luci�','lucija.lucic@gmail.com');



--INSERT PROJEKATA

insert into projekt (naziv,klijent) values
('ExploreEasy','Travel Company'),
('WebSiteTeheran','Band Teheran'),
('TimeMaster','Tesla Company');


--INSERTI ZADATAKA ZA PROJEKT ExploreEasy

insert into zadatak (naziv,pocetak,zavrsetak,projekt,opis) values
('Postavljanje Ciljeva','2024-01-01','2024-01-31',1,'Definirati glavne funkcionalnosti aplikacije (karte, turisti�ke atrakcije, preporuke restorana, smje�taj, itd.).'),
('Izrada Projektnog Plana','2024-02-01','2024-02-28',1,'Planirati resurse, vremenske okvire, bud�et i definirati tim'),
('Wireframing','2024-03-01','2024-03-31',1,'Kreirati osnovne skice korisni�kog su�elja (UI) kako bi se vizualizirale glavne komponente aplikacije'),
('UI/UX Dizajn','2024-04-01','2024-04-30',1,'Razviti detaljan dizajn korisni�kog su�elja i iskustva korisnika. Paziti na intuitivnost, estetiku i funkcionalnost.'),
('Izbor Tehnologija','2024-05-01','2024-05-31',1,'Odabrati platformu (iOS, Android, ili obje), programske jezike (Swift, Kotlin, React Native, itd.), i alate za razvoj.'),
('Back-end Razvoj','2024-06-01','2024-12-30',1,'Postaviti servere, baze podataka i API-je koji �e podr�avati aplikaciju.'),
('Front-end Razvoj','2024-07-01','2024-07-31',1,'Razviti korisni�ko su�elje prema dizajnu.'),
('Integracija API-ja','2024-08-01','2024-08-31',1,'Integrirati vanjske API-je za karte, informacije o atrakcijama, recenzije, itd.'),
('Funkcionalno Testiranje','2024-09-01','2024-09-30',1,'Provjeriti sve funkcionalnosti aplikacije.');


--INSERTI ZADATAKA ZA PROJEKT WebSiteTeheran (bez kolona pocetak i zavrsetak)

insert into zadatak (naziv,projekt,opis) values
('Definiranje ciljeva',2,'Razjasniti svrhu web stranice (promocija benda, informacije o koncertima, prodaja muzike i mercha, komunikacija s fanovima). Definirati ciljnu publiku (fanovi, promotori, mediji).'),
('Analiza zahtjeva',2,'Prikupiti zahteve od �lanova benda i menad�menta. Odrediti klju�ne funkcionalnosti (galerija, biografija, muzi�ki player, kalendar doga�aja, kontakt forma).'),
('Informacijska arhitektura',2,'Kreirati strukturu web stranice, uklju�uju�i glavne sekcije (po�etna stranica, biografija, muzika, turneje, galerija, kontakt).'),
('UI/UX dizajn',2,'Razviti wireframe-ove za glavne stranice. Dizajnirati vizuelni identitet stranice koji �e odra�avati stil i energiju benda Teheran. Izraditi prototipove za pregled i odobrenje. Osigurati da dizajn bude prilago�en razli�itim ure�ajima (desktop,tablet...)'),
('Front-end razvoj',2,'Kodirati dizajn koriste�i HTML, CSS i JavaScript. Implementirati responzivni dizajn za optimalno korisni�ko iskustvo na svim ure�ajima.'),
('Back-end razvoj',2,'Postaviti serversku stranu ako je potrebno za dinami�ke funkcionalnosti (CMS za upravljanje sadr�ajem, baza podataka za liste doga�aja). Integrisati potrebne servise (npr. muzi�ki player, integracija sa dru�tvenim mre�ama, newsletter prijava).'),
('Deployment',2,'Postaviti stranicu na produkciono okru�enje. Konfigurisati hosting i domen. Provjeriti je li sve pravilno postavljeno i funkcionalno.'),
('A�uriranja i unapre�enja',2,'Redovno a�urirati sadr�aj (nove pjesme, datumi turneja, novosti). Implementirati nove funkcionalnosti na osnovu korisni�kog feedback-a i tehnolo�kih unapre�enja.'),
('SEO optimizacija',2,'Optimizirati stranicu za tra�ilice kako bi se pobolj�ala vidljivost.'),
('Korisni�ka podr�ka',2,'Pru�ati podr�ku posetiocima stranice kroz razli�ite kanale (e-mail, chat) kako bi se osiguralo zadovoljstvo korisnika i re�ili eventualni problemi.');


--INSERTI ZADATAKA ZA PROJEKT TimeMaster (bez kolona pocetak i zavrsetak)

insert into zadatak (naziv,projekt,opis) values
('Tehni�ka analiza',3,'Odlu�iti o tehnologijama koje �e se koristiti za razvoj aplikacije (front-end, back-end, baza podataka, hosting itd.).'),
('UI/UX dizajn',3,'Razviti dizajn korisni�kog interfejsa i korisni�kog iskustva. To uklju�uje wireframe-ove, prototipove i dizajn svih ekrana i elemenata'),
('Dizajn baze podataka',3,'Definirati strukturu baze podataka, tablice, relacije i sheme.'),
('Front-end razvoj',3,'Kodirati korisni�ki interfejs koriste�i HTML, CSS, JavaScript i odgovaraju�e front-end framework-e (npr. React, Angular, Vue.js).'),
('Back-end razvoj',3,'Razviti serversku stranu aplikacije koriste�i odgovaraju�e tehnologije (npr. Node.js, Django, Ruby on Rails) i API-je za komunikaciju izme�u front-end-a i back-end-a.'),
('Integracija baze podataka',3,'Implementirati bazu podataka i integrirati je sa back-end-om'),
('Sistem testiranje',3,'Testirati kompletnu aplikaciju kako bi se osiguralo da svi delovi funkcioni�u zajedno bez problema.'),
('Deployment',3,'Postaviti aplikaciju na produkciono okru�enje. To uklju�uje konfiguraciju servera, baze podataka i bilo kojih drugih potrebnih servisa.'),
('A�uriranja i unapre�enja',3,'Redovno a�urirati aplikaciju novim funkcionalnostima i unapre�enjima na osnovu korisni�kog feedback-a i tehnolo�kih unapre�enja.');