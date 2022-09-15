using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIRoot : MonoBehaviour
{
    private static Dictionary<string,Transform> uiPrefabs = new Dictionary<string, Transform>();
    private void Awake()
    {
        var prefabs = Resources.LoadAll<Transform>("UIPrefab");
        for (int i = 0; i < prefabs.Length; i++)
        {
            var prefab = Instantiate(prefabs[i], transform);
            prefab.name = prefab.name.Replace("(Clone)", "");
            uiPrefabs.Add(prefab.name,prefab);
        }
    }
    public static Dictionary<string,View> GetAllView()
    {
        if (uiPrefabs == null || uiPrefabs.Count == 0)
        {
            return null;
        }
        var viewDic = new Dictionary<string,View>();
        foreach (var prefab in uiPrefabs)
        {
            viewDic.Add(prefab.Key, prefab.Value.GetComponent<View>());
        }
        return viewDic;
    }
}
