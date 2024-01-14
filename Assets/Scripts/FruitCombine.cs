using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitCombine : MonoBehaviour
{
    public GameObject cherry;
    public GameObject strawberry;
    public GameObject grape;
    public GameObject gyool;
    public GameObject orange;
    public GameObject apple;
    public GameObject pear;
    public GameObject peach;
    public GameObject pineapple;
    public GameObject melon;
    public GameObject watermelon;

    public bool isSpawned = false;

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(this == cherry && collision.gameObject.name.Contains("cherry") && !isSpawned)
        {
            Destroy(collision.gameObject);
            Instantiate(strawberry, this.transform.position, strawberry.transform.rotation);
            isSpawned = true;
            Destroy(this);
        }
    }
}
