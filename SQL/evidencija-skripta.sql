use master;
go
alter database evidencija set single_user with rollback immediate;
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
naziv varchar(100),
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
zadatak int,
djelatnik int
);


alter table zadatak add foreign key (projekt) references projekt(sifra);
alter table evidencija_rada add foreign key (zadatak) references zadatak(sifra);
alter table evidencija_rada add foreign key (djelatnik) references djelatnik(sifra);



--INSERT DJELATNIKA

insert into djelatnik (ime,prezime,email) values
('Pero','Perić','pero.peric@gmail.com'),
('Ivan','Ivić','ivan.ivic@gmail.com'),
('Jozo','Jozić','jozo.jozicgmail.com'),
('Lucija','Lucić','lucija.lucic@gmail.com');



--INSERT PROJEKATA

insert into projekt (naziv,klijent) values
('ExploreEasy','Travel Company'),
('WebSiteTeheran','Band Teheran'),
('TimeMaster','Tesla Company');


--INSERTI ZADATAKA ZA PROJEKT ExploreEasy

insert into zadatak (naziv,pocetak,zavrsetak,projekt,opis) values
('Postavljanje Ciljeva','2024-01-01','2024-01-31',1,'Definirati glavne funkcionalnosti aplikacije (karte, turističke atrakcije, preporuke restorana, smještaj, itd.).'),
('Izrada Projektnog Plana','2024-02-01','2024-02-28',1,'Planirati resurse, vremenske okvire, budžet i definirati tim'),
('Wireframing','2024-03-01','2024-03-31',1,'Kreirati osnovne skice korisničkog sučelja (UI) kako bi se vizualizirale glavne komponente aplikacije'),
('UI/UX Dizajn','2024-04-01','2024-04-30',1,'Razviti detaljan dizajn korisničkog sučelja i iskustva korisnika. Paziti na intuitivnost, estetiku i funkcionalnost.'),
('Izbor Tehnologija','2024-05-01','2024-05-31',1,'Odabrati platformu (iOS, Android, ili obje), programske jezike (Swift, Kotlin, React Native, itd.), i alate za razvoj.'),
('Back-end Razvoj','2024-06-01','2024-12-30',1,'Postaviti servere, baze podataka i API-je koji će podržavati aplikaciju.'),
('Front-end Razvoj','2024-07-01','2024-07-31',1,'Razviti korisničko sučelje prema dizajnu.'),
('Integracija API-ja','2024-08-01','2024-08-31',1,'Integrirati vanjske API-je za karte, informacije o atrakcijama, recenzije, itd.'),
('Funkcionalno Testiranje','2024-09-01','2024-09-30',1,'Provjeriti sve funkcionalnosti aplikacije.');


--INSERTI ZADATAKA ZA PROJEKT WebSiteTeheran (bez kolona pocetak i zavrsetak)

insert into zadatak (naziv,projekt,opis) values
('Definiranje ciljeva',2,'Razjasniti svrhu web stranice (promocija benda, informacije o koncertima, prodaja muzike i mercha, komunikacija s fanovima). Definirati ciljnu publiku (fanovi, promotori, mediji).'),
('Analiza zahtjeva',2,'Prikupiti zahtjeve od članova benda i menadžmenta. Odrediti ključne funkcionalnosti (galerija, biografija, muzički player, kalendar događaja, kontakt forma).'),
('Informacijska arhitektura',2,'Kreirati strukturu web stranice, uključujući glavne sekcije (početna stranica, biografija, muzika, turneje, galerija, kontakt).'),
('UI/UX dizajn',2,'Razviti wireframe-ove za glavne stranice. Dizajnirati vizuelni identitet stranice koji će odražavati stil i energiju benda Teheran. Izraditi prototipove za pregled i odobrenje. Osigurati da dizajn bude prilagođen različitim uređajima (desktop,tablet...)'),
('Front-end razvoj',2,'Kodirati dizajn koristeći HTML, CSS i JavaScript. Implementirati responzivni dizajn za optimalno korisničko iskustvo na svim uređajima.'),
('Back-end razvoj',2,'Postaviti serversku stranu ako je potrebno za dinamičke funkcionalnosti (CMS za upravljanje sadržajem, baza podataka za liste događaja). Integrisati potrebne servise (npr. muzički player, integracija sa društvenim mrežama, newsletter prijava).'),
('Deployment',2,'Postaviti stranicu na produkciono okruženje. Konfigurirati hosting i domen. Provjeriti je li sve pravilno postavljeno i funkcionalno.'),
('Ažuriranja i unapređenja',2,'Redovito ažurirati sadržaj (nove pjesme, datumi turneja, novosti). Implementirati nove funkcionalnosti na osnovu korisničkog feedback-a i tehnoloških unapređenja.'),
('SEO optimizacija',2,'Optimizirati stranicu za tražilice kako bi se poboljšala vidljivost.'),
('Korisnička podrška',2,'Pružati podršku posetiocima stranice kroz različite kanale (e-mail, chat) kako bi se osiguralo zadovoljstvo korisnika i rješili eventualni problemi.');


--INSERTI ZADATAKA ZA PROJEKT TimeMaster (bez kolona pocetak i zavrsetak)

insert into zadatak (naziv,projekt,opis) values
('Tehnička analiza',3,'Odlučiti o tehnologijama koje će se koristiti za razvoj aplikacije (front-end, back-end, baza podataka, hosting itd.).'),
('UI/UX dizajn',3,'Razviti dizajn korisničkog interfejsa i korisničkog iskustva. To uključuje wireframe-ove, prototipove i dizajn svih ekrana i elemenata'),
('Dizajn baze podataka',3,'Definirati strukturu baze podataka, tablice, relacije i sheme.'),
('Front-end razvoj',3,'Kodirati korisnički interfejs koristeći HTML, CSS, JavaScript i odgovarajuće front-end framework-e (npr. React, Angular, Vue.js).'),
('Back-end razvoj',3,'Razviti serversku stranu aplikacije koristeći odgovarajuće tehnologije (npr. Node.js, Django, Ruby on Rails) i API-je za komunikaciju između front-end-a i back-end-a.'),
('Integracija baze podataka',3,'Implementirati bazu podataka i integrirati je sa back-end-om'),
('Sistem testiranje',3,'Testirati kompletnu aplikaciju kako bi se osiguralo da svi dijelovi funkcioniraju zajedno bez problema.'),
('Deployment',3,'Postaviti aplikaciju na produkciono okruženje. To uključuje konfiguraciju servera, baze podataka i bilo kojih drugih potrebnih servisa.'),
('Ažuriranja i unapređenja',3,'Redovno ažurirati aplikaciju novim funkcionalnostima i unapređenjima na osnovu korisničkog feedback-a i tehnoloških unapređenja.');