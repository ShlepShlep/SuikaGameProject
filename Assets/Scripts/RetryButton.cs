using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RetryButton : MonoBehaviour
{
    private void OnMouseUp()
    {
        SceneManager.LoadScene("New Scene");
    }
}
