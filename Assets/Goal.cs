using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    private SpawnBall _spawnBall;
    private BoxCollider _boxCollider;
    void Start()
    {
        _spawnBall = GameObject.FindObjectOfType<SpawnBall>();
        _boxCollider = GetComponent<BoxCollider>();
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("YOU WIN !!");
        if (other.GetType() == typeof(SphereCollider))
        {
            _spawnBall.RespawnInstance();
        };
    }
}
