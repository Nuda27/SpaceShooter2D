using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "New Scriptable Integer", menuName = "Scriptable Variabel/Integer")]
public class ScriptableInteger : ScriptableObject
{
    public int value;
    public int defaultValue;
    public bool resetOnEnable;

    private void OnEnable()
    {
        if(resetOnEnable)
        {
            reset();
        }
    }

    internal void reset()
    {
        value = defaultValue;
    }
}