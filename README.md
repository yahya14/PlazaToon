# PlazaToon for Splatoon 2.12.0

<p align="center">
  <img src="http://i.imgur.com/MO3ZQ13.png" alt="PlazaToon Image"/>
</p>

[Downloads](https://github.com/yahya14/PlazaToon/releases/latest) | [Splatoon Modding Hub](http://gbatemp.net/threads/splatoon-modding-hub.425670/)

**Important note: This tool is still in beta. Many of the bugs still needs to be squashed and still needs some sort of crash prevention.**

PlazaToon is a tool that lets you freely change the size and locations of different NPCs in the plaza with much more ease and freedom. This can also be done by modifying the byamls in the splatoon game files, but to make things easier, this tool modifies them in ram via TCPGecko connection.

##What you need to know about the Recalculate button

So lets talk about moving addresses for a bit. In this situation, the NPC's addresses move everytime a loading screen appears. So once you are connected, keep in mind you'll need to click the *Recalculate* button *after* every loading screen. (but sometimes they don't move anymore, but better be safe to *prevent crashes*.)

##Usage

###Requirements

+ Windows Vista or higher (Mac and Linux users, use Wine)
+ [.NET Framework 4.5.2](http://go.microsoft.com/fwlink/?LinkId=328843)
+ Splatoon with version 2.12.0
+ TCPGecko (Only supports loadiine.ovh at the moment)

###How to use it

**Note:** Some of the features still needs re-design to make it easier to use for everyone.

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

####Scaling their size

To change their size, the *number boxes with light blue numbers*, respectively labeled with the correct axis, can be changed with the up and down buttons, by typing, or even with arrow keys. To understand how they work from the following:

- The x-axis can strech or compress their models left/right
- The y-axis can strech or compress their moddels up/down
- The z-axis can strech or compress their moddels forward/backward

Small note that the box with labels like *X* and *X 2* are basically the axis in two parts, because Nintendo designed it that way in ram. Oddly, Some of their NPCs still use the regular (x,y,z) scales, like you see with judd, which is seemingly easier to deal with.

Lastly, the *master scale with dark blue numbers* can change their size on all of its axis, so making them proportionally big (or smaller) wouldn't be stressful.

####Coordinating their location

To change their location, the *number boxes with red numbers* can be changed left/right, up/down, and forward/backward, respectively with the traditional (x,y,z) coordinate design. Small note, the x- and z-axis are inverted, which means that negative numbers actually means forward (in this case for the plaza *[even if this program is only meant for the plaza...ayyy]*).

##What to expect

This is only an early release of the tool, so expect more things to come in the near future such as more NPCs and the awaited gekiine support. In the meantime, stay tuned and have fun!
