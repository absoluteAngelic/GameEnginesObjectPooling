using UnityEngine;

public abstract class Enemy : MonoBehaviour
{
    float lifeTimer;
    public float totalLife;
    public float speedMultiplier;
    Vector3 movementDir;

    void Start()
    {
        setColour();
        movementDir = new Vector3(Random.Range(-1.0f, 1.0f), Random.Range(-1.0f, 1.0f), 0f).normalized;
    }

    public abstract void setColour();

    void Update()
    {
        lifeTimer += Time.deltaTime;

        this.gameObject.transform.position += movementDir * speedMultiplier;

        if (lifeTimer >= totalLife)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(this.gameObject);
    }
}
