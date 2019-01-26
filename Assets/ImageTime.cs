using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageTime : MonoBehaviour {

    
    public Image tea;
    public float timer = 0;
    

    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update ()
    {
        timer = Time.time / 50;
        var tempColor = tea.color;
        tempColor.a = timer;
        tea.color = tempColor;
    }

   
}
