using UnityEngine;
using UnityEngine.SceneManagement; // هذا المكتبة المسؤولة عن تبديل المراحل

public class LevelPortal : MonoBehaviour {
    // اسم المرحلة الثانية كما ستمسيها في المحرك
    public string nextLevelName = "MountainLevel"; 

    // هذه الوظيفة تعمل عندما يدخل اللاعب في منطقة البوابة
    void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Player")) {
            Debug.Log("تم إنهاء المرحلة الأولى.. جاري تحميل الجبال!");
            SceneManager.LoadScene(nextLevelName);
        }
    }
}
