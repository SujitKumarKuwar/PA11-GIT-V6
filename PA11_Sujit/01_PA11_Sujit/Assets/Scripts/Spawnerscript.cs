using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnerscript : MonoBehaviour
{
    //public GameObject SpawnObject;
    float PositionY;
    public GameObject[] Spawnee;
    private float spawntime = 0.5f;
    private float spawndelay = 1;
    private int randomInt;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObjects", spawntime, spawndelay);
    }

    // Update is called once per frame
    void Update()
    {
       


    }

    void SpawnObjects()
    {
        randomInt=Random.Range(0,Spawnee.Length);
        PositionY = Random.Range(4, -4f);
        this.transform.position = new Vector3(transform.position.x, PositionY, transform.position.z);
        Instantiate(Spawnee[randomInt], transform.position, transform.rotation);
    }
}
