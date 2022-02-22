using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rigid2D;
    Animation anim;
    Animator animator = null;
    private float velocityX = 1.0f;
    public SeachItem seach;


    // Start is called before the first frame update
    void Start()
    {
        float inputVelocityX = 0;
        this.rigid2D = GetComponent<Rigidbody2D>();
        anim = this.gameObject.GetComponent<Animation>();
        animator = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {

        float inputVelocityX = 0;
        
        //Player移動＆アニメーション
        //左走行（左矢印キーだけが押されているとき）
        if (Input.GetKey(KeyCode.LeftArrow) && !Input.GetKey(KeyCode.RightArrow))
        {
            inputVelocityX = -this.velocityX;
            animator.SetBool("left", true);
        }
        //右走行（右矢印キーだけが押されているとき）
        else if (Input.GetKey(KeyCode.RightArrow) && !Input.GetKey(KeyCode.LeftArrow))
        {
            inputVelocityX = this.velocityX;
            animator.SetBool("right", true);
        }
         
        else
        {
            animator.SetBool("left", false);
            animator.SetBool("right", false);
        }

        this.rigid2D.velocity = new Vector2(inputVelocityX, 0);


    }
    

}
     



