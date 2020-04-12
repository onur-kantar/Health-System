using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameHandler : MonoBehaviour
{
    public HealthBar healthBar;
    void Start()
    {
        HealthSystem healthSystem = new HealthSystem(100);
        Debug.Log("Health : " + healthSystem.GetHealthPercent());
        healthBar.Setup(healthSystem);
        healthSystem.Damage(10);
        Debug.Log("Health : " + healthSystem.GetHealthPercent());

    }
}
