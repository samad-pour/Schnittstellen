namespace Schnittstellen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_display_Click(object sender, EventArgs e)
        {
            Kreis k1 = new Kreis("rot", 20);
            Kreis k2 = (Kreis)k1.Clone();
            k1.Faerben("gelb");
            k1.Vergroessern(1.5);
            lbl_display.Text = k1 + "\n" + k2;
        }
    }
}