using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Store : MonoBehaviour
{

    [Header("FOR MAIN MENU ONLY")]
    public GameObject mainMenu;
    public GameObject storeMenu;
    [Space(5)]
    public Text mainCoins;
    public Text storeCoins;

    [Space(5)]
    [Header("Coins")]
    public int coins;
    public GameManager2 gm;
    public Text amountText;

    private GameObject character;

    void Start()
    {
        int currentCoins = PlayerPrefs.GetInt("_currency", 0);
        coins = currentCoins;

        character = GameObject.Find("character");
    }

    void Update()
    {
        mainCoins.text = coins.ToString();
        storeCoins.text = coins.ToString();

        if(Input.GetKeyDown(KeyCode.M))
        {
            coins += 100;
        }

        
    }

    public void UpdateCoins()
    {

        if(gm.score >= 100000)
        {
            coins += 5;
        }
        else if(gm.score >= 200000)
        {
            coins += 5;
        }
        else if (gm.score >= 300000)
        {
            coins += 5;
        }
        else if(gm.score <= 0)
        {
            coins = 0;
        }

        PlayerPrefs.SetInt("_currency", coins);
        amountText.text = "+" + coins;
       
    }

    
    public void AddCoins()
    {
        coins += 500;
        PlayerPrefs.SetInt("_currency", coins);
    }

    
    public void CloseStoreMenu()
    {
        storeMenu.SetActive(false);
        mainMenu.SetActive(true);
        character.SetActive(true);
    }


}
