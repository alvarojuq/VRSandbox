using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFood : MonoBehaviour
{

    public GameObject food;
    public Transform spawnPoint;

    public void SpawnFoodObject()
    {
        Instantiate(food, spawnPoint.position, Quaternion.identity);
    }

}
