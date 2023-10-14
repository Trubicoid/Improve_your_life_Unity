using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class firstweekly : MonoBehaviour
{
    public void completion3()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 3);
        StaticString.Xpforcompletion += 70;
    }
}
