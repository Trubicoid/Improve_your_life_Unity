using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CompletedQuest : MonoBehaviour
{
    //int po;
    //public LevelingSystem levelUpSystem;
    public void completion()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        StaticString.Xpforcompletion += 10;
    }
}
