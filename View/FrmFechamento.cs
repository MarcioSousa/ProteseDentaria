using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Model;


namespace View
{
    public partial class FrmFechamento : Form
    {
        Bitmap captura = null;
        List<ItemPedido> itemPedidos;
        int qtdenumeroTela;
        int numeroTela;

        public FrmFechamento(int codigopedido)
        {
            InitializeComponent();
            DgvItensPedido.AutoGenerateColumns = false;
            TxtCodigoPedido.Text = codigopedido.ToString();
        }

        private void FrmFechamento_Load(object sender, EventArgs e)
        {
            ItemPedidoNegocio itemPedidoNegocio = new ItemPedidoNegocio();
            itemPedidos = new List<ItemPedido>();
            itemPedidos = itemPedidoNegocio.CarregarGridImpressao(Convert.ToInt32(TxtCodigoPedido.Text));

            double verificandoqtde = 0;
            verificandoqtde = itemPedidos.Count() / (double)20;

            qtdenumeroTela = itemPedidos.Count() / 20;
            numeroTela = 0;

            if (verificandoqtde == qtdenumeroTela)
            {
                qtdenumeroTela--;
            }


            if (qtdenumeroTela > 0)
            {
                BtnAvancar.Visible = true;
                LblValorTotal.Visible = false;
                LblTextoValorTotal.Visible = false;
            }

            LblNumeroPagina.Text = (numeroTela+1).ToString();
            CarregarDataGrid();
            double valortotal = itemPedidoNegocio.SomaPedido(Convert.ToInt32(TxtCodigoPedido.Text));
            LblValorTotal.Text = valortotal.ToString("C");

            Pedido pedido = new Pedido();
            PedidoNegocio pedidoNegocio = new PedidoNegocio();
            pedido = pedidoNegocio.PesquisaPedido(Convert.ToInt32(TxtCodigoPedido.Text));
            LblDentista.Text = pedido.Dentista;
            DtpFechamento.Text = pedido.Datafechamento.ToString();

        }

        private void CarregarDataGrid()
        {
            DgvItensPedido.Rows.Clear();

            for (int t = (20 * numeroTela); t < (20 * numeroTela) + 20; t++)
            {
                if (t == itemPedidos.Count)
                {
                    break;
                }
                DgvItensPedido.Rows.Add(itemPedidos[t].Qtde, itemPedidos[t].NomeProduto, itemPedidos[t].Paciente, itemPedidos[t].Dataentrega, itemPedidos[t].ValorUnid, itemPedidos[t].Total);
            }
            DgvItensPedido.ClearSelection();
        }

        private void PrintFechamento_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(captura, 20, 20);
        }

        private void CapturarForm()
        {
            captura = new Bitmap(754, 715);
            var graphics = Graphics.FromImage(captura);
            graphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, new Size(754, 715));
        }

        public static class WindowHelper
        {
            [Serializable, System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
            public struct Rect
            {
                public int Left;
                public int Top;
                public int Right;
                public int Bottom;

                public System.Drawing.Rectangle ToRectangle()
                {
                    return System.Drawing.Rectangle.FromLTRB(Left, Top, Right, Bottom);
                }
            }

            [System.Runtime.InteropServices.DllImport(@"dwmapi.dll")]
            public static extern int DwmGetWindowAttribute(IntPtr hwnd, int dwAttribute, out Rect pvAttribute, int cbAttribute);

            public enum Dwmwindowattribute
            {
                DwmwaExtendedFrameBounds = 9
            }
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnImprimir_Click(object sender, EventArgs e)
        {
            CapturarForm();
            PrintFechamento.Print();

            this.Close();
        }

        private void BtnAvancar_Click(object sender, EventArgs e)
        {
      
            CbxVTotal.Checked = false;
            numeroTela++;
            if (numeroTela == qtdenumeroTela)
            {
                BtnAvancar.Visible = false;
                BtnVoltar.Visible = true;
                LblValorTotal.Visible = true;
                LblTextoValorTotal.Visible = true;
            }
            BtnVoltar.Visible = true;

            CarregarDataGrid();
      LblNumeroPagina.Text = (numeroTela + 1).ToString();
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            CbxVTotal.Checked = false;
            numeroTela--;
            if (numeroTela == 0)
            {
                BtnVoltar.Visible = false;
            }

            LblValorTotal.Visible = false;
            LblTextoValorTotal.Visible = false;
            BtnAvancar.Visible = true;
            CarregarDataGrid();
            LblNumeroPagina.Text = (numeroTela + 1).ToString();
        }

        private void BtnRegistrarFechamento_Click(object sender, EventArgs e)
        {
            try
            {
                PedidoNegocio pedidoNegocio = new PedidoNegocio();
                MessageBox.Show(pedidoNegocio.RegistrarFechamento(Convert.ToInt32(TxtCodigoPedido.Text), DtpFechamento.Value), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Não foi possível registrar o fechamento.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void CbxVTotal_CheckedChanged(object sender, EventArgs e)
        {
            if (CbxVTotal.Checked)
            {
                LblValorTotal.Visible = true;
                LblTextoValorTotal.Visible = true;
            }
            else
            {
                LblValorTotal.Visible = false;
                LblTextoValorTotal.Visible = false;
            }
        }
    }
}
