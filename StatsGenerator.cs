using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public static class StatsGenerator
{
    public static void InitialStats(Stats stats)
    {
        //players and NPC stats randomized
        stats.level = 1;
        stats.luck = Random.Range(15, 30);
        stats.rhythm = Random.Range(5, 11);
        stats.style = Random.Range(4, 11); 
        // start at 0 experience points
        stats.xp = 0;
        //for you to do - set the stats
    }

    public static void AssignUnusedPoints(Stats stats, int points)
    {
        Debug.Log(stats.rhythm);
        Debug.Log(stats.style);
        Debug.Log(stats.luck);
    }
}
