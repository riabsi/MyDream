using UnityEngine;

public class ClimbingSystem : MonoBehaviour {
    public float climbSpeed = 3f;
    private bool isClimbing = false;
    private Rigidbody rb;

    void Start() {
        rb = GetComponent<Rigidbody>();
    }

    // يتم استدعاء هذه الوظيفة عندما يلمس جسم اللاعب أي شيء
    void OnCollisionEnter(Collision collision) {
        // التأكد إذا كان الشيء الذي لمسناه يحمل وسم "قابل للتسلق"
        if (collision.gameObject.compareTag("Climbable")) {
            StartClimbing();
        }
    }

    void StartClimbing() {
        isClimbing = true;
        rb.useGravity = false; // إلغاء الجاذبية لكي لا يسقط اللاعب
        Debug.Log("بدأ التسلق...");
    }

    void Update() {
        if (isClimbing) {
            // استخدام الزر الدائري (Joystick) للتحرك للأعلى والأسفل على الجبل
            float verticalMove = Input.GetAxis("Vertical"); 
            Vector3 climbDirection = new Vector3(0, verticalMove * climbSpeed, 0);
            transform.Translate(climbDirection * Time.deltaTime);
        }
    }

    public void StopClimbing() {
        isClimbing = false;
        rb.useGravity = true; // إعادة الجاذبية عند القفز من على الشجرة
    }
}
