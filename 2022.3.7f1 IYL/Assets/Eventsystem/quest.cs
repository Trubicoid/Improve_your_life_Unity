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
    private int quest_id;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            loadquest(quest_id);
            showquest();
            questcompleted();
        }
    }

    private void loadquest(int quest_id)
    {
        quest_text = "gkys" + " \n reward:" + xp_gain + "xp";
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
