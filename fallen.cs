using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class fallen : MonoBehaviour
{
    private float coin = 0;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.transform.tag == "laot")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
        }
    }
}
