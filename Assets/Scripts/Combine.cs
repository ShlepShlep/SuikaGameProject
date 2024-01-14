using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Combine : MonoBehaviour
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

    public string otherFruit;

    public void OnCollisionEnter2D(Collision2D collision)
    {
        /*otherFruit = collision.gameObject.name;
        if (this.name.Contains("cherry") && otherFruit.Contains("cherry"))
        {
            Instantiate(strawberry, this.transform.position, strawberry.transform.rotation);
            Destroy(collision.gameObject);
            Destroy(this);
        }*/
    }
}
