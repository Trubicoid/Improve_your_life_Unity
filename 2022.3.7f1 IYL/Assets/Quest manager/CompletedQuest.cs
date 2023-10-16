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
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex -1);
        SceneManager.LoadScene("jiaming");
        StaticString.Xpforcompletion += 50;
        if (StaticString.Daily_1)
        {
            StaticString.Daily_1_completed = true;
        }
        if (StaticString.Daily_2)
        {
            StaticString.Daily_2_completed = true;
        }
        if (StaticString.Weekly_1)
        {
            StaticString.Weekly_1_completed = true;
        }
        if (StaticString.Weekly_2)
        {
            StaticString.Weekly_2_completed = true;
        }
        if (StaticString.Weekly_3)
        {
            StaticString.Weekly_3_completed = true;
        }
        if (StaticString.Weekly_4)
        {
            StaticString.Weekly_4_completed = true;
        }
    }
}
