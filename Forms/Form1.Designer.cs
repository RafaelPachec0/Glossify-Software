namespace Salao_de_Beleza
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblAgendamentosHoje = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.lblVendasDia = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.lblClientesCadastrados = new System.Windows.Forms.Label();
            this.btnNovoAgendamento = new Guna.UI2.WinForms.Guna2Button();
            this.btnNovoCliente = new Guna.UI2.WinForms.Guna2Button();
            this.btnRealizarVenda = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvProximosAgendamentos = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2Panel3.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProximosAgendamentos)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.guna2Panel3.Controls.Add(this.label7);
            this.guna2Panel3.Controls.Add(this.lblNome);
            this.guna2Panel3.Location = new System.Drawing.Point(208, -2);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(1008, 66);
            this.guna2Panel3.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 18);
            this.label7.TabIndex = 1;
            this.label7.Text = "Nome Usuário";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(925, 26);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(74, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome Usuário";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2Panel1.BorderThickness = 2;
            this.guna2Panel1.Controls.Add(this.lblAgendamentosHoje);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.guna2Panel1.Location = new System.Drawing.Point(242, 129);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(294, 66);
            this.guna2Panel1.TabIndex = 4;
            // 
            // lblAgendamentosHoje
            // 
            this.lblAgendamentosHoje.AutoSize = true;
            this.lblAgendamentosHoje.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgendamentosHoje.Location = new System.Drawing.Point(19, 29);
            this.lblAgendamentosHoje.Name = "lblAgendamentosHoje";
            this.lblAgendamentosHoje.Size = new System.Drawing.Size(29, 31);
            this.lblAgendamentosHoje.TabIndex = 1;
            this.lblAgendamentosHoje.Text = "0";
            this.lblAgendamentosHoje.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Agendamentos de hoje";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.guna2Panel2.BorderColor = System.Drawing.Color.Gray;
            this.guna2Panel2.BorderThickness = 2;
            this.guna2Panel2.Controls.Add(this.label6);
            this.guna2Panel2.Controls.Add(this.lblVendasDia);
            this.guna2Panel2.Controls.Add(this.label2);
            this.guna2Panel2.Location = new System.Drawing.Point(535, 129);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(305, 66);
            this.guna2Panel2.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(10, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 31);
            this.label6.TabIndex = 3;
            this.label6.Text = "R$";
            this.label6.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // lblVendasDia
            // 
            this.lblVendasDia.AutoSize = true;
            this.lblVendasDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVendasDia.ForeColor = System.Drawing.Color.Gray;
            this.lblVendasDia.Location = new System.Drawing.Point(56, 29);
            this.lblVendasDia.Name = "lblVendasDia";
            this.lblVendasDia.Size = new System.Drawing.Size(29, 31);
            this.lblVendasDia.TabIndex = 2;
            this.lblVendasDia.Text = "0";
            this.lblVendasDia.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(9, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Vendas do dia";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.guna2Panel4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2Panel4.BorderThickness = 2;
            this.guna2Panel4.Controls.Add(this.label5);
            this.guna2Panel4.Controls.Add(this.lblClientesCadastrados);
            this.guna2Panel4.Location = new System.Drawing.Point(840, 129);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.Size = new System.Drawing.Size(308, 66);
            this.guna2Panel4.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(10, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Clientes cadastrados";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblClientesCadastrados
            // 
            this.lblClientesCadastrados.AutoSize = true;
            this.lblClientesCadastrados.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientesCadastrados.ForeColor = System.Drawing.Color.Gray;
            this.lblClientesCadastrados.Location = new System.Drawing.Point(9, 29);
            this.lblClientesCadastrados.Name = "lblClientesCadastrados";
            this.lblClientesCadastrados.Size = new System.Drawing.Size(29, 31);
            this.lblClientesCadastrados.TabIndex = 3;
            this.lblClientesCadastrados.Text = "0";
            this.lblClientesCadastrados.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // btnNovoAgendamento
            // 
            this.btnNovoAgendamento.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNovoAgendamento.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNovoAgendamento.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNovoAgendamento.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNovoAgendamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoAgendamento.ForeColor = System.Drawing.Color.White;
            this.btnNovoAgendamento.Location = new System.Drawing.Point(242, 215);
            this.btnNovoAgendamento.Name = "btnNovoAgendamento";
            this.btnNovoAgendamento.Size = new System.Drawing.Size(146, 35);
            this.btnNovoAgendamento.TabIndex = 7;
            this.btnNovoAgendamento.Text = "Novo Agendamento";
            // 
            // btnNovoCliente
            // 
            this.btnNovoCliente.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNovoCliente.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNovoCliente.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNovoCliente.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNovoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoCliente.ForeColor = System.Drawing.Color.White;
            this.btnNovoCliente.Location = new System.Drawing.Point(404, 215);
            this.btnNovoCliente.Name = "btnNovoCliente";
            this.btnNovoCliente.Size = new System.Drawing.Size(130, 35);
            this.btnNovoCliente.TabIndex = 8;
            this.btnNovoCliente.Text = "Novo Cliente";
            // 
            // btnRealizarVenda
            // 
            this.btnRealizarVenda.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRealizarVenda.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRealizarVenda.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRealizarVenda.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRealizarVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRealizarVenda.ForeColor = System.Drawing.Color.White;
            this.btnRealizarVenda.Location = new System.Drawing.Point(551, 215);
            this.btnRealizarVenda.Name = "btnRealizarVenda";
            this.btnRealizarVenda.Size = new System.Drawing.Size(130, 35);
            this.btnRealizarVenda.TabIndex = 9;
            this.btnRealizarVenda.Text = "Realizar Venda";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(239, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Próximos Agendamentos";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // dgvProximosAgendamentos
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvProximosAgendamentos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvProximosAgendamentos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProximosAgendamentos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvProximosAgendamentos.ColumnHeadersHeight = 4;
            this.dgvProximosAgendamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProximosAgendamentos.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvProximosAgendamentos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvProximosAgendamentos.Location = new System.Drawing.Point(242, 325);
            this.dgvProximosAgendamentos.Name = "dgvProximosAgendamentos";
            this.dgvProximosAgendamentos.RowHeadersVisible = false;
            this.dgvProximosAgendamentos.Size = new System.Drawing.Size(906, 281);
            this.dgvProximosAgendamentos.TabIndex = 12;
            this.dgvProximosAgendamentos.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvProximosAgendamentos.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvProximosAgendamentos.ThemeStyle.HeaderStyle.Height = 4;
            this.dgvProximosAgendamentos.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1216, 861);
            this.Controls.Add(this.guna2Panel4);
            this.Controls.Add(this.dgvProximosAgendamentos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnRealizarVenda);
            this.Controls.Add(this.btnNovoCliente);
            this.Controls.Add(this.btnNovoAgendamento);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.guna2Panel3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel3.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.guna2Panel4.ResumeLayout(false);
            this.guna2Panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProximosAgendamentos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private Guna.UI2.WinForms.Guna2Button btnNovoAgendamento;
        private Guna.UI2.WinForms.Guna2Button btnNovoCliente;
        private Guna.UI2.WinForms.Guna2Button btnRealizarVenda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAgendamentosHoje;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblVendasDia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblClientesCadastrados;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2DataGridView dgvProximosAgendamentos;
    }
}

