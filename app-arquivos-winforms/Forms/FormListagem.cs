using app_arquivos_winforms.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app_arquivos_winforms.Forms
{
    public partial class FormListagem : Form
    {
        public FormListagem()
        {
            InitializeComponent();
            dataGridView1.DataSource=ListaDePets();
            
        }

        private List<Pet> ListaDePets()
        {
            StreamReader sr = 
                new StreamReader(Directory.GetCurrentDirectory()+"\\pet.txt");
            List<Pet> pets = new List<Pet>();
            while(!sr.EndOfStream)
            {
                var pet = new Pet();
                var linha = sr.ReadLine();
                var dados = linha.Split(';');
                pet.Id = dados[0];
                pet.Nome = dados[1];
                pet.Raca = dados[2];
                pet.Idade = int.Parse(dados[3]);    
                pet.Peso = double.Parse(dados[4]);
                pet.Porte = dados[5];               
                pets.Add(pet);
            }
            return pets;
        }
    }
}
