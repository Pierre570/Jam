using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class reader : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    public static List<Dictionary<string, object>> ReadCsvFile()
    {
        StreamReader strReader = new StreamReader("Assets/informationCharacter.csv");
        var list = new List<Dictionary<string, object>>();
        bool endOffFile = false;
        var id = strReader.ReadLine().Split(';');
        while (!endOffFile)
        {
            var entry = new Dictionary<string, object>();
            string data_string = strReader.ReadLine();
            if(data_string == null)
            {
                endOffFile = true;
                break;
            }
            var data_values = data_string.Split(';');
            for (int i = 0; i < data_values.Length;i++)
            {
                entry[id[i]] = data_values[i];
                // Debug.Log("Value:"+id[i] + " "+ entry[id[i]].ToString());
            }
            list.Add(entry);
        }
        return (list);
    }
}