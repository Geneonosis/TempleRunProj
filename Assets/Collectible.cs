using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    [SerializeField] bool speedUpCollectible = false;
    [SerializeField] bool slowDownCollectible = false;
    [SerializeField] bool otherCollectible = false;
    private void OnDestroy()
    {
        //Camera.main.gameObject.GetComponent<ProceduralGeneration>().SetSpeed(100);
        if (speedUpCollectible)
        {
            transform.parent.transform.parent.GetComponent<MovementManager>().SetSpeedUpFlag(true);
        }

        if (slowDownCollectible)
        {
            transform.parent.transform.parent.GetComponent<MovementManager>().SetSlowDownFlag(true);
        }

        if (otherCollectible)
        {
            transform.parent.transform.parent.GetComponent<MovementManager>().SetOtherCollected(true);
        }
    }
}
