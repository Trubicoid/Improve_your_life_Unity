using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;
using UnityEngine.SceneManagement;
using System.IO;
using UnityEngine.Networking;
using System;

public class quest : MonoBehaviour
{
    public GameEvent quest_completed;
    int xp_gain = 33;
    int xp_gain_weekly = 70;
    private int quest_type = -1;
    public TMP_Text quest_text_UI;
    private string quest_text;
    private int quest_id;
    //public static List<string> different_quests=new List<string> { "gkys", "gfys" , "i hope you die", "hello why are you gae", "sorry no more quests"};
    //public static List<string> different_weekly_quests = new List<string> { "pls go home", "Haha lol", "Chock Mock Schmock", "Suiiiiii", "hellooooooo, moooo, noooo", " Sorry no more quests" };
    //public static List<int> used_quests = new List<int> { -1};
    private List<string> different_quests = StaticString.different_quests;
    private List<string> different_weekly_quests = StaticString.different_weekly_quests;
    private List<int> used_quests = StaticString.used_quests;
    private List<int> used_weekly_quests = StaticString.used_weekly_quests;

    public InputField d1;
    public InputField d2;
    public InputField w1;
    public InputField w2;
    public InputField w3;
    public InputField w4;

    public string xpInputField = StaticString.Xpforcompletion.ToString();
    public string lvlInputField = StaticString.LVL.ToString();



