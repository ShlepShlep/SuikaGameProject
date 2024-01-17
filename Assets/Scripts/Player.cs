using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class Player : MonoBehaviour
{
    public Transform[] fruitArr;
    static public bool isSpawned = false;
    static public Vector2 playerPosX;

    public Transform fruitSpawnPosObj;
    static public Transform fruitSpawnPosition;
    public ParticleSystem smoke;

    void Start()
    {
        Vector3 mousePosition = Input.mousePosition;
        fruitSpawnPosition = fruitSpawnPosObj;
        GetComponent<ParticleSystem>();
    }

    private void Update()
    {
        SpawnFruit();

        fruitSpawnPosition = fruitSpawnPosObj;

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

    IEnumerator Timer()
    {
        yield return new WaitForSeconds(0.75f);
        smoke.Play();
        Instantiate(fruitArr[Random.Range(0, 4)], fruitSpawnPosition.position, fruitArr[0].rotation);
    }

}
