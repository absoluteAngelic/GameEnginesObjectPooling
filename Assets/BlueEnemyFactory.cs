using UnityEngine;

public class BlueEnemyFactory : EnemyFactory
{
    float spawnTimer;
    public float spawnCooldown;
    public GameObject blueEnemy;

    public override void Spawn()
    {
        Instantiate(blueEnemy);
    }

    void Update()
    {
        spawnTimer += Time.deltaTime;

        if (spawnTimer > spawnCooldown)
        {
            spawnTimer = 0f;

            Spawn();
        }
    }
}
