using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CollegeTroops
{
    public partial class Main : Form
    {
        public static MySqlConnection c = new MySqlConnection("Server=localhost; Database=prepods; User id = root; password=;");
        public static MySqlCommand cmd = c.CreateCommand();
        public static MySqlDataReader r;

        public static List<Man> mans = new List<Man>();
        public static List<FamStat> fss = new List<FamStat>();
        public static List<UchStep> uchss = new List<UchStep>();
        public static List<Duty> ds = new List<Duty>();
        public Main()
        {
            InitializeComponent();
        }
        void Update()
        {
            Open();

            //get teacher
            cmd.CommandText = "select * from teacher";
            r = cmd.ExecuteReader();
            Man t;
            mans.Clear();
            while (r.Read())
            {
                t = new Man();
                t.id = r[0];
                t.name = r[1];
                t.sex = r[2];
                t.age = r[3];
                t.idFamStat = r[4];
                t.kids = r[5];
                t.idDuty = r[6];
                t.idUchStep = r[7];
                t.oklad = r[8];

                mans.Add(t);
            }
            r.Close();

            //get famStat
            cmd.CommandText = "select * from famStat";
            r = cmd.ExecuteReader();
            FamStat f;
            fss.Clear();
            while (r.Read())
            {
                f = new FamStat();
                f.id = r[0];
                f.name = r[1];

                fss.Add(f);
            }
            r.Close();

            //get uchStep
            cmd.CommandText = "select * from uchStep";
            r = cmd.ExecuteReader();
            UchStep u;
            uchss.Clear();
            while (r.Read())
            {
                u = new UchStep();
                u.id = r[0];
                u.name = r[1];

                uchss.Add(u);
            }
            r.Close();

            //get duty
            cmd.CommandText = "select * from duty";
            r = cmd.ExecuteReader();
            Duty d;
            ds.Clear();
            while (r.Read())
            {
                d = new Duty();
                d.id = r[0];
                d.name = r[1];

                ds.Add(d);
            }
            r.Close();
            //t.name = r[1];
            //t.sex = r[2];
            //t.age = r[3];
            //t.idFamStat = r[4];
            //t.kids = r[5];
            //t.idDuty = r[6];
            //t.idUchStep = r[7];
            //t.oklad = r[8];
            DataTable dt = new DataTable();
            dt.Columns.Add("Код");
            dt.Columns.Add("ФИО");
            dt.Columns.Add("Пол");
            dt.Columns.Add("Возраст");
            dt.Columns.Add("Семейное положение");
            dt.Columns.Add("Есть дети");
            dt.Columns.Add("Должность");
            dt.Columns.Add("Ученая степень");
            dt.Columns.Add("Оклад");

            foreach(var v in mans)
            {
                string haveKids = "Есть";
                if (v.kids.ToString() == "0") haveKids = "Нет";
                dt.Rows.Add(new object[]
                {
                    v.id,
                    v.name,
                    v.sex,
                    v.age,
                    fss.Find(x => x.id.ToString() == v.idFamStat.ToString()).name,
                    haveKids,
                    ds.Find(x => x.id.ToString() == v.idDuty.ToString()).name,
                    uchss.Find(x => x.id.ToString() == v.idUchStep.ToString()).name,
                    v.oklad
                });
            }

            dgv.DataSource = dt;
        }
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void добавитьЗаписьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newTroop f = new newTroop();
            f.title.Text = (sender as ToolStripMenuItem).Text;
            f.ShowDialog();
            Update();
        }

        private void изменитьЗаписьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var row = dgv.SelectedCells[0].OwningRow.Cells;
            newTroop f = new newTroop();
            f.title.Text = (sender as ToolStripMenuItem).Text;
            f.id = row[0].Value.ToString();
            f.name = row[1].Value.ToString();
            f.sex = row[2].Value.ToString();
            f.age = Convert.ToDecimal(row[3].Value);
            f.famStat = row[4].Value.ToString();
            if (row[5].Value.ToString() == "0")
                f.haveKids = false;
            else
                f.haveKids = true;
            f.duty = row[6].Value.ToString();
            f.uchStep = row[7].Value.ToString();
            f.oklad = Convert.ToDecimal(row[8].Value);
            f.ShowDialog();
            Update();
        }

        private void печатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printDialog1.ShowDialog();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Update();
        }
        public static void Open()
        {
            if (c.State != ConnectionState.Open)
                c.Open();
        }
    }
    public class Man
    {
        public object
            id,
            name,
            sex,
            age,
            idFamStat,
            kids,
            idDuty,
            idUchStep,
            oklad;
    }
    public class FamStat
    {
        public object
            id,
            name;
    }
    public class UchStep
    {
        public object
            id,
            name;
    }
    public class Duty
    {
        public object
            id,
            name;
    }
}
