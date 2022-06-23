using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Life))]
public class LifeEditor : Editor
{
    private Life life;
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        life = (Life)target;

        life.useScriptable = EditorGUILayout.Toggle("Use Scriptable?", life.useScriptable);

        if(life.useScriptable)
        {
            life.lifeScriptable = (ScriptableInteger)EditorGUILayout.ObjectField("Life", life.lifeScriptable, typeof(ScriptableInteger), true);
            life.maxLifeScriptable = (ScriptableInteger)EditorGUILayout.ObjectField("Maximum Life", life.maxLifeScriptable, typeof(ScriptableInteger), true);
        }
        else 
        {
            life.life = EditorGUILayout.IntField("Life", life.life);
            life.maxLife = EditorGUILayout.IntField("Maximum Life", life.maxLife);
        }
    }
}
