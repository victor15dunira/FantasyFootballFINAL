# Final ReadMe.File

Created: May 9, 2021 11:38 PM

# **Fantasy Football Application**

## Brief/ Introduction

Outlined below is a README. File for the Web Application “Fantasy Football”. The main purpose and aim for the project were to create a Web Application that carries out CRUD (CREATE, READ, UPDATE and DELETE) functionalities. In order to do so, a use of a variety of tools and technologies were implemented.

Requirements

To highlight the key fundamental skills developed throughout the project. The following requirements were:

- A Trello Board, or Kanban board technology, with full expansion on user stories, use cases and tasks.
- Use of a relational database used to store data, with a minimum of two tables.
- Clear documentation from design phase to architecture
- A functional CRUD application written in C#
- Fully designed test suites for the application, as well ad automated tests for validation
- Provide high test coverage and provide consistent reports and evidence to support a TDD
- A functioning front-end website and integrated API’s
- Code integrated into a version control system, built through a CI server and deployed to a cloud-based VM.

## Approach

Initially from a design viewpoint there were two ideas which came to mind, the first idea was an application which could track a local football teams scores weekly. But instantly there were issues with implementing all aspects of the CRUD functionalities, as a result a Fantasy Football Application seemed more appropriate and fit for purpose.

- Create a team that stores:
- Name
- Logo/Badge
- Number of players
- Create a player that stores:
- First Name
- Last Name
- Position
- Creation date
- Height
- Image of player
- View and Update the players on an individual team
- View and Update the team
- Delete a player from an individual team
- Delete a team

## Architecture

## Data structure

As shown below are the Entity Relationship Diagrams, which show the structure of the database.

![Final%20ReadMe%20File%2001e204208ee24b13b47c8446a8f1b539/Untitled.png](Final%20ReadMe%20File%2001e204208ee24b13b47c8446a8f1b539/Untitled.png)

![Final%20ReadMe%20File%2001e204208ee24b13b47c8446a8f1b539/Untitled%201.png](Final%20ReadMe%20File%2001e204208ee24b13b47c8446a8f1b539/Untitled%201.png)

The ERD models the database as a one to many relationship, whereby a team can contain one or more players, each team must contain a minimum of one player.

## Project Tracking

Trello was used in order to track the progress of the project, a link is attached below.

https://trello.com/b/rWR1E2xE/software-development-web-app-ios-app-android-app

![Final%20ReadMe%20File%2001e204208ee24b13b47c8446a8f1b539/Untitled%202.png](Final%20ReadMe%20File%2001e204208ee24b13b47c8446a8f1b539/Untitled%202.png)

## Risk Assessment

Here is screenshot highlight a section of the risk assessment.

![Final%20ReadMe%20File%2001e204208ee24b13b47c8446a8f1b539/Untitled%203.png](Final%20ReadMe%20File%2001e204208ee24b13b47c8446a8f1b539/Untitled%203.png)

## CI Pipeline

The CI pipeline is a system which encompasses the four stages: Pull, Build, Test and Run. Whereby the pull stage consists of pulling code from the Git repository, which followed by the Build stage in which Visual Studio, creates a build of your project solution, then comes the testing stage which requires unit tests on sections of the project, mainly the utilities and controllers, in which you should generate coverage reports. Lastly the Run section is the installation of the web application on to a VM, in which tests and reports are comprehensively produced to highlight passed/failed build stages. Which provide the user with a more accurate diagnosis of failed builds.

The were issues experienced with deploying the code using Azure DevOps CI Pipeline, as a result the application was published and deployed to a VM using Azure, there are less advantages to using this method such as the inability to get accurate build/test reports.

## Testing

Unit Testing

A unit test enables the developer to isolate sections of the code, enabling them to perform checks on data returned and if the datatypes set and returned are as desired, ensuring the functions carried out are as expected.

- Player Utility Testing and Team Utility Testing

![Final%20ReadMe%20File%2001e204208ee24b13b47c8446a8f1b539/Untitled%204.png](Final%20ReadMe%20File%2001e204208ee24b13b47c8446a8f1b539/Untitled%204.png)

Both the Team Utility and Player Utility were the sections which were tested and the screenshot above shows the tests passed. The tests had random test data inserted and the functions were able to return expected results.

![Final%20ReadMe%20File%2001e204208ee24b13b47c8446a8f1b539/Untitled%205.png](Final%20ReadMe%20File%2001e204208ee24b13b47c8446a8f1b539/Untitled%205.png)

In the image above, towards the bottom of the screenshot shows the beginning of testing the PlayerControllerTest, which was not finished. This was a major drawback in terms of the testing, this was down to a factor of underestimating the scale of implementing the testing stage, there was some uncertainty in the method of testing, I found when watching the tutorial video on “Repository Pattern” there was some confusion between variable assignment/ replacement, since the implementation of the repositories required editing the main controllers, which are responsible for the web applications functionalities, I deemed it risky to proceed without concrete knowledge as it could result in broken code and failed design builds.

## Front-End

![Final%20ReadMe%20File%2001e204208ee24b13b47c8446a8f1b539/Untitled%206.png](Final%20ReadMe%20File%2001e204208ee24b13b47c8446a8f1b539/Untitled%206.png)

The front-end of the application uses a template from bootstrap, which has a minimalistic design, the navigation bar at the top takes you to the following pages; Home, Teams and Players.

![Final%20ReadMe%20File%2001e204208ee24b13b47c8446a8f1b539/Untitled%207.png](Final%20ReadMe%20File%2001e204208ee24b13b47c8446a8f1b539/Untitled%207.png)

![Final%20ReadMe%20File%2001e204208ee24b13b47c8446a8f1b539/Untitled%208.png](Final%20ReadMe%20File%2001e204208ee24b13b47c8446a8f1b539/Untitled%208.png)

![Final%20ReadMe%20File%2001e204208ee24b13b47c8446a8f1b539/Untitled%209.png](Final%20ReadMe%20File%2001e204208ee24b13b47c8446a8f1b539/Untitled%209.png)

Above are the screenshots which highlight the create a player and team, these sections are accessed from the navigation bar “Teams”.

![Final%20ReadMe%20File%2001e204208ee24b13b47c8446a8f1b539/Untitled%2010.png](Final%20ReadMe%20File%2001e204208ee24b13b47c8446a8f1b539/Untitled%2010.png)

Above are the two created players which belong to the team Arsenal. There are options to Edit, View and Delete the players from the team Arsenal.

![Final%20ReadMe%20File%2001e204208ee24b13b47c8446a8f1b539/Untitled%2011.png](Final%20ReadMe%20File%2001e204208ee24b13b47c8446a8f1b539/Untitled%2011.png)

Above are the two created players which belong to the team West Ham. There are options to Edit, View and Delete the players from the team West Ham.

![Final%20ReadMe%20File%2001e204208ee24b13b47c8446a8f1b539/Untitled%2012.png](Final%20ReadMe%20File%2001e204208ee24b13b47c8446a8f1b539/Untitled%2012.png)

This shows a collection of all the players belonging to various football teams in the database.

## Known Issues

- The number of players shown on the Homepage doesn’t correspond to the number of players in the database.

## Future Improvements

- Implement some error messages to state when incorrect datatypes or incorrect parameters have been inserted.
- To fix the issue with displaying the number of players in each team some type of count function/action should be used.
- Possibly add a personal user account system to make individual fantasy football teams private.
- In the ‘all players’ section shown reference which team each player belongs to.