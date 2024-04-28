using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public SpriteRenderer mySprite;
    public Sprite dead;
    public float jumpStrength;
    public LogicScript logic;
    public bool isDead = false;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space) && isDead==false) 
        {
            myRigidbody.AddForce(Vector2.up * jumpStrength, ForceMode2D.Impulse);

        }
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        isDead = true;
        //myRigidbody.constraints = RigidbodyConstraints2D.FreezeAll;
        mySprite.sprite = dead;
        Time.timeScale = 0;
    }
}
