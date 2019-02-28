using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public static class BattleHandler
{
    public static void Battle(BattleEventData data)
    {
       
        float outcome = 1;

      //player and npc dance power gets calculated
        data.player.luck = Random.Range(1, 4);
        data.npc.luck = Random.Range(1, 3);
        int playerDancePower = data.player.rhythm * data.player.luck * data.player.style;
        Debug.Log("player boggie battlestats" + playerDancePower);
        int npcDancePower = data.npc.rhythm * data.npc.luck * data.npc.style;
        Debug.Log("NPC boogie battle stats " + npcDancePower);

        //decides if the npc has a critical luck chance
        if (data.player.luck == data.npc.luck && data.player.luck < data.npc.luck)
        {
            int criticalLuck;
            criticalLuck = Random.Range(1, 20);
            npcDancePower = npcDancePower * criticalLuck;
        }
        else
        {
            int criticalLuck = 1;
            npcDancePower = npcDancePower * criticalLuck;
        }
        //decides the outcome of battle
        if (playerDancePower > npcDancePower)
        {
            outcome = 1;
            Debug.Log("player wins");
        }
        else if (npcDancePower => playerDancePower)
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
