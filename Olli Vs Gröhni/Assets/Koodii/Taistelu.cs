using UnityEngine;

public class Taistelu : MonoBehaviour
{
    public float vahinkoPerOsuma = 10f;
    public int vaaditutOsumat = 3;
    public GameObject vastustaja;
    public Animator pelaajaAnimaattori; // Lisätty pelaajan Animator-komponentti
    private int osumat = 0;
    private bool onTaistelussa = false;

    void Update()
    {
        // Tarkista, onko hiiren vasenta painiketta painettu
        if (Input.GetMouseButtonDown(0))
        {
            // Aloita taistelu, jos se ei ole jo käynnissä
            if (!onTaistelussa)
            {
                onTaistelussa = true;
                // Aloita animaatio tai muu visuaalinen indikaattori taistelun alkamisesta
            }

            // Tarkista, onko hahmo osunut vastustajaan
            if (onTaistelussa && TarkistaOsuma())
            {
                osumat++;
                // Tee jotain visuaalista, esim. animaatio osumasta
                pelaajaAnimaattori.SetTrigger("Lyonti"); // Käynnistä pelaajan lyöntiin liittyvä animaatio
                if (osumat >= vaaditutOsumat)
                {
                    // Vastustajan kuoleman käsittely
                    VastustajaKuoli();
                }
            }
        }
    }

    bool TarkistaOsuma()
    {
        // Tässä voit tarkistaa, osuuko hahmo vastustajaan esim. Raycastilla tai Collider-törmäyksellä
        // Palauta true, jos osuma tapahtuu, muuten false
        return false;
    }

    void VastustajaKuoli()
    {
        // Tee jotain, kun vastustaja kuolee, esim. animaatio, pisteiden lisääminen pelaajalle jne.
        // Voit myös tuhota vastustajan GameObjectin, jos haluat
    }
}
