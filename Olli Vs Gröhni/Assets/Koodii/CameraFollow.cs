using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform[] targets; // Taulukko pelaajien transformeille
    public float smoothSpeed = 0.125f; // Nopeus, jolla kamera liikkuu pelaajien per‰ss‰
    public Vector3 offset; // Offset, joka m‰‰rittelee kameran et‰isyyden pelaajista

    void FixedUpdate()
    {
        if (targets.Length == 0)
            return;

        Vector3 desiredPosition = GetCenterPoint() + offset; // Lasketaan pelaajien keskipiste ja lis‰t‰‰n offset
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed); // Tasainen liike pelaajien per‰ss‰
        transform.position = smoothedPosition; // P‰ivitet‰‰n kameran sijainti
    }

    Vector3 GetCenterPoint()
    {
        if (targets.Length == 1)
            return targets[0].position;

        Bounds bounds = new Bounds(targets[0].position, Vector3.zero);
        for (int i = 0; i < targets.Length; i++)
        {
            bounds.Encapsulate(targets[i].position);
        }
        return bounds.center;
    }
}
