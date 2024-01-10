using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    /*public GameObject cherry;
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

    public List<GameObject> startingFruits = new List<GameObject>();

    public int randomNumber;
    public Transform fruitSpawnPosition;
    */

    public bool isEmpty;

    void Start()
    {
        /*startingFruits.Add(cherry);
        startingFruits.Add(strawberry);
        startingFruits.Add(grape);
        startingFruits.Add(gyool);
        */
        Vector3 mousePosition = Input.mousePosition;
    }

    private void Update()
    {
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector3(mousePosition.x, transform.position.y, transform.position.z);

        if (mousePosition.x < -1.87) transform.position = new Vector3(-1.87f, transform.position.y, transform.position.z);
        if (mousePosition.x > 3) transform.position = new Vector3(3f, transform.position.y, transform.position.z);
    }
    /*
    public void GetRandomFruit()
    {
        randomNumber = Random.Range(0, 4);
        Instantiate(startingFruits[randomNumber], fruitSpawnPosition);
    }

    public void OnMouseUp()
    {
        GetRandomFruit();
    }
    */

}
