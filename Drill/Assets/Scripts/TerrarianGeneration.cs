using System.CodeDom.Compiler;
using System.Collections;
using UnityEngine;

public class TerrarianGeneration : MonoBehaviour
{
    //YouTube: How to make a 2d game like terraira
    public Sprite tile;
    public int worldSize = 100;
    public float noiseFreq = 0.05f;
    public float seed;
    public Texture2D noiseTexture;

    private void Start()
    {
        seed = Random.Range(-1000, 1000);
        GenerateNoiseTexture();
        GenerateTerrain();
    }

    public void GenerateTerrain()
    {

        for (int x = 0; x < worldSize; x++)
        {
            for (int y = 0; y < worldSize; y++)
            {
                GameObject newTile = new GameObject();
                newTile.AddComponent<SpriteRenderer>();
                newTile.GetComponent<SpriteRenderer>().sprite = tile;
                newTile.transform.position = new Vector2(x, y);
            }
        }
    }

    public void GenerateNoiseTexture()
    {
        noiseTexture = new Texture2D(worldSize, worldSize);

        for(int x = 0; x < noiseTexture.width; x++)
        {
            for (int y = 0; y < noiseTexture.height; y++)
            {
                float v = Mathf.PerlinNoise((x + seed) * noiseFreq, (y + seed) * noiseFreq);
                noiseTexture.SetPixel(x, y, new Color(v, v, v));
            }
        }

        noiseTexture.Apply();
    }

}
