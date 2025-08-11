namespace widget_form
{
    public partial class empireSystemsForm : Form {

        // -- FUNCTIONS --
        private void disableTypeASubtypeControls() {
            typeASubtypesLabel.Enabled = false;
            typeASubtypesLabel.Hide();

            typeASubtypesComboBox.Enabled = false;
            typeASubtypesComboBox.Hide();
        }

        private void enableTypeASubtypeControls() {
            typeASubtypesLabel.Enabled = true;
            typeASubtypesLabel.Show();
            typeASubtypesLabel.Location = new Point(299, 289);


            typeASubtypesComboBox.Enabled = true;
            typeASubtypesComboBox.Show();
            typeASubtypesComboBox.Location = new Point(302, 312);
        }

        private void disableTypeBSubtypeControls() {
            typeBSubtypesLabel.Enabled = false;
            typeBSubtypesLabel.Hide();

            typeBSubtypesComboBox.Enabled = false;
            typeBSubtypesComboBox.Hide();
        }

        private void enableTypeBSubtypeControls() {
            typeBSubtypesLabel.Enabled = true;
            typeBSubtypesLabel.Show();
            typeBSubtypesLabel.Location = new Point(299, 289);

            typeBSubtypesComboBox.Enabled = true;
            typeBSubtypesComboBox.Show();
            typeBSubtypesComboBox.Location = new Point(302, 312);
        }

        private void disableType1SubtypeControls() {
            type1SubtypesLabel.Enabled = false;
            type1SubtypesLabel.Hide();

            type1SubtypesComboBox.Enabled = false;
            type1SubtypesComboBox.Hide();
        }

        private void enableType1SubtypeControls() {
            type1SubtypesLabel.Enabled = true;
            type1SubtypesLabel.Show();
            type1SubtypesLabel.Location = new Point(299, 289);

            type1SubtypesComboBox.Enabled = true;
            type1SubtypesComboBox.Show();
            type1SubtypesComboBox.Location = new Point(302, 312);
        }

        private void disableType2SubtypeControls() {
            type2SubtypesLabel.Enabled = false;
            type2SubtypesLabel.Hide();

            type2SubtypesComboBox.Enabled = false;
            type2SubtypesComboBox.Hide();
        }

        private void enableType2SubtypeControls() {
            type2SubtypesLabel.Enabled = true;
            type2SubtypesLabel.Show();
            type2SubtypesLabel.Location = new Point(299, 289);

            type2SubtypesComboBox.Enabled = true;
            type2SubtypesComboBox.Show();
            type2SubtypesComboBox.Location = new Point(302, 312);
        }

        // -- EVENTS --

        public empireSystemsForm() {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            disableTypeBSubtypeControls();
            disableType1SubtypeControls();
            disableType2SubtypeControls();
        }

        private void widgetTypeOptA_CheckedChanged(object sender, EventArgs e) {
            if (widgetTypeOptA.Checked) {   // type A is selected
                enableTypeASubtypeControls();
            }
            else {                          // type A is NOT selected
                disableTypeASubtypeControls();
            }
        }

        private void widgetTypeOptB_CheckedChanged(object sender, EventArgs e) {
            if (widgetTypeOptB.Checked) {   // type B is selected
                enableTypeBSubtypeControls();
            }
            else {                          // type B is NOT selected
                disableTypeBSubtypeControls();
            }
        }

        private void widgetTypeOpt1_CheckedChanged(object sender, EventArgs e) {
            if (widgetTypeOpt1.Checked) {   // type 1 is selected
                enableType1SubtypeControls();
            }
            else {                          // type 1 is NOT selected
                disableType1SubtypeControls();
            }
        }

        private void widgetTypeOpt2_CheckedChanged(object sender, EventArgs e) {
            if (widgetTypeOpt2.Checked) {   // type 2 is selected
                enableType2SubtypeControls();
            }
            else {                          // type 2 is NOT selected
                disableType2SubtypeControls();
            }
        }
    }
}
