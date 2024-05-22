using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Characontroller : MonoBehaviour
{
    [Header("VFX")]
    [SerializeField] private ParticleSystem m_deathVFX;
    private bool m_isaAlive = true;
    public Camerashake camshake;
    public GameObject childObject;

    private void Start()
    {
        camshake = FindObjectOfType<Camerashake>();
    }
    public void TakeDamage()
    {
        KillChara();
    }

    public void KillChara()
    {
        m_deathVFX.Play();
        camshake.TriggerShake();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Disc") && gameObject.GetComponent<Dash>().isdashing == false)
        {
            TakeDamage();
             childObject.SetActive(false);
        }
    }
}
