using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_TImer : MonoBehaviour
{
    [SerializeField] private float _waktuJawab = 30f; //dalam detik

    private float _sisaWaktu = 0f;

    private bool waktuBerjalan = false;

    public bool WaktuBerjalan
    {
        get => waktuBerjalan;
        set => waktuBerjalan = value;
    }

    [SerializeField] private Slider _timeBar = null;

    //Pesan Waktu habis
    [SerializeField] private UI_PesanLevel _pesanWaktuHabis = null;
    [SerializeField] private GameObject _panelWaktuHabis = null;

    private void Start()
    {
        UlangiWaktu();
        waktuBerjalan = true;
    }

    private void Update()
    {
        if(!waktuBerjalan)
        {
            return;
        }

        _sisaWaktu -= Time.deltaTime;
        _timeBar.value = _sisaWaktu / _waktuJawab;

        if(_sisaWaktu <= 0f)
        {
            // Debug.Log("Waktu Habis");
            _pesanWaktuHabis.Pesan = "Waktu Habis";
            _panelWaktuHabis.SetActive(true);
            waktuBerjalan = false;
            return;
        }
        // Debug.Log("Sisa Waktu: " + _sisaWaktu);

    }

    public void UlangiWaktu()
    {
        _sisaWaktu = _waktuJawab;
    }
}
