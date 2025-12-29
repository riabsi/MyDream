using UnityEngine;

public class DamageDealer : MonoBehaviour {
    public float damageAmount = 25f; // مقدار الضرر (للسيف أو الرصاصة)
    public bool isBullet = false;   // هل هذا الجسم رصاصة؟

    // هذه الوظيفة تعمل عندما يلمس السلاح أو الرصاصة جسم العدو
    void OnTriggerEnter(Collider other) {
        // التأكد أن الجسم الذي صدمناه هو "عدو"
        if (other.CompareTag("Enemy")) {
            // نبحث عن نظام الحياة في العدو وننقص منه
            EnemyAI enemy = other.GetComponent<EnemyAI>();
            if (enemy != null) {
                Debug.Log("تمت إصابة العدو!");
                // هنا نستدعي وظيفة نقص دم العدو
                // enemy.TakeDamage(damageAmount); 
            }

            // إذا كانت رصاصة، تختفي بعد الاصطدام
            if (isBullet) {
                Destroy(gameObject);
            }
        }
    }
}
