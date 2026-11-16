using UnityEngine;

public class BlueEnemy : Enemy
{
    public override void setColour()
    {
        this.gameObject.GetComponent<SpriteRenderer>().color = Color.blue;
    }
}
