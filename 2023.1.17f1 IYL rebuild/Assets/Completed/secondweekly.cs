using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class secondweekly : MonoBehaviour
{
    // Start is called before the first frame update
    public void completion4()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 4);
        StaticString.Xpforcompletion += 70;
    }
}
