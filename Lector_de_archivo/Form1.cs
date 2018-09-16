using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lector_de_archivo{

    public partial class Form1 : Form{

        private int copa = 0;
        private int coca = 0;
        private int coes = 0;
        private int cota = 0;
        private int coli = 0;
        private int covo = 0;
        private int coco = 0;
        Stream myStream = null;
        OpenFileDialog ventana = new OpenFileDialog();

        public Form1(){
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e){
            cbxOpcionesQuitar.DisplayMember = "Text";
            cbxOpcionesQuitar.ValueMember = "Value";

            var items = new[] {
                new { Text = "Espacios en Blanco", Value = "blanco" },
                new { Text = "Vocales", Value = "vocales" },
                new { Text = "Consonantes", Value = "consonantes" }
            };

            cbxOpcionesQuitar.DataSource = items;
        }

        private void updateStats() {
            string get = txbLecturaFile.Text;
            copa = Regex.Matches(get, "[a-zA-Z]").Count;
            coca = Regex.Matches(get, @"\b\w+\b").Count;
            coes = Regex.Matches(get, "\x20").Count;
            cota = Regex.Matches(get, "\t").Count;
            coli = Regex.Matches(get, "[\n\r]+").Count + 1;
            covo = Regex.Matches(get, "[aeiouAEIOU]").Count;
            coco = Regex.Matches(get, "[bcdfghjklmñpqrstvwxyzBCDFGHJKLMÑPQRSTVWXYZ]").Count;

            txbRutaFile.Text = ventana.FileName.ToString();
            txbResultPalabras.Text = "" + copa;
            txbResultCaracteres.Text = "" + coca;
            txbResultEspacioBlanco.Text = "" + coes;
            txbResultTabuladores.Text = "" + cota;
            txbResultLineas.Text = "" + coli;
            txbResultVocales.Text = "" + covo;
            txbResultConsonates.Text = "" + coco;
        }

        private void btnExaminarFile_Click(object sender, EventArgs e){
            ventana.Title = "Abir Archivo de Texto...";
            ventana.Filter = "Documentos de texto (*.txt)|*.txt";
            ventana.InitialDirectory = @"C:\";
            if (ventana.ShowDialog() == DialogResult.OK){

                try{
                    if ((myStream = ventana.OpenFile()) != null){
                        using (myStream){
                            txbLecturaFile.Text = File.ReadAllText(ventana.FileName,Encoding.UTF8);

                            StreamReader sr = new StreamReader(ventana.FileName);
                            string text = File.ReadAllText(ventana.FileName);

                            copa = Regex.Matches(text, "[a-zA-Z]").Count;
                            coca = Regex.Matches(text, @"\b\w+\b").Count;
                            coes = Regex.Matches(text, "\x20").Count;
                            cota = Regex.Matches(text, "\t").Count;
                            coli = Regex.Matches(text, "[\n\r]+").Count +1;
                            covo = Regex.Matches(text, "[aeiouAEIOU]").Count;
                            coco = Regex.Matches(text, "[bcdfghjklmñpqrstvwxyzBCDFGHJKLMÑPQRSTVWXYZ]").Count;
                            sr.Close();
                        }
                    }
                }
                catch (Exception ex){
                    MessageBox.Show("Hubo un error en la lectura del archivo. (Mensaje original " + ex.Message + ")");
                }
            }

            txbRutaFile.Text = ventana.FileName.ToString();
            txbResultPalabras.Text = "" + copa;
            txbResultCaracteres.Text = "" + coca;
            txbResultEspacioBlanco.Text = "" + coes;
            txbResultTabuladores.Text = "" + cota;
            txbResultLineas.Text = "" + coli;
            txbResultVocales.Text = "" + covo;
            txbResultConsonates.Text = "" + coco;

            myStream.Close();

        }

        private void btnProcesarEdit_Click(object sender, EventArgs e){
             if (cbxOpcionesQuitar.SelectedValue.ToString().Equals("blanco")){
                string get = txbLecturaFile.Text;
                string rep = Regex.Replace(get, "\x20","");
                txbLecturaFile.Text = rep;
                updateStats();
             }
             else if (cbxOpcionesQuitar.SelectedValue.ToString().Equals("vocales")){
                string get = txbLecturaFile.Text;
                string rep = Regex.Replace(get, "[aeiouAEIOU]", "");
                txbLecturaFile.Text = rep;
                updateStats();
            }
            else if (cbxOpcionesQuitar.SelectedValue.ToString().Equals("consonantes")){
                string get = txbLecturaFile.Text;
                string rep = Regex.Replace(get, "[bcdfghjklmñpqrstvwxyzBCDFGHJKLMÑPQRSTVWXYZ]", "");
                txbLecturaFile.Text = rep;
                updateStats();
            }
        }

        private void btnGuardarFile_Click(object sender, EventArgs e){
            SaveFileDialog ventana2 = new SaveFileDialog();
            ventana2.Title = "Guardar Archivo de Texto...";
            ventana2.Filter = "Documento de texto (*.txt)|*.txt";
            ventana2.InitialDirectory = @"C:\";
            ventana2.ShowDialog();
            if (ventana2.FileName != ""){
                using (StreamWriter sw = new StreamWriter(ventana2.OpenFile())){
                    sw.Write(txbLecturaFile.Text);
                    MessageBox.Show("Archivo Guardado en: " + ventana2.FileName.ToString(), "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
