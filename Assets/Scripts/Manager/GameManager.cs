using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;

    public GameObject playerPrefab;
    public GameObject activePlayer;
    public bool isPlaying;
    public UnityAction OnGameOverAction;
    public ScriptableInteger life;
    public ScriptableInteger coin;
    public EnemySpawner spawner;
    public ChangeBackground cb;
    public List<GameObject> items;
    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else 
        {
            Destroy(gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        //spawnPlayer();
        items = new List<GameObject>();
    }

    private void spawnPlayer()
    {
        activePlayer = Instantiate(playerPrefab);
    }

    public static GameManager GetInstance()
    {
        return instance;
    }

    public Vector3 getPlayerPosition()
    {
        if(activePlayer != null)
        {
            return activePlayer.transform.position;
        }
        return Vector3.zero;
    }

    public void startGame()
    {
        isPlaying = true;
        spawnPlayer();
    }

    public void pauseGame()
    {
        isPlaying = false;
        Time.timeScale = 0;
    }

    public void resumeGame()
    {
        isPlaying = true;
        Time.timeScale = 1;
    }

    internal void gameOver()
    {
        isPlaying = false;
        OnGameOverAction?.Invoke();

    }

    internal void retry()
    {
        life.reset();
        coin.reset();
        spawner.clearEnemy();
        ObjectPool.GetInstance().deactivateAllObject();
        clearAllItem();
    }

    internal void addItem(GameObject gameObject)
    {
        items.Add(gameObject);
    }

    public void clearAllItem()
    {
        foreach(GameObject go in items)
        {
            Destroy(go);
        }
        items.Clear();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
