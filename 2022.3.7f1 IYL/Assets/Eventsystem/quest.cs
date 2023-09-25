using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class quest : MonoBehaviour
{
    public GameEvent quest_completed;
    int xp_gain = 10;
    public TMP_Text quest_text_UI;
    private string quest_text;
    private int quest_id = 0;
    public static List<string> different_quests=new List<string>();


    void Start()
    {
        different_quests.Add("gkys");
        different_quests.Add("gfys");
        different_quests.Add("i hope you die");
        different_quests.Add("hello why are you gae");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            loadquest(quest_id);
            quest_id++;
            showquest();
            questcompleted();
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



    private void questcompleted()
    {
        quest_completed.Raise(this, xp_gain);
        Debug.Log("Raised");
    }
}
