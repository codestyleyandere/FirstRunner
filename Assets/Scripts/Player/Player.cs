using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    [SerializeField] private int _health;

    public event UnityAction<int> HealthChange;
    public event UnityAction Died;

    private void Start()
    {
        HealthChange?.Invoke(_health);
    }
    public void ApplyDamage(int damage)
    {
        _health -= damage;
        HealthChange?.Invoke(_health);
        if (_health <= 0)
            Die();
    }
    public void Die()
    {
        Died?.Invoke();
    }
}
