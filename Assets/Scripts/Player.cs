using System.Collections;
using System.Collections.Generic;
using Unity.Burst;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.Video;

public class Player : MonoBehaviour
{
    public Transform[] fruitArr;
    static public Transform nextFruit;
    public Transform currentFruit;
    static public string isSpawned = "n";
    static public Vector2 playerPosX;

    public Transform fruitSpawnPositionNOTSTATIC;
    static public Transform fruitSpawnPosition;
    public Transform nextFruitSpawnPosition;

    static public Vector2 newFruitSpawnPos;
    static public bool newFruit = false;

    static public int whichFruit = 1;
    static public int score = 0;

    public TMPro.TextMeshPro scoreText;
    public TMPro.TextMeshPro bestScoreText;

    void Start()
    {
        Vector3 mousePosition = Input.mousePosition;
        fruitSpawnPosition = fruitSpawnPositionNOTSTATIC;
        bestScoreText.text = PlayerPrefs.GetInt("score").ToString();
        score = 0;
        //scoreText.text = "0";
        //currentFruit = fruitArr[Random.Range(0, 4)];
        //nextFruit = fruitArr[Random.Range(0, 4)];
    }

    private void Update()
    {
        SpawnFruit();
        ReplaceFruit();

        fruitSpawnPosition = fruitSpawnPositionNOTSTATIC;

        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector3(mousePosition.x, transform.position.y, transform.position.z);

        if (mousePosition.x < -1.2f) transform.position = new Vector3(-1.2f, transform.position.y, transform.position.z);
        if (mousePosition.x > 3.3f) transform.position = new Vector3(3.3f, transform.position.y, transform.position.z);

        if (Input.GetMouseButtonUp(0) && (isSpawned == "y"))
        {
            isSpawned = "n";

            currentFruit = nextFruit;
        }

        scoreText.text = score.ToString();
    }

    private void SpawnFruit()
    {
        if (isSpawned == "n")
        {
            
            nextFruit = fruitArr[Random.Range(0, 4)];
            StartCoroutine(Timer());
            isSpawned = "w";
            
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
        //Instantiate(nextFruit, nextFruitSpawnPosition.position, fruitArr[0].rotation);
        //nextFruit.GetComponent<Rigidbody2D>().gravityScale = 0f;
        //Destroy(nextFruit.gameObject);
        //DestroyImmediate(nextFruit.gameObject, true);
        isSpawned = "y";
    }

}
