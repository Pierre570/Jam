using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class click_intro : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnMouseDown()
    {
        SceneManager.LoadScene("intro");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
