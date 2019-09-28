using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyTrack : MonoBehaviour
{
    private GameObject parent;
    private GameObject lastFemale;
    private GameObject [] startArray;
    [SerializeField] private ClockScript clock;
    int arrayEnding = 0;

    private void Start()
    {
        startArray = Camera.main.gameObject.GetComponent<ProceduralGeneration>().anchorpoints;
        //choose the last child's female anchor point
        parent = Camera.main.gameObject.GetComponent<ProceduralGeneration>()._parent;
        foreach (Transform kid in parent.transform)
        {
            if (kid.tag == "platform")
            {
                lastFemale = kid.gameObject;
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {

        Debug.Log("hi");
        //choose a random block object
        Transform pos = lastFemale.transform.GetChild(1).transform;

        if (clock.levelNumber == 1)
        {
            arrayEnding = 1;
        }if (clock.levelNumber == 2)
        {
            arrayEnding = 2;
        }if (clock.levelNumber == 3)
        {
            arrayEnding = 3;
        }if (clock.levelNumber >= 4)
        {
            arrayEnding = startArray.Length;
        }
        int randomNumber = Random.Range(0, arrayEnding);
        GameObject _newPlatform = Instantiate<GameObject>(startArray[randomNumber], pos.position, transform.rotation);
        _newPlatform.transform.SetParent(parent.transform);
        //_newPlatform = Instantiate<GameObject>(startArray[randomNumber], pos.position, transform.rotation);
        //_newPlatform.transform.SetParent(parent.transform);
        lastFemale = _newPlatform;
        Destroy(other.gameObject);
    }
}
