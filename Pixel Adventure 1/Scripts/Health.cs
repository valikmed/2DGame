using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public float CurrentValue;
    public SpriteRenderer Renderer;
    public float MaxValue;
    // Start is called before the first frame update
    void Start()
    {
        MaxValue = CurrentValue;
    }

    public void TakeDamage(float damage)
    {
        CurrentValue -= damage;
        Renderer.color = Color.Lerp(Color.red, Color.white, CurrentValue/ MaxValue); 
        if (CurrentValue <= 0)
        {
            Destroy(gameObject);
        }
    }
}
