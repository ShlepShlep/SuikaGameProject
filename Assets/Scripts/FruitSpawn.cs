using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class FruitSpawn : MonoBehaviour
{
    public bool inCloud = true;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (inCloud)
        {
            GetComponent<Transform>().position = Player.fruitSpawnPosition.position;
        }

        if (Input.GetMouseButtonUp(0))
        {
            GetComponent<Rigidbody2D>().gravityScale = 0.5f;
            inCloud = false;
            Player.isSpawned = false;
            
        }
    }
}
