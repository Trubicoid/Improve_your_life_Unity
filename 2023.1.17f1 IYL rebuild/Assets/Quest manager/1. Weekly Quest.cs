using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Weekly1 : MonoBehaviour
{
    public TMP_Text quest_text_UI;
    private void Update()
    {
        if (!StaticString.T_Weekly_1)
        {
            DateTime temp = StaticString.dateCurrent_weekly_1.AddDays(7);
            TimeSpan remainingTime = temp - DateTime.Now;
            quest_text_UI.text = "Weekly 1 available in: \n" + remainingTime.Days + "days" + remainingTime.Hours + "hours" + remainingTime.Minutes + "minutes";
        }
        else
        {
            quest_text_UI.text = "Weekly 1";
        }
    }
        public void Dailyhin() 
    {
        if (StaticString.T_Weekly_1)
        {
            StaticString.Weekly_1 = true;
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 7);
            SceneManager.LoadScene("Daily_Quests");
        }
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
