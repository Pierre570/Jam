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
        SceneManager.LoadScene("SampleScene");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
