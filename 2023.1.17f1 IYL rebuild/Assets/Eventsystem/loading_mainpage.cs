using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class loading_mainpage : MonoBehaviour
{
    public Image uiImage;

    // Start is called before the first frame update
    void Start()
    {
        //load.SetActive(true);
        if (StaticString.startup == false)
        {
            uiImage.enabled = false;
        }
        //uiImage.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
