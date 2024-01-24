using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Video;
using Random = UnityEngine.Random;
using UnityEngine.SceneManagement;

public class FruitSpawn : MonoBehaviour
{
    public bool inCloud = true;
    private bool timeToCheck = false;
    
    //static public int rounded;
    
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
            StartCoroutine(checkGameOver());
            
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == gameObject.tag)
        {
            #region score
            if (collision.gameObject.tag == "1")
            {
                Player.score += 1;
            }
            else if(collision.gameObject.tag == "2") 
            { 
                Player.score += 3; 
            }
            else if (collision.gameObject.tag == "3")
            {
                Player.score += 6;
            }
            else if (collision.gameObject.tag == "4")
            {
                Player.score += 10;
            }
            else if (collision.gameObject.tag == "5")
            {
                Player.score += 15;
            }
            else if (collision.gameObject.tag == "6")
            {
                Player.score += 21;
            }
            else if (collision.gameObject.tag == "7")
            {
                Player.score += 28;
            }
            else if (collision.gameObject.tag == "8")
            {
                Player.score += 36;
            }
            else if (collision.gameObject.tag == "9")
            {
                Player.score += 45;
            }
            else if (collision.gameObject.tag == "10")
            {
                Player.score += 55;
            }
            else if (collision.gameObject.tag == "11")
            {
                Player.score += 66;
            }
            #endregion
            Player.newFruitSpawnPos = transform.position;
            Player.newFruit = true;
            Player.whichFruit = int.Parse(gameObject.tag);
            /*score = score * Random.Range(1.01f, 1.05f); ;
            rounded = (int)Math.Ceiling(score);*/
            PlayerPrefs.SetInt("score", Player.score);
            Destroy(gameObject);
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.name.Contains("GameOver") && timeToCheck == true)
        {
            if(PlayerPrefs.GetInt("score")<= Player.score)
            {
                PlayerPrefs.SetInt("score", Player.score);
            }
            Debug.Log("Game over");
            SceneManager.LoadScene("EndScreen");
            
        }
    }

    IEnumerator checkGameOver()
    {
        yield return new WaitForSeconds(2f);
        timeToCheck = true;
    }

    public void Score()
    {

    }
}
