//using UnityEngine;

//public class BlueEnemyPooledFactory : EnemyFactory
//{
//    float spawnTimer;
//    public float spawnCooldown;
//    public Enemy blueEnemy;

//    public override void Spawn()
//    {
//        BlueEnemyPool.Instance.Pool.Get();
//    }

//    void Update()
//    {
//        spawnTimer += Time.deltaTime;

//        if (spawnTimer > spawnCooldown)
//        {
//            spawnTimer = 0f;

//            Spawn();
//        }
//    }
//}
