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


    public static List<string> different_quests = new List<string> {
  "Gehe alleine auf einen mind. 20-min�tigen Spaziergang.",
  "Gehe in den Wald oder einen Park und jogge 15 Minuten.",
  "Dehne dich, indem du dich beugst und deine F��e versuchst zu ber�hren.",
  "Dehne deine H�fte, indem du einen Ausfallschritt machst.",
  "Dehne dich f�r 15 Minuten.",
  "Dehne deinen ganzen K�rper.",
  "Suche dir ein ruhiges Pl�tzchen und mache 20 Minuten Yoga.",
  "Beginne eine Konversation mit einem Familienmitglied.",
  "Sage dir selbst im Spiegel mind. 5 positive Eigenschaften �ber dich, die du gerne h�ttest oder schon hast.",
  "Schreibe dir 5 positive Affirmationen auf ein St�ck Papier auf.",
  "Schreibe dir auf, wof�r du dankbar bist.",
  "Notiere dir, was dich gerade besch�ftigt oder stresst.",
  "Notiere dir 3 Dinge, f�r die du in diesem Moment dankbar bist.",
  "Nimm dir einen Block & einen Stift und notiere dir 3 Dinge, die du im vergangenen Tag gut gemacht hast.",
  "L�chle 3 Minuten lang, auch wenn dir dies wom�glich merkw�rdig erscheint.",
  "Meditiere f�r 10 Minuten.",
  "Mache eine Atem�bung.",
  "Lege dich hin und versuche nach und nach all deine Muskeln zu entspannen.",
  "Nimm dir eine Auszeit, h�re deine Lieblingsplaylist und konzentriere dich voll und ganz auf die Musik.",
  "Schalte m�glichst viele Push-Benachrichtigungen aus.",
  "Lege das Smartphone f�r 1h weg und bewege dich.",
  "Versuche etwas selbst zu bauen.",
  "Suche dir ein Rezept aus dem Internet und backe etwas Neues.",
  "Backe einen Kuchen/Muffins.",
  "Versuche, etwas Neues zu backen und anschlie�end zu dekorieren.",
  "Suche dir ein gesundes Rezept aus einem Kochbuch oder im Internet, welches du an diesem Tag zubereiten m�chtest.",
  "Kaufe dir Obst und stell dir einen Fr�chteteller als Snack zusammen.",
  "Bereite dir einen Smoothie zu. Benutze daf�r ausschlie�lich frische Zutaten.",
  "Nimm dir einen Block und Stift, schlie�e die Augen und versuche zu malen, was du dir vorstellst.",
  "Schau dir ein Zeichnungs-Tutorial auf dem Internet an und male dein Lieblingstier.",
  "Setze dich auf eine Bank oder in ein Caf� und skizziere die Landschaft.",
  "Bastle eine Sache, die dir gef�llt. Als Inspiration kann Google helfen.",
  "Erfinde eine Melodie auf einem Instrument.",
  "Du hast es Geschaft! Du hast alle Quests erledigt!"
};






    public static List<string> different_weekly_quests = new List<string> {
  "Beginne eine Konversation mit einem*r Freund*in, mit dem*der du lange nichts mehr zu tun hattest.",
  "Gehe mit jemandem, den du lange nicht mehr gesehen hast, etwa ein Nachbar, spazieren.",
  "Triff dich mit einem Freund oder Bekannten und skizziert euch gegenseitig.",
  "Gehe in eine Bibliothek und lasse dich beraten.",
  "Gehe mit jemandem einen Kaffee trinken.",
  "Gehe ins Kino mit jemandem.",
  "Unterhalte dich mit einer sympathischen, fremden Person.",
  "Nimm dir eine kurze digitale Pause von 30 Minuten und lege alle elektronischen Ger�te zur Seite.",
  "Lies ein Buch.",
  "Beginne eine neue Sprache auf einer App zu lernen.",
  "Nimm dir jeden Tag f�r eine Woche 15 Minuten Zeit, um das Jonglieren zu erlernen.",
        "Du hast es Geschaft! Du hast alle Quests erledigt!"
};
    public static List<int> used_quests = new List<int> { -1 };
    public static List<int> used_weekly_quests = new List<int> { -1 };

    public static string date;

    public static object XPforcompletion { get; internal set; }
}
