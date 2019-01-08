using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DustEffect : MonoBehaviour {

    private void OnDestroy()
    {
        Destroy(gameObject);
    }

}
