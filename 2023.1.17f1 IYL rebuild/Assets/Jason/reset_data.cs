using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using UnityEngine.SceneManagement;
using NUnit.Framework.Constraints;

public class reset_data : MonoBehaviour
{


public void reset_saved_data()
    {
        SaveToJason();
        Debug.LogWarning("reset of data");
    }
public void SaveToJason()
    {
        Data_save data = new Data_save();
        data.xp = "0";
        data.lvl = "0";
        data.uqd = new List<int> { -1 };
        data.uqw = new List<int> { -1 };
        data.q1 = -1;
        data.q2 = -1;
        data.q3 = -1;
        data.q4 = -1;
        data.q5 = -1;
        data.q6 = -1;
        data.qq1 = StaticString.dateCurrent_daily_1.AddDays(-7).ToString("yyyy-MM-ddTHH:mm:ss");
        data.qq2 = StaticString.dateCurrent_daily_2.AddDays(-7).ToString("yyyy-MM-ddTHH:mm:ss"); ;
        data.qq3 = StaticString.dateCurrent_weekly_1.AddDays(-7).ToString("yyyy-MM-ddTHH:mm:ss"); ;
        data.qq4 = StaticString.dateCurrent_weekly_2.AddDays(-7).ToString("yyyy-MM-ddTHH:mm:ss"); ;
        data.qq5 = StaticString.dateCurrent_weekly_3.AddDays(-7).ToString("yyyy-MM-ddTHH:mm:ss"); ;
        data.qq6 = StaticString.dateCurrent_weekly_4.AddDays(-7).ToString("yyyy-MM-ddTHH:mm:ss"); ;

        string json = JsonUtility.ToJson(data, true);
        File.WriteAllText(Application.persistentDataPath + "/SaveDataFile.json", json);
        StaticString.startup = true;
        SceneManager.LoadScene("jiaming");

    }

}
