using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto1003
{
    public partial class TelaUsuario : Form
    {
        public TelaUsuario()
        {
            InitializeComponent();
        }

        //criar Metodo
        public void SalvarUsuario(List<Usuario> lista)
        {
            string json = JsonSerializer.Serialize(lista);
            File.WriteAllText("usuarios.json", json);
        }

        public List<Usuario> CarregarUsuarios()
        {
            if (!File.Exists("usuarios.json"))
                return new List<Usuario>();

            string json = File.ReadAllText("usuarios.json");
            return JsonSerializer.Deserialize<List<Usuario>>(json);

        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            List<Usuario> usuarios = CarregarUsuarios();
            Usuario usuarioCadasrar = new Usuario();
            usuarioCadasrar.Nome = txtNome.Text;
            usuarioCadasrar.Email = txtEmail.Text;
            usuarioCadasrar.Senha = txtSenha.Text;

            usuarios.Add(usuarioCadasrar);
            SalvarUsuario(usuarios);

            MessageBox.Show("Usuário cadastrado com sucesso!");

            txtEmail.Text = "";

            dgv_usuarios.DataSource = null;
            dgv_usuarios.DataSource = CarregarUsuarios();
        }

        private void TelaUsuario_Load(object sender, EventArgs e)
        {
            dgv_usuarios.DataSource = CarregarUsuarios();
        }
    }
}
