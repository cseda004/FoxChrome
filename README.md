
# FoxChrome

I've made a simple Windows application for installing Firefox CSS Themes (userChrome.css, userContent.css, etc.). I've posted it on Reddit and quite a few people seemed to be interested so I decided to upload it to GitHub. 

## What it is capable of:
- It has its own file format (basically a renamed zip that contains all the files) that you can share with others. If you use the installer all .foxchrome files will automatically be associated with the program.
- Installing included extensions, applying prefs.js settings (All of them have toggles to turn them off or make them optional of course)
- Toggling Legacy-User-Profile-Customizations. 
- Selecting the Firefox profile to which you want to install the modifications. Opening the chrome and profile folder belonging to the selected profile is also an option.
- Creating .foxchrome files using the chrome folder of the selected profile as a sample. 
- Displaying Developer notes after installing a theme. 
- Removing installation files (Optional)
- Resetting Firefox Live Debugging Tool

## Screenshots

![App Screenshot](https://cdn.discordapp.com/attachments/702801259014389900/1213541086245421137/image.png?ex=65f5d935&is=65e36435&hm=019f3b6f272a9282ee704dbf9b7b1bf6adf75cdb56a3be0947198cbbeb800098&=&format=webp&quality=lossless)

## FoxChrome File Layout
A FoxChrome file is basically just a compressed chrome folder with an additional ".foxchrome" folder containing all the extra files (extensions, user.js, Developer Notes).

#### What the ".foxchrome" folder looks like:

| Path                  | Description                                                        |
| ----------------------| ------------------------------------------------------------------ |
| .foxchrome\note.txt   | Developer Notes                                                    |
| .foxchrome\user.js    | user.js configuration file                                         |
| .foxchrome\extensions | Folder for the extensions you want to include                      |

![File Screenshot](https://media.discordapp.net/attachments/702801259014389900/1213545399328182283/image.png?ex=65f5dd39&is=65e36839&hm=3c03b7220ae6405e398c2326f3c4f6a78c81dfeb9694e11f45325bda3ed5765a&=&format=webp&quality=lossless)

## Planned improvements in the future 
- The code is pretty junky and lacks both comments and documentation. I'm planning on doing something about this. 
- I might as well add a new Windows 11-like UI which I’ve created the controls for in one of my other projects. 
- I’ve also thought of revamping the setting applier module which, to my recollection is pretty much a mess. 
- I'm also considering adding a language pack loader. The module for this feature has already been developed for one of my other projects.

Feel free to share any feature recommendations you might have, they are the most welcome! 😀


