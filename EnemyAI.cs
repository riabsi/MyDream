using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    // إحصائيات العدو
    public float health = 100f;
    public float walkSpeed = 2f;
    public float chaseSpeed = 4.5f;
    public float attackRange = 2f; // المسافة التي يبدأ فيها الهجوم
    public float detectionRange = 10f; // المسافة التي يراك منها

    // الأهداف والمواقع
    public Transform player; // البطلة (ليلا أو روكسي أو جيد)
    private bool isChasing = false;

    void Update()
    {
        // حساب المسافة بين العدو والبطلة
        float distanceToPlayer = Vector3.Distance(transform.position, player.position);

        if (distanceToPlayer <= detectionRange)
        {
            // إذا اقتربت البطلة، يبدأ العدو بالمطاردة
            isChasing = true;
            ChasePlayer();
        }
        else
        {
            // إذا كانت بعيدة، يستمر في مراقبة المكان (دورية)
            isChasing = false;
            Patrol();
        }

        // إذا كان قريباً جداً، يبدأ الهجوم
        if (distanceToPlayer <= attackRange)
        {
            Attack();
        }
    }

    void Patrol()
    {
        // كود تحريك العدو في مسار محدد بمجلد الغابة
        Debug.Log("العدو يقوم بدورية حراسة...");
    }

    void ChasePlayer()
    {
        // كود اللحاق بالبطلة وزيادة السرعة
        Debug.Log("العدو رصد الهدف! بدأ المطاردة بسرعة: " + chaseSpeed);
    }

    void Attack()
    {
        Debug.Log("العدو يهاجم فريق Crazy Baby!");
    }

    public void TakeDamage(float amount)
    {
        health -= amount;
        if (health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Debug.Log("سقط العدو! تم تطهير منطقة من غابة الصمت.");
        Destroy(gameObject); // حذف العدو من اللعبة
    }
}
