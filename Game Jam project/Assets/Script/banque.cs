using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class banque : MonoBehaviour
{
    public SpriteRenderer introSprite;
    public Sprite banqueSprite;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void OnMouseDown()
    {
        introSprite.sprite = banqueSprite;
        Debug.Log("test banque");
    }
    // Update is called once per frame
    void Update()
    {
    }
}
