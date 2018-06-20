using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CollegeTroops
{
    public partial class newTroop : Form
    {
        public string id, name, sex, famStat, duty, uchStep;
        public decimal age, oklad;

        private void b_done_Click(object sender, EventArgs e)
        {
            string havKids;
            if (ch_haveKids.Checked)
                havKids = "1";
            else
                havKids = "0";

            if (title.Text.ToLower().Contains("изменить"))
            {
                Main.Open();
                Main.cmd.CommandText = "UPDATE teacher SET " + 
                    "name = '" + cb_name.Text + "', " +
                    "sex = '" + cb_gender.Text + "', " +
                    "age = '" + n_age.Value + "', " +
                    "idFamStat = '" + (cb_familyStatus.SelectedIndex + 1) + "', " +
                    "kids = '" + havKids + "', " +
                    "idDuty = '" + (cb_duty.SelectedIndex + 1) + "', " +
                    "idUchStep = '" + (cb_knowledge.SelectedIndex + 1) + "', " +
                    "oklad = '" + n_oklad.Value + "'" +
                    "where id = " + id;
                Clipboard.SetText(Main.cmd.CommandText);
                Main.cmd.ExecuteNonQuery();
                Main.c.Close();
            }
            else
            {
                Main.Open();
                Main.cmd.CommandText = "INSERT INTO teacher (name, sex, age, idFamStat, kids, idDuty, idUchStep, oklad) VALUES(" +
                    "'" + cb_name.Text + "', " +
                    "'" + cb_gender.Text + "', " +
                    "'" + n_age.Value + "', " +
                    "'" + (cb_familyStatus.SelectedIndex + 1) + "', " +
                    "'" + havKids + "', " +
                    "'" + (cb_duty.SelectedIndex + 1) + "', " +
                    "'" + (cb_knowledge.SelectedIndex + 1) + "', " +
                    "'" + n_oklad.Value + "')";
                Main.cmd.ExecuteNonQuery();
                Main.c.Close();
            }
            MessageBox.Show("Операция выполнена");
            Close();
        }

        public bool haveKids;

        private void newTroop_Load(object sender, EventArgs e)
        {
            cb_name.Items.Clear();
            foreach (var v in Main.mans)
                cb_name.Items.Add(v.name);
            cb_familyStatus.Items.Clear();
            foreach (var v in Main.fss)
                cb_familyStatus.Items.Add(v.name);
            cb_duty.Items.Clear();
            foreach (var v in Main.ds)
                cb_duty.Items.Add(v.name);
            cb_knowledge.Items.Clear();
            foreach (var v in Main.uchss)
                cb_knowledge.Items.Add(v.name);

            if(title.Text.ToLower().Contains("изменить"))
            {
                cb_name.Text = name;
                cb_familyStatus.Text = famStat;
                cb_duty.Text = duty;
                cb_knowledge.Text = uchStep;
                ch_haveKids.Checked = haveKids;
                n_age.Value = age;
                n_oklad.Value = oklad;
            }
        }

        public newTroop()
        {
            InitializeComponent();
        }

        private void b_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
