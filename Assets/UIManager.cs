using UnityEngine;

public class UIManager : MonoBehaviour
{
    [Header("Daftar Halaman UI")]
    public GameObject panelMainMenu;
    public GameObject panelStartAR;
    public GameObject panelExplore1;
    public GameObject panelExplore2;
    public GameObject panelHowToUse;
    public GameObject panelQuizMenu; // Entry point kuis
    public GameObject panelAbout;

    void Start()
    {
        // Saat game baru dimulai, pastikan hanya Main Menu yang muncul
        ShowMainMenu();
    }

    // Fungsi internal untuk menyembunyikan semua halaman
    private void HideAllPanels()
    {
        panelMainMenu.SetActive(false);
        panelStartAR.SetActive(false);
        panelExplore1.SetActive(false);
        panelExplore2.SetActive(false);
        panelHowToUse.SetActive(false);
        panelQuizMenu.SetActive(false);
        panelAbout.SetActive(false);
    }

    // --- FUNGSI NAVIGASI TOMBOL ---

    public void ShowMainMenu()
    {
        HideAllPanels();
        panelMainMenu.SetActive(true);
    }

    public void ShowStartAR()
    {
        HideAllPanels();
        panelStartAR.SetActive(true);
    }

    public void ShowExplore1()
    {
        HideAllPanels();
        panelExplore1.SetActive(true);
    }

    public void ShowExplore2()
    {
        HideAllPanels();
        panelExplore2.SetActive(true);
    }

    public void ShowHowToUse()
    {
        HideAllPanels();
        panelHowToUse.SetActive(true);
    }

    public void ShowQuizMenu()
    {
        HideAllPanels();
        panelQuizMenu.SetActive(true);
    }

    public void ShowAbout()
    {
        HideAllPanels();
        panelAbout.SetActive(true);
    }
}