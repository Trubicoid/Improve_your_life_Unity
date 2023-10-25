using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class quest_mainpage : MonoBehaviour
{
    public TMP_Text levelText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        Debug.Log(StaticString.quest_id_daily_1);
        Debug.Log(StaticString.quest_id_daily_2);
        Debug.Log(StaticString.quest_id_weekly_1);
        Debug.Log(StaticString.quest_id_weekly_2);
        Debug.Log(StaticString.quest_id_weekly_3);
        Debug.Log(StaticString.quest_id_weekly_4);
        if (StaticString.quest_id_daily_1 == -1)
        {
            if (StaticString.used_quests.Count == StaticString.different_quests.Count)
            {
                StaticString.quest_id_daily_1 = StaticString.different_quests.Count;
            }
            else
            {
                while (StaticString.used_quests.Contains(StaticString.quest_id_daily_1))
                {
                    StaticString.quest_id_daily_1 = UnityEngine.Random.Range(0, StaticString.different_quests.Count - 1);
                }
                StaticString.used_quests.Add(StaticString.quest_id_daily_1);
            }
        }



        if (StaticString.quest_id_daily_2 == -1)
        {
            if (StaticString.used_quests.Count == StaticString.different_quests.Count)
            {
                StaticString.quest_id_daily_2 = StaticString.different_quests.Count;
            }
            else
            {
                while (StaticString.used_quests.Contains(StaticString.quest_id_daily_2))
                {
                    StaticString.quest_id_daily_2 = UnityEngine.Random.Range(0, StaticString.different_quests.Count - 1);
                }
                StaticString.used_quests.Add(StaticString.quest_id_daily_2);
            }
        }



        if (StaticString.quest_id_weekly_1 == -1)
        {
            if (StaticString.used_weekly_quests.Count == StaticString.different_weekly_quests.Count)
            {
                StaticString.quest_id_weekly_1 = StaticString.different_weekly_quests.Count;
            }
            else
            {
                while (StaticString.used_weekly_quests.Contains(StaticString.quest_id_weekly_1))
                {
                    StaticString.quest_id_weekly_1 = UnityEngine.Random.Range(0, StaticString.different_weekly_quests.Count - 1);
                }
                StaticString.used_weekly_quests.Add(StaticString.quest_id_weekly_1);
            }
        }



        if (StaticString.quest_id_weekly_2 == -1)
        {
            if (StaticString.used_weekly_quests.Count == StaticString.different_weekly_quests.Count)
            {
                StaticString.quest_id_weekly_2 = StaticString.different_weekly_quests.Count;
            }
            else
            {
                while (StaticString.used_weekly_quests.Contains(StaticString.quest_id_weekly_2))
                {
                    StaticString.quest_id_weekly_2 = UnityEngine.Random.Range(0, StaticString.different_weekly_quests.Count - 1);
                }
                StaticString.used_weekly_quests.Add(StaticString.quest_id_weekly_2);
            }
        }



        if (StaticString.quest_id_weekly_3 == -1)
        {
            if (StaticString.used_weekly_quests.Count == StaticString.different_weekly_quests.Count)
            {
                StaticString.quest_id_weekly_3 = StaticString.different_weekly_quests.Count;
            }
            else
            {
                while (StaticString.used_weekly_quests.Contains(StaticString.quest_id_weekly_3))
                {
                    StaticString.quest_id_weekly_3 = UnityEngine.Random.Range(0, StaticString.different_weekly_quests.Count - 1);
                }
                StaticString.used_weekly_quests.Add(StaticString.quest_id_weekly_3);
            }
        }



        if (StaticString.quest_id_weekly_4 == -1)
        {
            if (StaticString.used_weekly_quests.Count == StaticString.different_weekly_quests.Count)
            {
                StaticString.quest_id_weekly_4 = StaticString.different_weekly_quests.Count;
            }
            else
            {
                while (StaticString.used_weekly_quests.Contains(StaticString.quest_id_weekly_4))
                {
                    StaticString.quest_id_weekly_4 = UnityEngine.Random.Range(0, StaticString.different_weekly_quests.Count - 1);
                }
                StaticString.used_weekly_quests.Add(StaticString.quest_id_weekly_4);

            }
        }
        levelText.text = StaticString.different_quests[StaticString.quest_id_daily_1];
    }
}
