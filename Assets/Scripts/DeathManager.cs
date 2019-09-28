using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathManager : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            //in theory should reset the game if i die

            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
