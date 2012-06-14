-- DDL-Skript für das BONN-IT-Projekt <Zeiterfassung>

-- Datenbank erstellen
CREATE DATABASE /*!32312 IF NOT EXISTS*/ zeiterfassung /*!40100 DEFAULT CHARACTER SET utf8 COLLATE utf8_general_ci */;
USE zeiterfassung;

-- Vorhandene Datensätze löschen
DROP TABLE IF EXISTS TZeiterfassung;
DROP TABLE IF EXISTS TMita_Proj;
DROP TABLE IF EXISTS TProj_Taet;
DROP TABLE IF EXISTS TProjekt;
DROP TABLE IF EXISTS TMitarbeiter;
DROP TABLE IF EXISTS TKunde;
DROP TABLE IF EXISTS TTaetigkeitenvorlage;
DROP TABLE IF EXISTS TRolle;

-- Tabelle für Benutzerberechtigungen (Mitarbeiter, Geschäftsführung etc)
CREATE TABLE TRolle(
	roID 			INTEGER UNSIGNED NOT NULL AUTO_INCREMENT,
	roBezeichnung 	VARCHAR(32) NOT NULL,
	CONSTRAINT pk_roID PRIMARY KEY(roID)
)
DEFAULT CHARACTER SET utf8 COLLATE utf8_general_ci;

-- Vorlage für Tätigkeit bei Zeiterfassung
CREATE TABLE TTaetigkeitenvorlage (
	taID			INTEGER UNSIGNED NOT NULL AUTO_INCREMENT,
	taBeschreibung	VARCHAR(50) NOT NULL,
	CONSTRAINT pk_taID PRIMARY KEY(taID)
)
DEFAULT CHARACTER SET utf8 COLLATE utf8_general_ci;

-- Tabelle mit Kundendaten u. Kontaktinformationen
CREATE TABLE TKunde (
	kuID 				INTEGER UNSIGNED NOT NULL AUTO_INCREMENT,
	kuFirma 			VARCHAR(64), -- Firma nicht zwingend erforderlich (Einzelperson o.ä.)
	kuStrasse 			VARCHAR(64) NOT NULL,
	kuPLZ 				VARCHAR(5) NOT NULL,
	kuOrt 				VARCHAR(64) NOT NULL,
	kuTel 				VARCHAR(32) NOT NULL,
	kuFax 				VARCHAR(32),
	kuAnsprechpartner 	VARCHAR(64) NOT NULL,
	kuEMail 			VARCHAR(32) NOT NULL,
	CONSTRAINT pk_kuID PRIMARY KEY(kuID)
)
DEFAULT CHARACTER SET utf8 COLLATE utf8_general_ci;

-- Mitarbeiter mit Logindaten
CREATE TABLE TMitarbeiter (
	miID		INTEGER UNSIGNED NOT NULL AUTO_INCREMENT,
	roID		INTEGER UNSIGNED NOT NULL,
	miName		VARCHAR(32)  NOT NULL,
	miVorname	VARCHAR(32) NULL,
	miUsername	VARCHAR(32) NOT NULL,
	miPasswort	VARCHAR(32) NOT NULL,
	miEMail		VARCHAR(32),
	CONSTRAINT pk_miID PRIMARY KEY(miID),
	CONSTRAINT fk_miroID FOREIGN KEY(roID) REFERENCES TRolle(roID)
)
DEFAULT CHARACTER SET utf8 COLLATE utf8_general_ci;

-- Projekttabelle
CREATE TABLE TProjekt (
	prID			INTEGER UNSIGNED NOT NULL AUTO_INCREMENT,
	kuID			INTEGER UNSIGNED NOT NULL,
	prName			VARCHAR(64) NOT NULL,
	prBeschreibung	VARCHAR(128),
	CONSTRAINT pk_prID PRIMARY KEY(prID),
	CONSTRAINT fk_prkuID FOREIGN KEY(kuID) REFERENCES TKunde(kuID)
)
DEFAULT CHARACTER SET utf8 COLLATE utf8_general_ci;

-- Zuordnung Tätigkeitenbeschreibungsvorlage zu Projekt
CREATE TABLE TProj_Taet (
	prID	INTEGER UNSIGNED NOT NULL,
	taID	INTEGER UNSIGNED NOT NULL,
	CONSTRAINT pk_prID_taID PRIMARY KEY(prID, taID),
	CONSTRAINT fk_ptprID FOREIGN KEY(prID) REFERENCES TProjekt(prID),
	CONSTRAINT fk_pttaID FOREIGN KEY(taID) REFERENCES TTaetigkeitenvorlage(taID)
)
DEFAULT CHARACTER SET utf8 COLLATE utf8_general_ci;

-- Zuordnung, welcher Mitarbeiter auf welches Projekt verschreiben darf
CREATE TABLE TMita_Proj (
	miID	INTEGER UNSIGNED NOT NULL,
	prID	INTEGER UNSIGNED NOT NULL,
	mpAktiv	BOOLEAN,
	CONSTRAINT pk_miID_prID PRIMARY KEY(miID, prID),
	CONSTRAINT fk_mpmiID FOREIGN KEY(miID) REFERENCES TMitarbeiter(miID),
	CONSTRAINT fk_mpprID FOREIGN KEY(prID) REFERENCES TProjekt(prID)
)
DEFAULT CHARACTER SET utf8 COLLATE utf8_general_ci;

-- Zeiterfassungstabelle
CREATE TABLE TZeiterfassung (
	zeID 			INTEGER UNSIGNED NOT NULL AUTO_INCREMENT,
	miID 			INTEGER UNSIGNED NOT NULL,
	prID 			INTEGER UNSIGNED NOT NULL,
	zeTag 			DATE NOT NULL,
	zeTaetigkeit	VARCHAR(50) NOT NULL,
	zeDauer			DECIMAL(4,2) NOT NULL, -- max. 99.99
	zeReisekosten	DECIMAL(6,2) DEFAULT 0.00, -- max. 9999.99
	CONSTRAINT pk_zeID PRIMARY KEY(zeID),
	CONSTRAINT fk_zemiID FOREIGN KEY(miID) REFERENCES TMitarbeiter(miID),
	CONSTRAINT fk_zeprID FOREIGN KEY(prID) REFERENCES TProjekt(prID),
	CONSTRAINT chk_dauer CHECK(zeDauer BETWEEN 0.25 AND 24.0),
	CONSTRAINT chk_reiko CHECK(zeReisekosten BETWEEN 0.00 AND 9999.99)
)
DEFAULT CHARACTER SET utf8 COLLATE utf8_general_ci;
