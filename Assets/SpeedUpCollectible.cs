using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedUpCollectible : MonoBehaviour
{
    private void OnDestroy()
    {
        Camera.main.gameObject.GetComponent<ProceduralGeneration>().SetSpeed(100);
    }
}
