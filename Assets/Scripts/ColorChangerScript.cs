using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChangerScript : MonoBehaviour
{
    [SerializeField] private Color color;
    private bool _changeTheColor = false;

    // Update is called once per frame
    void Update()
    {
        //if the remainder of the time across 3 seconds is 0 and the color changing flag is false then set the color changing flag to true
        //select a new color at random, and then assign that new color to the gameObject's Material

        if((int)(Time.time % 3) == 0 && _changeTheColor == false)
        {
            _changeTheColor = true;
            if (_changeTheColor)
            {
                color = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f));
                gameObject.GetComponent<MeshRenderer>().materials[0].color = color;
            }
        }

        //if the remainder of the time across 3 seconds is 1 and the color changing flag is true then reset the color changing flag to false

        if((int)(Time.time % 3) == 1 && _changeTheColor == true)
        {
            _changeTheColor = false;
        }
    }
}
