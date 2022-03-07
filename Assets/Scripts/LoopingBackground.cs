using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopingBackground : MonoBehaviour
{ //
    public float backgroundSpeed;
    public Renderer meshRendrer;
    

    // Update is called once per frame
    void Update()
    {
        meshRendrer.material.mainTextureOffset += new Vector2(backgroundSpeed * Time.deltaTime, 0);
           
    }
}
