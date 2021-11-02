using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "New Tile", menuName = "Create New Tile")]
public class MapTile : ScriptableObject
{
    public enum TileStatus
    {
        NOT_OWNED,
        LEVEL1,
        LEVEL2,
        LEVEL3,
    }

    public class TileCost
    {
        public TileStatus upgradeLevel;
        public int upgradeCost;
    }

    public string tileName;
    public List<TileCost> tileUpgrades;
    public List<TileCost> tileRent;
    public Vector3 tilePos;
}
