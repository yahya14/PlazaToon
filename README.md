# PlazaToon for Splatoon 2.12.0

<p align="center">
  <img src="http://i.imgur.com/rbE7TwV.png" alt="PlazaToon Image"/>
</p>

[Downloads](https://github.com/yahya14/PlazaToon/releases/latest) | [Splatoon Modding Hub](http://gbatemp.net/threads/splatoon-modding-hub.425670/)

**Important note: Despite many of the bugs have been fixed, the tool still needs a sort of crash prevention implemented in the program.**

PlazaToon is a tool that lets you freely change the size and locations of different NPCs in the plaza with much more ease and freedom. This can also be done by modifying the byamls in the splatoon game files, but to make things easier, this tool modifies them in ram via TCPGecko connection.

##What you need to know about the Recalculate button

So lets talk about moving addresses for a bit. In this situation, the NPC's addresses move everytime a loading screen appears. So once you are connected, keep in mind you'll need to click the *Recalculate* button *after* every loading screen in the plaza. (but sometimes they don't move anymore, but better be safe to *prevent crashes*.)

Also make sure that you disconnect the tool if you want to go online, if by chance you change a value in the tool during a match, your game will likely crash.

**NEW:** With the new Geckiine support, you would see that the recalculate button will differ in colour depending on which one you are using. Light blue indicates that you're loading loadiine addresses, while dark blue is loading geckiine's.

##Usage

###Requirements

+ Windows Vista or higher (Mac and Linux users, use Wine)
+ [.NET Framework 4.5.2](http://go.microsoft.com/fwlink/?LinkId=328843)
+ Splatoon with version 2.12.0
+ TCPGecko + kernel on the Wii U (Supports both Loadiine and Geckiine)

###How to use it

When launching the program, enter you Wii U's local IP in the entry box then click the connect button. The button will tranform into a blue *Recalculate* button, which also indicates that you're conected and the addresses are calculated for use. Remember that to always click the blue button after *every* loading screen.

####Character selection

To select an NPC of your choice, click the drop down where it shows Callie. So far, you can chose between 7 different NPCs in the current version of the tool:

+ Callie
+ Callie's Chair
+ Marie
+ Marie's Chair
+ Judd
+ Spyke
+ Tree
+ Arcade **NEW**
+ Manhole **NEW**

####Scaling their size

To change their size, the *number boxes with light blue numbers*, respectively labeled with the correct axis, can be changed with the up and down buttons, by typing, or even with arrow keys. To understand how they work from the following:

- The x-axis can strech or compress their models left/right
- The y-axis can strech or compress their moddels up/down
- The z-axis can strech or compress their moddels forward/backward

Small note that the box with labels like *X* and *X 2* are basically the axis in two parts, because Nintendo designed it that way in ram. Oddly, Some of their NPCs still use the regular (x,y,z) scales, like you see with judd, which is seemingly easier to deal with.

**NEW:** If you find it difficult to change the two seperate parts of the x- and z- axis, the checkbox below will allow them to be synced together and you can start changing them as one. This is unchecked at default.

Lastly, the *master scale with dark blue numbers* can change their size on all of its axis, so making them proportionally big (or smaller) wouldn't be stressful.

####Coordinating their location

To change their location, the *number boxes with red numbers* can be changed left/right, up/down, and forward/backward, respectively with the traditional (x,y,z) coordinate design. Small note, the x- and z-axis are inverted, which means that negative numbers actually means forward (in this case for the plaza *[even if this program is only meant for the plaza...ayyy]*).

####**NEW** Reset all sizes and locations

On the top left of the program, there's an options tab that leads you to the *Reset All* button. This will reset all your cutrent settings back to default. It's there for you if everything is all messed up for some silly reason.

##Credits

Special thanks to all for their useful stuff; Chadderz, Amibu, Lean, Splatonka, and CosmoCortney.

If it weren't for them, I wouldn't be able to make this in the first place.
