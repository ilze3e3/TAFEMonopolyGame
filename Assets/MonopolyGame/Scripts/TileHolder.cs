using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileHolder
{
    public MapTile tileInfo;
    public MapTile.TileStatus tileStatus;
    public PlayerController owner;
    

    public TileHolder(MapTile tile)
    {
        tileStatus = MapTile.TileStatus.NOT_OWNED;
        tileInfo = tile;
        owner = null;
    }
}
