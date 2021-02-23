# _Triangle Testing Using MSTest and C#_

#### _Brief Synopsis_
* Takes in three side lengths and determines type of triangle or if a triangle can even be formed from these

#### By _**Olha Hizhytska, Salim Mayan, Tyler Sinks**_
_originally created 23 February, 2021_

## Technologies Used
* _C#, .NET 5.0_
* _MSTest_
* _VS Code_

## Description
* Accepts side lengths from the user for triangle **no user interface has yet been built to allow for this**
* Determines if these three lengths can form a triangle
* If triangle can be made which has these three sides, project will determine which kind of triangle would be formed
>  egs. scalene, isosceles, equilateral

## Specs
Describe: Triangle
Test: should return a new instance of Triangle whose type is Triangle
Code: Triangle newTriangle = new Triangle();
Expect:(typeof newTriangle).toEqual(testTriangle)




|                                            **Describe: Triangle**                                  |                       |                                   |
|:---------------------------------------------------------------------------------------------------|----------------------:|-----------------------------------|
|                                                Test                                                |         Input         |         Output                    |
| should return a new instance of Triangle whose type is Triangle                                    | Triangle newTriangle  | type of newTriangle = Triangle    |
|                                                                                                    | = new Triangle()      |                                   | 
|                                           **Describe: IsTriangle()**                               |                       |                                   |
|:---------------------------------------------------------------------------------------------------|----------------------:|-----------------------------------|
|                                                Test                                                |         Input         |         Output                    |
| Will compare every combination of two sides against the third side. returns false if any sum of two| Triangle testTriangle | false                             |
|   sides is greater than third side.                                                                | = new Triangle(2,2,8) |                                   |

|                                 **Describe: convertToVenus())**                                    |                       |                                   |
|                                                Test                                                |         Input         |         Output                    |
| should return a number that accurately converts age in Earth years to age in Venus years           | new Age(45)           | newAge.venus = 73.11 Venus years  |
| (conversion used: 1 Venus year = 224.65 Earth days)                                                |                       |                                   | 
|                                                                                                    |                       |                                   |
|                                        **Describe: convertToMars()**                               |                       |                                   |
|                                                Test                                                |         Input         |         Output                    |
| should return a number that accurately converts age in Earth years to age in Mars years            | new Age(45)           | newAge.mars = 23.91 Mars years    |
| (conversion used: 1 Mars year = 687 Earth days)                                                    |                       |                                   |
|                                                                                                    |                       |                                   |
|                                     **Describe: convertToJupiter()**                               |                       |                                   |
|                                                Test                                                |         Input         |         Output                    |
| should return a number that accurately converts age in Earth years to age in Jupiter years         | new Age(45)           | newAge.jupiter = 3.794 Jupiter years |
| (conversion used: 1 Jupiter year = 11.8618 Earth years)                                            |                       |                                   | 
|                                                                                                    |                       |                                   |
|                                                                                                    |                       |                                   |
|                                        **Describe: calcLifeExpectance()**                          |                       |                                   |
|                                                Test                                                |         Input         |         Output                    |
| should return a number that is the mean life expectancy in Earth years worldwide                   | new Age(45)           | newAge.lifeExpect = 73 Earth years|
|                                                                                                    |                       |                                   |
|                                                Test                                                |         Input         |         Output                    |
| should return a number that accurately adjusts Earth years life expectancy up by 7 years           | new Age(45)           |                                   |
| to be applied to users who mark they are from a first world country NOT in the Americas         | newAge.firstWorld = true | newAge.lifeExpect = 80 Earth years| 
|                                                                                                    |                       |                                   |
|                                                Test                                                |         Input         |         Output                    |
| should return a number that accurately adjusts Earth years life expectancy down by 10 years        | new Age(45)           |                                   |
| to be applied to users who mark they are from an African country                              | newAge.isFromAfrica = true |newAge.lifeExpect = 63 Earth years | 
|                                                                                                    |                       |                                   |
|                                                Test                                                |         Input         |         Output                    |
| should return a number that accurately adjusts Earth years life expectancy up by 6 years           | new Age(45)           |                                   |
| to be applied to users who mark they are from a country in North or South America           | newAge.isFromAmericas = true | newAge.lifeExpect = 79 Earth years| 
|                                                                                                    |                       |                                   |
|                                                Test                                                |         Input         |         Output                    |
| should return a number that accurately adjusts Earth years life expectancy up by 2 years | newAge.region = "any country in Americas" |                         |
| to be applied to users who mark sex = female                                                       | newAge.sex = "female" | newAge.lifeExpect = 81 years      | 
|                                                                                                    |                       |                                   |
|                                        **Describe: calcYearsLeft()**                               |         Input         |         Output                    |
|                                                Test                                                | new Age(45)           |                                   |
| should return a number in Mercury years that finds the difference between current Mercury years    | newAge.calcLifeExpectance() |                             |
| age and Mercury years life expectancy  (no sex or region data provided, thus EarthExpected = 73)   | newAge.calcYearsLeft("mercury") | newAge.mercuryLeft = (116.18) |
|                                                                                                    |                       |                                   |
|                                                Test                                                | new Age(45)           |                                   |
| should return a number in Venus years that is the difference between current Venus years      | newAge.calcLifeExpectance() |                                  |
| age and Venus years life expectancy  (no sex or region data provided, thus EarthExpected = 73)     | newAge.calcYearsLeft("venus") | newAge.venusLeft = (45.50) |
|                                                                                                    |                       |                                   |
|                                                Test                                                | new Age(45)           |                                   |
| should return a number in Mars years that is the difference between current Mars years             | newAge.calcLifeExpectance() |                             |
| age and Mars years life expectancy  (no sex or region data provided, thus EarthExpected = 73)      | newAge.calcYearsLeft("mars") | newAge.marsLeft = (14.87)  |
|                                                                                                    |                       |                                   |
|                                                Test                                                | new Age(45)           |                                   |
| should return a number in Jupiter years that is the difference between current Jupiter years age   | newAge.calcLifeExpectance() |                             |
| and Jupiter years life expectancy  (no sex or region data provided, thus EarthExpected = 73)  | newAge.calcYearsLeft("jupiter") | newAge.jupiterLeft = (6.15)  |
|                                                                                                    |                       |                                   |
|                                  **Describe: roundToNearestHundredth()**                           |                       |                                   |
|                                                Test                                                | new Age(45)           |                                   |
| should return a number that has more than two digits after its dot rounded to the nearest  | roundToNearestHundredth(41.96549) |  41.97                        |
| hundredth.                                                                                         |                       |                                   |

