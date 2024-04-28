using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cameraScript : MonoBehaviour
{
    public float duration = 2;
    private int oldScore;
    private int check=0;
    public Text score;
    private float transPoint;
    private float H;
    // Start is called before the first frame update
    void Start()
    {
        H = RandomColor();
        oldScore = int.Parse(score.text)+10;
        Camera.main.backgroundColor = Color.HSVToRGB(H, 37f/101, 79f/101);
    }

    // Update is called once per frame
    void Update()
    {
        if (check == 1 && int.Parse(score.text) == oldScore)
        {
            H = RandomColor();
            check = 0;
            oldScore += 10;
            
        }

        if (int.Parse(score.text) % 10 == 0 && check==0)
        {
            Transition();
            
          
        }
        
        
    }
    float RandomColor() 
    {
        return ((float)(Random.Range(0, 361))) / 360;
        
    
    }
    void Transition() 
    {
        transPoint +=Time.deltaTime / duration;
        Camera.main.backgroundColor = Color.Lerp(Camera.main.backgroundColor,Color.HSVToRGB(H, 37f / 101, 79f / 101),transPoint);
        if (transPoint >= 1f) 
        {
            transPoint = 0f;
            check = 1;


        }

    }
}
