using System.Diagnostics;
using System.Data;
using Npgsql;

namespace widget_form {
    public partial class empireSystemsForm : Form {

        // WARNING DO NOT COMMIT YET !!!
        // TODO: HIDE PASSWORD
        // TODO: revert to only DB connection before committing,, "Connect to PostgreSQL database" and THEN "Store widget data in PostgreSQL database"

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

        // -- FUNCTIONS --

        // TODO: take in name, type, subtype parameters
        public void submitWidget() {
            DBConnection();

            NpgsqlCommand vCmd = new() {
                Connection = vCon,
                CommandText = "INSERT INTO widget (name, type, subtype) VALUES ('test', 'A', 'Astronaut');"
            };

            _ = vCmd.ExecuteReader();

            Debug.WriteLine("Widget stored in database.");
        }

        private void disableSubtypeControls(Label label, ComboBox comboBox) {
            label.Enabled = false;
            label.Hide();

            comboBox.Enabled = false;
            comboBox.Hide();
        }

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

            disableSubtypeControls(typeBSubtypesLabel, typeBSubtypesComboBox);
            disableSubtypeControls(type1SubtypesLabel, type1SubtypesComboBox);
            disableSubtypeControls(type2SubtypesLabel, type2SubtypesComboBox);
        }

        // TODO: refactor code??? repetitive

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
            submitWidget();
        }
    }
}