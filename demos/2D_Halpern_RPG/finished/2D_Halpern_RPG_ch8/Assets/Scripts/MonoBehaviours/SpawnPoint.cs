using UnityEngine;

public class SpawnPoint : MonoBehaviour {

	public GameObject prefabToSpawn;
	public float repeatInterval;
		
	void Start () {
		if(repeatInterval > 0){
			InvokeRepeating("SpawnObject", 0.0f, repeatInterval);
		}	
	}
	// generic spawn function
	public GameObject SpawnObject () {
		if(prefabToSpawn != null){
			return Instantiate(prefabToSpawn,transform.transform.position,Quaternion.identity);
		}
		return null;
	}
}
