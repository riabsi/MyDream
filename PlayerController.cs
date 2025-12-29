using UnityEngine;
using System.Collections.Generic;

public class PlayerController : MonoBehaviour {
    // إعدادات الحركة
    public Joystick variableJoystick; // الزر الدائري لليسار
    public float speed = 5f;
    public float jumpForce = 7f;
    private Rigidbody rb;

    // نظام الأسلحة والحقيبة
    public List<string> inventory = new List<string> {"سيف", "حبل تسلق", "مسدس", "كلاشينكوف"};
    public string currentWeapon = "";
    public int ammo = 30;

    void Start() {
        rb = GetComponent<Rigidbody>();
    }

    void Update() {
        // 1. نظام المشي بالزر الدائري
        Vector3 direction = Vector3.forward * variableJoystick.Vertical + Vector3.right * variableJoystick.Horizontal;
        transform.Translate(direction * speed * Time.deltaTime);
    }

    // 2. زر القفز
    public void Jump() {
        if(Mathf.Abs(rb.velocity.y) < 0.01f) {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }

    // 3. زر الحقيبة واختيار السلاح
    public void OpenInventoryAndSelect(int index) {
        currentWeapon = inventory[index];
        Debug.Log("تم تجهيز: " + currentWeapon);
    }

    // 4. زر الضرب (يختلف حسب السلاح)
    public void Attack() {
        if (currentWeapon == "مسدس" || currentWeapon == "كلاشينكوف") {
            if (ammo > 0) {
                Shoot();
                ammo--;
            }
        } else if (currentWeapon == "سيف") {
            SwingSword();
        } else if (currentWeapon == "حبل تسلق") {
            StartClimbing();
        }
    }

    void Shoot() { /* كود إطلاق النار */ }
    void SwingSword() { /* كود الضرب بالسيف */ }
    void StartClimbing() { /* كود التفاعل مع الأشجار والجبال */ }
}
