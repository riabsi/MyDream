using UnityEngine;

public class EnvironmentManager : MonoBehaviour
{
    public bool isDayTime = true;
    public float forestDensity = 0.5f;

    void Start() {
        Debug.Log("مرحباً بك في غابة My Dream - استعد للمغامرة");
    }

    // كود لتغيير الإضاءة عند دخول الكوخ
    public void EnterCottage() {
        Debug.Log("الإضاءة خافتة الآن.. أنت داخل الكوخ");
    }
}
