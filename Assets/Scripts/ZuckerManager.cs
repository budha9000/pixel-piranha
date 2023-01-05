using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ZuckerManager : MonoBehaviour
{
    public int zucker;
    public Text zuckerWert;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        zuckerWert.text = zucker.ToString();
    }

    public void AddZucker()
    {
        zucker++;
    }
}
