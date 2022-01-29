using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public float Health = 100f;
    public Slider HealthBar;

    private float CurrentHealth = 100f;

    public void Awake()
    {
        if (Instance)
            Destroy(gameObject);
        else
            Instance = this;
    }

    public void Start()
    {
        CurrentHealth = Health;
        UpdateSliderValue();
    }

    public void TakeDamage(float DamageAmount)
    {
        CurrentHealth -= DamageAmount;
        UpdateSliderValue();

        if (CurrentHealth <= 0f)
            SceneManager.LoadScene(SceneManager.GetActiveScene().name, LoadSceneMode.Single);
    }

    public void UpdateSliderValue()
    {
        HealthBar.value = CurrentHealth / Health;
    }
}
