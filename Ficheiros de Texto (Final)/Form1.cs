using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Ficheiros_de_Texto__Final_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public struct moto
        {
            public string marca, modelo, ano, estado, preco;
        }
        //Variavel que representa o struct
        moto dados;

        //Variavel do ficheiro
        string Ficheiro = "stand.txt";

        private void Form1_Load(object sender, EventArgs e)
        {
            //Limpa os campos ao iniciar o programa
            LimparCampos();

            if (File.Exists(Ficheiro) == true) //Caso o ficheiro exista
            {
                //Lê o ficheiro e mostra os dados existentes na Grelha
                LerFicheiro();
            }
            else //Caso não exista ficheiro
            {
                //Criar ficheiro para baixos
                FileStream file = new FileStream(Ficheiro, FileMode.CreateNew, FileAccess.Write);

                //Fechar instância FileStream
                file.Close();
            }
        }
        //------------------------------------Butões-----------------------------------
        private void btguardar_Click(object sender, EventArgs e)
        {

        }

        private void bteditar_Click(object sender, EventArgs e)
        {
           
        }

        private void bteliminar_Click(object sender, EventArgs e)
        {
            
        }
        //------------------------------------Funções-----------------------------------
        private void LimparCampos()
        {
            tbmarca.ResetText();
            tbmodelo.ResetText();
            numano.ResetText();
            cbestado.ResetText();
            numpreco.ResetText();
        }

        private void LerFicheiro()
        {
            //Apagar dados antigos da Grelha
            dgvGrelha.Rows.Clear();

            //Variáveis para as posições
            int p1, p2, p3, p4, p5;

            //Abrir ficheiro
            FileStream fs = new FileStream(Ficheiro, FileMode.Open, FileAccess.Read);
            //Criar instância
            StreamReader sr = new StreamReader(fs, Encoding.UTF8);

            //Passar dados para a DataGridView
            while (sr.Peek() != -1)
            {
                // Mostrar/Identificar limitadores
                string linhas = sr.ReadLine();

                p1 = linhas.IndexOf(";") + 1;
                p2 = linhas.IndexOf(";", p1) + 1;
                p3 = linhas.IndexOf(";", p2) + 1;
                p4 = linhas.IndexOf(";", p3) + 1;
                p5 = linhas.IndexOf(";", p4) + 1;

                //Guardar os dados no registo
                dados.marca = linhas.Substring(p1, p2 - p1 - 1);
                dados.modelo = linhas.Substring(p2, p3 - p2 - 1);
                dados.ano = linhas.Substring(p3, p4 - p3 - 1);
                dados.estado = linhas.Substring(p4, p5 - p4 - 1);
                dados.preco = linhas.Substring(p5);

                //Colocar dados do registo na DGV
                dgvGrelha.Rows.Add(
                        dados.marca,
                        dados.modelo,
                        dados.ano,
                        dados.estado,
                        dados.preco);
            }

            //Fechar ficheiro
            sr.Close();
        }
    }
}
