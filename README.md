# Memory MAUI

![GitHub all releases](https://img.shields.io/github/downloads/GiorgioCitterio/MemoryMAUI/total)
![GitHub](https://img.shields.io/github/license/GiorgioCitterio/MemoryMAUI)
![GitHub deployments](https://img.shields.io/github/deployments/GiorgioCitterio/MemoryMAUI/github-pages)
![GitHub repo size](https://img.shields.io/github/repo-size/GiorgioCitterio/MemoryMAUI)
![GitHub Repo stars](https://img.shields.io/github/stars/GiorgioCitterio/MemoryMAUI)

![C#](https://img.shields.io/badge/c%23-%23239120.svg?style=for-the-badge&logo=c-sharp&logoColor=white)
![.Net](https://img.shields.io/badge/.NET-5C2D91?style=for-the-badge&logo=.net&logoColor=white)
![SQLite](https://img.shields.io/badge/sqlite-%2307405e.svg?style=for-the-badge&logo=sqlite&logoColor=white)
![Android](https://img.shields.io/badge/Android-3DDC84?style=for-the-badge&logo=android&logoColor=white)
![Windows](https://img.shields.io/badge/Windows-0078D6?style=for-the-badge&logo=windows&logoColor=white)

<a href="https://github.com/GiorgioCitterio/MemoryMAUI/blob/master/README.it.md">README.it 🇮🇹</a>

---

## Table of Contents
- <a  href="#appoverview">App Overview</a>
- <a  href="#gameplay">Gameplay</a>
- <a  href="#features">Features</a>
  - <a  href="#difflvl">Difficulty Levels</a>
  - <a  href="#resstor">Result Storage</a>
  - <a  href="#backmus">Background Music</a>
  - <a  href="#theme">Theme Selection</a>
  - <a  href="#timer">Score and Timer Display</a>
- <a  href="#platforms">Supported platforms</a>
- <a  href="#sysreq">System Requirments</a>
- <a  href="#installation">Installation</a>
- <a  href="#mauiversion">.NET MAUI Version</a>
- <a  href="#nuget">Nuget Packages</a>
- <a  href="#todo">Changes/Features to Add</a>

## Overview <a name="appoverview"></a>
Memory MAUI is a memory game available for Android and Windows platforms. The game offers three difficulty levels: easy, medium, and hard. In addition to the difficulty levels, the game also supports storing the results and playing background music. Furthermore, there are four different themes available to customize the game's appearance.

## Gameplay <a name="gameplay"></a>
1. Launch the Memory Game app on your device.
2. Select the desired theme: Art, Marvel, Fruit, Cities.
3. Select the desired difficulty level: Easy, Medium, or Difficult.
4. The game grid will be displayed, consisting of face-down cards.
5. Tap on a card to flip it and reveal the image.
6. Tap on a second card to flip it as well.
7. If the two flipped cards match, they will remain face-up.
8. If the two flipped cards do not match, they will be flipped back face-down.
9. Continue flipping cards and trying to find matching pairs until all pairs have been found.
10. The game ends when all pairs have been successfully matched.
11. Your score and time will be recorded and displayed at the end of the game.

## Features <a name="features"></a>
### 1. Difficulty Levels <a name="difflvl"></a>
- The game offers three difficulty levels to cater to different skill levels - Easy, Medium, and Difficult. Each level has a different grid size and card complexity.
### 2. Result Storage <a name="resstor"></a>
- The game keeps track of the player's scores and times for each difficulty level. This allows players to track their progress and aim for better performance in subsequent sessions.
### 3. Background Music <a name="backmus"></a>
- Enjoy playing the game with background music to enhance the gaming atmosphere. The game provides four different themes to choose from, allowing you to personalize your gaming experience.
### 4. Theme Selection <a name="theme"></a>
- Customize the appearance of the game by selecting one of the available themes. Choose a theme that suits your preferences and adds a visually pleasing touch to the game.
### 5. Score and Timer Display <a name="timer"></a>
- During gameplay, the game displays your current score and elapsed time. This allows you to track your performance and challenge yourself to improve with each playthrough.

## Supported Platforms <a name="platforms"></a>
- Windows
- Android

## System Requirements <a name="sysreq"></a>
- Android: Requires an Android device running Android OS version 9 or higher.
- Windows: Requires a Windows PC with Windows OS version 10 or higher.

## Installation <a name="installation"></a>
To install Memory game on your Android device, follow [this guide](https://github.com/GiorgioCitterio/MemoryMAUI/wiki).

## .NET MAUI Version: <a name="mauiversion"></a>
The project was developed using [.NET MAUI 6](https://learn.microsoft.com/en-us/dotnet/maui/what-is-maui?view=net-maui-6.0), which provides the latest features and improvements for building cross-platform apps.

## NuGet Packages <a name="nuget"></a>
The project utilizes the following NuGet packages:
- Plugin.Maui.Audio: Used for playing background music within the app.
- sqlite-net-pc: Used for handling the SQLite database in the app.
- SQLitePCLRaw.bundle_green: Used for SQLite database support.
  
## Changes/Features to Add: <a name="todo"></a>
- [x] SQLite database
- [x] Markdown
- [x] Android
- [x] Audio manager (easy, medium, hard)
- [x] APK download
- [x] Settings
- [x] Version and source code
- [x] Icons
- [x] Image resizing
