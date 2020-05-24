using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CodeMonkey.Utils;

public class LevelGeneratorTest : MonoBehaviour
{
    public Texture2D map;

    public ColorToPrefab[] colorMappings;
    
    private Grid grid;

    private void Start()
    {
        GenerateLevel();
    }

    void GenerateLevel () 
    {
        grid = new Grid(map.width, map.height, 1f, new Vector3(0,0));
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
                Instantiate(colorMapping.prefab, position, Quaternion.identity, transform);
                if (colorMapping.prefab.name == "56")
                {
                    grid.SetValue(position, 56);
                }
            }
        }
    }

}