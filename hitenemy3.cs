using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class hitenemy3 : MonoBehaviour
{
    private float coin = 0;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.transform.tag == "finish state")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
