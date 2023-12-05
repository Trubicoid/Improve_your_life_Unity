using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using Unity.VisualScripting;
using System.IO;
using TMPro;
using UnityEngine.SceneManagement;
using System;

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
        StaticString.different_quests = new List<string> {
  "Gehe alleine auf einen mind. 20-minütigen Spaziergang.",
  "Gehe in den Wald oder einen Park und jogge 15 Minuten.",
  "Dehne dich, indem du dich beugst und deine Füße versuchst zu berühren.",
  "Dehne deine Hüfte, indem du einen Ausfallschritt machst.",
  "Dehne dich für 15 Minuten.",
  "Dehne deinen ganzen Körper.",
  "Suche dir ein ruhiges Plätzchen und mache 20 Minuten Yoga.",
  "Beginne eine Konversation mit einem Familienmitglied.",
  "Sage dir selbst im Spiegel mind. 5 positive Eigenschaften über dich, die du gerne hättest oder schon hast.",
  "Schreibe dir 5 positive Affirmationen auf ein Stück Papier auf.",
  "Schreibe dir auf, wofür du dankbar bist.",
  "Notiere dir, was dich gerade beschäftigt oder stresst.",
  "Notiere dir 3 Dinge, für die du in diesem Moment dankbar bist.",
  "Nimm dir einen Block & einen Stift und notiere dir 3 Dinge, die du im vergangenen Tag gut gemacht hast.",
  "Lächle 3 Minuten lang, auch wenn dir dies womöglich merkwürdig erscheint.",
  "Meditiere für 10 Minuten.",
  "Mache eine Atemübung.",
  "Lege dich hin und versuche nach und nach all deine Muskeln zu entspannen.",
  "Nimm dir eine Auszeit, höre deine Lieblingsplaylist und konzentriere dich voll und ganz auf die Musik.",
  "Schalte möglichst viele Push-Benachrichtigungen aus.",
  "Lege das Smartphone für 1h weg und bewege dich.",
  "Versuche etwas selbst zu bauen.",
  "Suche dir ein Rezept aus dem Internet und backe etwas Neues.",
  "Backe einen Kuchen/Muffins.",
  "Versuche, etwas Neues zu backen und anschließend zu dekorieren.",
  "Suche dir ein gesundes Rezept aus einem Kochbuch oder im Internet, welches du an diesem Tag zubereiten möchtest.",
  "Kaufe dir Obst und stell dir einen Früchteteller als Snack zusammen.",
  "Bereite dir einen Smoothie zu. Benutze dafür ausschließlich frische Zutaten.",
  "Nimm dir einen Block und Stift, schließe die Augen und versuche zu malen, was du dir vorstellst.",
  "Schau dir ein Zeichnungs-Tutorial auf dem Internet an und male dein Lieblingstier.",
  "Setze dich auf eine Bank oder in ein Café und skizziere die Landschaft.",
  "Bastle eine Sache, die dir gefällt. Als Inspiration kann Google helfen.",
  "Erfinde eine Melodie auf einem Instrument.",
  "Du hast es Geschaft! Du hast alle Quests erledigt!"
};






        StaticString.different_weekly_quests = new List<string> {
  "Beginne eine Konversation mit einem*r Freund*in, mit dem*der du lange nichts mehr zu tun hattest.",
  "Gehe mit jemandem, den du lange nicht mehr gesehen hast, etwa ein Nachbar, spazieren.",
  "Triff dich mit einem Freund oder Bekannten und skizziert euch gegenseitig.",
  "Gehe in eine Bibliothek und lasse dich beraten.",
  "Gehe mit jemandem einen Kaffee trinken.",
  "Gehe ins Kino mit jemandem.",
  "Unterhalte dich mit einer sympathischen, fremden Person.",
  "Nimm dir eine kurze digitale Pause von 30 Minuten und lege alle elektronischen Geräte zur Seite.",
  "Lies ein Buch.",
  "Beginne eine neue Sprache auf einer App zu lernen.",
  "Nimm dir jeden Tag für eine Woche 15 Minuten Zeit, um das Jonglieren zu erlernen.",
  "Du hast es Geschaft! Du hast alle Quests erledigt!"
};
        if (StaticString.startup)
        {
            LoadFromJson();
        }
        if (StaticString.startup)
        {
            SceneManager.LoadScene("Daily_Quests");
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

    bool HasOneDayPassed(DateTime nowtime, DateTime last, int Days)
    {
        // Calculate the time difference between the current date and the last check date
        TimeSpan timeDifference = nowtime - last;

        // Check if at least one day has passed
        return timeDifference.TotalDays >= Days;
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
        data.qq1 = StaticString.dateCurrent_daily_1.ToString("yyyy-MM-ddTHH:mm:ss");
        data.qq2 = StaticString.dateCurrent_daily_2.ToString("yyyy-MM-ddTHH:mm:ss");
        data.qq3 = StaticString.dateCurrent_weekly_1.ToString("yyyy-MM-ddTHH:mm:ss");
        data.qq4 = StaticString.dateCurrent_weekly_2.ToString("yyyy-MM-ddTHH:mm:ss");
        data.qq5 = StaticString.dateCurrent_weekly_3.ToString("yyyy-MM-ddTHH:mm:ss");
        data.qq6 = StaticString.dateCurrent_weekly_4.ToString("yyyy-MM-ddTHH:mm:ss");
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
        StaticString.dateCurrent_daily_1 = DateTime.Parse(data.qq1);
        StaticString.dateCurrent_daily_2 = DateTime.Parse(data.qq2);
        StaticString.dateCurrent_weekly_1 = DateTime.Parse(data.qq3);
        StaticString.dateCurrent_weekly_2 = DateTime.Parse(data.qq4);
        StaticString.dateCurrent_weekly_3 = DateTime.Parse(data.qq5);
        StaticString.dateCurrent_weekly_4 = DateTime.Parse(data.qq6);
        //Debug.Log(StaticString.used_quests.Count);

    }
}
