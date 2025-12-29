using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20f;
    public float damage = 25f;

    void Update()
    {
        // الرصاصة تتحرك للأمام باستمرار
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    // عند اصطدام الرصاصة بالعدو
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            other.GetComponent<EnemyHealth>().TakeDamage(damage);
            Destroy(gameObject); // تدمير الرصاصة بعد الإصابة
        }
    }
}
