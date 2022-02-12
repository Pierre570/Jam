using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class reader : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ReadCsvFile();
    }

    void ReadCsvFile()
    {
        StreamReader strReader = new StreamReader("Assets/informationCharacter.csv");
        bool endOffFile = false;
        while (!endOffFile)
        {
            string data_string = strReader.ReadLine();
            if(data_string == null)
            {
                endOffFile = true;
                break;
            }
            var data_values = data_string.Split(',');
            for (int i = 0; i < data_values.Length;i++)
            {
                Debug.Log("Value:"+i.ToString() + " "+data_values[i].ToString());
            }
        }
    }
}
