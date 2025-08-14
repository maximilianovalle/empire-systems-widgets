using System.Diagnostics;
using System.Data;
using Npgsql;

namespace widget_form {
    public partial class empireSystemsForm : Form {

        NpgsqlConnection vCon = null!;

        private void DBConnection() {
            string password = File.ReadAllText("C:\\Users\\twofa\\Desktop\\repos\\empire-systems\\widget-form\\password.txt");
            string vDBConnectionString = "Host=localhost;Username=postgres;Password=" + password + ";Database=empireSystems";
            vCon = new NpgsqlConnection(vDBConnectionString);

            if (vCon.State == ConnectionState.Closed) {
                vCon.Open();
                Debug.WriteLine("Database connection initialized.");
            }
        }

        int labelXLocation = 299, labelYLocation = 294;
        int comboBoxXLocation = 302, comboBoxYLocation = 317;

        string defaultComboBoxOpt = " -- SELECT ONE --";

        // -- FUNCTIONS --

        public void submitWidget(string name, string type, string subtype) {
            DBConnection();

            // # Bad Practice: dangerous to use string concatenation

            NpgsqlCommand vCmd = new() {
                Connection = vCon,
                CommandText = "INSERT INTO widget (name, type, subtype) VALUES ('" + name + "', '" + type + "', '" + subtype + "');"
            };

            // TODO: use following code,, curr not working bc 'type' and 'subtype' values are string not widgetType

            // var vCmd = new NpgsqlCommand("INSERT INTO widget (name, type, subtype) VALUES (@name, @type, @subtype);", vCon);
            // vCmd.Parameters.AddWithValue("@name", name);
            // vCmd.Parameters.AddWithValue("@type", type);
            // vCmd.Parameters.AddWithValue("@subtype", subtype);

             _ = vCmd.ExecuteNonQuery();

            Debug.WriteLine("Widget stored in database.");
        }

        // disables a given subtype's controls (label + combo box / dropdown box)
        private void disableSubtypeControls(Label label, ComboBox comboBox) {
            label.Enabled = false;
            label.Hide();

            comboBox.Enabled = false;
            comboBox.Hide();
        }

        // enables a given subtype's controls (label + combo box / dropdown box)
        private void enableSubtypeControls(Label label, ComboBox comboBox) {
            label.Enabled = true;
            label.Show();
            label.Location = new Point(labelXLocation, labelYLocation);

            comboBox.Enabled = true;
            comboBox.Show();
            comboBox.Location = new Point(comboBoxXLocation, comboBoxYLocation);
        }

        // -- EVENTS --

        public empireSystemsForm() {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            // enables only type A subtype controls
            disableSubtypeControls(typeBSubtypesLabel, typeBSubtypesComboBox);
            disableSubtypeControls(type1SubtypesLabel, type1SubtypesComboBox);
            disableSubtypeControls(type2SubtypesLabel, type2SubtypesComboBox);
        }

        private void widgetTypeOptA_CheckedChanged(object sender, EventArgs e) {
            if (widgetTypeOptA.Checked) {   // type A is selected
                enableSubtypeControls(typeASubtypesLabel, typeASubtypesComboBox);
            }
            else {                          // type A is NOT selected
                disableSubtypeControls(typeASubtypesLabel, typeASubtypesComboBox);
            }
        }

        private void widgetTypeOptB_CheckedChanged(object sender, EventArgs e) {
            if (widgetTypeOptB.Checked) {   // type B is selected
                enableSubtypeControls(typeBSubtypesLabel, typeBSubtypesComboBox);
            }
            else {                          // type B is NOT selected
                disableSubtypeControls(typeBSubtypesLabel, typeBSubtypesComboBox);
            }
        }

        private void widgetTypeOpt1_CheckedChanged(object sender, EventArgs e) {
            if (widgetTypeOpt1.Checked) {   // type 1 is selected
                enableSubtypeControls(type1SubtypesLabel, type1SubtypesComboBox);
            }
            else {                          // type 1 is NOT selected
                disableSubtypeControls(type1SubtypesLabel, type1SubtypesComboBox);
            }
        }

        private void widgetTypeOpt2_CheckedChanged(object sender, EventArgs e) {
            if (widgetTypeOpt2.Checked) {   // type 2 is selected
                enableSubtypeControls(type2SubtypesLabel, type2SubtypesComboBox);
            }
            else {                          // type 2 is NOT selected
                disableSubtypeControls(type2SubtypesLabel, type2SubtypesComboBox);
            }
        }

        private void submitBtn_Click(object sender, EventArgs e) {
            // check all form fields are filled / have selection
            if (string.IsNullOrEmpty(widgetNameTextBox.Text)) {
                MessageBox.Show("Please enter a widget name.");
                widgetNameTextBox.Focus();
                return;
            }
            else if ((widgetTypeOptA.Checked && typeASubtypesComboBox.Text == defaultComboBoxOpt)
            || (widgetTypeOptB.Checked && typeBSubtypesComboBox.Text == defaultComboBoxOpt)
            || (widgetTypeOpt1.Checked && type1SubtypesComboBox.Text == defaultComboBoxOpt)
            || (widgetTypeOpt2.Checked && type2SubtypesComboBox.Text == defaultComboBoxOpt)) {
                MessageBox.Show("Please select a subtype.");
                return;
            }

            // submit widget
            string widgetName = widgetNameTextBox.Text;

            if (widgetTypeOptA.Checked) {
                submitWidget(widgetName, "A", typeASubtypesComboBox.Text);
                Debug.WriteLine("Stored in DB: " + widgetName + ", A, " + typeASubtypesComboBox.Text);
            }
            else if (widgetTypeOptB.Checked) {
                submitWidget(widgetName, "B", typeBSubtypesComboBox.Text);
                Debug.WriteLine("Stored in DB: " + widgetName + ", B, " + typeBSubtypesComboBox.Text);
            }
            else if (widgetTypeOpt1.Checked) {
                submitWidget(widgetName, "1", type1SubtypesComboBox.Text);
                Debug.WriteLine("Stored in DB: " + widgetName + ", 1, " + type1SubtypesComboBox.Text);
            }
            else {
                submitWidget(widgetName, "2", type2SubtypesComboBox.Text);
                Debug.WriteLine("Stored in DB: " + widgetName + ", 2, " + type2SubtypesComboBox.Text);
            }

            MessageBox.Show("Widget '" + widgetName + "' successfully submitted!");

            // reset widget submission form
            widgetNameTextBox.Clear();
            widgetTypeOptA.Checked = true;
            typeASubtypesComboBox.Text = defaultComboBoxOpt;
        }
    }
}