using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class quest : MonoBehaviour
{
    public GameEvent quest_completed;
    int xp_gain = 10;
    public TMP_Text quest_text_UI;
    private string quest_text;
    private int quest_id = 0;
    public static List<string> different_quests=new List<string>();
    int quest_id_daily_1=-1;
    int quest_id_daily_2=-1;



    void Start()
    {
        different_quests.Add("gkys");
        different_quests.Add("gfys");
        different_quests.Add("i hope you die");
        different_quests.Add("hello why are you gae");
        Debug.Log(quest_id_daily_1);
        StaticString.Daily_1 = true;
        loadjason_lvl();
    }

    // Update is called once per frame
    void Update()
    {
        if (StaticString.Daily_1)
        {
            if (quest_id_daily_1 != -1)
            {
                quest_id = quest_id_daily_1;
            }
            else
            {
                quest_id_daily_1 = Random.Range(0, different_quests.Count);
            }
        }
        if (StaticString.Daily_1)
        {
            if (quest_id_daily_2 != -1)
            {
                quest_id = quest_id_daily_2;
            }
            else
            {
                quest_id_daily_2 = Random.Range(0, different_quests.Count);
            }
        }
        loadquest(quest_id);
        //quest_id++;
        showquest();
        //questcompleted();
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

    private void loadjason_lvl()
    {
        
    }

    public void questcompleted()
    {
        
        quest_completed.Raise(this, xp_gain);
        Debug.Log("Raised");
    }
}
