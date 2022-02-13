using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class accept : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnMouseDown()
    {
        List<Dictionary<string, object>> list = new List<Dictionary<string, object>>();
        list = reader.ReadCsvFile();
        Debug.Log(list[TextHandler.tab[TextHandler.i]]["nom"].ToString());
        if (list[TextHandler.tab[TextHandler.i]]["fin"].ToString() == "1")
            TextHandler.influence++;
        else if (list[TextHandler.tab[TextHandler.i]]["fin"].ToString() == "2")
            TextHandler.rich++;
        else if (list[TextHandler.tab[TextHandler.i]]["fin"].ToString() == "3")
            TextHandler.utile++;
        TextHandler.i++;
        TextHandler.count++;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
