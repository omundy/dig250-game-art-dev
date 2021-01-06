
![unity logo](images/unity-logo-293w.png)

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

To publish and distribute your game you generally need the following for each platform on which you intend to distribute. I'll describe the process for distributing an iOS game and then explain these steps in detail below ...

> To publish an iOS game, you'll 1. click Build in Unity. Unity will compile all your code and assets and send it to 2. XCode which will further compile the project, 3. using the developer identity, 4. sign the files, 5. install it on your test device, and finally 6. upload the packaged game to accompany your images and text and make it available on the App Store.

1. A build that translates your Unity game assets and code into native code for the platform you are targeting 
2. The software that packages your code and assets (XCode in the example)
3. A developer account to identify you (an Apple Developer account)
4. The tokens or security keys needed to code sign your project (identifies you as the developer and that software you upload is your own)
5. A device to test the game locally (iPad or iPhone)
6. Distribution page where you enter text and images about your game (like on the [iOS app store](https://apps.apple.com/us/app/the-speed-of-thinking/id1263001692)) 




## Distributing to mobile

Coming soon. For now see information on building...
1. [iOS](Unity-Building-to-iOS.md)
1. [Android](Unity-Building-to-Android.md)




## Mac App Store

Coming soon. 


## Itch.io

After you create an Itch account and your game page...

#### Upload your game to Itch with Butler

1. [Install Itch app](https://itch.io/docs/butler/installing.html) and login
1. Inside the Itch app, search for Butler and install
1. Add to path (Mac users): `export PATH="$PATH:$HOME/Library/Application Support/itch/apps/butler"`
1. Verify Butler installation: `butler -V`
1. [Login to Butler](https://itch.io/docs/butler/login.html): `butler login`
1. [Push to Itch with Butler](https://itch.io/docs/butler/pushing.html)
```
# cd into directory
cd /Users/owenmundy/Documents/_code/Unity/tally-tracker-explorer/_Releases/

# examples
butler push gamefile username/gamename:channel --userversion 1.0.0
butler push TheSpeedofThinking.zip sneakawaystudio/TheSpeedofThinking:win --userversion 1.1.0
butler push 20210105-tally-tracker-explorer-0.1.5-mac.zip sneakawaystudio/tally-tracker-explorer:mac --userversion 0.1.5
butler push 20210105-tally-tracker-explorer-0.1.5-win.zip sneakawaystudio/tally-tracker-explorer:win --userversion 0.1.5
```



