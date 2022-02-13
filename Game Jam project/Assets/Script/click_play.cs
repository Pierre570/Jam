using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class click_play : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnMouseDown()
    {
        TextHandler.count = 0;
        TextHandler.i = 0;
        TextHandler.utile = 0;
        TextHandler.rich = 0;
        TextHandler.influence = 0;
        SceneManager.LoadScene("SampleScene");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
