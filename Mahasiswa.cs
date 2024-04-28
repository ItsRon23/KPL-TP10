using System;

public class Mahasiswa
{

    // deklarasi attribut nama, NIM
    public String nama { get; set; }
    public String NIM { get; set; }


    // constructor class Mahasiswa
    public Mahasiswa(String nama, String NIM)
    {
        this.nama = nama;
        this.NIM = NIM;
    }

}

