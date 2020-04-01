<!-- Headings -->
# Dragonite
#### Enjoy raising your very own virtual dragon with this cross-platform app built using C# and Xamarin Forms.


## Getting Started
#### These instructions will get you a copy of the project up and running on your local machine for development and testing purposes

## Prequisites
#### For development, the latest version of Visual Studio is required. The latest version can be downloaded from [here](https://visualstudio.microsoft.com/downloads/).

## Installing 
1. Clone the repo
> git clone https://github.com/James-Havinga/Dragonite.git

2. Open the project
> Use Open Worspace in Visual Studio

3. Recommended Devices 
* Iphone 8 plus
* Pixel 2xl

## Unit Tests
#### These are all the unit tests that can be run on this system

### GetLevelFromXpTest
#### This test checks if the correct level is selected based on the Xp level. Navigate to Test Explorer and run unit tests.

            //Arrange   
            int xp = 1500;
            int expectedReturn = 1;

            //Act
            int result = Level.GetLevelFromXp(xp);

            //Assert
            Assert.AreEqual(expectedReturn, result);
        
### GetDragonState
#### This test checks if the correct dragon state is being selected based on the string value.
            //Arrange   
            string dragonString = "dead";
            var expectedReturn = DragonState.dead;

            //Act
            int result = DragonStates.GetDragonState(dragonString);

            //Assert
            Assert.AreEqual(expectedReturn, result);

### UpdateUIEgg
#### This test checks if the correct string is being outputed based on the xp of the egg.
        //Arrange   
        int eggXp = 10;
        string expectedReturn = "YOUR EGG IS TOO COLD !";

        //Act
        int result = Dragonite.Hatching_Egg.UpdateUI(eggXp);

        //Assert
        Assert.AreEqual(expectedReturn, result);

## Built With
* Xamarin and more specifically Xamarin Forms

## Contributing 
#### If anybody would like to contribute or make some changes to the project they are more than welcome to do so. Any contributions you make would be greatly appreciated.

1. Fork the Porject
2. Create your Feature Branch ( git checkout -b feature/AmazingFeature)
3. Commit your Changes (git commit -m 'Added some new Features')
4. Push to the Branch ( git push origin feature/AmazingFeature)
5. Open a Pull Request

## Author

* [James Havinga](https://github.com/James-Havinga)

## Licence
#### This product is licensed under the MIT Licence - see the [LICENCE.md](https://github.com/James-Havinga/Dragonite/pull/1/commits/e211e30e9809e9422e0149128e9c22899b4b49c6) file for details.
