using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tuyaux : MonoBehaviour
{
    private readonly float speed = 0.25f;
    private float temps = 0;
    void Update()
    {
        transform.Translate((Vector2.left / speed) * Time.deltaTime);

        temps += 1 * Time.deltaTime;

        if (temps > 5)
        {
            Destroy(gameObject);
        }
    }
}
