using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FakeWind : MonoBehaviour
{

    // public axis = 1;

    // void Tilt(){
    //     Vector3 euler = transform.localEulerAngles;
    //     euler.z = Mathf.Lerp(euler.z, axis, 2.0f * Time.deltaTime);
    //     transform.localEulerAngles = euler;
    // }




    public enum OccilationFuntion { Sine, Cosine }
    public void Start()
    {
        //to start at zero
        StartCoroutine(Oscillate(OccilationFuntion.Sine, 1f));
        //to start at scalar value
        //StartCoroutine (Oscillate (OccilationFuntion.Cosine, 1f));
    }

    private IEnumerator Oscillate(OccilationFuntion method, float scalar)
    {
        while (true)
        {
            if (method == OccilationFuntion.Sine)
            {
                transform.position = new Vector3(Mathf.Sin(Time.time) * scalar, 0, 0);
            }
            else if (method == OccilationFuntion.Cosine)
            {
                transform.position = new Vector3(Mathf.Cos(Time.time) * scalar, 0, 0);
            }
            yield return new WaitForEndOfFrame();
        }
    }






}
