using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KuralTabanliVarlikIsmiTanimaProgrami
{
    class KayitSinif
    {
        public void Kaydet(string textBoxText)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            save.Filter = "Metin Dosyası|*.txt";
            
            //Aşağıdaki kod satırları daha önce kayıtlı dosya var mı ve üzerine yazılsın mı soruları için. Ama koda eklemedim.
            //save.OverwritePrompt = true;
            //save.CreatePrompt = true;

            if (save.ShowDialog() == DialogResult.OK)
            {
                StreamWriter Kayit = new StreamWriter(save.FileName);
                Kayit.WriteLine(textBoxText);
                Kayit.Close();
            }
        }
    }
}
