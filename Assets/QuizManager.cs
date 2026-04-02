using UnityEngine;

public class QuizManager : MonoBehaviour
{
    [Header("Referensi Semua Panel")]
    public GameObject panelMainMenu;
    public GameObject panelQuizMenu;
    public GameObject panelTanya1;
    public GameObject panelTanya2;
    public GameObject panelTanya3;
    public GameObject panelPopupBenar;

    [Header("Audio (Jawaban Salah)")]
    public AudioSource audioSource;
    public AudioClip suaraTetot;

    private int jawabanTerpilih = -1;
    private int tahapKuis = 1; // Melacak posisi: 1, 2, atau 3

    // 1. Dipanggil oleh tombol Start
    public void MulaiKuis()
    {
        tahapKuis = 1;
        jawabanTerpilih = -1;

        if (panelQuizMenu != null) panelQuizMenu.SetActive(false);
        if (panelMainMenu != null) panelMainMenu.SetActive(false);

        panelTanya1.SetActive(true);
        panelTanya2.SetActive(false);
        panelTanya3.SetActive(false);
        panelPopupBenar.SetActive(false);
    }

    // 2. Dipanggil oleh Tombol A, B, C, D
    public void PilihJawaban(int indeks) { jawabanTerpilih = indeks; }

    // 3. Dipanggil oleh tombol SUBMIT
    public void CekJawaban(int indeksJawabanBenar)
    {
        if (jawabanTerpilih == -1) return;

        if (jawabanTerpilih == indeksJawabanBenar)
        {
            panelPopupBenar.SetActive(true);
        }
        else
        {
            if (audioSource != null && suaraTetot != null)
            {
                audioSource.PlayOneShot(suaraTetot);
            }
        }
    }

    // 4. Dipanggil oleh tombol LANJUT di Pop-up
    public void Lanjut()
    {
        panelPopupBenar.SetActive(false);
        NavigasiNext(); // Kita gunakan fungsi Next yang baru di bawah
    }

    // ==================================================
    // FUNGSI BARU: NAVIGASI HEADER KUIS (HOME, NEXT, PREV)
    // ==================================================

    public void NavigasiHome()
    {
        // Tutup semua urusan kuis, paksa pulang ke Main Menu
        panelTanya1.SetActive(false);
        panelTanya2.SetActive(false);
        panelTanya3.SetActive(false);
        panelPopupBenar.SetActive(false);

        panelMainMenu.SetActive(true);
    }

    public void NavigasiNext()
    {
        panelPopupBenar.SetActive(false); // Tutup pop-up jika masih terbuka
        jawabanTerpilih = -1; // Reset pilihan

        if (tahapKuis == 1)
        {
            panelTanya1.SetActive(false);
            panelTanya2.SetActive(true);
            tahapKuis = 2;
        }
        else if (tahapKuis == 2)
        {
            panelTanya2.SetActive(false);
            panelTanya3.SetActive(true);
            tahapKuis = 3;
        }
        else if (tahapKuis == 3)
        {
            // ==========================================
            // UBAH DI SINI: KEMBALI KE MAIN MENU
            // ==========================================
            panelTanya3.SetActive(false);
            panelMainMenu.SetActive(true); // Membuka Home

            // Kita kembalikan tahap ke 1 agar kuis siap dimainkan ulang nanti
            tahapKuis = 1;
        }
    }

    public void NavigasiPrev()
    {
        panelPopupBenar.SetActive(false);
        jawabanTerpilih = -1;

        if (tahapKuis == 1)
        {
            // Jika Prev di panel 1, mundur ke panel 3 (Looping)
            panelTanya1.SetActive(false); panelTanya3.SetActive(true);
            tahapKuis = 3;
        }
        else if (tahapKuis == 2)
        {
            panelTanya2.SetActive(false); panelTanya1.SetActive(true);
            tahapKuis = 1;
        }
        else if (tahapKuis == 3)
        {
            panelTanya3.SetActive(false); panelTanya2.SetActive(true);
            tahapKuis = 2;
        }
    }
}