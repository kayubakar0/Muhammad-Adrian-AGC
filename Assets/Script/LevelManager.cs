using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    [System.Serializable]
    private struct DataSoal
    {
        public string judulLevel;
        public Sprite hint;
        public string pertanyaan;

        public string[] jawaban;
        public bool[] isBenar;
    }

    [SerializeField] private DataSoal[] _dataSoal = new DataSoal[0];

    [SerializeField] private UI_Pertanyaan _uiPertanyaan = null;

    [SerializeField] private UI_PoinJawaban[] _uiPoinJawaban = new UI_PoinJawaban[0];

    private int _soalIndex = -1;

    private void Start()
    {
        NextLevel();
    }

    public void NextLevel()
    {
        //Soal Index selanjutnya
        _soalIndex++;

        //Jika soal index sudah melebihi jumlah soal, maka kembali ke soal pertama
        if (_soalIndex >= _dataSoal.Length)
        {
            _soalIndex = 0;
        }

        //Ambil data pertanyaa
        DataSoal dataSoal = _dataSoal[_soalIndex];

        //Set pertanyaan
        _uiPertanyaan.SetPertanyaan(dataSoal.judulLevel ,dataSoal.pertanyaan, dataSoal.hint);

        for(int i = 0; i < _uiPoinJawaban.Length; i++)
        {
            //Set jawaban
            UI_PoinJawaban poin = _uiPoinJawaban[i];
            poin.SetJawaban(dataSoal.jawaban[i], dataSoal.isBenar[i]);
        }
    }
}
