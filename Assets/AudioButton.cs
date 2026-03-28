using UnityEngine;

public class AudioButton : MonoBehaviour
{
    // Audio untuk button ini (assign di Inspector)
    public AudioClip clip;

    // Fungsi yang dipanggil dari Button OnClick()
    public void OnClick()
    {
        // Debug untuk memastikan button kepencet
        Debug.Log("Clicked: " + gameObject.name);

        // Pastikan AudioManager ada
        if (AudioManager.instance == null)
        {
            Debug.LogError("AudioManager not found in scene!");
            return;
        }

        // Pastikan clip ada
        if (clip == null)
        {
            Debug.LogError("AudioClip belum di-assign di " + gameObject.name);
            return;
        }

        // Jalankan audio lewat AudioManager
        AudioManager.instance.PlayOrToggle(clip);
    }
}