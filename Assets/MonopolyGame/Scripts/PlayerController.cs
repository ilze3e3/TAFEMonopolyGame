using Mirror;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : NetworkBehaviour
{
    public string playerName;
    public int money;
    public int position;

    private void Update()
    {
        if(isLocalPlayer){

        }
    }

    [Command]
    public void MovePlayer(int move)
    {

    }
}
