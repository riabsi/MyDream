using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public float health = 100f; // صحة العدو

    // دالة لتلقي الضرر من فريق Crazy Baby
    public void TakeDamage(float amount)
    {
        health -= amount;
        Debug.Log("العدو تلقى ضربة! الصحة المتبقية: " + health);

        if (health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Debug.Log("تم القضاء على العدو بنجاح!");
        Destroy(gameObject); // اختفاء العدو من اللعبة
    }
}
