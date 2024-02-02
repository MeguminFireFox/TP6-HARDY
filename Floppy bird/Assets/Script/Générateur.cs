using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Générateur : MonoBehaviour
{
    [SerializeField]
    private GameObject Tuyaux;

    [SerializeField]
    private Vector2 zone;

    private float Temps = 0;

    void Update()
    {
        Temps += 1 * Time.deltaTime;

        if (Temps >= 1)
        {
            GameObject instantiated = Instantiate(Tuyaux);

            instantiated.transform.position = new Vector2(
                Random.Range(transform.position.x - zone.x / 1, transform.position.x + zone.x / 1),
                Random.Range(transform.position.y - zone.y / 2, transform.position.y + zone.y / 2));

            Temps = 0;
        }
    }
}
