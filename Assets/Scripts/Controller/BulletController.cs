using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MoveController
{
    int timeCount = 0;

    // Update is called once per frame
    void Update()
    {
        if (Game.Instance.isAllowStartGame)
        {
            Destroy(gameObject);
        }
        timeCount++;
        if(timeCount == 1000)
        {
            Destroy(gameObject);
            return;
        }

        RaycastHit2D hit = Physics2D.Raycast(transform.position, transform.up, 0.1f);
        if (hit.transform != null)
        {
            if (hit.transform.tag != tag)
            {
                Creater.Instance.CreateExplosion(hit.transform.position); // tạo ra vụ nổ
                if (hit.transform.tag == "Player")
                {
                    Game.Instance.ShowLose();
                    hit.transform.position = new Vector3(10000, 10000, 0);
                }
                else
                {
                    Destroy(hit.transform.gameObject);
                    Destroy(gameObject);
                }
                return;
            }
        }

        Move(transform.up);
    }
}
