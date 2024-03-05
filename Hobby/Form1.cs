namespace Hobby
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.DataSource = comboBox1.Items;
        }
    }
}

/*public partial class Form1 : Form
{
    private Dictionary<string, List<string>> countriesAndTowns = new Dictionary<string, List<string>>
    {
        { "Bulgaria", new List<string> { "Sofia", "Plovdiv", "Varna" } },
        { "USA", new List<string> { "New York", "Los Angeles", "Chicago" } },
        { "France", new List<string> { "Paris", "Lyon", "Marseille" } },
        { "Japan", new List<string> { "Tokyo", "Osaka", "Kyoto" } }
    };

    private List<string> hobbies = new List<string> { "Reading", "Swimming", "Coding", "Gardening", "Photography" };

    public Form1()
    {
        InitializeComponent();

        // Populate the ComboBoxes and Checkboxes
        cbCountry.Items.AddRange(countriesAndTowns.Keys.ToArray());
        cbHobbies.Items.AddRange(hobbies.ToArray());
    }

    private void btnSubmit_Click(object sender, EventArgs e)
    {
        string country = cbCountry.SelectedItem.ToString();
        string town = cbTown.SelectedItem.ToString();
        string timeToPractice = rbMorning.Checked ? "morning" : rbAfternoon.Checked ? "afternoon" : "evening";
        string hobbies = "";

        foreach (var item in lbHobbies.Items)
        {
            hobbies += item.ToString() + ", ";
        }

        MessageBox.Show($"Country: {country}\nTown: {town}\nTime to practice hobbies: {timeToPractice}\nHobbies: {hobbies}");
    }

    private void cbCountry_SelectedIndexChanged(object sender, EventArgs e)
    {
        // Update the towns ComboBox based on the selected country
        string selectedCountry = cbCountry.SelectedItem.ToString();
        cbTown.Items.Clear();
        cbTown.Items.AddRange(countriesAndTowns[selectedCountry].ToArray());
    }

    private void cbHobbies_ItemCheck(object sender, ItemCheckEventArgs e)
    {
        // Add or remove hobbies from the ListBox based on the checked state
        if (e.NewValue == CheckState.Checked)
        {
            lbHobbies.Items.Add(cbHobbies.Items[e.Index]);
        }
        else
        {
            lbHobbies.Items.Remove(cbHobbies.Items[e.Index]);
        }
    }

    private void lbHobbies_SelectedIndexChanged(object sender, EventArgs e)
    {
        // Move the selected hobby to the other ListBox and vice versa
        if (lbHobbies.SelectedItem != null)
        {
            lbSelectedHobbies.Items.Add(lbHobbies.SelectedItem);
            lbHobbies.Items.Remove(lbHobbies.SelectedItem);
        }
    }
}*/