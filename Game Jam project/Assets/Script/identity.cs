using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class identity : MonoBehaviour
{
    public SpriteRenderer introSprite;
    public Sprite identitySprite;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void OnMouseDown()
    {
        introSprite.sprite = identitySprite;
        Debug.Log("test banque");
    }
    // Update is called once per frame
    void Update()
    {
    }
}
