using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UltimateKnowledgeHub
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHealth_Click(object sender, EventArgs e)
        {
            panelContent.Controls.Clear();
            HealthControl health = new HealthControl();
            health.Dock = DockStyle.Fill;
            panelContent.Controls.Add(health);

        }

        private void btnLaw_Click(object sender, EventArgs e)
        {
            panelContent.Controls.Clear();
            LawControl law = new LawControl();
            law.Dock = DockStyle.Fill;
            panelContent.Controls.Add(law);


        }

        private void btnPKH_Click(object sender, EventArgs e)
        {
            panelContent.Controls.Clear(); // clear current content
            PKHControl pkh = new PKHControl(); // create new PKHControl
            pkh.Dock = DockStyle.Fill; // fill the panel
            panelContent.Controls.Add(pkh); // add control to panel
        }

        private void btnCareer_Click(object sender, EventArgs e)
        {
            panelContent.Controls.Clear();
            CareerControl career = new CareerControl();
            career.Dock = DockStyle.Fill;
            panelContent.Controls.Add(career);

        }

        private void btnPolitics_Click(object sender, EventArgs e)
        {
            panelContent.Controls.Clear();
            PoliticsControl politics = new PoliticsControl();
            politics.Dock = DockStyle.Fill;
            panelContent.Controls.Add(politics);

        }

        private void btnPlant_Click(object sender, EventArgs e)
        {
            panelContent.Controls.Clear();
            PlantsControl plants = new PlantsControl();
            plants.Dock = DockStyle.Fill;
            panelContent.Controls.Add(plants);

        }

        private void btnTech_Click(object sender, EventArgs e)
        {
            panelContent.Controls.Clear();
            TechControl tech = new TechControl();
            tech.Dock = DockStyle.Fill;
            panelContent.Controls.Add(tech);

        }

        private void btnFacts_Click(object sender, EventArgs e)
        {
            panelContent.Controls.Clear();
            FactsControl facts = new FactsControl();
            facts.Dock = DockStyle.Fill;
            panelContent.Controls.Add(facts);

        }

        private void btnAid_Click(object sender, EventArgs e)
        {
            panelContent.Controls.Clear();
            FirstAidControl firstAid = new FirstAidControl();
            firstAid.Dock = DockStyle.Fill;
            panelContent.Controls.Add(firstAid);

        }

        private void btnNutrition_Click(object sender, EventArgs e)
        {
            panelContent.Controls.Clear();
            NutritionControl nutrition = new NutritionControl();
            nutrition.Dock = DockStyle.Fill;
            panelContent.Controls.Add(nutrition);

        }
     
    }
}
