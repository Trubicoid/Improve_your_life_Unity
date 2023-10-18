using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Thirdweekly : MonoBehaviour
{
    // Start is called before the first frame update
    public void completion5()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 5);
        StaticString.Xpforcompletion += 70;
    }
}
