namespace ejercicio_4_Laboratorio_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(Atxt.Text);
            int m = Convert.ToInt32(Btxt.Text);
            int p = Convert.ToInt32(Ctxt.Text);

            int tiempoA = 5;
            int tiempoB = 8;
            int tiempoC = 6;

            int tiempoTotalMinutos = (tiempoA * n) + (tiempoB * m) + (tiempoC * p);

            int horas = tiempoTotalMinutos / 60;
            int minutos = tiempoTotalMinutos % 60;

            resultadolbl.Text = "Tiempo total de revisión: " + horas + " horas y " + minutos + " minutos";
        }
    }
}