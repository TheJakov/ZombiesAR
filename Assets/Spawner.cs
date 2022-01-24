using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject character;


    void Start()
    {
        InvokeRepeating("Spawn", 0, 4f);
    }

    void Spawn()
    {
        GameObject gameObject = Instantiate(character, character.transform.position, character.transform.rotation);
        gameObject.transform.Rotate(new Vector3(0, Random.Range(-90, 90), 0));
    }
}
