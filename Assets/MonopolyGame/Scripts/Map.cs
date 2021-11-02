using Mirror;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour
{
    public enum MapCorners
    {
        START = 0,
        VISITJAIL = 10,
        FREEPARKING = 20,
        GOTOJAIL = 30,
    }
    public List<TileHolder> map;
    public PlayerController player1;
    public PlayerController player2;
    public PlayerController player3;
    public PlayerController player4;

    public void MoveCharacter(PlayerController player, int moves)
    {
        int playerPos = player.position;
        playerPos += moves;
        if(playerPos >= map.Count)
        {
            playerPos -= map.Count;
            GivePlayerMoney(player, 1500);
        }

    
    }

    public void GivePlayerMoney(PlayerController player, int moneyToAdd)
    {
        player.money += moneyToAdd;
    }

    public void ApplyTileEffects(PlayerController player, int pos)
    {
        TileHolder tile = map[pos];
        if (tile.owner.playerName != player.playerName)
        {
            int rent = tile.tileInfo.tileRent[(int)tile.tileStatus].upgradeCost;
            player.money -= rent;
            tile.owner.money += rent;
        }
        else
        {
            // Display option to either upgrade, sell or skip property.
        }
    }
}
