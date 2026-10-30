

<img width="275" src="../assets/img/logos/logo-unity-b-w.png">

## Reference Sheet - AI / LLMs

Info below is about using LLMs (ChatGPT, CoPilot, Claude, etc.) to develop games with Unity (not about AI within game design for wandering scripts, enemy AI, etc). 





## Unity CLI + Claude Code Tutorial

See [Code Monkey](https://www.youtube.com/watch?v=ppFshgFOgXU) tutorial

1. Install the [Unity CLI tool](https://docs.unity.com/en-us/unity-cli/use-unity-cli) 

```bash 
curl -fsSL https://unity.com/install.sh | bash
# check version
unity --version
# update version
unity self-update
# view help
unity
```

You should see this:

```
➜  ~ unity

        @@  @@        
     @@@@@  @@@@@      ██╗   ██╗███╗   ██╗██╗████████╗██╗   ██╗
  @@@@@@      @@@@@@   ██║   ██║████╗  ██║██║╚══██╔══╝╚██╗ ██╔╝
  @@@@@@@    @@@####   ██║   ██║██╔██╗ ██║██║   ██║    ╚████╔╝ 
  @@@ @@@@@@@### ###   ██║   ██║██║╚██╗██║██║   ██║     ╚██╔╝  
  @@@    @@##    ###   ╚██████╔╝██║ ╚████║██║   ██║      ██║   
  @@     @@##     ##    ╚═════╝ ╚═╝  ╚═══╝╚═╝   ╚═╝      ╚═╝   
   @@@@@.@@#%.#####   C  L  I  v1.0.0-beta.13
      @@@@@#####      
         @@##         

  ───────────────────────────────────────────────────────
```



2. Login 

Run the below and a browser will open for you to login. When your system asks to save your details, click "Always Allow"

```bash 
unity auth login
```


3. Install the Unity Pipeline package in your project. This only installs for this project. 

```bash 
# change to the project directory
cd /FULL/PROJECT/PATH
# run installation script
unity pipeline install
# confirm installation
unity status
```



4. Connect to your agent

Open your project in VS Code and install the Claude Code or Copilot plugin. 

Basic prompts:

```text
Check code in my .cs file for errors
Add comments to this .cs files
Can you see my open Unity project?
Playtest my game and look for errors 
```

You can also have it do more advanced work. It's a good idea to ask for a plan so you know what it's about to do:

```
Create a plan to add a health system to my game
```










## Art Best Practices

- [Prompt guidelines for asset generation](https://docs.unity3d.com/Packages/com.unity.ai.assistant@2.9/manual/best-practice/prompts.html)






## Other Methods

These are other methods available

- Unity MCP Server - Published by Unity (potentially deprecated)
  - [How to make a 3D Platformer with Unity MCP and Claude Code](https://www.youtube.com/watch?v=gSFHyso_uuI)
  - [Install Unity MCP server](https://www.youtube.com/shorts/6tQFwWYyJrE)
  - Watch out for: Unity MCP often loses connection without warning. And, it can create scripts missing basic functionality (e.g. failing to wire up listeners in Inspector; creating UI buttons that are `0px` wide and so can't be seen or clicked)
- [Unity Bridge](https://github.com/cziberpv/unity-bridge) - Let AI agents see and control Unity Editor through plain files.
  - [How I gave Claude Code access to Unity Editor — file-based protocol, no MCP needed](https://www.reddit.com/r/ClaudeCode/comments/1r0fy8m/how_i_gave_claude_code_access_to_unity_editor/)
- [UniCli](https://github.com/yucchiy/UniCli) - Lets AI interact with Unity Editor directly via structured CLI commands with JSON output.
