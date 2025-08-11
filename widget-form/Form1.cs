namespace widget_form
{
    public partial class empireSystemsForm : Form {

        int labelXLocation = 299;
        int labelYLocation = 294;
        int comboBoxXLocation = 302;
        int comboBoxYLocation = 317;

        // -- FUNCTIONS --

        private void disableSubtypeControls(Label label, ComboBox  comboBox) {
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
    }
}