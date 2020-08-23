using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
using System.IO.Compression;
using System.Runtime.Serialization.Formatters.Binary;

public class saveload : MonoBehaviour
{
    public static string accountID = "";
    public static string accountName = "";


    public static string currentgroupId = "";

    public static void Save()
    {
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(Application.persistentDataPath + "/info.dat");
        Finance_Data data = new Finance_Data();

        data.AccountID = accountID;
        

        bf.Serialize(file, data);
        file.Close();
    }

    public static void Load()
    {

        if (File.Exists(Application.persistentDataPath + "/info.dat"))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(Application.persistentDataPath + "/info.dat", FileMode.Open);
            Finance_Data data = (Finance_Data)bf.Deserialize(file);

            accountID = data.AccountID;
            accountID = "1";
            file.Close();

        }
        else
            saveload.Save();
    }

}


[Serializable]
class Finance_Data
{
    public string AccountID;
    public string AccountName;
}


