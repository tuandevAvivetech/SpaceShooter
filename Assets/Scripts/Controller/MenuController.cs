using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void LoadGame()
    {
        //Debug.Log("sceneName to load: " + scenename);
        SceneManager.LoadScene("GamePlay");
    }
}
