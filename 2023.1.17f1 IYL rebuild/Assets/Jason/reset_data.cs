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
        data.qq1 = "";
        data.qq2 = "";
        data.qq3 = "";
        data.qq4 = "";
        data.qq5 = "";
        data.qq6 = "";

        string json = JsonUtility.ToJson(data, true);
        File.WriteAllText(Application.persistentDataPath + "/SaveDataFile.json", json);
        StaticString.startup = true;
        SceneManager.LoadScene("jiaming");

    }

}
