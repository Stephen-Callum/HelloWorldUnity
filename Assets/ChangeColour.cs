using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColour : MonoBehaviour
{
    Renderer rend;
    
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        
    }

    IEnumerator ColorChange()
    {
        rend.material.SetColor("_Color", UnityEngine.Random.ColorHSV());
        yield return new WaitForSeconds(1);
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(ColorChange());
    }
}
