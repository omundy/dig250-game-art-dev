

![unity logo](images/unity-logo-293w.png)

## Reference Sheet - Unity + Git


See [this presentation first](https://docs.google.com/presentation/d/1phoKp9d7BjhM0scs78rim6DtcUGoJAy4L31eDrR3zGE/edit#slide=id.g9b165dbc7b_0_0)


## Setup SmartMerge

Unity comes with its own UnityYAMLMerge tool but to use with Git requires some setup


### Mac instructions

- Assumes you have Git, Unity Hub, Unity <version> installed
- In Unity Project Settings > 
  - Editor > Asset Serialization, set Mode = "Force Text"
  - Version Control, set Mode = "Visible Meta Files"
- Windows-specific paths can be found [here](https://github.com/anacat/unity-mergetool)

```

# Download a fallback merge tool, for example diffmerge
brew cask install diffmerge

# edit .git/config file
nano .git/config

# ... and link to merge tool

[merge]
        tool = unityyamlmerge
[mergetool "unityyamlmerge"]
        trustExitCode = false
        cmd = '/Applications/Unity/Hub/Editor/2020.1.2f1/Unity.app/Contents/Tools/UnityYAMLMerge' merge -p "$BASE" "$REMOTE" "$LOCAL" "$MERGED"

```

Now, whenever you merge or rebase and a conflict appears, instead of manually fixing, open Git Shell/Bash and type the following command:
```
git mergetool
```
The tool will then resolve those conflicts for you automatically.

Then to run `git add .` in order to save the changes made, and then `git rebase --continue` when rebasing or `git merge --continue` when merging.


#### References

- Unity Manual: [SmartMerge](https://docs.unity3d.com/Manual/SmartMerge.html)
- [anacat/unity-mergetool](https://github.com/anacat/unity-mergetool)



#### Notes on other methods

- [Unity Forum thread](https://forum.unity.com/threads/smart-merge-not-working.315903/) (dead?) and [Reddit Thread](https://www.reddit.com/r/Unity3D/comments/39bdq5/how_to_solve_scene_conflicts_with_unitys_smart/)
- The [Perforce installation instructions](https://www.perforce.com/video-tutorials/vcs/installing-and-configuring-p4connect-unity) mention "P4Connect" connect on the asset store 
but it [does not exist](https://assetstore.unity.com/?q=P4Connect&orderBy=1)
- Perforce and P4V seem extra complicated to setup, with the only benefit a GUI to complete the merging. They are available on homebrew using `brew cask install p4v` and `brew cask install perforce`




### Sources
* 


