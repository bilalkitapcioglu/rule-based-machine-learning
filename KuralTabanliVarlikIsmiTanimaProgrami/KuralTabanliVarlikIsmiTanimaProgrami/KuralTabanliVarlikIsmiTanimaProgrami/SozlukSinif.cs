using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace KuralTabanliVarlikIsmiTanimaProgrami
{
    class SozlukSinif:TemelSinif
    {
        public static int progRun = 1;
        StreamReader oku;

        string dosya_SozlukOrganizasyon_IsimdenSonra = @"C:\Users\akadir7\Documents\Visual Studio 2013\Projects\KuralTabanliVarlikIsmiTanimaProgrami\SozlukAnahtarKelime\SozlukOrganizasyon_IsimdenSonra.txt";
        string dosya_SozlukOrganizasyon_IsminIcinde = @"C:\Users\akadir7\Documents\Visual Studio 2013\Projects\KuralTabanliVarlikIsmiTanimaProgrami\SozlukAnahtarKelime\SozlukOrganizasyon_IsminIcinde.txt";
        string dosya_SozlukUnvan_IsimdenOnce = @"C:\Users\akadir7\Documents\Visual Studio 2013\Projects\KuralTabanliVarlikIsmiTanimaProgrami\SozlukAnahtarKelime\SozlukUnvan_IsimdenOnce.txt";
        string dosya_SozlukUnvan_IsimdenSonra = @"C:\Users\akadir7\Documents\Visual Studio 2013\Projects\KuralTabanliVarlikIsmiTanimaProgrami\SozlukAnahtarKelime\SozlukUnvan_IsimdenSonra.txt";

        public static string[] sozluk_Organizasyon_IsimdenSonra = new string[100];
        public static string[] sozluk_Organizasyon_IsminIcinde = new string[100];
        public static string[] sozluk_Unvan_IsimdenOnce = new string[100];
        public static string[] sozluk_Unvan_IsimdenSonra = new string[100];
        public static string[] sozluk_Yer_IsimdenOnce = new string[100];
        public static string[] sozluk_Yer_IsimdenSonra = new string[100];

        public void SozlukleriAl()
        {
            string sozluk;

            int i = 0;

            if (progRun == 1)
            {
                //----------------------------------------------------------
                oku = new StreamReader(dosya_SozlukOrganizasyon_IsimdenSonra, false);
                while ((sozluk = oku.ReadLine()) != null)
                {
                    sozluk_Organizasyon_IsimdenSonra[i++] = sozluk;
                }
                i = 0;
                oku.Close();
                //---------------------------------------------------------
                oku = new StreamReader(dosya_SozlukOrganizasyon_IsminIcinde, false);
                while ((sozluk = oku.ReadLine()) != null)
                {
                    sozluk_Organizasyon_IsminIcinde[i++] = sozluk;
                }
                i = 0;
                oku.Close();
                //---------------------------------------------------------
                oku = new StreamReader(dosya_SozlukUnvan_IsimdenOnce, false);
                while ((sozluk = oku.ReadLine()) != null)
                {
                    sozluk_Unvan_IsimdenOnce[i++] = sozluk;
                }
                i = 0;
                oku.Close();
                //---------------------------------------------------------
                oku = new StreamReader(dosya_SozlukUnvan_IsimdenSonra, false);
                while ((sozluk = oku.ReadLine()) != null)
                {
                    sozluk_Unvan_IsimdenSonra[i++] = sozluk;
                }
                i = 0;
                oku.Close();
                //----------------------------------------------------------
                progRun++;
            }
        }
    }
}
