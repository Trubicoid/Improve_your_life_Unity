using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class seconddaily : MonoBehaviour
{
    // Start is called before the first frame update
    public void completion2()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
        StaticString.Xpforcompletion += 50;
    }
}
