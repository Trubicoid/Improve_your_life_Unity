using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Weekly4 : MonoBehaviour
{
public void Dailyhin() 
    {
        StaticString.Weekly_4 = true;
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 7);
        SceneManager.LoadScene("Daily_Quests");
    } 
    public void DailyBack() 
    {
        StaticString.Daily_1 = false;
        StaticString.Daily_2 = false;
        StaticString.Weekly_1 = false;
        StaticString.Weekly_2 = false;
        StaticString.Weekly_3 = false;
        StaticString.Weekly_4 = false;
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 7);
        StaticString.startup = false;
        SceneManager.LoadScene("jiaming");
    }
}
