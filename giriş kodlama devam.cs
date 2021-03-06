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
        SqlConnection con = new SqlConnection(gnl.conString);
        SqlCommand cmd = new SqlCommand("Select * from Personeller where ID = @Id and PAROLA = @password", con);
        Cmd.Parameters.Add("@Id", SqlDbType.Varchar).Value = UserId;
        Cmd.Parameters.Add("@password", SqlDbType.Varchar).Value = password;

        try
           
        {
            if(con.State== ConnectionState.Closed)
            {
                con.Open();
            }

            result = Convert.ToBoolen(ExecuteScalar());
            catch (SqlException ex)
        {
            string hata = ex.mesage;

        }
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
