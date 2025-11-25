using Unity.VisualScripting;
using UnityEngine;

public abstract class Unit:MonoBehaviour
{
    public int maxhealth;
    public int damage;
    public float rate;
    public int cost;
    public float cooldown;
    private int health;
    protected Cell assignedCell;
    public Unit(int maxhealth, int damage, float rate, int cost, float cooldown)
    {
        this.maxhealth=maxhealth;
        this.damage=damage;
        this.rate=rate;
        this.cost=cost;
        this.cooldown=cooldown;
        health=maxhealth;
    }

    public void TakeDamage(int EnemyDamage)
    {
        health -= EnemyDamage;
        if (health <= 0)
        {
            onDeath();
        }
    }

    public void onDeath()
    {
        
    }
    public void AssignToCell(Cell cell) {
        assignedCell = cell;
        transform.position = cell.Position;
    }
}



