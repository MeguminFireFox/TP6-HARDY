using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    public Rigidbody2D rb;
    private float forceAmount = 5;
    public GameObject Panel;

    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            rb.AddForce(Vector2.up * forceAmount, ForceMode2D.Impulse);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Tuyau")
        {
            Panel.SetActive(true);
            Destroy(gameObject);
        }
    }
}
