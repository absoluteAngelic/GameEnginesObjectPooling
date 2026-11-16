using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Pool;

public class BlueEnemy : Enemy
{
    public IObjectPool<BlueEnemy> Pool { get; set; }

    protected override void setColour()
    {
        this.gameObject.GetComponent<SpriteRenderer>().color = Color.blue;
    }

    protected override void Die()
    {
        Pool.Release(this);
    }

    void OnDisable()
    {
        FullReset();
    }

    void FullReset()
    {
        lifeTimer = 0f;
        this.gameObject.transform.position = Vector3.zero;
    }
}