## **Installation Instructions to Setup This Project on Your Machine**
* Copy the following link to your clipboard: https://github.com/sinkstyt/galaxy-age.git
* Open a Bash Terminal (some might call it a 'command line')
* In this terminal window, navigate to a directory into which you will clone this project (make a local copy from the GitHub remote copy)
* Within your git bash terminal type in `$ git clone   ` with one space between "clone" and pasted clipboard contents (https://github.com/sinkstyt/galaxy-age.git)
> at Terminal promt
```
users/YOUR_USERNAME/ $ git clone https://github.com/sinkstyt/galaxy-age.git
```
* After the page has been cloned to your chosen directory, use `$ cd galaxy-age` to switch into its root folder.
* Check to see that you have npm installed with the prompt `$ npm -v`. As long as the first number in the version is 3 or greater, you should not anticipate any problems. If you are using OS X or greater and npm is not installed, use the command `$ brew install node`
* Check node version with `$ node -v`. Node version should start with a 4 or higher.
* For Windows users without npm, go to https://nodejs.org/en/download/ and download the LTS (long term support) option most appropriate for your system
* From within the root directory, use the following commands to have npm (Node package manager) install other dependencies
> `$ npm install`
* To see the project assembled and rendered in browser, use the following npm prompt. A tab should open to the rendered page.
> `$ npm run start`

### Examine all this project's contents in a text editor
* Launch all the files in your text editor of choice (such as VS Code, Atom, Sublime, VIM, etc.)
* If configured, use `$ code .` to open the entire repository in VS Code

## Known Bugs

* _The user interface is not yet connected to the business logic_

## License
MIT 2.0

## Contact Information
_[Contact Tyler](mailto:tyler.sinks@gmail.com)_
_[Contact Olha](mailto:<olgainfotech@gmail.com)_
_[Contact Salim](mailto:<mailsalim@gmail.com)_