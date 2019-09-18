using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyTrack : MonoBehaviour
{
    [SerializeField] private GameObject trackBlock;
    [SerializeField] private GameObject prefabbedTrackBlock;
    private void OnTriggerEnter(Collider other)
    {
        //choose a random block object
        trackBlock = other.gameObject;
        Instantiate<GameObject>(prefabbedTrackBlock, new Vector3(0, 0, 58), transform.rotation);
        Destroy(trackBlock);
    }
}
