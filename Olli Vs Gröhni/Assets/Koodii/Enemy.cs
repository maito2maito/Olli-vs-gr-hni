using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float moveSpeed = 3f; // Liikkumisnopeus
    public float attackRange = 1.5f; // Hy�kk�ysalue
    public float attackCooldown = 2f; // Hy�kk�yksen j��hdytysaika
    private float lastAttackTime; // Viimeisin hy�kk�ysaika
    private Transform player; // Pelaajan sijainti

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform; // Etsi pelaajan transformaatio
    }

    void Update()
    {
        // Liikuta vihollista pelaajaa kohti
        transform.position = Vector2.MoveTowards(transform.position, player.position, moveSpeed * Time.deltaTime);

        // Tarkista, onko pelaaja hy�kk�ysalueella ja voiko hy�k�t�
        if (Vector2.Distance(transform.position, player.position) <= attackRange && Time.time - lastAttackTime >= attackCooldown)
        {
            Attack();
            lastAttackTime = Time.time;
        }
    }

    void Attack()
    {
        // T�h�n voit lis�t� koodin, joka toteuttaa vihollisen hy�kk�yksen
        Debug.Log("Hy�kk�ys!");
    }
}
