using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    // متغيرات لمعرفة حالة اللاعب
    public bool isClimbing = false;
    public bool isHidden = false;

    // هذه الدالة تعمل عندما يلمس اللاعب شيئاً (شجرة، جبل، كوخ)
    private void OnTriggerEnter(Collider other)
    {
        // إذا لمس شجرة أو جبل للتسلق
        if (other.CompareTag("Tree") || other.CompareTag("Mountain")) 
        {
            isClimbing = true;
            Debug.Log("أنت تتسلق الآن يا رياض");
        }
        
        // إذا دخل كوخاً للاختباء
        if (other.CompareTag("Cottage")) 
        {
            isHidden = true;
            Debug.Log("أنت الآن مختبئ داخل الكوخ");
        }
    }

    // هذه الدالة تعمل عندما يبتعد اللاعب عن الشيء
    private void OnTriggerExit(Collider other)
    {
        isClimbing = false;
        isHidden = false;
        Debug.Log("خرجت من منطقة التفاعل");
    }
}
