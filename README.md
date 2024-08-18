# Unity-Packages
Repo for all of my unity packages/utilities!

## TimerUtils
TimerUtils contains timer necessities that I find myself using a ton in a lot of my projects. 
These include a normal basic `Timer`, as well as an `IntervalTimer` (repeats), and a `RandomIntervalTimer` repeats at defined random intervals.

~ Can be imported through the package manager or with the unitypackage.

## SaveSystem
SaveSystem is a save system I have created that uses an ISaveable interface.
Essentially the purpose of this system is for each saveable object to define its own `Data` derived class.
All you have to do is define the data you want to store, and implement the interface! then it will save on its own. (as long as you call the save load functions somewhere :P

~ Can be downloaded using the unitypackage. Source code is on github for show but it does not have a package as it has scripts that should be in assets

## Utils
This is a generic namespace im going to be using for all sorts of utility classes.
As of now this includes a MonoSingleton for manager scripts, as well as an AudioManager (which uses the MonoSingleton) built in for use.

~ Can be downloaded using the package manager or with the unitypackage.

