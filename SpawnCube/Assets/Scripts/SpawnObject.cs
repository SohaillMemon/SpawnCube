using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObject : MonoBehaviour
{
    public GameObject Spawnee;
    public bool Stopspawning = false;
    public float Spawntime;
    public float SpawnDelay;

    // Start is called before the first frame update
    void Start()
    {


    }

    void spawnCube()
    {
        Instantiate(Spawnee, new Vector3(0, 17, 0), transform.rotation);


    }
    public void StopSpawning()
    {
        if (Stopspawning)
        {
            InvokeRepeating("spawnCube", Spawntime, SpawnDelay);
            Stopspawning = false;

        }
        else
        {
            CancelInvoke("spawnCube");
            Stopspawning = true;
        }

    }
}
