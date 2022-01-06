using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBall : MonoBehaviour
{
    public GameObject ball;
    private GameObject instance;
 
    void Start()
    {
        Spawn();
    }


    void Spawn()
    {
        var transform1 = this.transform;
        instance = Instantiate(ball, transform1.position, transform1.rotation);
    }

    public void RespawnInstance()
    {
        Destroy(instance);
        Spawn();
    }
    
}
