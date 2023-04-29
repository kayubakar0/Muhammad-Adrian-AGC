using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UI_PoinJawaban : MonoBehaviour
{
    [SerializeField] private UI_PesanLevel _tempatPesan = null;

    [SerializeField] private TextMeshProUGUI _textjawaban = null;

    [SerializeField] private bool _benar = false;


    public void PilihJawaban()
    {
        _tempatPesan.Pesan = $"Jawaban anda {_textjawaban.text}  ({_benar})";
        // Debug.Log($"Jawaban anda {_textjawaban.text}  ({_benar})");
    }

    public void SetJawaban(string jawaban, bool benar)
    {
        _textjawaban.text = jawaban;
        _benar = benar;
    }
}
