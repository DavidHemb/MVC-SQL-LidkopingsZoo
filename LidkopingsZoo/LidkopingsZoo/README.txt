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


INSERT INTO Animal (name, Description, Age, HasHabitat, HabitatId, LandAnimal)
VALUES ('Palle', 'Snel Hest', 19, 1,2, 'Cow')
INSERT INTO Animal (name, Description, Age, HasHabitat, HabitatId,LandAnimal)
VALUES ('Kalle', 'Fest Hest', 4, 1,2, 'Cow')
INSERT INTO Animal (name, Description, Age, HasHabitat, HabitatId,LandAnimal)
VALUES ('Ralle', 'Cool Hest', 33, 1,2, 'Cow')
INSERT INTO Animal (name, Description, Age, HasHabitat, HabitatId,LandAnimal)
VALUES ('Salle', 'Ko Hest', 22, 1,2, 'Cow')

INSERT INTO Animal (name, Description, Age, HasHabitat, HabitatId,WaterAnimal)
VALUES ('Krakis', 'Stor Bläckfisk', 432, 1,3, 'Kraken')
INSERT INTO Animal (name, Description, Age, HasHabitat, HabitatId,WaterAnimal)
VALUES ('Willy', 'Cute Killer', 133, 1,3, 'Orca')
INSERT INTO Animal (name, Description, Age, HasHabitat, HabitatId,WaterAnimal)
VALUES ('Pingu', 'TOTOTO', 11, 1,3, 'Penguin')

INSERT INTO Animal (name, Description, Age, HasHabitat, HabitatId,AirAnimal)
VALUES ('Smaug', 'Hides In The Mountain', 11, 1,1, 'Dragon')
INSERT INTO Animal (name, Description, Age, HasHabitat, HabitatId,AirAnimal)
VALUES ('Scrooge', 'Flips a coin', 11, 1,1, 'Goose')
INSERT INTO Animal (name, Description, Age, HasHabitat, HabitatId,AirAnimal)
VALUES ('Gryffen', 'FlaxFlaxFlax', 11, 1,1, 'Griffin')




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