using MinecraftManager.Models;
using MinecraftManager.Models.Enumerable;
using MinecraftManager.Models.Interface;

namespace MinecraftManager
{
    public partial class Form1 : Form
    {
        private List<Item> inventario = new List<Item>();
        private int prossimoId = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (Rarity r in Enum.GetValues(typeof(Rarity)))
                cmbRarita.Items.Add(r);
            cmbRarita.SelectedIndex = 0;

            foreach (ToolType t in Enum.GetValues(typeof(ToolType)))
                cmbToolType.Items.Add(t);
            cmbToolType.SelectedIndex = 0;

            cmbTipo.SelectedIndex = 0;
            AggiornaCampiVisibili();
        }

        private void AggiornaCampiVisibili()
        {
            bool isTool = cmbTipo.SelectedIndex == 0;
            cmbToolType.Enabled = isTool;
            txtDurabilita.Enabled = isTool;
            chkStackable.Enabled = !isTool;
            txtDurezza.Enabled = !isTool;
        }

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            AggiornaCampiVisibili();
        }

        private void btnAggiungi_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text.Trim();
            if (nome == "")
            {
                MessageBox.Show("Inserisci un nome.");
                return;
            }

            int valore;
            if (!int.TryParse(txtValore.Text, out valore))
            {
                MessageBox.Show("Il valore deve essere un numero intero.");
                return;
            }

            Rarity rarita = (Rarity)cmbRarita.SelectedItem;
            string id = "I" + prossimoId;

            if (cmbTipo.SelectedIndex == 0)
            {
                int durabilita;
                if (!int.TryParse(txtDurabilita.Text, out durabilita))
                {
                    MessageBox.Show("La durabilità deve essere un numero intero.");
                    return;
                }
                ToolType tipo = (ToolType)cmbToolType.SelectedItem;
                inventario.Add(new ToolItem(id, nome, valore, rarita, durabilita, tipo));
            }
            else
            {
                float durezza;
                if (!float.TryParse(txtDurezza.Text, out durezza))
                {
                    MessageBox.Show("La durezza deve essere un numero (es. 1,5).");
                    return;
                }
                inventario.Add(new BlockItem(id, nome, valore, rarita, chkStackable.Checked, durezza));
            }

            prossimoId++;
            AggiornaGriglia();
            txtNome.Clear();
        }

        private void btnCrafta_Click(object sender, EventArgs e)
        {
            if (dgvInventario.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleziona un oggetto.");
                return;
            }

            Item item = (Item)dgvInventario.SelectedRows[0].Tag;

            if (item is ICraftable craftabile)
            {
                if (craftabile.CanCraft())
                {
                    craftabile.Craft();
                    MessageBox.Show(item.Name + " craftato!");
                    AggiornaGriglia();
                }
                else
                {
                    MessageBox.Show("Durabilità insufficiente per craftare.");
                }
            }
            else
            {
                MessageBox.Show(item.Name + " non è craftabile.");
            }
        }

        private void AggiornaGriglia()
        {
            dgvInventario.Rows.Clear();
            foreach (Item item in inventario)
            {
                int riga = dgvInventario.Rows.Add(item.Id, item.Name, item.GetDetails());
                dgvInventario.Rows[riga].Tag = item;
            }
        }
    }
}
