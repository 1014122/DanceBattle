using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Static class with method (function) to determine the outcome of a dance battle based on the player and NPC that are 
///     dancing off against each other.
///     
/// TODO:
///     Battle needs to use stats and random to determine the winner of the dance off
///       - outcome value to be a float value between 1 and negative 1. 1 being the biggest possible player win over NPC, 
///         through to -1 being the most decimating defeat of the player possible.
/// </summary>
public static class BattleHandler
{
    public static void Battle(BattleEventData data)
    {
        //This needs to be replaced with some actual battle logic, at present 
        // we just award the maximum possible win to the player
        float outcome = 1;

        //your  code between here


        // use rhythm  



        // something wiht luck but more randomness
        data.player.luck = Random.Range(1, 4);
        data.npc.luck = Random.Range(1, 3);
        int PlayerBoogieBoii = data.player.rhythm * data.player.luck * data.player.style;
        Debug.Log("player boggie battlestats" + PlayerBoogieBoii);
        int NPCBoogieBoii = data.npc.rhythm * data.npc.luck * data.npc.style;
        Debug.Log("NPC boogie battle stats " + NPCBoogieBoii);

        
        if (data.player.luck == data.npc.luck && data.player.luck < data.npc.luck)
        {
            int crazyBoogie;
            crazyBoogie = Random.Range(1, 20);
            NPCBoogieBoii = NPCBoogieBoii * crazyBoogie;
        }
        else
        {

            int crazyBoogie = 1;
             NPCBoogieBoii = NPCBoogieBoii * crazyBoogie;
        }
        if (PlayerBoogieBoii > NPCBoogieBoii)
        {
            outcome = 1;
            Debug.Log("player wins");
        }
        else if (NPCBoogieBoii > PlayerBoogieBoii)
        {
            outcome = 0;
            Debug.Log("NPC wins");
        }





        // set outcome to 0 if player lost 
        //set outcome to 1 if the player won

        //and here
        var results = new BattleResultEventData(data.player, data.npc, outcome);

        GameEvents.FinishedBattle(results);
    }
}
