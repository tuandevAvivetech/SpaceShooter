using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : SpaceController
{
    Vector3 direction = Vector3.zero;

    int timeCountChangeDirection = 0;

    // Update is called once per frame
    void Update()
    {
        if (Game.Instance.isAllowStartGame)
        {
            Destroy(gameObject);
        }
        if (timeCountChangeDirection == 0)
        {
            direction = new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f));
            timeCountChangeDirection = Random.Range(1, 1000);
        }
        timeCountChangeDirection--;
        Move(direction);

        if (Random.Range(1,10000)%500 == 0)
        {
            Shoot();
        }
    }

    private void OnDestroy()
    {
        Debug.Log("Enemy Destroy");
        Game.Instance.currentEnemy--;
        if (Game.Instance.currentEnemy == 0 && Game.Instance.isPlaying)
        {
            Game.Instance.NextLevel();
        }
    }
}
