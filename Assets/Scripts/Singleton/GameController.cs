using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LTAUnityBase.Base.DesignPattern;
using UnityEngine.UI;

using TMPro;
[System.Serializable]
public class Level
{
    public int numEnemy;
}

public class GameController : MonoBehaviour
{
    public Level[] levels;
    public bool isPlaying = false;
    
    //public int numEnemy = 10;

    public int currentEnemy = 0;
    public int currentScore = 0;

    public bool isAllowStartGame = true;

    public TextMeshProUGUI txtGame, txtStage,txtScore;
    [SerializeField] private PopupEndGame _popupEndGame;
    public int currentLevel = 0;

    // Update is called once per frame
    void Update()
    {
        txtScore.text = "Score : " + Game.Instance.currentScore.ToString();
        if (!isPlaying && Input.GetKeyDown(KeyCode.Return))
        {
            if (isAllowStartGame)
            {
                
                txtGame.gameObject.SetActive(false);
                isAllowStartGame = false;
                StartCoroutine(CreateEnemy());
            }
            else
            {
                ShowMenu();
            }
        }
    }

    public void NextLevel()
    {
        currentLevel++;
        if (currentLevel >= levels.Length)
        {
            ShowWin();
            return;
        }
        StartCoroutine(CreateEnemy());
    }

    public void ShowWin()
    {
        txtGame.gameObject.SetActive(true);
        isPlaying = false;
        txtGame.text = "YOU WIN \n Press Enter To Replay";
    }

    public void ShowLose()
    {
        _popupEndGame.OnShow(true);
        txtGame.gameObject.SetActive(true);
        isPlaying = false;
        txtGame.text = "YOU LOSE \n Press Enter To Replay";
    }

    public void ShowMenu()
    {
        
        txtScore.text = "Score : " + Game.Instance.currentScore.ToString();
        txtStage.gameObject.SetActive(false);
        currentLevel = 0;
        isAllowStartGame = true;
        txtGame.text = "Press Enter To Play";
        Player.Instance.transform.position = new Vector3(0, -2);
    }

    IEnumerator CreateEnemy()
    {
        txtStage.gameObject.SetActive(true);
        txtStage.text = "Stage " + (currentLevel + 1);
        int numEnemy = levels[currentLevel].numEnemy;
        for (int i = 0; i < numEnemy; i++)
        {
            yield return null;
            Creater.Instance.CreateEnemy(new Vector3(Random.Range(-5f,5f),Random.Range(0,2.5f)));
            currentEnemy++;
        }
        isPlaying = true;
    }
}

public class Game : SingletonMonoBehaviour<GameController>
{
    
}