using System;
using System.Collections.Generic;
using Unity.Burst.Intrinsics;
using UnityEngine;
using Object = UnityEngine.Object;
using Random = UnityEngine.Random;
public class SaveManager
{
    private static volatile SaveManager _instance;
    private static readonly object _syncRoot = new object();
    
    private SaveData _saveData;
    
    private SaveManager() { }

    public static SaveManager GetInstance()
    {
        SaveManager result = _instance;
        if (result == null)
        {
            lock (_syncRoot)
            {
                result = _instance;
                if (result == null)
                {
                    _instance = result = new SaveManager();
                }
            }
        }
        
        return result;
    }
    
}
