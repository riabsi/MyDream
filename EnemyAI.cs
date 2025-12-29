using UnityEngine;
using UnityEngine.AI; // مكتبة الذكاء الاصطناعي

public class EnemyAI : MonoBehaviour {
    public Transform player; // مرجع لمكان اللاعب
    public float chaseRange = 10f; // المسافة التي يبدأ عندها المطاردة
    public float attackRange = 2f; // المسافة التي يبدأ عندها الهجوم
    public float speed = 3f;

    void Update() {
        // حساب المسافة بين العدو واللاعب
        float distanceToPlayer = Vector3.Distance(transform.position, player.position);

        if (distanceToPlayer <= attackRange) {
            AttackPlayer();
        } 
        else if (distanceToPlayer <= chaseRange) {
            ChasePlayer();
        } 
        else {
            Patrol();
        }
    }

    void ChasePlayer() {
        // التحرك باتجاه اللاعب
        transform.LookAt(player);
        transform.position = Vector3.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
        Debug.Log("العدو يطاردك!");
    }

    void AttackPlayer() {
        Debug.Log("العدو يهاجم اللاعب!");
        // هنا يمكن إضافة كود لإنقاص نقاط الحياة (HP)
    }

    void Patrol() {
        // كود بسيط للمشي في المكان (يمكن تطويره لاحقاً)
    }
}
