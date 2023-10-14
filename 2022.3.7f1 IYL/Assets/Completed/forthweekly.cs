using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class forthweekly : MonoBehaviour
{
    // Start is called before the first frame update
    public void completion6()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 6);
        StaticString.Xpforcompletion += 70;
    }
}
