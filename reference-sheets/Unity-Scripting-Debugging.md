

![unity logo](../assets/img/logos/unity-logo-293w.png)

## Reference Sheet - Unity C# Scripting - Debugging


### General

- Always keep the console open








### Error handling
- [Exception handling](https://forum.unity.com/threads/exception-handling-how-it-work.289511/#post-1910871)






### Editor Crashes

When the Unity Editor crashes or becomes unresponsive you will see no specific line numbers or other clues which tell you where problem lies.



### Be careful with loops!

Runaway loops will **always** cause the editor to become unresponsive. This example uses a `safety` var to prevent runaway loops

```
// example function with a logic error and "safety"
Vector3 ReturnNewFloatWithError ()
{
    float newFloat = -1; // default is -1 so loop starts
    int safety = 0; // a var to keep track of how many loops have occurred

    // loop until condition is false, if expression is always true then the loop will never stop
    while (newFloat <= 0) {
        // create new float (this is the logic error, it should be creating a positive value so the loop stops)
        newFloat = Random.Range (-1,0); // this is the logic error
        // this is the safety, which realistically should never occur, but can help you find other errors in development
        if (++safety > 10) {
            Debug.Log ("ReturnNewFloatWithError() - Safety first!");
            break;
        }
    }
    return newFloat;
}
```



### Sources
- [Unity Scripting Reference](https://docs.unity3d.com/ScriptReference/index.html)
- Chapter 8 in Halpern, Jared. Developing 2D Games with Unity. APress, 2019.
