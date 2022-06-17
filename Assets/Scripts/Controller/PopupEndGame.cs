using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LTAUnityBase.Base.DesignPattern;

public class PopupEndGame : MonoBehaviour
{
    // Start is called before the first frame update
    
    void Start()
    {
        
    }

    public void OnShow(bool value)
    {
        gameObject.SetActive(value);
    }
    
}
