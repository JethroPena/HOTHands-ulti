using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class fightingHandler : MonoBehaviour
{   
    public TextMeshProUGUI playerOneName;
    public TextMeshProUGUI playerTwoName;
    public TextMeshProUGUI playerOneHPUI;
    public TextMeshProUGUI playerTwoHPUI;

    public int playerOneHP;
    public int playerTwoHP;

    void Awake()
    {
        playerOneName.text = variableHandler.vPasser.playerName1;
        playerTwoName.text = variableHandler.vPasser.playerName2;
        playerOneHP = variableHandler.vPasser.playerHealth;
        playerTwoHP = variableHandler.vPasser.playerHealth;
    }
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        playerOneHPUI.text = playerOneHP + "";
        playerTwoHPUI.text = playerTwoHP + "";
        StartCoroutine(healthChecker());
    }

    IEnumerator healthChecker()
    {
        if (playerOneHP <= 0)
        {
            variableHandler.vPasser.winner = 2;
            yield return new WaitForSeconds(.1f);
            SceneManager.LoadScene("WinnerScene");
        }

        if (playerTwoHP <= 0)
        {
            variableHandler.vPasser.winner = 1;
            yield return new WaitForSeconds(.1f);
            SceneManager.LoadScene("WinnerScene");
        }

    }
}
