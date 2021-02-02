using UnityEngine;
using UnityEngine.SceneManagement;

public class SuperScreenshot : MonoBehaviour
{
    [Range(1, 6)]
    [Header("Multiplier résolution écran par : ")]
    [Tooltip("Sur un écran HD, 1 ≈ 2 megapixels ≈ A5. Avec un multiplier x6, vous avec une image d'un mètre de long en 300DPI...")]
    public int multiplier = 3;
    
    void Update()
    {
        // sauve une capture d'écran quand on appuye sur F12
        if (Input.GetKeyDown(KeyCode.F12))
        {
            string filename = SceneManager.GetActiveScene().name + "_" + System.DateTime.Now.ToString("yyyyMMdd_hhmmssff") + ".png";
            ScreenCapture.CaptureScreenshot(filename, multiplier);
            Debug.Log(filename + " a été enregistré.");
        }
    }
}
