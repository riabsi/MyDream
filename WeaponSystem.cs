using UnityEngine;

public class WeaponSystem : MonoBehaviour
{
    public float damage = 20f;
    public float range = 100f;

    public void Shoot()
    {
        Debug.Log("تم إطلاق النار! إصابة العدو بضرر: " + damage);
        // هنا يتم إضافة تأثير الرصاصة
    }
}
