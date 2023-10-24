using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Imageloader : MonoBehaviour
{
    public Sprite new_image;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.gameObject.GetComponent<SpriteRenderer>().sprite = new_image;
    }
}
