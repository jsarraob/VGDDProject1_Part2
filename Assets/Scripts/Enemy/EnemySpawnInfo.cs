using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class EnemySpawnInfo : MonoBehaviour
{
    #region Editor Variables
    [SerializeField]
    [Tooltip("the name of this enemy")]
    private string m_Name;
    public string EnemyName
    {
        get
        {
            return m_Name;
        }
    }

    [SerializeField]
    [Tooltip("the prefab of this enemy")]
    private GameObject m_EnemyGO;
    public GameObject EnemyGO
    {
        get
        {
            return m_EnemyGO;
        }
    }

    [SerializeField]
    [Tooltip("the numer of seconds before the next enemy is spawned")]
    private float m_TimeToNextSpawn;
    public float TimeToNextSpawn
    {
        get
        {
            return m_TimeToNextSpawn;
        }
    }

    [SerializeField]
    [Tooltip("the number of enemies to spawn")]
    private int m_NumberToSpawn;
    public int NumberToSpawn
    {
        get
        {
            return m_NumberToSpawn;
        }
    }
    #endregion
}
