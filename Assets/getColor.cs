using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getColor : MonoBehaviour
{
    public SpriteRenderer mySprite;
    [Range(0, 1f)]
    public float rOff=0.12f, gOff=0.23f, bOff=0.13f;
    public Camera myCamera;
    private Color lastColor;
    // Start is called before the first frame update
    void Start()
    {
        myCamera = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
        mySprite.color = new Color(myCamera.backgroundColor.r+rOff, myCamera.backgroundColor.g+gOff, 
                                   myCamera.backgroundColor.b+bOff, myCamera.backgroundColor.a);
        lastColor = myCamera.backgroundColor;
    }

    // Update is called once per frame
    void Update()
    {
        if (myCamera.backgroundColor != lastColor) 
        {
            mySprite.color = new Color(myCamera.backgroundColor.r + rOff, myCamera.backgroundColor.g + gOff,
                                       myCamera.backgroundColor.b + bOff, myCamera.backgroundColor.a);

        }
    }
}
