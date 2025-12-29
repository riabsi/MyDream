using UnityEngine;

public class CameraDirector : MonoBehaviour
{
    public float rotationSpeed = 20.0f; // سرعة دوران الكاميرا
    
    void Update()
    {
        // الكاميرا ستدور ببطء حول مركز الغابة (حيث توجد الأكواخ والأبطال)
        transform.RotateAround(Vector3.zero, Vector3.up, rotationSpeed * Time.deltaTime);
        
        // الكاميرا ستبقى تنظر دائماً إلى منتصف المشهد
        transform.LookAt(Vector3.zero);
    }

    void Start()
    {
        Debug.Log("--- تم تفعيل الكاميرا السينمائية ---");
        Debug.Log("الكاميرا الآن تدور حول ليلا وماريا والأكواخ لرؤية النتيجة.");
    }
}
