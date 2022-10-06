# Nandonalts-Snowy-Trees
Nandonalt's Snowy Trees updated to v1.0 Sourced from Tejko's a17 update on the Ludeon Forums

## Installation Instructions

### To install a non-workshop RimWorld mod from zip download:
Click on the Clone or download button.
Click Download ZIP
Extract the zip to your RimWorld install folder (by windows default it's C:\Program Files (x86)\Steam\steamapps\common\RimWorld) and open the "Mods" folder.

After that run Rimworld and "Snowy Trees" will show up in your mod list with a little folder icon next to it.
From there it should be just like any other workshop item

### To install using git:
Click on the Clone or download button.
Copy the url (https://github.com/Alias44/B18-Snowy-Trees.git)
Open your preferred console (cmd, bash, etc).
cd into the mods directory. Default is C:\Program Files (x86)\Steam\steamapps\common\RimWorld\Mods
Enter the command git clone https://github.com/Alias44/B18-Snowy-Trees.git
Note: You can get future changes by using the command get pull origin master

## Changes
v1.21.8
* 1.4 update
* Added explicit assemblies instead of version version fall backs

v1.21.7
* bugfix for new extracted (minifed) trees

v1.21.6
* Fixed 1.2 backwards compatibility
* Restructured to use default multi-versioning system
* Configured project files for simultaneous 1.2 and 1.3 builds
* Removed packaged harmony (**Harmony is now a hard dependency**)

v1.21.5
* 1.3 update
* Harmony update (v2.1.0)
* Regular berry plant disabled, pending a re-draw (core art changed)

v1.21.4
* 1.2 update
* Harmony update (v2.0.2)
* Added snow graphics for Brambles and Chokevine (both leafless and regular)

v0.21.3
* Harmony update (2.0.0.8)

v0.21.2
* Hotfix: 1.0 support fixed

v0.21.1
* 1.1 update with 1.0 backwards compatibility

v0.21.0
* v1.0 support

v0.20.1
* Fixed typo in Maple tree definition causing errors

v0.20.0
* b19 support
* Snowy definitions are now XML based- this means that Snowy Trees can now be used as a platform to snow-ify plants and trees from other mods

v0.19.2
* Fixed bug that caused plants in the leafless state but have no leafless sprite to not swap the regular sprite when snowed on.

v0.19.1
* Fixed bug that caused errors when plants added by other mods got snowed on.

v0.19.0
* Refactored the tree swap code, not that it was an issue, but by making fewer string comparisons it runs faster now.
* Added snow graphics for the leafless versions of: Birch, Cypress, Maple, Oak, Poplar, and Willow Trees.
* Added snow graphics for Agave and Willow Tree.

0.18.0t
* Removed HugsLib dependence.

## Thanks
* to [Purple Gator Ninja](https://steamcommunity.com/profiles/76561198296940599/) for creating art (Brambles, Chokevine)
* to [Nandonalt](https://ludeon.com/forums/index.php?action=profile;u=58544) for making the mod
* to [Tejko](https://ludeon.com/forums/index.php?action=profile;u=67219) for updating it to a17/Harmony
* to all the wonderful people on the Rimworld Discord
