using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    [SerializeField] bool speedUpCollectible = false;
    [SerializeField] bool slowDownCollectible = false;
    [SerializeField] bool otherCollectible = false;
    public bool touchedPlayer;
    private void OnDestroy()
    {
        //Camera.main.gameObject.GetComponent<ProceduralGeneration>().SetSpeed(100);
        if (speedUpCollectible && touchedPlayer)
        {
            transform.parent.transform.parent.GetComponent<MovementManager>().SetSpeedUpFlag(true);
            touchedPlayer = false;
        }

        if (slowDownCollectible && touchedPlayer)
        {
            transform.parent.transform.parent.GetComponent<MovementManager>().SetSlowDownFlag(true);
            touchedPlayer = false;
        }

        if (otherCollectible && touchedPlayer)
        {
            transform.parent.transform.parent.GetComponent<MovementManager>().SetOtherCollected(true);
            touchedPlayer = false;
        }
    }
}
