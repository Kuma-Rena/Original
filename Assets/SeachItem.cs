using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SeachItem : MonoBehaviour
{

    public GameObject HintObject = null;
    Text Hint_text;
    public static bool flag = false;


    void OnTriggerStay2D(Collider2D other)
    {

        this.Hint_text = HintObject.GetComponent<Text>();
        Hint_text.text = "スペースキーで調べる";


        if (Input.GetKey(KeyCode.Space))
        {
            flag = true;
            switch (transform.name)
            {

                case "bed":
                    Hint_text.text = "ふかふかのふとんだ。";
                    break;

                case "chest":
                    Hint_text.text = "棚だ。引き出しには日用品が収納されている。";
                    break;


                default:
                    Hint_text.text = "";
                    break;
            }
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        this.Hint_text = HintObject.GetComponent<Text>();
        Hint_text.text = "";
    }

}