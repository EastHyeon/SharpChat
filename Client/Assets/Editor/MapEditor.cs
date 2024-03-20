using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#if UNITY_EDITOR
using UnityEditor;
#endif
public class MapEditor
{
#if UNITY_EDITOR

    // %(Ctrl) #(Shift) &(Alt)
    [MenuItem("Tools/GenerateMap %g")]
    private static void GenerateMap()
    {
        GameObject go = GameObject.Find("Map");
        if (go != null)
            return;
        
    }

#endif
}