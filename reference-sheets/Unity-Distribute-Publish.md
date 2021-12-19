
![unity logo](../assets/img/logos/unity-logo-293w.png)

## Reference Sheet - Unity - Distribution & Publishing


Outline

1. General
1. Distributing to mobile
    1. iOS
    1. Android
1. Distributing to Mac / PC
    1. Mac App Store
    1. Itch.io
1. Other platforms




## General information

To publish and distribute your game you generally need the following for each platform on which you intend to distribute. 

I'll start with an example ...

> To publish an iOS game, you'll 1. build the project in Unity, which will compile all your code and assets and send it to 2. XCode which will further compile the project, and, 3. using your developer identity, 4. sign the files, 5. install it on your test device, and finally 6. upload the packaged game to accompany your images and text and make it available on the App Store.

In the example above we have ...

1. A build that translates your Unity game assets and code into native code for your target platform (iOS)
2. The software that packages your code and assets (XCode in the example)
3. A developer account to identify you (an Apple Developer account)
4. A token or key to code sign your project (to identify you and your software, like a notary in real life)
5. A device to test the game locally (iPad or iPhone)
6. A distribution page where you enter text and images about your game (like on the [iOS app store](https://apps.apple.com/us/app/the-speed-of-thinking/id1263001692)) 




## Distributing to mobile

Basically described in the example above. Also see information on building...

1. [iOS](Unity-Building-to-iOS.md)
1. [Android](Unity-Building-to-Android.md)







## Itch.io

After you create an Itch account and your game page...

#### Upload your game to Itch with Butler

1. [Install](https://itch.io/docs/butler/installing.html) the Itch app and login
1. Inside the Itch app, search for Butler and install
1. Mac only: Add to path: `export PATH="$PATH:$HOME/Library/Application Support/itch/apps/butler"`
1. Verify your Butler installation: `butler -V` (should print the version)
1. [Login to Butler](https://itch.io/docs/butler/login.html): `butler login`
1. [Push your game to Itch with Butler](https://itch.io/docs/butler/pushing.html)
```
# cd into directory
cd /Users/owenmundy/Documents/_code/Unity/tally-tracker-explorer/_Releases/

# some examples
butler push gamefile username/gamename:channel --userversion 1.0.0
butler push TheSpeedofThinking.zip sneakawaystudio/TheSpeedofThinking:win --userversion 1.1.0
butler push 20210105-tally-tracker-explorer-0.1.5-mac.zip sneakawaystudio/tally-tracker-explorer:mac --userversion 0.1.5
butler push 20210105-tally-tracker-explorer-0.1.5-win.zip sneakawaystudio/tally-tracker-explorer:win --userversion 0.1.5
```



