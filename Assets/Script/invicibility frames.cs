using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class invicibilityframes : MonoBehaviour
{
    public float speed = 0f;
    public int health = 3;
    public float invincibilityDuration = 2.0f;
    private bool isInvincible = false;
    private Renderer playerRenderer;
    private Color originalColor;

    void Start()
    {
        playerRenderer = GetComponent<Renderer>();
        originalColor = playerRenderer.material.color;
    }

    void Update()
    {
        float x = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float y = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        float z = gameObject.transform.position.z;
        gameObject.transform.Translate(x, y, z);
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Disc") && !isInvincible)
        {
            TakeDamage(1);
            StartCoroutine(BecomeInvincible());
        }
    }

    void TakeDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            // Gérer la mort du joueur
            Debug.Log("Player Died");
        }
    }

    IEnumerator BecomeInvincible()
    {
        isInvincible = true;
        playerRenderer.material.color = Color.red; // Changer la couleur pour indiquer l'invincibilité

        yield return new WaitForSeconds(invincibilityDuration);

        isInvincible = false;
        playerRenderer.material.color = originalColor; // Réinitialiser la couleur
    }
}

    /*void OnDiscCollision()
    {
        if (Collision.gameObject.tag == "disc")
        {
            Destroy(Collision.gameObject);
        } 

    }
    */

