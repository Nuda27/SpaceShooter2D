using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    private Animator anim;
    private PoolObject poolObject;

    private void Awake()
    {
        anim = GetComponent<Animator>();
        poolObject = GetComponent<PoolObject>();
    }
    // Start is called before the first frame update
    void Start()
    {
        //anim.GetCurrentAnimatorStateInfo(0).name
    }

    // Update is called once per frame
    void Update()
    {
        if(poolObject.isActive())
        {
            if(animationIsDone())
            {
                poolObject.deactivate();
            }
        }
    }

    private bool animationIsDone()
    {
        if(anim.GetCurrentAnimatorStateInfo(0).normalizedTime > 1 && !anim.IsInTransition(0))
        {
            return true;
        }
        return false;
    }
}
