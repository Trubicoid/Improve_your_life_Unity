using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weekly3Imageloader : MonoBehaviour
{
    public Sprite new_image;
    public Sprite new_image1;
    public Sprite new_image2;
    public Sprite new_image3;
    public Sprite new_image4;
    public Sprite new_image5;
    public Sprite new_image6;
    public Sprite new_image7;
    public Sprite new_image8;
    public Sprite new_image9;
    public Sprite new_image10;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (StaticString.quest_id_weekly_3 == 0)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = new_image;
        }
        if (StaticString.quest_id_weekly_3 == 1)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = new_image1;
        }
        if (StaticString.quest_id_weekly_3 == 2)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = new_image2;
        }
        if (StaticString.quest_id_weekly_3 == 3)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = new_image3;
        }
        if (StaticString.quest_id_weekly_3 == 4)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = new_image4;
        }
        if (StaticString.quest_id_weekly_3 == 5)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = new_image5;
        }
        if (StaticString.quest_id_weekly_3 == 6)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = new_image6;
        }
        if (StaticString.quest_id_weekly_3 == 7)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = new_image7;
        }
        if (StaticString.quest_id_weekly_3 == 8)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = new_image8;
        }
        if (StaticString.quest_id_weekly_3 == 9)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = new_image9;
        }
        if (StaticString.quest_id_weekly_3 == 10)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = new_image10;
        }
    }
}
