using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private static float platformSpeed;
    [SerializeField] private static int lives;
    [SerializeField] private static int numberOfJumps;

    static public void increaseJumpByOne()
    {
        numberOfJumps += 1;
    }

    static public void takeAwayLifeOnDeath()
    {
        lives -= 1;
    }

    static public float getPlatformSpeed()
    {
        return platformSpeed;
    }

    static public int getNumberOfLives()
    {
        return lives;
    }

    static public int getNumberOfTimesJumped()
    {
        return numberOfJumps;
    }
}
