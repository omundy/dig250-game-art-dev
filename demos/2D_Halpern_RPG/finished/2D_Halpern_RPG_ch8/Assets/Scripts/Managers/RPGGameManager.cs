using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RPGGameManager : MonoBehaviour
{

    public static RPGGameManager sharedInstance = null;
    public RPGCameraManager cameraManager;
    public SpawnPoint playerSpawnPoint;

    void Awake()
    {
        if (sharedInstance != null && sharedInstance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            sharedInstance = this;
        }
    }

    void Start()
    {
        SetupScene();
    }

    void Update()
    {
        if (Input.GetKey("escape"))
        {
			Application.Quit();
        }
    }

    void SetupScene()
    {
        SpawnPlayer();
    }

    public void SpawnPlayer()
    {
        if (playerSpawnPoint != null)
        {
            GameObject player = playerSpawnPoint.SpawnObject();
            cameraManager.virtualCamera.Follow = player.transform;
        }
    }

}
