using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CodeMonkey.Utils;

public class LevelGeneratorTest : MonoBehaviour
{
    private Pathfinding pathfinding;

    public Texture2D map;

    public ColorToPrefab[] colorMappings;

    public int t;
    public int t2;

    private void Start()
    {
        GenerateLevel();
    }

    void GenerateLevel () 
    {
        pathfinding = new Pathfinding(map.width, map.height); 
        for (int x = 0; x < map.width; x++)
        {
            for (int y = 0; y < map.height; y++)
            {
                GenerateTile(x,y);
            }
        }
    }

   void GenerateTile (int x, int y)
    {
        Color pixelColor = map.GetPixel(x,y);

        if (pixelColor.a == 0)
        {
            //The pixel is transparrent. Let's ignore it!
            return;
        }


        foreach (ColorToPrefab colorMapping in colorMappings)
        {
            if (colorMapping.color.Equals(pixelColor))
            {
                Vector2 position = new Vector2(x,y);

                pathfinding.GetGrid().GetXY(position, out int t, out int t2);

                Instantiate(colorMapping.prefab, position, Quaternion.identity, transform);
                if (colorMapping.prefab.name == "Mur")
                {
                    Debug.Log("1");
                    pathfinding.GetNode(t, t2).SetValue2();
                    pathfinding.GetNode(t, t2).SetIsWalkable(!pathfinding.GetNode(t, t2).isWalkable);
                    pathfinding.GetNode(t, t2).SetIsWalkable(!pathfinding.GetNode(t, t2).isWalkable);
                }
            }
        }
    }

}