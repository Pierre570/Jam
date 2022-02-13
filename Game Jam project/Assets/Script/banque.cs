using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class banque : MonoBehaviour
{
    public GameObject introSprite;
    public GameObject banqueSprite;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void OnMouseDown()
    {
        introSprite = banqueSprite;
        Debug.Log("test banque");
    }
    // Update is called once per frame
    void Update()
    {
    }
}
