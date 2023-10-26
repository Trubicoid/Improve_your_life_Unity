using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using Unity.VisualScripting;
using System.IO;
using TMPro;

public class LevelUP : MonoBehaviour
{
    public Slider slider;
    int flowingxp = 0;
    public string xpInputField = StaticString.Xpforcompletion.ToString();
    public string lvlInputField = StaticString.LVL.ToString();
    int temp_xp = 0;
    public TMP_Text levelText;
    public TMP_Text xpText;

    //public void SetMinExp(int xp)
    //{
    //  slider.minValue = xp;
    //slider.value = xp;
    //}

    public void Start()
    {
        StaticString.different_quests = new List<string> { "fox", "Vogel", "Schmetterling", "Elefant", "Bär", "sorry no more quests" };
        StaticString.different_weekly_quests = new List<string> { "Yone", "Ezreal", "Fizz", "Soraka", "Lulu", " Sorry no more quests", " Sorry no more quests" };
        if (StaticString.startup)
        {
            LoadFromJson();
        }
        maxValstatic.slidermaxvaluE = 100 + StaticString.LVL * 10;
        slider.value = 0;
        slider.maxValue = maxValstatic.slidermaxvaluE;
        //slider.maxValue = 100;


    }
    public void Update()
    {
        
        flowingxp = StaticString.Xpforcompletion;
        slider.value = flowingxp;
        
        if (slider.value == slider.maxValue)
        {
            if (StaticString.Xpforcompletion > slider.maxValue)
            {
                StaticString.Xpforcompletion = StaticString.Xpforcompletion - (int)slider.maxValue;
            }
            else
            {
                StaticString.Xpforcompletion = 0;
            }
            maxValstatic.slidermaxvaluE = 100+StaticString.LVL*10;
            //slider.value = 0;
            StaticString.LVL += 1;
            SaveToJason();
            //StaticString.Xpforcompletion=0;
            //LevelUp();
        }

        if (temp_xp != StaticString.Xpforcompletion)
        {
            SaveToJason();
        }
        temp_xp = StaticString.Xpforcompletion;
    }
    public void SetXP(int xp)
    {
        slider.value = xp;
        slider.value += flowingxp;
    }
    public void CheckForLevelUp()
    {
        if (slider.value >= slider.maxValue)
        {
            LevelUp();
        }
    }
    public void LevelUp()
    {
        //slider.value = 0;
        slider.maxValue += 10;

    }

    public void SaveToJason()
    {
        xpInputField = StaticString.Xpforcompletion.ToString();
        lvlInputField = StaticString.LVL.ToString();
        Data_save data = new Data_save();
        data.xp = xpInputField;
        data.lvl = lvlInputField;
        //data.dq = StaticString.different_quests;
        //data.wq = StaticString.different_weekly_quests;
        data.uqd = StaticString.used_quests;
        data.uqw = StaticString.used_weekly_quests;
        data.q1 = StaticString.quest_id_daily_1;
        data.q2 = StaticString.quest_id_daily_2;
        data.q3 = StaticString.quest_id_weekly_1;
        data.q4 = StaticString.quest_id_weekly_2;
        data.q5 = StaticString.quest_id_weekly_3;
        data.q6 = StaticString.quest_id_weekly_4;
        string json = JsonUtility.ToJson(data, true);
        File.WriteAllText(Application.persistentDataPath + "/SaveDataFile.json", json);

    }

    public void LoadFromJson()
    {
        string json = File.ReadAllText(Application.persistentDataPath + "/SaveDataFile.json");
        Data_save data = JsonUtility.FromJson<Data_save>(json);

        xpInputField = data.xp;
        lvlInputField = data.lvl;
        //StaticString.different_quests = data.dq;
        //StaticString.different_weekly_quests = data.wq;
        StaticString.used_quests = data.uqd;
        StaticString.used_weekly_quests = data.uqw;
        StaticString.Xpforcompletion = int.Parse(xpInputField);
        StaticString.LVL = int.Parse(lvlInputField);
        StaticString.quest_id_daily_1 = data.q1;
        StaticString.quest_id_daily_2 = data.q2;
        StaticString.quest_id_weekly_1 = data.q3;
        StaticString.quest_id_weekly_2 = data.q4;
        StaticString.quest_id_weekly_3 = data.q5;
        StaticString.quest_id_weekly_4 = data.q6;
        //Debug.Log(StaticString.used_quests.Count);

    }
}
