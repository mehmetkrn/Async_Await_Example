using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Async_Await_Example
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private async void BtnHazirla_Click(object sender, EventArgs e)
        {
            //Zaman Tutuyoruz
            var sw = Stopwatch.StartNew();

            //Cay işlemlerini grupluyoruz
            Cay_Basladi();
            var Cay =await Cay_Suyu_Koy_Async().ContinueWith(async x =>
              {
                  await Cay_Suyu_Kaynat_Async();
                  await Cay_Koy_Async();
                  await Cay_Kaynar_Su_Ekle_Async();
                  await Cay_Demlendi_Async();
                  await Cay_Bitti();
              });
            //Kahve işlemlerini grupluyoruz
            Kahve_Basladi();
            var Kahve =await Kahve_Suyu_Koy_Async().ContinueWith(async x =>
            {
                await Kahve_Koy_Async();
                await Kahve_Karistir_Async();
                await Kahve_Kaynat_Async();
                await Kahve_Bitti();

            });

            //Task Gruplarının bitmesini bekliyoruz.
            await Task.WhenAll(Cay, Kahve);

            await Servis_Et_Async();
            sw.Stop();
            Log_Ekle("Toplam Kahve Yapma Süresi " + sw.ElapsedMilliseconds);

        }
     
        #region Cay 
        private async Task Cay_Suyu_Koy_Async()
        {
            await Task.Delay(2000);
            Log_Ekle(Tarih_Getir()+ "Çay Suyu Koyuldu" );
        }
        private async Task Cay_Suyu_Kaynat_Async()
        {
            await Task.Delay(2000);
            Log_Ekle(Tarih_Getir() + "Çay Suyu Kaynadı ");
        }
        private async Task Cay_Koy_Async()
        {
            await Task.Delay(2000);
            Log_Ekle(Tarih_Getir() + "Çay Koyuldu ");
        }
        private async Task Cay_Kaynar_Su_Ekle_Async()
        {
            await Task.Delay(2000);
            Log_Ekle(Tarih_Getir() + "Çay Kaynar Su Eklendi ");
        }
        private async Task Cay_Demlendi_Async()
        {
            await Task.Delay(2000);
            Log_Ekle(Tarih_Getir() + "Çay Demlendi ");
        }
        #endregion
        #region Kahve
        private async Task Kahve_Suyu_Koy_Async()
        {
            await Task.Delay(2000);
            Log_Ekle(Tarih_Getir() + "Kayve Suyu Koyuldu ");
        }
        private async Task Kahve_Koy_Async()
        {
            await Task.Delay(2000);
            Log_Ekle(Tarih_Getir() + "Kayve Koyuldu " );
        }
        private async Task Kahve_Karistir_Async()
        {
            await Task.Delay(2000);
            Log_Ekle(Tarih_Getir() + "Kayve Karıştır " );
        }
        private async Task Kahve_Kaynat_Async()
        {
            Task.Delay(2000).Wait();
            Log_Ekle(Tarih_Getir() + "Kayve Kaynadı" );
        } 
        private async Task Servis_Et_Async()
        {
            await Task.Delay(2000);
            Log_Ekle(Tarih_Getir() + "Servis Edildi ");
        }
        #endregion
        #region Renklendirme
        private async Task Cay_Basladi()
        {
            BtnCay.BackColor = Color.Orange;
        }
        private async Task Cay_Bitti()
        {
            BtnCay.BackColor = Color.Green;
        }
        private async Task Kahve_Basladi()
        {
            BtnKahve.BackColor = Color.Orange;
        }
        private async Task Kahve_Bitti()
        {
            BtnKahve.BackColor = Color.Green;
        }
        #endregion

        private void Log_Ekle(string Log)
        {
            //Log ekleme Müsait mi diye bakılıyor eğer müsait değilse true döner.
            if (Lst.InvokeRequired)
            {
                Lst.Invoke(new Action(() => { Log_Ekle(Log); }));
                return;
            }
            Lst.Items.Add(Log);
            Lst.TopIndex = Lst.Items.Count - 1;
        }
        private string Tarih_Getir()
        {
            return "[" + DateTime.Now + "] ";
        }
    }
}
