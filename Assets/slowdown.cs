using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slowdown : MonoBehaviour
{
    [SerializeField] private GameObject PauseMenu;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(PauseMenu.activeSelf == true)
        {
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;
        }
    }
}
