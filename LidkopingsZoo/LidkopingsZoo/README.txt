ADMIN
Username: Admin@mail.com
Password: Admin1!



Db init query
INSERT INTO Guides (name)
VALUES ('Guido The Guide')

INSERT INTO Guides (name)
VALUES ('Ace Ventura')

INSERT INTO Guides (name)
VALUES ('Crocodile Dundee')


INSERT INTO Animal (name, Description, Age, HasHabitat, HabitatId, LandAnimal, AirAnimal, WaterAnimal, MaxAltitude, Speed, DivingDepth)
VALUES ('Palle', 'Snel Hest', 19, 1,2, 'Cow','','',0,0,0)
INSERT INTO Animal (name, Description, Age, HasHabitat, HabitatId, LandAnimal, AirAnimal, WaterAnimal, MaxAltitude, Speed, DivingDepth)
VALUES ('Kalle', 'Fest Hest', 4, 1,2, 'Cow','','',0,0,0)
INSERT INTO Animal (name, Description, Age, HasHabitat, HabitatId, LandAnimal, AirAnimal, WaterAnimal, MaxAltitude, Speed, DivingDepth)
VALUES ('Ralle', 'Cool Hest', 33, 1,2, 'Cow','','',0,0,0)
INSERT INTO Animal (name, Description, Age, HasHabitat, HabitatId, LandAnimal, AirAnimal, WaterAnimal, MaxAltitude, Speed, DivingDepth)
VALUES ('Salle', 'Ko Hest', 22, 1,2, 'Cow','','',0,0,0)

INSERT INTO Animal (name, Description, Age, HasHabitat, HabitatId,WaterAnimal, AirAnimal, LandAnimal, MaxAltitude, Speed, DivingDepth)
VALUES ('Krakis', 'Stor Bläckfisk', 432, 1,3, 'Kraken','','',0,0,0)
INSERT INTO Animal (name, Description, Age, HasHabitat, HabitatId,WaterAnimal, AirAnimal, LandAnimal, MaxAltitude, Speed, DivingDepth)
VALUES ('Willy', 'Cute Killer', 133, 1,3, 'Orca','','',0,0,0)
INSERT INTO Animal (name, Description, Age, HasHabitat, HabitatId,WaterAnimal, AirAnimal, LandAnimal, MaxAltitude, Speed, DivingDepth)
VALUES ('Pingu', 'TOTOTO', 11, 1,3, 'Penguin','','',0,0,0)

INSERT INTO Animal (name, Description, Age, HasHabitat, HabitatId,AirAnimal, LandAnimal, WaterAnimal, MaxAltitude, Speed, DivingDepth)
VALUES ('Smaug', 'Hides In The Mountain', 11, 1,1, 'Dragon','','',0,0,0)
INSERT INTO Animal (name, Description, Age, HasHabitat, HabitatId,AirAnimal, LandAnimal, WaterAnimal, MaxAltitude, Speed, DivingDepth)
VALUES ('Scrooge', 'Flips a coin', 11, 1,1, 'Goose','','',0,0,0)
INSERT INTO Animal (name, Description, Age, HasHabitat, HabitatId,AirAnimal, LandAnimal, WaterAnimal, MaxAltitude, Speed, DivingDepth)
VALUES ('Gryffen', 'FlaxFlaxFlax', 11, 1,1, 'Griffin','','',0,0,0)




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