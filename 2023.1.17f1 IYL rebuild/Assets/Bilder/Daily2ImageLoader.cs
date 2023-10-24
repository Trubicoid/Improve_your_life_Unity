using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Daily2ImageLoader : MonoBehaviour
{
    public Sprite new_image;
    public Sprite new_image1;
    public Sprite new_image2;
    public Sprite new_image3;
    public Sprite new_image4;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (StaticString.quest_id_daily_2 == 0)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = new_image;
        }
        if (StaticString.quest_id_daily_2 == 1)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = new_image1;
        }
        if (StaticString.quest_id_daily_2 == 2)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = new_image2;
        }
        if (StaticString.quest_id_daily_2 == 3)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = new_image3;
        }
        if (StaticString.quest_id_daily_2 == 4)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = new_image4;
        }
    }
}
