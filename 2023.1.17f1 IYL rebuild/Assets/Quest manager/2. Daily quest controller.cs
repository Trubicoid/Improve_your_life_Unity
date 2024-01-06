using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NeuesScipt : MonoBehaviour
{
    public TMP_Text quest_text_UI;
    private void Update()
    {
        if (quest_text_UI != null)
        {
            if (!StaticString.T_Daily_2)
            {
                DateTime temp = StaticString.dateCurrent_daily_2.AddDays(1);
                TimeSpan remainingTime = temp - DateTime.Now;
                quest_text_UI.text = "Daily available in\n" + remainingTime.Hours + " hours " + remainingTime.Minutes + " minutes";
            }
            else
            {
                quest_text_UI.text = "Daily\n" + StaticString.titel_daily[StaticString.quest_id_daily_2];
            }
        }
    }
        public void Dailyhin() 
    {
        if (StaticString.T_Daily_2)
        {
            StaticString.Daily_2 = true;
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 7);
            SceneManager.LoadScene("Daily_Quests");
        }
    } 
public void DailyBack() 
    {
        StaticString.Daily_2 = false;
        Debug.LogWarning("D2 False");
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 7);
        StaticString.startup = false;
    }
}
