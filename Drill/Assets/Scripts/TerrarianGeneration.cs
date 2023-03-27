using System.CodeDom.Compiler;
using System.Collections;
using UnityEngine;

public class TerrarianGeneration : MonoBehaviour
{
    //How to make a 2d game like terraira
    public int worldSize = 100;
    public float noiseFreq = 0.05f;
    public float speed;
    public Texture2D noiseTexture;

    private void Start()
    {
        GenerateNoiseTexture();
    }

    private void GenerateNoiseTexture()
    {

    }

}
