using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
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

    public GameObject cherry_Art;
    public GameObject strawberry_Art;
    public GameObject grape_Art;
    public GameObject gyool_Art;

    public List<GameObject> startingFruits = new List<GameObject>();

    public int randomNumber1;
    public int randomNumber2;
    public Transform fruitSpawnPosition;
    public Transform fruitArtSpawnPosition;

    public GameObject currentFruit;
    public GameObject nextFruit;

    public int checkIfNull;

    void Start()
    {
        startingFruits.Add(cherry);
        startingFruits.Add(strawberry);
        startingFruits.Add(grape);
        startingFruits.Add(gyool);
    }

    void Update()
    {
        // Check if any mouse button is pressed
        if (Input.GetMouseButtonUp(0))
        {
            PrintFruit();
            //ShowNext(nextFruit);
        }
    }

    public void GetRandomFruit()
    {
        randomNumber1 = Random.Range(0, 4);
        randomNumber2 = Random.Range(0, 4);
        currentFruit = startingFruits[randomNumber1];
        nextFruit = startingFruits[randomNumber2];
        
        //Instantiate(startingFruits[randomNumber], fruitSpawnPosition.position, startingFruits[randomNumber].transform.rotation);
    }

    public void OnMouseUp()
    {
        /*
        if (checkIfNull == 0)
        {
            GetRandomFruit();
            checkIfNull += 1;
        }
        Instantiate(currentFruit, fruitSpawnPosition.position, currentFruit.transform.rotation);
        currentFruit = nextFruit;
        randomNumber2 = Random.Range(0, 4);
        nextFruit = startingFruits[randomNumber2];
        */
    }

    public void PrintFruit()
    {
        if (checkIfNull == 0)
        {
            GetRandomFruit();
            checkIfNull += 1;
        }
        Instantiate(currentFruit, fruitSpawnPosition.position, currentFruit.transform.rotation);
        currentFruit = nextFruit;
        randomNumber2 = Random.Range(0, 4);
        nextFruit = startingFruits[randomNumber2];

        /*if (nextFruit = cherry)
        {
            Instantiate(cherry_Art, fruitArtSpawnPosition.position, cherry_Art.transform.rotation);
        }
        else if (nextFruit == strawberry)
        {
            Instantiate(strawberry_Art, fruitArtSpawnPosition.position, strawberry_Art.transform.rotation);
        }
        else if (nextFruit == grape)
        {
            Instantiate(grape_Art, fruitArtSpawnPosition.position, grape_Art.transform.rotation);
        }
        else if (nextFruit == gyool)
        {
            Instantiate(gyool_Art, fruitArtSpawnPosition.position, gyool_Art.transform.rotation);
        }*/
    }

    public void ShowNext(GameObject next)
    {
        if (next = cherry)
        {
            next = cherry_Art;
            Instantiate(next, fruitArtSpawnPosition.position, next.transform.rotation);
        }
        else if (next == strawberry)
        {
            next = strawberry_Art;
            Instantiate(next, fruitArtSpawnPosition.position, next.transform.rotation);
        }
        else if (next == grape)
        {
            next = grape_Art;
            Instantiate(next, fruitArtSpawnPosition.position, next.transform.rotation);
        }
        else if (next == gyool)
        {
            next = gyool_Art;
            Instantiate(next, fruitArtSpawnPosition.position, next.transform.rotation);
        }

        //Instantiate(next, fruitArtSpawnPosition.position, next.transform.rotation);


    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject otherFruit = collision.gameObject;

        if (otherFruit == cherry)
        {
            Instantiate(strawberry, otherFruit.transform.position, strawberry.transform.rotation);
            Destroy(otherFruit);
            Destroy(cherry);
        }
    }
}
