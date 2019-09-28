using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextScene : MonoBehaviour
{
    public void loadNextScene()
    {
        Debug.Log("NextScene");
        SceneManager.LoadScene("GameScene");
    }

    public void loadMainMenuScene()
    {
        SceneManager.LoadScene(0);
    }
}
