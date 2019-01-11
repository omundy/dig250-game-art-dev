using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Character {

	void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.gameObject.CompareTag("CanBePickedUp")){
			collision.gameObject.SetActive(false);
		}
	}

}