    void Start()
    {
        //LoadFromJson();
        checkTime();
        if (StaticString.Daily_1)
        {
            quest_type = 1;
            if (StaticString.quest_id_daily_1 != -1)
            {
                quest_id = StaticString.quest_id_daily_1;
            }
            else
            {
                if (used_quests.Count == different_quests.Count)
                {
                    StaticString.quest_id_daily_1 = different_quests.Count;
                }
                else
                {
                    while (used_quests.Contains(StaticString.quest_id_daily_1))
                    {
                        StaticString.quest_id_daily_1 = UnityEngine.Random.Range(0, different_quests.Count - 1);
                    }
                    used_quests.Add(StaticString.quest_id_daily_1);
                }
                quest_id = StaticString.quest_id_daily_1;
            }
        }
        if (StaticString.Daily_2)
        {
            quest_type = 2;
            if (StaticString.quest_id_daily_2 != -1)
            {
                quest_id = StaticString.quest_id_daily_2;
            }
            else
            {
                if (used_quests.Count == different_quests.Count)
                {
                    StaticString.quest_id_daily_2 = different_quests.Count;
                }
                else
                {
                    while (used_quests.Contains(StaticString.quest_id_daily_2))
                    {
                        StaticString.quest_id_daily_2 = UnityEngine.Random.Range(0, different_quests.Count - 1);
                    }
                    used_quests.Add(StaticString.quest_id_daily_2);
                }
                quest_id = StaticString.quest_id_daily_2;
            }
        }
        if (StaticString.Weekly_1)
        {
            quest_type = 3;
            if (StaticString.quest_id_weekly_1 != -1)
            {
                quest_id = StaticString.quest_id_weekly_1;
            }
            else
            {
                if (used_weekly_quests.Count == different_weekly_quests.Count)
                {
                    StaticString.quest_id_weekly_1 = different_weekly_quests.Count;
                }
                else
                {
                    while (used_weekly_quests.Contains(StaticString.quest_id_weekly_1))
                    {
                        StaticString.quest_id_weekly_1 = UnityEngine.Random.Range(0, different_weekly_quests.Count - 1);
                    }
                    used_weekly_quests.Add(StaticString.quest_id_weekly_1);
                }
                quest_id = StaticString.quest_id_weekly_1;
            }
        }
        if (StaticString.Weekly_2)
        {
            quest_type = 4;
            if (StaticString.quest_id_weekly_2 != -1)
            {
                quest_id = StaticString.quest_id_weekly_2;
            }
            else
            {
                if (used_weekly_quests.Count == different_weekly_quests.Count)
                {
                    StaticString.quest_id_weekly_2 = different_weekly_quests.Count;
                }
                else
                {
                    while (used_weekly_quests.Contains(StaticString.quest_id_weekly_2))
                    {
                        StaticString.quest_id_weekly_2 = UnityEngine.Random.Range(0, different_weekly_quests.Count - 1);
                    }
                    used_weekly_quests.Add(StaticString.quest_id_weekly_2);
                }
                quest_id = StaticString.quest_id_weekly_2;
            }
        }
        if (StaticString.Weekly_3)
        {
            quest_type = 5;
            if (StaticString.quest_id_weekly_3 != -1)
            {
                quest_id = StaticString.quest_id_weekly_3;
            }
            else
            {
                if (used_weekly_quests.Count == different_weekly_quests.Count)
                {
                    StaticString.quest_id_weekly_3 = different_weekly_quests.Count;
                }
                else
                {
                    while (used_weekly_quests.Contains(StaticString.quest_id_weekly_3))
                    {
                        StaticString.quest_id_weekly_3 = UnityEngine.Random.Range(0, different_weekly_quests.Count - 1);
                    }
                    used_weekly_quests.Add(StaticString.quest_id_weekly_3);
                }
                quest_id = StaticString.quest_id_weekly_3;
            }
        }
        if (StaticString.Weekly_4)
        {
            quest_type = 6;
            if (StaticString.quest_id_weekly_4 != -1)
            {
                quest_id = StaticString.quest_id_weekly_4;
            }
            else
            {
                if (used_weekly_quests.Count == different_weekly_quests.Count)
                {
                    StaticString.quest_id_weekly_4 = different_weekly_quests.Count;
                }
                else
                {
                    while (used_weekly_quests.Contains(StaticString.quest_id_weekly_4))
                    {
                        StaticString.quest_id_weekly_4 = UnityEngine.Random.Range(0, different_weekly_quests.Count - 1);
                    }
                    used_weekly_quests.Add(StaticString.quest_id_weekly_4);
                }
                quest_id = StaticString.quest_id_weekly_4;
            }
        }
        Debug.Log(quest_id);
        if (quest_type != -1)
        {
            loadquest(quest_id);
            showquest();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (StaticString.Daily_1_completed)
        {
            StaticString.quest_id_daily_1 = -1;
            StaticString.Daily_1_completed = false;
            questcompleted();
        }
        if (StaticString.Daily_2_completed)
        {
            StaticString.quest_id_daily_2 = -1;
            StaticString.Daily_2_completed = false;
            questcompleted();
        }
        if (StaticString.Weekly_1_completed)
        {
            StaticString.quest_id_weekly_1 = -1;
            StaticString.Weekly_1_completed = false;
            questcompleted();
        }
        if (StaticString.Weekly_2_completed)
        {
            StaticString.quest_id_weekly_2 = -1;
            StaticString.Weekly_2_completed = false;
            questcompleted();
        }
        if (StaticString.Weekly_3_completed)
        {
            StaticString.quest_id_weekly_3 = -1;
            StaticString.Weekly_3_completed = false;
            questcompleted();
        }
        if (StaticString.Weekly_4_completed)
        {
            StaticString.quest_id_weekly_4 = -1;
            StaticString.Weekly_4_completed = false;
            questcompleted();
        }

    }

    private void loadquest(int quest_id)
    {
        if(quest_type <= 2)
        {
            if (different_quests.Count - 1 >= quest_id)
            {
                quest_text = different_quests[quest_id] + "\nreward:" + xp_gain + "xp";
            }
            else
            {
                quest_text = "no more quests";
            }
        }

        if(quest_type > 2)
        {
            if (different_weekly_quests.Count - 1 >= quest_id)
            {
                quest_text = different_weekly_quests[quest_id] + "\nreward:" + xp_gain_weekly + "xp";
            }
            else
            {
                quest_text = "no more quests";
            }
        }
    }
    private void checkTime()
    {
        Debug.Log(StaticString.date);
    }
    private void showquest()
    {
        quest_text_UI.text = quest_text;
    }

    public void SaveToJason()
    {
        xpInputField = StaticString.Xpforcompletion.ToString();
        lvlInputField = StaticString.LVL.ToString();
        Data_save data = new Data_save();
        data.xp = xpInputField;
        data.lvl = lvlInputField;

        string json = JsonUtility.ToJson(data, true);
        File.WriteAllText(Application.dataPath + "/SaveDataFile.json", json);

    }

    public void LoadFromJson()
    {
        string json = File.ReadAllText(Application.dataPath + "/SaveDataFile.json");
        Data_save data = JsonUtility.FromJson<Data_save>(json);

        xpInputField = data.xp;
        lvlInputField = data.lvl;
        StaticString.Xpforcompletion = int.Parse(xpInputField);
        StaticString.LVL = int.Parse(lvlInputField);
    }

    public void questcompleted()
    {

        //quest_completed.Raise(this, xp_gain);
        if (quest_type <= 2)
        {
            if (quest_id <= different_quests.Count - 1)
            {
                StaticString.Xpforcompletion += xp_gain;
                Debug.Log("Raised");
                //SaveToJason();
            }
        }

        if (quest_type > 2)
        {
            if (quest_id <= different_weekly_quests.Count - 1)
            {
                StaticString.Xpforcompletion += xp_gain_weekly;
                Debug.Log("Raised");
                //SaveToJason();
            }
        }
        SceneManager.LoadScene("jiaming");
    }


}
