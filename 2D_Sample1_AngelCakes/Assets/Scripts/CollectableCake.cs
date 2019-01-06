using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CircleCollider2D))]
[RequireComponent(typeof(AudioSource))]
public class CollectableCake : MonoBehaviour
{

    public AudioClip collectableSound;
    public int cakeValue = 1;

    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.tag == "Player")
        {
            //If so, increase the number of cakes the player has collected (see in the next chapter)
            FindObjectOfType<UI_Score>().IncreaseScore(cakeValue);

            //Play the collectable sound
            GetComponent<AudioSource>().PlayOneShot(collectableSound);

            //Hide the cake by disabling the renderer 
            GetComponent<Renderer>().enabled = false;

            //Then, destroy the cake after a delay (so the sound can finish to play) 
            GameObject.Destroy(gameObject, collectableSound.length);

            //Destory this script, in case the player hits again the cake before that is destroyed 
            Destroy(this);
        }

    }

}
