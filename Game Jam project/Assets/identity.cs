using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class identity : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void OnMouseDown()
    {
        var list = new List<Dictionary<string, object>>();
        list = reader.ReadCsvFile();
    }
    // Update is called once per frame
    void Update()
    {
    }
}
