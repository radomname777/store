using Newtonsoft.Json;
using System.Text.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public static bool Mybool { get; set; } = false;
        public Form1() { InitializeComponent(); Desrializer(); }

        public double count = 0;
        private void Button_Click(object sender, EventArgs e)
        {
            if (price_txtbox.Text.Length != 0 && Mybool) count = Convert.ToDouble(price_txtbox.Text);
            if (sender is Guna.UI2.WinForms.Guna2CircleButton btn)
            {
                switch (btn.Tag)
                {
                    case "10": count += 0.10; break;
                    case "20": count += 0.20; break;
                    case "50": count += 0.50; break;
                    case "1": count += 1; break;
                    case "5": count += 5; break;
                    case "10a": count += 10; break;
                }
            }
            price_txtbox.Text = count.ToString();
            while (price_txtbox.Text.Length > 4) price_txtbox.Text = price_txtbox.Text.Remove(price_txtbox.Text.Length - 1);
            Mybool = true;
        }
        private void price_txtbox_TextChanged(object sender, EventArgs e)
        {
            if (sender is TextBox a)
            {
                try { Convert.ToDecimal(a.Text); }
                catch (Exception) { a.Text = ""; return; }
                Mybool = true;
            }
        }
        List<string> list = new List<string>();
        private void Seriali()
        {
            foreach (var item in Controls)
            {
                if (item is Product product)
                    if (product.Checked)
                    {
                        if ((Convert.ToDouble(product.Count_txt.Text) - 1) == 0) { list.Add("No product"); }
                        else list.Add((Convert.ToDouble(product.Count_txt.Text) - 1).ToString());
                    }
                    else list.Add(product.Count_txt.Text);
            }
        }
        double CheckPrice()
        {
            double num = 0;
            list.Clear();
            foreach (var item in Controls)
                if (item is Product product&& product.Checked == true)num += Convert.ToDouble(product.Price);
            return num;
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            double num = CheckPrice();
            if (num == 0&& price_txtbox.Text.Length != 0) { MessageBox.Show($"Refund: {price_txtbox.Text} AZN"); price_txtbox.Text = ""; }
            else if (price_txtbox.Text.Length != 0 && Convert.ToDouble(price_txtbox.Text) - num >= 0)
            {
                
                if (Convert.ToDouble(price_txtbox.Text) - num != 0)
                {
                    label3.Visible = true;
                    txt_residual.Text = (Convert.ToDouble(price_txtbox.Text) - num).ToString();
                    while (txt_residual.Text.Length > 4) txt_residual.Text = txt_residual.Text.Remove(txt_residual.Text.Length - 1);
                    MessageBox.Show("Thanks", $"Residual {txt_residual.Text}");
                }
                else MessageBox.Show("Thanks");
                Serializer();
               
                Close();
            }
        }
        void Desrializer()
        {
            if (File.Exists("admin.json"))
            {
                List<string> list2 = new List<string>();
                {

                    var stringData = File.ReadAllText("admin.json");
                    list2 = JsonConvert.DeserializeObject<List<string>>(stringData);
                }
                int num = 0;
                foreach (var item in Controls)
                {
                    if (item is Product pr)
                    {
                        pr.Count_txt.Text = list2[num++];
                        if (pr.Count_txt.Text == "No product") pr.Visible = false;

                    }
                }
            }
        }
        void Serializer(){
            Seriali();
            var json = System.Text.Json.JsonSerializer.Serialize(list);
            File.WriteAllText("admin.json", json);
        }
       private void panel1_Paint(object sender, PaintEventArgs e)
       {

       }
    }
}