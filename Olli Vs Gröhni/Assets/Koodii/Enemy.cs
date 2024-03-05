using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float moveSpeed = 3f; // Liikkumisnopeus
    public float attackRange = 1.5f; // Hyökkäysalue
    public float attackCooldown = 2f; // Hyökkäyksen jäähdytysaika
    private float lastAttackTime; // Viimeisin hyökkäysaika
    private Transform player; // Pelaajan sijainti

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform; // Etsi pelaajan transformaatio
    }

    void Update()
    {
        // Liikuta vihollista pelaajaa kohti
        transform.position = Vector2.MoveTowards(transform.position, player.position, moveSpeed * Time.deltaTime);

        // Tarkista, onko pelaaja hyökkäysalueella ja voiko hyökätä
        if (Vector2.Distance(transform.position, player.position) <= attackRange && Time.time - lastAttackTime >= attackCooldown)
        {
            Attack();
            lastAttackTime = Time.time;
        }
    }

    void Attack()
    {
        // Tähän voit lisätä koodin, joka toteuttaa vihollisen hyökkäyksen
        Debug.Log("Hyökkäys!");
    }
}
