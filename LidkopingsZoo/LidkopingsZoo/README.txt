ADMIN
Username: Admin@mail.com
Password: Admin1!

ADMIN
Username: Guidotheguide@mail.com
Password: Guide1!


Db init query
INSERT INTO Guides (name, email)
VALUES ('Guido The Guide')

INSERT INTO Guides (name, email)
VALUES ('Ace Ventura')

INSERT INTO Guides (name, email)
VALUES ('Crocodile Dundee')


INSERT INTO Animal (name, Description, Age, HabitatId, WaterAnimal, Speed, SpeciesName)
VALUES ('Palle', 'Snel Hest', 19, 2, 'Cow', 27,'Cow')
INSERT INTO Animal (name, Description, Age, HabitatId, WaterAnimal, Speed, SpeciesName)
VALUES ('Kalle', 'Fest Hest', 4, 2, 'Cow', 27,'Cow')
INSERT INTO Animal (name, Description, Age, HabitatId, WaterAnimal, Speed, SpeciesName)
VALUES ('Ralle', 'Cool Hest', 33, 2, 'Cow', 27,'Cow')
INSERT INTO Animal (name, Description, Age, HabitatId, WaterAnimal, Speed, SpeciesName)
VALUES ('Salle', 'Ko Hest', 22, 2, 'Cow', 27,'Cow')
INSERT INTO Animal (name, Description, Age, HabitatId, WaterAnimal, Speed, SpeciesName)
VALUES ('Santa', 'Flying maniac', 1751, 2, 'SantaClaus', 539626424,'SantaClaus')
INSERT INTO Animal (name, Description, Age, HabitatId, WaterAnimal, Speed, SpeciesName)
VALUES ('Giga', 'Giant dinosoar', 68000000, 2, 'Giganotosaurus', 50,'Giganotosaurus')

INSERT INTO Animal (name, Description, Age, HabitatId, WaterAnimal, DivingDepth, SpeciesName)
VALUES ('Krakis', 'Stor Bläckfisk', 432, 3, 'Kraken', 10500, 'Kraken')
INSERT INTO Animal (name, Description, Age, HabitatId, WaterAnimal, DivingDepth, SpeciesName)
VALUES ('Willy', 'Cute Killer', 133, 3, 'Orca', 1087,'Orca')
INSERT INTO Animal (name, Description, Age, HabitatId, WaterAnimal, DivingDepth, SpeciesName)
VALUES ('Pingu', 'TOTOTO', 11, 3, 'Penguin', 300, 'Penguin')

INSERT INTO Animal (name, Description, Age, HabitatId, WaterAnimal, MaxAltitude, SpeciesName)
VALUES ('Smaug', 'Hides In The Mountain', 11, 1, 'Dragon', 7000,'Dragon')
INSERT INTO Animal (name, Description, Age, HabitatId, WaterAnimal, MaxAltitude, SpeciesName)
VALUES ('Scrooge', 'Flips a coin', 11, 1, 'Goose', 8800, 'Goose')
INSERT INTO Animal (name, Description, Age, HabitatId, WaterAnimal, MaxAltitude, SpeciesName)
VALUES ('Gryffen', 'FlaxFlaxFlax', 11, 1, 'Griffin', 4000,'Griffin')




INSERT INTO guideAnimals (GuideId, AnimalId)
Values (1, 1)
INSERT INTO guideAnimals (GuideId, AnimalId)
Values (1, 2)
INSERT INTO guideAnimals (GuideId, AnimalId)
Values (1, 3)
INSERT INTO guideAnimals (GuideId, AnimalId)
Values (1, 4)

INSERT INTO guideAnimals (GuideId, AnimalId)
Values (2, 6)

INSERT INTO guideAnimals (GuideId, AnimalId)
Values (3, 7)