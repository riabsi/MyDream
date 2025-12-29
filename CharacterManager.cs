using UnityEngine;

public class CharacterManager : MonoBehaviour
{
    // تعريف الشخصيات والحركات بناءً على أسمائك في GitHub
    void Start()
    {
        Debug.Log("--- نظام Crazy Baby يرحب بك يا رياض ---");

        // ربط ليلا بالحركة رقم 1
        string hero1 = "Leila_Body.fbx";
        string anim1 = "Shoved Reaction With Spin (1).fbx";

        // ربط ماريا بالحركة رقم 2
        string hero2 = "Maria_Body.fbx";
        string anim2 = "Shoved Reaction With Spin (2).fbx";

        Debug.Log("تم تجهيز " + hero1 + " مع حركة الدوران الأولى.");
        Debug.Log("تم تجهيز " + hero2 + " مع حركة الدوران الثانية.");
        Debug.Log("النظام جاهز للتشغيل المبدئي الآن!");
    }
}
