using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class FruitSpawn : MonoBehaviour
{
    public bool inCloud = true;
    void Start()
    {
        if(transform.position.y < 2.7)
        {
            inCloud = false;
            GetComponent<Rigidbody2D>().gravityScale = 0.5f;
        }
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

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == gameObject.tag)
        {
            Player.newFruitSpawnPos = transform.position;
            Player.newFruit = true;
            Player.whichFruit = int.Parse(gameObject.tag);
            Destroy(gameObject);
        }
    }
}
