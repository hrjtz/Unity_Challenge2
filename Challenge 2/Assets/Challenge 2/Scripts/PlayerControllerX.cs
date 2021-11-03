using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;

    private float spawnRate = 1.5f;
    private float respawnLimit = 0.0f;

    // Update is called once per frame
    void Update()
    {
        SpawnDog();
    }

    private void SpawnDog()
    {
        if(Input.GetKeyDown(KeyCode.Space) && Time.time > respawnLimit)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);

            //Increase respawnlimit by how much time has passed and spawnrate
            respawnLimit = Time.time + spawnRate;
        }
    }
}
