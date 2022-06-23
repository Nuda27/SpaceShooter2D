using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Moveable))]
public class MoveTowardPlayer : MonoBehaviour
{
    private Moveable moveable;

    private void Awake()
    {
        moveable = GetComponent<Moveable>();
    }
    // Start is called before the first frame update
    void Start()
    {
        moveable.setDirection(getDirection());
    }

    
    // Update is called once per frame
    void Update()
    {
        
    }

    private Vector3 getDirection()
    {
        Vector3 dir;
        dir = GameManager.GetInstance().getPlayerPosition() - transform.position;
        dir = dir.normalized;

        return dir;
    }
}
