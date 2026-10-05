 public class GameRules { public int Score { get; private set; } = 0; public int Health { get; private set; } = 100;
public void AddScore(int amount)
{
    if (amount > 0)
    {
        Score += amount;
    }
}

public void TakeDamage(int damage)
{
    if (damage > 0)
    {
        Health -= damage;
        if (Health < 0)
        {
            Health = 0;
        }
    }
}

public void Heal(int amount)
{
    if (amount > 0)
    {
        Health += amount;
        if (Health > 100)
        {
            Health = 100;
        }
    }
}
}
[10/5/2026 2:49 AM] .: public class GameRules { public int Score { get; private set; } = 0; public int Health { get; private set; } = 100;
public void AddScore(int amount)
{
    if (amount > 0)
    {
        Score += amount;
    }
}

public void TakeDamage(int damage)
{
    if (damage > 0)
    {
        Health -= damage;
        if (Health < 0)
        {
            Health = 0;
        }
    }
}

public void Heal(int amount)
{
    if (amount > 0)
    {
        Health += amount;
        if (Health > 100)
        {
            Health = 100;
        }
    }
}
}