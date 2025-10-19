
<img width="275" src="../assets/img/logos/logo-unity-b-w.png">

## Reference Sheet - Unity - Publishing




## General information

Building and publishing generally involve the following ***for each platform you distribute***. For example, to publish an iOS game:

1. In Unity, **Build** the project. This exports and translates Unity game assets and code into native code for your target platform (iOS).
1. After the build is complete Unity then opens **XCode** which you use to...
1. **Check** your build and further package your code and assets.
1. This requires a **developer account** to identify you (an Apple Developer account), and a token or key to code sign your project (to identify you and your software, like a notary in real life).
1. You will also need a **test device** to install and test the game locally (iPad or iPhone).
1. Once you've created a **distribution page** where you enter text and images about your game ([example](https://apps.apple.com/us/app/the-speed-of-thinking/id1263001692))
1. You can finally **upload the packaged game** to accompany your images and text, and **submit it for approval**, which will then make it available on the App Store.

As you can see, it is not a simple task. However, if possible you should use [Unity Remote](https://docs.unity3d.com/2021.2/Documentation/Manual/UnityRemote5.html) to test your game on mobile before you do all of the work described above.





## Distributing to mobile

1. [iOS](Unity-Building-to-iOS.md)
1. [Android](Unity-Building-to-Android.md)



## Screenshots and App Store Media

- [Complete Guide to Product Page Creative Requirements: App Store Screenshots, Icon & Video](https://www.storemaven.com/academy/product-page-creative-requirements-guide/) (2022)
- [Guide to App Store Screenshots: Sizes, Styles and ASO Best Practices](https://splitmetrics.com/blog/app-store-screenshots-aso-guide/) (2021)
- [Google: Add preview assets to showcase your app](https://support.google.com/googleplay/android-developer/answer/9866151)






## Itch.io

After you create an Itch account and your game page...

#### Upload your game to Itch with Butler

> butler is the command-line helper for itch.io, used for uploading and managing game builds.

1. In Unity, **Build** the project to Mac and/or Windows
1. Install the [Itch app](https://itch.io/app) and login.
    1. Alternately, use Homebrew on macOS to install the itch.io desktop client, which includes butler `brew install --cask itch` [more on command line](https://itch.io/docs/butler/installing.html)
1. Inside the Itch app, search for Butler and install
1. (Mac) Add to path: `export PATH="$PATH:$HOME/Library/Application Support/itch/apps/butler"`
1. Verify your Butler installation: `butler -V` (should print the version)
1. [Login to Butler](https://itch.io/docs/butler/login.html): `butler login`
1. [Push your game to Itch with Butler](https://itch.io/docs/butler/pushing.html) (e.g. `butler push gamefile username/gamename:channel --userversion 1.0.0`

```bash
cd ~/Documents/_code/Unity/_Builds/SuperBirthdayWorld/Mac 
butler push SuperBirthdayWorld-v.07.app sneakawaystudio/super-birthday-world:mac --userversion 07
# On Mac, Unity buids many Windows files to a single .app 
butler push SuperBirthdayWorld-v.07.app sneakawaystudio/super-birthday-world:win --userversion 07
```

```bash
cd ~/Documents/_code/Unity/_Builds/Pillage\ Party/Pillage\ Party_MacOS/
butler push PillageParty_macOS.app sneakawaystudio/pillage-party:mac --userversion 0.1.12
butler push PillageParty_Windows.app sneakawaystudio/pillage-party:win --userversion 0.1.12
```

```bash
cd ~/Documents/_code/Unity/tally-tracker-explorer/_Releases/
butler push TheSpeedofThinking.zip sneakawaystudio/TheSpeedofThinking:win --userversion 1.1.0
```

```bash
cd ~/Documents/_code/Unity/Tally\ Tracker\ Explorer/tally-tracker-explorer/_Releases
butler push 20210105-tally-tracker-explorer-0.1.5-mac.zip sneakawaystudio/tally-tracker-explorer:mac --userversion 0.1.5
butler push 20210105-tally-tracker-explorer-0.1.5-win.zip sneakawaystudio/tally-tracker-explorer:win --userversion 0.1.5
```



#### Set up your Itch page

Add images, text, video, etc. telling others about your game. Some examples:

- https://adriaan.itch.io/hidden-folks
- https://sokpop.itch.io/simmiland
- https://afterburn.itch.io/golf-peaks
- https://arhpositive.itch.io/wave-of-democracy
