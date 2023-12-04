using System;
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

    public static DateTime dateCurrent_daily_1 = DateTime.Now;
    public static DateTime dateCurrent_daily_2 = DateTime.Now;
    public static DateTime dateCurrent_weekly_1 = DateTime.Now;
    public static DateTime dateCurrent_weekly_2 = DateTime.Now;
    public static DateTime dateCurrent_weekly_3 = DateTime.Now;
    public static DateTime dateCurrent_weekly_4 = DateTime.Now;


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


    public static List<string> different_quests = new List<string> { "fox", "Vogel", "Schmetterling", "Elefant", "Bär", "Du hast es geschafft! Du hast alle unsere Quests gemeistert!" };
    public static List<string> different_weekly_quests = new List<string> { "Yone", "Ezreal", "Fizz", "Soraka", "Lulu", "Du hast es geschafft! Du hast alle unsere Quests gemeistert!" };
    public static List<int> used_quests = new List<int> { -1 };
    public static List<int> used_weekly_quests = new List<int> { -1 };

    public static string date;

    public static object XPforcompletion { get; internal set; }
}
