using System;

public class HealthSystem
{
    private int health;
    private int healthMax;
    public event EventHandler OnHealthChanged;
    public HealthSystem(int healthMax)
    {
        this.healthMax = healthMax;
        this.health = healthMax;
    }
    public void Damage(int damageAmount)
    {
        health -= damageAmount;
        if (health < 0)
            health = 0;
        OnHealthChanged(this, EventArgs.Empty);

    }
    public void Heal(int healAmount)
    {
        health += healAmount;
        if (health > healthMax)
            health = healthMax;
        OnHealthChanged(this, EventArgs.Empty);
    }
    public float GetHealthPercent()
    {
        return (float)health / healthMax;
    }
    public int GetHealth()
    {
        return health;
    }

}
