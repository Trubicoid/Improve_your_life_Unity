using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class quest : MonoBehaviour
{
    public GameEvent quest_completed;
    int xp_gain = 10;
    private int quest_type;
    public TMP_Text quest_text_UI;
    private string quest_text;
    private int quest_id;
    public static List<string> different_quests=new List<string> { "gkys", "gfys" , "i hope you die", "hello why are you gae", "sorry no more quests"};
    public static List<int> used_quests = new List<int> { -1};





    void Start()
    {
        loadjason_quest();

        Debug.Log(StaticString.Daily_1);
        Debug.Log(StaticString.Daily_2);
        if (StaticString.Daily_1)
        {
            Debug.LogWarning("Nr.1");
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
                        StaticString.quest_id_daily_1 = Random.Range(0, different_quests.Count - 1);
                    }
                    used_quests.Add(StaticString.quest_id_daily_1);
                }
                quest_id = StaticString.quest_id_daily_1;
            }
        }
        if (StaticString.Daily_2)
        {
            Debug.LogWarning("Nr.2");
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
                        StaticString.quest_id_daily_2 = Random.Range(0, different_quests.Count - 1);
                    }
                    used_quests.Add(StaticString.quest_id_daily_2);
                }
                quest_id = StaticString.quest_id_daily_2;
            }
        }
        Debug.Log(quest_id);
        loadquest(quest_id);
        writejason_quest_activ(quest_id, quest_type);
        writejason_quest_used(quest_id);
        showquest();
    }

    // Update is called once per frame
    void Update()
    {
        if (StaticString.Daily_1_completed)
        {
            StaticString.quest_id_daily_1 = -1;
            StaticString.Daily_1_completed = false;
        }
        if (StaticString.Daily_2_completed)
        {
            StaticString.quest_id_daily_2 = -1;
            StaticString.Daily_2_completed = false;
        }

    }

    private void loadquest(int quest_id)
    {
        if (different_quests.Count - 1 >= quest_id)
        {
            quest_text = different_quests[quest_id] + "\nreward:" + xp_gain + "xp";
        }
        else
        {
            quest_text = "no more quests";
        }
        Debug.Log(quest_id);
    }

    private void showquest()
    {
        quest_text_UI.text = quest_text;
    }

    private void loadjason_quest()
    {
        //used_quests.Clear();
        //used_quests.Add(-1);
    }
    
    private void writejason_quest_activ(int quest_id, int quest_type)
    {

    }

    private void writejason_quest_used(int quest_id)
    {

    }

    public void questcompleted()
    {
        
        quest_completed.Raise(this, xp_gain);
        Debug.Log("Raised");
    }
}
