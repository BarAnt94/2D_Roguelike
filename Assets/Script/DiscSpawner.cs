using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class DiscSpawner : MonoBehaviour
{
    [SerializeField] private DiscController m_discPrefab;
    [SerializeField] public float m_spawnFrequency = 2;

    void Start()
    {
        StartCoroutine(C_Spawn());
    }

    private void SpawnDisc()
    {
        DiscController spawnedDisc = Instantiate(m_discPrefab, transform.position, Quaternion.identity);
    }

    private IEnumerator C_Spawn()
    {
        yield return new WaitForSeconds(m_spawnFrequency);
        SpawnDisc();
        StartCoroutine(C_Spawn());
    }
}
