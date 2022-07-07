using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rest
{


     class Personeller
    {
        private int _PersonelId;
        private int _PersonelGörevId;
        private string _PersonelAd;
        private string _PersonelParola;
        private string _PersonelKullaniciAdi;
        private bool _PersonelDurum;

        public int PersonelId { get => _PersonelId; set => _PersonelId = value; }
        public int PersonelGörevId { get => _PersonelGörevId; set => _PersonelGörevId = value; }
        public string PersonelAd { get => _PersonelAd; set => _PersonelAd = value; }
        public string PersonelParola { get => _PersonelParola; set => _PersonelParola = value; }
        public string PersonelKullaniciAdi { get => _PersonelKullaniciAdi; set => _PersonelKullaniciAdi = value; }
        public bool PersonelDurum { get => _PersonelDurum; set => _PersonelDurum = value; }
    }
    public pool personelEntryControl ( string password,int UserId)
    {
        bool result = false;
        try
        {
            SqlConnection con = new SqlConnection();
            catch (Exception)
        {
            throw;
        }

        }
        return true;
    }
    {

    }
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
