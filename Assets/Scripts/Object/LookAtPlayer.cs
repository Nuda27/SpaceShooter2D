using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        lookAt();
    }

    private void lookAt()
    {
        if(GameManager.GetInstance().activePlayer != null)
        {
            transform.up = GameManager.GetInstance().activePlayer.transform.position - transform.position;
        }
    }
}
