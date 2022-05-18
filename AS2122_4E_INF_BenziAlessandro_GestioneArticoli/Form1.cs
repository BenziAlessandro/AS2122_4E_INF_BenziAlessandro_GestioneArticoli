namespace AS2122_4E_INF_BenziAlessandro_GestioneArticoli
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //creazione dizionario articoli
            articoli = new Dictionary<string, Articolo>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //aggiungi articoli all'elenco
            if (articoli.ContainsKey(txtCodice.Text))
                articoli[txtCodice.Text] =
                    new Articolo(txtCodice.Text, txtDescrizione.Text, cmbUnitaMisura.Text, txtPrezzo.Text);
            else
                articoli.add(txtCodice.Text,
                    new Articolo(txtCodice.Text, txtDescrizione.Text, cmbUnitaMisura.Text, txtPrezzo.Text);

            lblArticoliInseriti.Text = $"Articoli ({articoli.count})";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDescrizione_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrezzo_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbUnitaMisura_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbVisualizza_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnVisualizza_Click(object sender, EventArgs e)
        {
            lstElenco.Items.Clear();
            switch (cmbVisualizza.Text)
            {
                case "Visualizza articoli":
                    foreach (KeyValuePair<string, Articolo> articolo in articoli)
                    {
                        lstElenco.Items.Add(articolo.Value.To());
                    }
                    break;
            }
        }

        private void lstElenco_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Item = lstElenco.SelectedItem.ToString();
            int index = lstElenco.FindString(Item);

            //visualizza gli articoli nell'elenco
            txtCodice.Text = articoli.ElementAt(index).Value.Codice;
            txtDescrizione.Text = articoli.ElementAt(index).Value.Codice;
            cmbUnitaMisura.Text = articoli.ElementAt(index).Value.Codice;
            txtPrezzo.Text = articoli.ElementAt(index).Value.Codice;
        }
    }
}