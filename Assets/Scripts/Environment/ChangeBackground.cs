using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeBackground : MonoBehaviour
{
    public GameObject[] background;
    //public EnemySpawner enemy;
    public ScriptableInteger Coin;
    void Start()
    {
        // background[0].SetActive(true);
        // background[1].SetActive(false);
        //Coin = GetComponent<ScriptableInteger>();
    }

    // Update is called once per frame
    void Update()
    {
       changebackground();
    }

    public void changebackground()
    {
        if(Coin.value < 10)
        {
            background[0].SetActive(true);
            background[1].SetActive(false);
        }
        if(Coin.value > 10 && Coin.value < 20)
        {
            background[0].SetActive(false);
            background[1].SetActive(true);
        }
        if(Coin.value > 20 && Coin.value < 30)
        {
            background[0].SetActive(true);
            background[1].SetActive(false);
        }
        if(Coin.value > 30 && Coin.value < 40)
        {
            background[0].SetActive(false);
            background[1].SetActive(true);
        }
        if(Coin.value > 40 && Coin.value < 50)
        {
            background[0].SetActive(true);
            background[1].SetActive(false);
        }
        if(Coin.value > 59 && Coin.value < 60)
        {
            background[0].SetActive(false);
            background[1].SetActive(true);
        }
    }
}
