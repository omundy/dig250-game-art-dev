using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float xR, yR, zR;

    void Start()
    {
        xR = Random.Range(-10.0f, 10.0f);
        yR = Random.Range(-10.0f, 10.0f);
        zR = Random.Range(-10.0f, 10.0f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Time.deltaTime * xR, Time.deltaTime * yR, Time.deltaTime * zR);
    }
}
