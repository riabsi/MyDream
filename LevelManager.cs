using UnityEngine;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour 
{
    // تعريف عناصر الغابة
    public string environmentName = "Silence Forest";
    public bool hasTrees = true;
    public int enemyCount = 5;

    void Start() {
        Debug.Log("مرحباً بك في " + environmentName);
        SetupUI(); // استدعاء أزرار التحكم
    }

    void SetupUI() {
        // تخيل وجود أزرار على شاشة هاتفك الآن:
        Debug.Log("تم تفعيل زر إطلاق النار لـ ليلا");
        Debug.Log("تم تفعيل زر الركض لـ روكسي");
    }
}
