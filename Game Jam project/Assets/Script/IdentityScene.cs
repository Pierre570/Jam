using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdentityScene : MonoBehaviour
{
    public GameObject test;
    // Start is called before the first frame update
    void Start()
    {
        test.GetComponent("Text");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
