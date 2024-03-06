using UnityEngine;

public class Taistelu : MonoBehaviour
{
    public float vahinkoPerOsuma = 10f;
    public int vaaditutOsumat = 3;
    public GameObject vastustaja;
    public Animator pelaajaAnimaattori; // Lis�tty pelaajan Animator-komponentti
    private int osumat = 0;
    private bool onTaistelussa = false;

    void Update()
    {
        // Tarkista, onko hiiren vasenta painiketta painettu
        if (Input.GetMouseButtonDown(0))
        {
            // Aloita taistelu, jos se ei ole jo k�ynniss�
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
                pelaajaAnimaattori.SetTrigger("Lyonti"); // K�ynnist� pelaajan ly�ntiin liittyv� animaatio
                if (osumat >= vaaditutOsumat)
                {
                    // Vastustajan kuoleman k�sittely
                    VastustajaKuoli();
                }
            }
        }
    }

    bool TarkistaOsuma()
    {
        // T�ss� voit tarkistaa, osuuko hahmo vastustajaan esim. Raycastilla tai Collider-t�rm�yksell�
        // Palauta true, jos osuma tapahtuu, muuten false
        return false;
    }

    void VastustajaKuoli()
    {
        // Tee jotain, kun vastustaja kuolee, esim. animaatio, pisteiden lis��minen pelaajalle jne.
        // Voit my�s tuhota vastustajan GameObjectin, jos haluat
    }
}
