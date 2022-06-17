using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LTAUnityBase.Base.DesignPattern;
public class CreateController : MonoBehaviour
{
    public BulletController prefabBullet;

    public GameObject prefabExplosion;

    public GameObject prefabEnemy;

    public BulletController CreateBullet(Transform tranPos)
    {
        return Instantiate(prefabBullet, tranPos.position, tranPos.rotation);
    }

    public void CreateExplosion(Vector3 pos)
    {
        Instantiate(prefabExplosion, pos, Quaternion.identity);
    }

    public void CreateEnemy(Vector3 pos)
    {
        Instantiate(prefabEnemy, pos, prefabEnemy.transform.rotation);
    }

}

public class Creater : SingletonMonoBehaviour<CreateController>
{

}
