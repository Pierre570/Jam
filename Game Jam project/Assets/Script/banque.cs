using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class banque : MonoBehaviour
{
    public GameObject introSprite;
    public GameObject banqueSprite;
    public GameObject tmp;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void OnMouseDown()
    {
        tmp = introSprite;
        introSprite = banqueSprite;
        banqueSprite = tmp;
        Debug.Log("test banque");
    }
    // Update is called once per frame
    void Update()
    {
    }
}
