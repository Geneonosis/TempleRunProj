using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedUpCollectible : MonoBehaviour
{
    private void OnDestroy()
    {
        EnumsForCollectables.TryThis();
    }


}
