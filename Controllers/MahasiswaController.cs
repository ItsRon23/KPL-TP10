using Microsoft.AspNetCore.Mvc;

namespace tpmodul10_1302223057.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MahasiswaController
    {
        // inisialisasi data mahasiswa berupa anggota kelompok
        private static List<Mahasiswa> mahasiswa = new List<Mahasiswa>()
        {
            new Mahasiswa("Aaron Joseph Karel Daimbani","1302223083"),
            new Mahasiswa("Indra Mahesa","1302220067"),
            new Mahasiswa("Reinhard Efraim Situmeang","1302220001"),
            new Mahasiswa("Rifqi Alghifari","1302223028"),
            new Mahasiswa("Wildan Syukri Niam","1302220005"),
            new Mahasiswa("Yazid Al Ghozali","1302223047"),
        };

        // menggunakan IEnumerable untuk menampilkan seluruh list
        [HttpGet(Name = "GetMahasiswa")]
        public IEnumerable<Mahasiswa> Get()
        {
            return mahasiswa;
        }

        // menggunakan post untuk menambah data pada list mahasiswa
        [HttpPost]
        public void post([FromBody] Mahasiswa ListMahasiswa)
        {
            mahasiswa.Add(ListMahasiswa);
        }
        [HttpGet("{id}")]

        // menampilan data mahasiwa berdasarkan id yang diinput
        public Mahasiswa Get(int id)
        {
            return mahasiswa[id];
        }
        [HttpDelete("{id}")]


        // menggunakan delete untuk menghapus data list berdasarkan id
        public void delete(int id)
        {
            mahasiswa.RemoveAt(id);
        }

    }
}