using UnityEngine;

public class BackgroundController : MonoBehaviour
{
    public float parallaxEffectMultiplier; // T‰m‰ m‰‰ritt‰‰ kuinka nopeasti tausta liikkuu pelaajan mukana

    private Transform cameraTransform;
    private Vector3 lastCameraPosition;

    private void Start()
    {
        cameraTransform = Camera.main.transform;
        lastCameraPosition = cameraTransform.position;
    }

    private void Update()
    {
        // Lasketaan kameran liike viime frameen verrattuna
        float deltaX = cameraTransform.position.x - lastCameraPosition.x;
        float deltaY = cameraTransform.position.y - lastCameraPosition.y;

        // P‰ivitet‰‰n taustan sijainti pelaajan liikkeen mukaisesti
        transform.position += new Vector3(deltaX * parallaxEffectMultiplier, deltaY * parallaxEffectMultiplier, 0);

        // P‰ivitet‰‰n viimeisin kameran sijainti
        lastCameraPosition = cameraTransform.position;
    }
}
