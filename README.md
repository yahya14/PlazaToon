# PlazaToon for Splatoon 2.12.0

<p align="center">
  <img src="http://i.imgur.com/vbH71TO.png" alt="PlazaToon Image"/>
</p>

[Downloads](https://github.com/yahya14/PlazaToon/releases/latest) | [Splatoon Modding Hub](http://gbatemp.net/threads/splatoon-modding-hub.425670/)

PlazaToon is a tool that allows you to freely change the size and locations of different NPCs in the plaza with ease and freedom. This could also be done by modifying the byamls in the splatoon game files, but this tool can modify them in the ram via TCPGecko connection.

###Automatic Mode in PlazaToon

As of version 0.5, this tool now requires you to press the poke buttons manually everytime you want to poke changes to the ram. To switch to **Automatic Mode**, you must need check it under the **Options** button on the top left corner. This mode will allow the tool to poke values instantaneously to the ram everytime the value changes in any numeric box. Note, this mode requires the *Recalculate* button everytime you change between loading screens while going in and out of the plaza to prevent crashes. When you want to switch out of Automatic Mode, simply uncheck Automatic Mode again.

###Things to know about the Connect/Recalculate button

Because NPC addresses tend to move everytime a loading screen appears, the **Recalculate** button will help find the dynamic addresses for you, which needs to be pressed after every loading screen in the plaza. if the addresses aren't recalculated properly, the game has a chance of crashing.

The **Connect** button also acts as a way to differentiate between loadiine and geckiine. It's somewhat useful if you want to know which one you're using:

+ Light blue indicaties a loadiine connection.
+ Dark blue indicates geckiine connection.

##Usage

###Requirements

+ Windows Vista or higher (Mac and Linux users, use Wine)
+ [.NET Framework 4.5.2](http://go.microsoft.com/fwlink/?LinkId=328843)
+ Splatoon with version 2.12.0
+ TCPGecko + kernel from loadiine.ovh (Also works with Geckiine which can be found [here](http://466gaming.ga/geckiine/))

###How to use it

First off, you'll need to start TCPGecko + kernel from the loadiine.ovh website. Or Geckiine if you want.

When launching the program, enter you Wii U's local IP in the entry box then click the connect button. The button will establish the connection, turning it into a blue button.


####Character selection

To select an NPC of your choice, click the drop down where it shows Callie. So far, you can chose between 18 different NPCs in the current version of the tool:

+ Callie
+ Callie's Chair
+ Marie
+ Marie's Chair
+ Judd
+ Spyke
+ Sea Snails
+ Train ***NEW***
+ Amiibo Box 
+ Balloon 
+ Miiverse Post
+ Tree 1 to 4 
+ Arcade
+ Manhole
+ Weapon Sign

####Scaling their size

To change their size, the numeric boxes with **light blue** numbers, respectively labeled with the correct axis, can be changed with the up and down buttons on them, by typing, or even with arrow keys. this can be understood by the following:

- The x- and x2- axis can strech or compress their models left/right
- The y-axis can strech or compress their moddels up/down
- The z and z2- axis can strech or compress their moddels forward/backward

Small note that the box with labels like *x* and *x2* are basically the axis in two parts, because Nintendo designed it that way in ram. Some NPCs however still use the regular three param scales (x,y,z), like you see with judd or the train.

Do you by chance find playing with the two seperate x- or z- axis difficult for you? The checkbox below the numeric boxes may help you with that in some form. This is unchecked at default.

The master scale with **dark blue** numbers can change values on all of its axis, making them proportionally big or small much easier.

####Coordinating their location

To change their location, the number boxes with **red** numbers can be understood by the following:

- The x-axis can move the objects left and right (positive and negative)
- The x-axis can move the objects up and down (positive and negative)
- The x-axis can move the objects forward and backward (negative and positive)

####Reset all sizes and locations

On the top left of the program, there's an options tab that leads you to the *Reset All* button; which can reset all your current settings back to default. It's there for you if everything is all messed up for some silly reason.

##Credits

Special thanks to all for their useful stuff; Chadderz, Amibu, Lean, Splatonka, and CosmoCortney.

If it weren't for them, I wouldn't be able to make this in the first place.
