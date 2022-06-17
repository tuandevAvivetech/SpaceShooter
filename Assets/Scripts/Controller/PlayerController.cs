using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LTAUnityBase.Base.DesignPattern;
public class PlayerController : SpaceController
{

    // Update is called once per frame
    void Update()
    {
        if (!Game.Instance.isPlaying) return;
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Move(new Vector3(horizontal,vertical,0));

        if(Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }
    }
}

public class Player : SingletonMonoBehaviour<PlayerController>
{

}
