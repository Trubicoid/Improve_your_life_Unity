using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class loading : MonoBehaviour
{
    public Image uiImage;

    // Start is called before the first frame update
    void Start()
    {
        //load.SetActive(true);
        uiImage.enabled = true;
        Debug.Log(StaticString.startup);
        if (StaticString.startup)
        {
            StaticString.startup = false;
            SceneManager.LoadScene("jiaming");
        }

        if (StaticString.startup ==false)
        {
            uiImage.enabled = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
