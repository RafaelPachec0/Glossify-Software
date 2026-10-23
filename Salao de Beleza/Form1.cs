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
        }

        private void AplicarEstilo()
        {
            this.BackColor = Cores.Fundo;

            btnNovoAgendamento.FillColor = Cores.AzulMarinho;
            btnNovoAgendamento.ForeColor = Cores.TextoBranco;
            btnNovoAgendamento.BorderRadius = 4;
            btnNovoAgendamento.BorderThickness = 0;

            btnNovoAgendamento.HoverState.FillColor = Cores.AzulSelecionado;
            btnNovoAgendamento.PressedColor = Cores.Rosa;

            btnNovoCliente.FillColor = Cores.Branco;
            btnNovoCliente.ForeColor = Cores.TextoPrincipal;
            btnNovoCliente.BorderColor = Cores.AzulAcinzentado;
            btnNovoCliente.BorderThickness = 1;
            btnNovoCliente.BorderRadius = 4;

            btnNovoCliente.HoverState.FillColor = Cores.LinhaSelecionada;
            btnNovoCliente.PressedColor = Cores.Rosa;

            btnRealizarVenda.FillColor = Cores.Branco;
            btnRealizarVenda.ForeColor = Cores.TextoPrincipal;
            btnRealizarVenda.BorderColor = Cores.AzulAcinzentado;
            btnRealizarVenda.BorderThickness = 1;
            btnRealizarVenda.BorderRadius = 4;

            btnRealizarVenda.HoverState.FillColor = Cores.LinhaSelecionada;
            btnRealizarVenda.PressedColor = Cores.Rosa;
        }

        private void Panel_Lateral_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
