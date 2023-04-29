using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UI_Pertanyaan : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI TempatText;
    [SerializeField] private TextMeshProUGUI _tempatJudulLevel;
    [SerializeField] private Image TempatGambar;

    
    void Start()
    {
        Debug.Log("Isi tempat text: " + TempatText.text);
    }

    public void SetPertanyaan(string judulLevel,string pertanyaan, Sprite gambarHint)
    {
        _tempatJudulLevel.text = judulLevel;
        TempatText.text = pertanyaan;
        TempatGambar.sprite = gambarHint;
    }
}
