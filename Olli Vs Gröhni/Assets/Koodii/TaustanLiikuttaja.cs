using UnityEngine;

public class TaustanLiikuttaja : MonoBehaviour
{
    public Transform pelaaja1; // Ensimm‰isen pelaajan transform-komponentti
    public Transform pelaaja2; // Toisen pelaajan transform-komponentti

    // Update is called once per frame
    void LateUpdate() // LateUpdate() varmistaa, ett‰ taustan sijainti p‰ivitet‰‰n muiden muutosten j‰lkeen
    {
        if (pelaaja1 != null && pelaaja2 != null) // Tarkista, ett‰ molemmat pelaajat on asetettu
        {
            // Lasketaan keskipiste pelaajien sijaintien X-koordinaattien perusteella
            float keskiX = (pelaaja1.position.x + pelaaja2.position.x) / 2f;

            // S‰ilytet‰‰n taustan alkuper‰iset Y- ja Z-koordinaatit
            float taustaY = transform.position.y;
            float taustaZ = transform.position.z;

            // P‰ivitet‰‰n taustan sijainti pelaajien keskipisteen mukaan, mutta s‰ilytet‰‰n alkuper‰iset Y- ja Z-koordinaatit
            transform.position = new Vector3(keskiX, taustaY, taustaZ);
        }
    }
}
