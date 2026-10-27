using System;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace Salao_de_Beleza
{
    public partial class MenuLateral : System.Windows.Forms.UserControl
    {
        public MenuLateral()
        {
            InitializeComponent();
            EstilizarMenu();
        }

        private void EstilizarMenu()
        {
            PnlMenu.FillColor = Cores.AzulMarinho;
            PnlMenu.BorderThickness = 0;

            EstilizarBotaoMenu(btnInicio, true);
            EstilizarBotaoMenu(btnAgendamentos, false);
            EstilizarBotaoMenu(btnProdutos, false);
            EstilizarBotaoMenu(BtnClientes, false);
            EstilizarBotaoMenu(btnVendas, false);
            EstilizarBotaoMenu(btnEstoque, false);
            EstilizarBotaoMenu(btnRelatorios, false);
        }

        private void EstilizarBotaoMenu(Guna2Button botao, bool selecionado)
        {
            botao.FillColor = selecionado
                ? Cores.AzulSelecionado
                : Cores.AzulMarinho;

            botao.ForeColor = Cores.TextoBranco;
            botao.Font = new Font("Roboto", 9F, FontStyle.Regular);

            botao.BorderThickness = 0;
            botao.BorderRadius = 0;

            botao.HoverState.FillColor = Cores.AzulSelecionado;
            botao.HoverState.ForeColor = Cores.TextoBranco;

            botao.PressedColor = Cores.Rosa;
            botao.Cursor = Cursors.Hand;
        }
    }
}