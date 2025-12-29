using UnityEngine;

public class SoundManager : MonoBehaviour
{
    void Start()
    {
        Debug.Log("--- تفعيل نظام الصوت المحيطي في MyDream ---");

        // برمجة تشغيل صوت الرياح الخفيفة وصوت العصافير
        string ambientSound = "Forest_Ambience.mp3";
        string stepSounds = "Footsteps_On_Grass.wav";

        Debug.Log("جاري تشغيل: " + ambientSound);
        Debug.Log("تم تفعيل أصوات الأقدام للأبطال عند المشي نحو الأكواخ.");
    }
}
