

![unity logo](../assets/img/logos/unity-logo-293w.png)

## Reference Sheet - Unity - Building to Android



### Steps

1. [Android environment setup](https://docs.unity3d.com/Manual/android-sdksetup.html)
2. Accept Android SDK license (via Terminal: `$ANDROID_HOME/tools/bin/sdkmanager --licenses`)
3. Make keys (see this [video](https://www.youtube.com/watch?v=av5ANVlkU3g))
4. Build and Run


### Terminology

Term | Definition
--- | ---
`SDK` | Software Development Kit, stored in `/Users/<username>/Library/Android/sdk`
`JDK` | Java Development Kit, stored in `/Library/Java/JavaVirtualMachines/jdk1.8.0_144.jdk/Contents/Home`
`NDK` | Native Development Kit, stored in `/Users/<username>/Library/Android/android-ndk-r10e`
[`Gradle`](https://docs.unity3d.com/Manual/android-gradle-overview.html) | Gradle is an Android build system which automates a number of build processes.


### Debugging

1. Connect the Unity Profiler ([setup instructions](https://medium.com/ironequal/android-optimization-with-unity-3504b34f00b0))
2. Run the Android Device Monitor using Terminal `/Users/owmundy/Library/Android/sdk/tools/monitor` or through the [Android SDK Tools](https://unity3d.com/learn/tutorials/topics/mobile-touch/building-your-unity-game-android-device-testing)
3. Install and use ADB [using Terminal](https://stackoverflow.com/a/28208121/441878)
    * view devices `adb devices`
    * get pid for app `adb shell ps | grep <app name>`
    * display log (filters for only Unity) `adb [logcat](https://developer.android.com/studio/command-line/logcat) -s Unity`
    * display log (other filters) `adb [logcat](https://developer.android.com/studio/command-line/logcat) -s Unity ActivityManager PackageManager DEBUG`
    * save log to file `adb [logcat](https://developer.android.com/studio/command-line/logcat) -s Unity ActivityManager PackageManager dalvikvm DEBUG > logcat.txt`



### Tips and Common Issues

* You can download Android Studio to manage SDKs, etc., however (as of Jan 2019) Unity requires >= r13e when using [IL2CPP](https://docs.unity3d.com/Manual/IL2CPP.html)
* Check that AndroidManifest files are the same version.
* Errors mentioning `arryoutfoindex` - See this [StackOverflow question](https://stackoverflow.com/a/49640161/441878)
* Errors mentioning `Package signatures do not match the previously ...` - You have switched signatures (likely by changing to/from development build) and your original build is not 100% deinstalled on the Android device. See this [StackOverflow question](https://stackoverflow.com/a/54389002/441878) for a solution.



### Sources

* [Building your Unity game to an Android device for testing](https://unity3d.com/learn/tutorials/topics/mobile-touch/building-your-unity-game-android-device-testing)
* [Player settings for the Android platform](https://docs.unity3d.com/Manual/class-PlayerSettingsAndroid.html)
