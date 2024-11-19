namespace GeneracionVectores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            lstVector.Items.Clear();

            
            if (int.TryParse(txtTama�o.Text, out int tamano) && tamano > 0)
            {
                
                int[] vector = new int[tamano];
                Random rand = new Random();

                
                for (int i = 0; i < tamano; i++)
                {
                    vector[i] = rand.Next(1, 101); 
                }

                
                foreach (int valor in vector)
                {
                    lstVector.Items.Add(valor);
                }
            }
            else
            {
                
                MessageBox.Show("Por favor ingresa un n�mero v�lido para el tama�o del vector.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
        
    

