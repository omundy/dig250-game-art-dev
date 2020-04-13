using UnityEngine;
using System.Collections;

public class ArrayExample : MonoBehaviour
{
    // create a new array of strings. length is inferred
    public string[] colors = new string[] { "red", "green", "blue" };

    void Start()
    {
        for (int i = 0; i < colors.Length; i++)
        {
            Debug.Log("Array " + i + " = " + colors[i]);
        }
    }
}