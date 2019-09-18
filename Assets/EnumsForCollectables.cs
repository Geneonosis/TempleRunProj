using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnumsForCollectables : MonoBehaviour
{
    //MonoBehaviour instance;
    public static void TryThis()
    {
        MonoBehaviour instance;
        instance.StartCoroutine("Dothisthing");
    }

    public static IEnumerator Dothisthing()
    {
        Camera.main.GetComponent<ProceduralGeneration>().SetSpeed(5);
        yield return new WaitForSeconds(3);
    }
}
