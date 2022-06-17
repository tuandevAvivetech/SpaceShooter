using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceController : MoveController
{
    public Transform tranShoot;

    private float minX;
    private float maxX;
    private float minY;
    private float maxY;


    protected override void Move(Vector3 direction)
    {

        if (transform.position.y > maxY || transform.position.y < minY || transform.position.x > maxX || transform.position.x < minX)
        {
            transform.position = new Vector3(
                Mathf.Clamp(transform.position.x,minX,maxX),
                Mathf.Clamp(transform.position.y,minY,maxY)
                );

            return;
        }
        base.Move(direction);
    }

    protected void Shoot()
    {
       BulletController bullet = Creater.Instance.CreateBullet(tranShoot);
       bullet.tag = tag;
    }
}
