using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingBg : MonoBehaviour
{
    public float speed;
    public Transform[] Background;
    private Vector3 direction;
    // Start is called before the first frame update
    void Start()
    {
        direction = new Vector3(0, -1, 0);
    }

    // Update is called once per frame
    void Update()
    {
        positionUpdate();
        checkPosition();
    }

    private void checkPosition()
    {
        if(Background[0].position.y <= -24f)
        {   
            moveToTop(0);
        }

        if(Background[1].position.y <= -24f)
        {   
            moveToTop(1);
        }

        if(Background[2].position.y <= -24f)
        {   
            moveToTop(2);
        }
        // if(Background[3].position.y <= -48f)
        // {   
        //     moveToTop(3);
        // }
    }

    private void moveToTop(int index)
    {

        if(index == 0)
        {
            Background[0].position = Background[0].position += new Vector3(0,36,0);
            Debug.Log("Environment 1");
        }
        else if(index == 1)
        {
            Background[1].position = Background[1].position += new Vector3(0,36,0);
            Debug.Log("Environment 2");
        }
        else if(index == 2)
        {
            Background[2].position = Background[2].position += new Vector3(0,36,0);
            Debug.Log("Environment 3");
        }
        // // else if(index == 3)
        // // {
        // //     Background[3].position = Background[3].position += new Vector3(0,48,0);
        // //     Debug.Log("Environment 4");
        // // }
    }

    private void positionUpdate()
    {
        Background[0].position += direction * Time.deltaTime * speed;
        Background[1].position += direction * Time.deltaTime * speed;
        Background[2].position += direction * Time.deltaTime * speed;
    }

}
