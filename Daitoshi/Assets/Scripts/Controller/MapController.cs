using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Daitoshi;

public class MapController : MonoBehaviour
{
    public GameObject mapParent;
    public Sprite grassSprite;

    private Transform _mapParentTransform;
    Map map;

    void Start()
    {
        map = new Map();

        _mapParentTransform = mapParent.transform;

        for (int x = 0; x < map.width; x++)
        {
            for (int y = 0; y < map.height; y++)
            {
                var tileGo = new GameObject();
                tileGo.name = $"Tile_{x}_{y}";
                tileGo.transform.parent = _mapParentTransform;

                var tile = map.GetTileAt(x, y);

                tileGo.transform.position = new Vector3(tile.x, 0, tile.y);
                tileGo.transform.Rotate(90, 0, 0);
                
                var tileSprite = tileGo.AddComponent<SpriteRenderer>();
                tileSprite.sprite = grassSprite;
            }
        }
    }

    void Update()
    {
        mapParent.transform.Rotate(new Vector3(0,1,0));
    }
}
