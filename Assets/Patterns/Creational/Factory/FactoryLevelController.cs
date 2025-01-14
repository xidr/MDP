using System;
using System.Collections.Generic;
using Unity.Burst.Intrinsics;
using UnityEngine;
using Object = UnityEngine.Object;
using Random = UnityEngine.Random;

public class FactoryLevelController : MonoBehaviour
{

    [SerializeField] private List<System.Type> m_enemiesTypes = new List<System.Type>();

    private void Awake()
    {
        m_enemiesTypes.Add(typeof(CommonEnemy));
        m_enemiesTypes.Add(typeof(EliteEnemy));
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            var newGO = new GameObject();
            // Instantiate(newGO, gameObject.transform);
            newGO.AddComponent(m_enemiesTypes[Random.Range(0, m_enemiesTypes.Count)]);
            newGO.transform.parent = transform;
        }
    }

    // private void SpawnEnemy<T>() where T : MonoBehaviour
    // {
    //     var newGO = new GameObject();
    //     Instantiate(newGO, gameObject.transform);
    //     newGO.AddComponent<T>();
    // }
}
