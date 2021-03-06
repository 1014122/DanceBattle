﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This class is responsible for converting a battle result into xp to be awarded to the player.
/// 
/// TODO:
///     Respond to battle outcome with xp calculation based on;
///         player win 
///         how strong the win was
///         stats/levels of the dancers involved
///     Award the calculated XP to the player stats
///     Raise the player level up event if needed
/// </summary>
public class XPHandler : MonoBehaviour
{
    private void OnEnable()
    {
        GameEvents.OnBattleConclude += GainXP;
    }

    private void OnDisable()
    {
        GameEvents.OnBattleConclude -= GainXP;
    }

    public void GainXP(BattleResultEventData data)
    {
       //if statement that decides when the player levels up based on xp amount
        data.player.xp += 3;
        if (data.player.xp == 10)
        {
            GameEvents.PlayerLevelUp(data.player.level =+ 1);
            Debug.Log("Level UP");
            StatsGenerator.AssignUnusedPoints(data.player, 10);
            Debug.Log(data.player.level);
        }
        
    }
}
