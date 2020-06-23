using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObject : MonoBehaviour
{
    public float maxHeight;
    public float minHeight;
    public float rateSpawn;
    private float currentRateSpawn;
    public int maxCarro;
    public List<GameObject> Carro;
    private float randPositionY;
    private float randPositionZ;


    void Update()
    {
        currentRateSpawn += Time.deltaTime;

        if(currentRateSpawn > rateSpawn)
        {
            currentRateSpawn = 0;
            Spawn();
        }
    }

    private void Spawn()
    {
        int rand = Random.Range(0, 10);

        if(rand < 5)
        {
            randPositionY = minHeight;
            randPositionZ = transform.position.z - 0.1f;
        }
        else
        {
            randPositionY = maxHeight;
            randPositionZ = transform.position.z + 0.1f;
        }

        int rnd = Random.Range(0, Carro.Count);

        GameObject tempCarro = Instantiate(Carro[rnd], new Vector3(transform.position.x, randPositionY, randPositionZ), transform.rotation);
    }
}