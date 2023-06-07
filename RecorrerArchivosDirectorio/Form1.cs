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

namespace RecorrerArchivosDirectorio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string rutaDirectorio = string.Empty;

            FolderBrowserDialog dialog = new FolderBrowserDialog();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                rutaDirectorio = dialog.SelectedPath;

            }

            //string[] dirs = Directory.GetFiles(rutaDirectorio);

            //string[] dirs = Directory.GetDirectories(rutaDirectorio);
            string[] dirs = Directory.GetFiles(rutaDirectorio, "*", SearchOption.AllDirectories);

            for (int i = 0; i < dirs.Length; i++)
            {
                string directorio = dirs[i].Remove(0, dirs[i].Length - 4);
                //string directorioFlac = dirs[i].Remove(0, dirs[i].Length - 5);
                //Console.WriteLine(directorio);
                if (directorio == ".mp3" || directorio == "flac")
                {
                    Console.WriteLine(directorio);
                    //Console.WriteLine(directorioFlac);
                    listBox1.Items.Add(dirs[i]);
                }
            }

            Console.WriteLine(listBox1.Items.Count);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Console.WriteLine(listBox1.Items.Count);
        }
    }
}
