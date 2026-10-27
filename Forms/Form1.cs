using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Salao_de_Beleza
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            AplicarEstilo();
            EstilizarDataGridView();
            
            MenuLateral menu = new MenuLateral();

            menu.Dock = DockStyle.Left;

            this.Controls.Add(menu);

            menu.BringToFront();
            
        }

        private void AplicarEstilo()
        {
            this.BackColor = Cores.Fundo;
            this.ForeColor = Cores.TextoPrincipal;
            this.Font = new Font("Roboto", 9F, FontStyle.Regular);

            EstilizarBotaoPrincipal(btnNovoAgendamento);
            EstilizarBotaoSecundario(btnNovoCliente);
            EstilizarBotaoSecundario(btnRealizarVenda);

            EstilizarIndicador(lblAgendamentosHoje);
            EstilizarIndicador(lblVendasDia);
            EstilizarIndicador(lblClientesCadastrados);
        }

        private void EstilizarBotaoPrincipal(Guna.UI2.WinForms.Guna2Button botao)
        {
            botao.FillColor = Cores.AzulMarinho;
            botao.ForeColor = Cores.TextoBranco;

            botao.Font = new Font("Roboto", 9F, FontStyle.Bold);

            botao.BorderThickness = 0;
            botao.BorderRadius = 4;

            botao.HoverState.FillColor = Cores.AzulSelecionado;
            botao.PressedColor = Cores.Rosa;

            botao.Cursor = Cursors.Hand;
        }

        private void EstilizarBotaoSecundario(Guna.UI2.WinForms.Guna2Button botao)
        {
            botao.FillColor = Cores.Branco;
            botao.ForeColor = Cores.TextoPrincipal;

            botao.Font = new Font("Roboto", 9F, FontStyle.Regular);

            botao.BorderColor = Cores.AzulAcinzentado;
            botao.BorderThickness = 1;
            botao.BorderRadius = 4;

            botao.HoverState.FillColor = Cores.LinhaSelecionada;
            botao.HoverState.ForeColor = Cores.TextoPrincipal;

            botao.PressedColor = Cores.Rosa;
            botao.Cursor = Cursors.Hand;
        }

        private void EstilizarIndicador(Label label)
        {
            label.ForeColor = Cores.TextoPrincipal;
            label.Font = new Font("Roboto", 16F, FontStyle.Bold);
            label.BackColor = Cores.Branco;
        }

        private void EstilizarDataGridView()
        {
            dgvProximosAgendamentos.BorderStyle = BorderStyle.None;
            dgvProximosAgendamentos.GridColor = Cores.Borda;
            dgvProximosAgendamentos.Font = new Font("Roboto", 9F, FontStyle.Regular);
            dgvProximosAgendamentos.ForeColor = Cores.TextoPrincipal;
            dgvProximosAgendamentos.AllowUserToAddRows = false;
            dgvProximosAgendamentos.AllowUserToResizeRows = false;
            dgvProximosAgendamentos.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvProximosAgendamentos.RowHeadersVisible = false;
            dgvProximosAgendamentos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProximosAgendamentos.MultiSelect = false;
            dgvProximosAgendamentos.ReadOnly = true;
            dgvProximosAgendamentos.AlternatingRowsDefaultCellStyle.BackColor = Cores.Fundo;
            dgvProximosAgendamentos.DefaultCellStyle.BackColor = Cores.Branco;
            dgvProximosAgendamentos.DefaultCellStyle.ForeColor = Cores.TextoPrincipal;
            dgvProximosAgendamentos.DefaultCellStyle.SelectionBackColor =  Cores.LinhaSelecionada;
            dgvProximosAgendamentos.DefaultCellStyle.SelectionForeColor = Cores.TextoPrincipal;
            dgvProximosAgendamentos.DefaultCellStyle.Padding = new Padding(8, 4, 8, 4);
            dgvProximosAgendamentos.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvProximosAgendamentos.EnableHeadersVisualStyles = false;
            dgvProximosAgendamentos.ColumnHeadersDefaultCellStyle.BackColor = Cores.FundoTabela;
            dgvProximosAgendamentos.ColumnHeadersDefaultCellStyle.ForeColor = Cores.TextoPrincipal;
            dgvProximosAgendamentos.ColumnHeadersDefaultCellStyle.Font = new Font("Roboto", 9F, FontStyle.Bold);
            dgvProximosAgendamentos.ColumnHeadersDefaultCellStyle.Padding = new Padding(8, 4, 8, 4);
            dgvProximosAgendamentos.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvProximosAgendamentos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvProximosAgendamentos.ColumnHeadersHeight = 38;
            dgvProximosAgendamentos.RowTemplate.Height = 40;
            dgvProximosAgendamentos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProximosAgendamentos.AutoSizeRowsMode =  DataGridViewAutoSizeRowsMode.None;
        }


        private void Panel_Lateral_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnClientes_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlProximosAgendamentos_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
