using System.Collections;
using System.Collections.Generic;
using Unity.Burst;
using UnityEngine;
using UnityEngine.Video;

public class Player : MonoBehaviour
{
    public Transform[] fruitArr;
    static public bool isSpawned = false;
    static public Vector2 playerPosX;

    public Transform fruitSpawnPositionNOTSTATIC;
    static public Transform fruitSpawnPosition;

    static public Vector2 newFruitSpawnPos;
    static public bool newFruit = false;

    static public int whichFruit = 1;

    void Start()
    {
        Vector3 mousePosition = Input.mousePosition;
        fruitSpawnPosition = fruitSpawnPositionNOTSTATIC;
        GetComponent<ParticleSystem>();
    }

    private void Update()
    {
        SpawnFruit();
        ReplaceFruit();

        fruitSpawnPosition = fruitSpawnPositionNOTSTATIC;

        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector3(mousePosition.x, transform.position.y, transform.position.z);

        if (mousePosition.x < -1.87) transform.position = new Vector3(-1.87f, transform.position.y, transform.position.z);
        if (mousePosition.x > 3) transform.position = new Vector3(3f, transform.position.y, transform.position.z);
    }

    private void SpawnFruit()
    {
        if (isSpawned == false)
        {
            StartCoroutine(Timer());

            
            isSpawned = true;
        }
    }

    void ReplaceFruit()
    {
        if(newFruit == true)
        {
            newFruit = false;
            Instantiate(fruitArr[whichFruit], newFruitSpawnPos, fruitArr[0].rotation);
        }
    }

    IEnumerator Timer()
    {
        yield return new WaitForSeconds(0.75f);
        Instantiate(fruitArr[Random.Range(0, 4)], fruitSpawnPosition.position, fruitArr[0].rotation);
    }

}
