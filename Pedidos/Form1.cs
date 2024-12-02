
using System.Diagnostics.Eventing.Reader;
namespace Pedidos

{
    public partial class Form1 : Form
    {

        private int contadorId = 1;
        private Cola<Pedidos>  colaPedidos;
        private Productor productor;
        private Consumidor consumidor;
        public Form1()
        {
            InitializeComponent();
            colaPedidos = new Cola<Pedidos>(10);
            productor = new Productor(colaPedidos);
            consumidor = new Consumidor(colaPedidos);
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            Pedidos nuevoPedidos = new Pedidos(
                contadorId++,
                txtNombrePedidos.Text,
                txtDirecccion.Text
                );

            ThreadPool.QueueUserWorkItem(
                state =>
                {
                    colaPedidos.Agregaar(nuevoPedidos);
                }
                );


            txtNombrePedidos.Clear();
            txtDirecccion.Clear();
        }

        private void BtnProcesar_Click(object sender, EventArgs e)
        {
            Thread hiloConsumidor = new Thread(ProcesarPedidos);
            hiloConsumidor.Start();
        }
        private void ProcesarPedidos()
        {
            Pedidos pedidos = colaPedidos.Extraer();
            AgregarPedidosADataGrib(pedidos);

        }
        private void AgregarPedidosADataGrib(Pedidos pedidos)
        {
            if (dgvPedidos.InvokeRequired)
            {
                dgvPedidos.Invoke(new Action(() =>
                {
                    dgvPedidos.Rows.Add(
                        pedidos.Id, pedidos.NombrePedido,
                        pedidos.Direccion,
                        pedidos.FechaCreacion
                        );
                })
                    );
            }
            else
            {
                dgvPedidos.Rows.Add(
                       pedidos.Id, pedidos.NombrePedido,
                       pedidos.Direccion,
                       pedidos.FechaCreacion
                       );
            }
        }
    }
}
