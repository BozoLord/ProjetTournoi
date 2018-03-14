CREATE TABLE `Person` (
	`id` int(50) NOT NULL AUTO_INCREMENT,
	`FirstName` varchar(50) NOT NULL,
	`LastName` varchar(50) NOT NULL,
	`EmailAdress` varchar(200) NOT NULL UNIQUE,
	`CellphoneNumber` varchar(20) NOT NULL,
	`RegDate` TIMESTAMP NOT NULL,
	PRIMARY KEY (`id`)
);

CREATE TABLE `Teams` (
	`id` int(50) NOT NULL AUTO_INCREMENT,
	`TeamName` varchar(100) NOT NULL,
	`RegDate` TIMESTAMP NOT NULL,
	PRIMARY KEY (`id`)
);

CREATE TABLE `TeamMembers` (
	`id` int(50) NOT NULL AUTO_INCREMENT,
	`TeamId` int(50) NOT NULL,
	`PersonId` int(50) NOT NULL,
	PRIMARY KEY (`id`)
);

CREATE TABLE `Tournaments` (
	`id` int(50) NOT NULL AUTO_INCREMENT,
	`TournamentName` varchar(100) NOT NULL UNIQUE,
	`EntryFee` DECIMAL(50) NOT NULL,
	`RegDate` TIMESTAMP NOT NULL,
	PRIMARY KEY (`id`)
);

CREATE TABLE `TournamentEntries` (
	`id` int(50) NOT NULL AUTO_INCREMENT,
	`TeamId` int(50) NOT NULL,
	`TournamentId` int(50) NOT NULL,
	PRIMARY KEY (`id`)
);

CREATE TABLE `Prizes` (
	`id` int(50) NOT NULL AUTO_INCREMENT,
	`PlaceNumber` int(50) NOT NULL,
	`PlaceName` varchar(100) NOT NULL,
	`PrizeAmount` DECIMAL(10) NOT NULL,
	`PrizePercentage` FLOAT(10) NOT NULL,
	PRIMARY KEY (`id`)
);

CREATE TABLE `TournamentPrize` (
	`id` int(50) NOT NULL AUTO_INCREMENT,
	`TournamentId` int(50) NOT NULL,
	`PrizeId` int(50) NOT NULL,
	PRIMARY KEY (`id`)
);

CREATE TABLE `Matchups` (
	`id` int(50) NOT NULL AUTO_INCREMENT,
	`WinnerId` int(50) NOT NULL,
	`MatchupRound` int(10) NOT NULL,
	PRIMARY KEY (`id`)
);

CREATE TABLE `MatchupEntries` (
	`id` int(50) NOT NULL AUTO_INCREMENT,
	`TeamCompetingId` int(50) NOT NULL,
	`MatchupId` int(50) NOT NULL,
	`ParentMatchupId` int(50) NOT NULL,
	PRIMARY KEY (`id`)
);

ALTER TABLE `TeamMembers` ADD CONSTRAINT `TeamMembers_fk0` FOREIGN KEY (`TeamId`) REFERENCES `Teams`(`id`);

ALTER TABLE `TeamMembers` ADD CONSTRAINT `TeamMembers_fk1` FOREIGN KEY (`PersonId`) REFERENCES `Person`(`id`);

ALTER TABLE `TournamentEntries` ADD CONSTRAINT `TournamentEntries_fk0` FOREIGN KEY (`TeamId`) REFERENCES `Teams`(`id`);

ALTER TABLE `TournamentEntries` ADD CONSTRAINT `TournamentEntries_fk1` FOREIGN KEY (`TournamentId`) REFERENCES `Tournaments`(`id`);

ALTER TABLE `TournamentPrize` ADD CONSTRAINT `TournamentPrize_fk0` FOREIGN KEY (`TournamentId`) REFERENCES `Tournaments`(`id`);

ALTER TABLE `TournamentPrize` ADD CONSTRAINT `TournamentPrize_fk1` FOREIGN KEY (`PrizeId`) REFERENCES `Prizes`(`id`);

ALTER TABLE `Matchups` ADD CONSTRAINT `Matchups_fk0` FOREIGN KEY (`WinnerId`) REFERENCES `Teams`(`id`);

ALTER TABLE `MatchupEntries` ADD CONSTRAINT `MatchupEntries_fk0` FOREIGN KEY (`TeamCompetingId`) REFERENCES `Teams`(`id`);

ALTER TABLE `MatchupEntries` ADD CONSTRAINT `MatchupEntries_fk1` FOREIGN KEY (`MatchupId`) REFERENCES `Matchups`(`id`);

ALTER TABLE `MatchupEntries` ADD CONSTRAINT `MatchupEntries_fk2` FOREIGN KEY (`ParentMatchupId`) REFERENCES `Matchups`(`id`);

