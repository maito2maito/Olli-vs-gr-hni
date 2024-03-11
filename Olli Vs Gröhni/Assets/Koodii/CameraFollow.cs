using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; // Pelaajan Transform-komponentti, jonka kamera seuraa
    public float smoothSpeed = 0.125f; // Kuinka pehmeästi kamera seuraa pelaajaa
    public Vector3 offset; // Lisäys pelaajan sijaintiin kameran sijainnin laskemiseksi

    void FixedUpdate()
    {
        if (target != null)
        {
            Vector3 desiredPosition = target.position + offset;
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
            transform.Translate(smoothedPosition - transform.position);

            transform.LookAt(target); // Kamera katsoo pelaajaa
        }
    }
}
