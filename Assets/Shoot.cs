using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    int layerMask;
    // Start is called before the first frame update
    void Start()
    {
        layerMask = 1 << 9;
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetButton("Fire1"))
        {
            RaycastHit hitInfo;
            
            //out - pass by reference "im gonna use this again and I will reference it"
            bool hit = Physics.Raycast(transform.position,transform.forward, out hitInfo, Mathf.Infinity, layerMask);

            //1<<10, taking a 1 and bit shifting it over 10 spaces
            if (hit && hitInfo.collider.gameObject.name.Equals("Badguy"))
            {
                //Debug.Log("HIT BAD GUY");
                //hitInfo.collider.gameObject.SetActive(false);
                hitInfo.collider.gameObject.GetComponent<MeshRenderer>().materials[0].color = Color.red;
            }

            if (hit && hitInfo.collider.gameObject.name.Equals("Wall"))
            {
                hitInfo.collider.gameObject.GetComponent<MeshRenderer>().materials[0].color = Color.green;
            }

            //debug.DrawRay(transform.position,-transform.forward,Color.red);
            //good practice to minimize raycasting

        }
        Debug.DrawRay(transform.position, transform.forward, Color.red);
    }
}
