using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticString : MonoBehaviour
{

    public static bool startup = true;

    public static int Xpforcompletion;
    public static int LVL;

    public static int quest_id_daily_1  = -1;
    public static int quest_id_daily_2  = -1;
    public static int quest_id_weekly_1 = -1;
    public static int quest_id_weekly_2 = -1;
    public static int quest_id_weekly_3 = -1;
    public static int quest_id_weekly_4 = -1;


    public static bool Daily_1;
    public static bool Daily_2;

    public static bool Weekly_1;
    public static bool Weekly_2;
    public static bool Weekly_3;
    public static bool Weekly_4;

    public static bool Daily_1_completed;
    public static bool Daily_2_completed;

    public static bool Weekly_1_completed;
    public static bool Weekly_2_completed;
    public static bool Weekly_3_completed;
    public static bool Weekly_4_completed;


    public static List<string> different_quests = new List<string> { "gkys", "gfys", "i hope you die", "hello why are you gae", "sorry no more quests" };
    public static List<string> different_weekly_quests = new List<string> { "pls go home", "Haha lol", "Chock Mock Schmock", "Suiiiiii", "hellooooooo, moooo, noooo", " Sorry no more quests" };
    public static List<int> used_quests = new List<int> { -1 };
    public static List<int> used_weekly_quests = new List<int> { -1 };

    public static string date;

    public static object XPforcompletion { get; internal set; }
}
