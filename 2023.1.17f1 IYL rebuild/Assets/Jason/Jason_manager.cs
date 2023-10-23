using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class Jason_manager : MonoBehaviour
{
    public InputField Ad1InputField;
    public InputField Ad2InputField;
    public InputField Aw1InputField;
    public InputField Aw2InputField;
    public InputField Aw3InputField;
    public InputField Aw4InputField;
    public InputField used_listInputField;
    //public InputField xpInputField;
    public string xpInputField = StaticString.Xpforcompletion.ToString();

    public void SaveToJason()
    {
        Data_save data = new Data_save();
        data.xp = xpInputField;

        string json = JsonUtility.ToJson(data, true);
        File.WriteAllText(Application.dataPath+"/SaveDataFile.json", json);

    }

    public void LoadFromJson()
    {
        string json = File.ReadAllText(Application.dataPath + "/SaveDataFile.json");
        Data_save data = JsonUtility.FromJson<Data_save>(json);

        xpInputField = data.xp;
    }
}
