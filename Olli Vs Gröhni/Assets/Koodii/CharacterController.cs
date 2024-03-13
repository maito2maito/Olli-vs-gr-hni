using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public GameObject[] characters; // T‰h‰n aseta Unityss‰ hahmojen GameObjectit
    private int activeCharacterIndex = 0; // Aktiivisen hahmon indeksi
    private Rigidbody2D activeCharacterRigidbody; // Aktiivisen hahmon Rigidbody2D-komponentti

    // Muokattavat arvot hahmon nopeudelle ja hyppyvoimalle
    public float moveSpeed = 5f;
    public float jumpForce = 10f;

    void Start()
    {
        // Otetaan k‰yttˆˆn ensimm‰inen hahmo ja asetetaan sen Rigidbody2D-komponentti
        SetActiveCharacter(activeCharacterIndex);
    }

    void Update()
    {
        // Tarkistetaan painetaanko vaihto-n‰pp‰int‰ (esim. v‰lilyˆnti)
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Vaihdetaan aktiivista hahmoa
            SwitchCharacter();
        }

        // Liikuta aktiivista hahmoa vain, jos ei ole toista hahmoa aktiivisena
        if (Input.GetKey(KeyCode.LeftArrow) && activeCharacterIndex == 0)
        {
            MoveCharacter(-1f); // Liikuta hahmoa vasemmalle
        }
        else if (Input.GetKey(KeyCode.RightArrow) && activeCharacterIndex == 0)
        {
            MoveCharacter(1f); // Liikuta hahmoa oikealle
        }

        // Tarkistetaan hyppy-n‰pp‰in (esim. v‰lilyˆnti) ja aktiivisen hahmon indeksi
        if (Input.GetKeyDown(KeyCode.UpArrow) && activeCharacterIndex == 0)
        {
            Jump(); // Hahmo hypp‰‰
        }
    }

    void SwitchCharacter()
    {
        // Piilota nykyinen hahmo
        characters[activeCharacterIndex].SetActive(false);

        // Siirry seuraavaan hahmoon
        activeCharacterIndex++;
        if (activeCharacterIndex >= characters.Length)
        {
            activeCharacterIndex = 0;
        }

        // N‰yt‰ uusi hahmo ja aseta sen Rigidbody2D-komponentti
        SetActiveCharacter(activeCharacterIndex);
    }

    void SetActiveCharacter(int index)
    {
        characters[index].SetActive(true);
        activeCharacterRigidbody = characters[index].GetComponent<Rigidbody2D>();
    }

    void MoveCharacter(float direction)
    {
        // Liikuta aktiivista hahmoa
        Vector2 movement = new Vector2(direction * moveSpeed, activeCharacterRigidbody.velocity.y);
        activeCharacterRigidbody.velocity = movement;
    }

    void Jump()
    {
        // Hypp‰‰ aktiivinen hahmo
        activeCharacterRigidbody.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
    }
}
