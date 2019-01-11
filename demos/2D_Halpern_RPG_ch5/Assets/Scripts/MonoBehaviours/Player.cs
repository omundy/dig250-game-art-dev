using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Character {

	void Start()
	{
		Debug.Log("00");
	}
	

	void OnTriggerEnter(Collider collision)
	{
		Debug.Log("11");
		if (collision.gameObject.CompareTag("CanBePickedUp")){
			Debug.Log("22");
			collision.gameObject.SetActive(false);
		}
	}

}
