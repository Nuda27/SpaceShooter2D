using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinUI : MonoBehaviour
{
    public Text text;
    public ScriptableInteger coinScriptable;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        getCoin();
    }

    public void getCoin()
    {
        text.text = coinScriptable.value.ToString();
    }
}
