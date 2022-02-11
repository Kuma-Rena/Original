using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
 
    Rigidbody2D rigid2D;
    Animation anim;
    Animator animator;
    private float velocityX = 10f;

    // Start is called before the first frame update
    void Start()
    {
        float inputVelocityX = 0;        
        this.rigid2D = GetComponent<Rigidbody2D>();
        anim=this.gameObject.GetComponent<Animation>();
    }

    // Update is called once per frame
    void Update()
    {
        
        float inputVelocityX = 0;
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            inputVelocityX = -this.velocityX;
 
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            inputVelocityX = this.velocityX;
   
        }
        //Unityちゃんに速度を与える（変更）
        this.rigid2D.velocity = new Vector2(inputVelocityX, 0);
    }
}
