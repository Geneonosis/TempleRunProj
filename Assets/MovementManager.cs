using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementManager : MonoBehaviour
{
    private float platformSpeed = 3;
    private const float ORIGINAL_SPEED = 3;
    public bool speedUpCollected = false;
    public bool slowDownCollected = false;
    public bool otherCollected = false;
    public bool speedUpUnlock = false;
    public float speedup = ORIGINAL_SPEED;
    void FixedUpdate()
    {
        transform.localPosition += new Vector3(0, 0, -(platformSpeed * Time.deltaTime));
        PowerUpModifiers();

        if (speedUpUnlock)
        {
            Debug.Log("collected!");
            speedup += 0.1f;
            SetSpeed(speedup);

        }
        else
        {
            speedup = ORIGINAL_SPEED;
            SetSpeed(ORIGINAL_SPEED);
        }
    }


    /********* PowerUpModifiers ***************************************************
    * private void PowerUpModifiers()
    * =============================================================================
    * Purpose: 
    *   checks the flag that has been set by the type of collectible collected by 
    *   the player the boolean is selected and chosen upon the destruction of the
    *   associated game object
    *   
    *   starts the behavior associated with that collectible type.
    ******************************************************************************/
    private void PowerUpModifiers()
    {
        if (speedUpCollected)
        {
            speedUpCollected = false;
            StartCoroutine(SpeedUpForSetTime());
        }
        else if (slowDownCollected)
        {
            slowDownCollected = false;
            StartCoroutine(SlowDownForSetTime());
        }
        else if (otherCollected)
        {
            //start co-routine?

            //set the flag back to false
            otherCollected = false;
            this.platformSpeed = ORIGINAL_SPEED;
        }
    }

    private IEnumerator SpeedUpForSetTime()
    {
        //SetSpeed(10);
        speedUpUnlock = true;
        yield return new WaitForSeconds(5f);
        speedUpUnlock = false;
        this.platformSpeed = ORIGINAL_SPEED;
    }
    private IEnumerator SlowDownForSetTime()
    {
        SetSpeed(1f);
        yield return new WaitForSeconds(3f);
        this.platformSpeed = ORIGINAL_SPEED;
    }

    public void SetSpeed(float speed)
    {
        platformSpeed = speed;
    }

    public void SetSpeedUpFlag(bool speedUpFlag)
    {
        this.speedUpCollected = speedUpFlag;
    }

    public void SetSlowDownFlag(bool slowDownFlag)
    {
        this.slowDownCollected = slowDownFlag;
    }

    public void SetOtherCollected(bool otherFlag)
    {
        this.otherCollected = otherFlag;
    }
}
