using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Characontroller : MonoBehaviour
{
    [Header("VFX")]
    [SerializeField] private ParticleSystem m_deathVFX;

    private bool m_isAlive = true;

    [SerializeField] GameObject character;

    public void TakeDamage(DiscController disc)
    {
        KillChara();
        isAlive();
    }

    public void KillChara()
    {
        m_deathVFX.Play();
        m_isAlive = false;
    }
    public void isAlive()
    {
        if (m_isAlive == false)
        {
            character.SetActive(false);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Disc"))
        {
            DiscController disc = collision.GetComponentInParent<DiscController>();
            if (disc)
            {
                TakeDamage(disc);
            }
        }
    }
}
