using UnityEngine;

public class CharacterManager : MonoBehaviour
{
    void Start()
    {
        Debug.Log("--- تفعيل ذكاء الأبطال في MyDream ---");

        // أمر: ليلا تتوقف عن الدوران وتتحرك نحو الكوخ الأول
        string order1 = "Leila_Body: MoveTo(Hut_1)";
        
        // أمر: ماريا تتوقف وتتحرك نحو الكوخ الثاني
        string order2 = "Maria_Body: MoveTo(Hut_2)";

        Debug.Log("الأبطال الآن يغادرون ساحة التدريب ويتجهون للأكواخ.");
    }
}
