using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopupPause : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void OnShow(bool value)
    {
        gameObject.SetActive(value);
    }
}
