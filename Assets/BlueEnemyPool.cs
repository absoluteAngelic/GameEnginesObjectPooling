using UnityEngine;
using UnityEngine.Pool;

public class BlueEnemyPool : Singleton<BlueEnemyPool>
{
    public int maxPoolSize;
    public int stackDefaultCapacity;
    public GameObject blueEnemyPrefab;

    private IObjectPool<BlueEnemy> _pool;
    public IObjectPool<BlueEnemy> Pool
    {
        get
        {
            if (_pool == null)
            {
                _pool = new ObjectPool<BlueEnemy>(CreatePooledItem, OnTakeFromPool, OnReturnedToPool, OnDestroyPoolObject, true, stackDefaultCapacity, maxPoolSize);
            }

            return _pool;
        }
    }

    private BlueEnemy CreatePooledItem()
    {
        BlueEnemy spawnedBlueEnemy = Instantiate(blueEnemyPrefab).GetComponent<BlueEnemy>();
        spawnedBlueEnemy.Pool = this.Pool;
        return spawnedBlueEnemy;
    }

    void OnReturnedToPool(BlueEnemy _blueEnemy)
    {
        _blueEnemy.gameObject.SetActive(false);
    }

    void OnTakeFromPool(BlueEnemy _blueEnemy)
    {
        _blueEnemy.gameObject.SetActive(true);
    }

    void OnDestroyPoolObject(BlueEnemy _blueEnemy)
    {
        Destroy(_blueEnemy.gameObject);
    }
}
